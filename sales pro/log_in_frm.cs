using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Text.RegularExpressions;
using System.Drawing.Imaging;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;


namespace sales_pro
{
    public partial class log_in_frm : Form
    {
        public log_in_frm()
        {
            InitializeComponent();
            
        }
        public string user_name_var;
        private SqlConnection connect_sal = new SqlConnection("server=.\\SQLEXPRESS;database=sales;integrated security=SSPI");
        private methodes meth = new methodes();
        
        private void log_in_btn_Click(object sender, EventArgs e)
        {
           
            if (log_rdbtn.Checked)
            {
                if (user_nam_bx.Text != "" && password_bx.Text != "")
                {
                    try
                    {
                        SqlCommand select_user_cmd = connect_sal.CreateCommand();
                        SqlDataAdapter user_adap = new SqlDataAdapter();
                        DataTable user_dt = new DataTable();
                        user_adap.SelectCommand = select_user_cmd;

                        select_user_cmd.CommandText = "SELECT * FROM user_table WHERE user_name='" + user_nam_bx.Text.Trim() + "' AND user_pass='" + password_bx.Text + "'";
                        user_adap.Fill(user_dt);
                        if (user_dt.Rows.Count != 0)
                        {
                            user_name_var = user_nam_bx.Text.Trim();
                            this.Visible = false;
                            
                           
                            // Application.Run();
                            
                        }
                        else
                            MessageBox.Show("تأكد من اسم المستخدم وكلمة السر");
                        password_bx.Clear();
                    }
                    catch (Exception g)
                    {
                        MessageBox.Show(g.Message + "دخول");
                    }
                }
                else
                    MessageBox.Show("تأكد من اسم المستخدم وكلمة السر");
            }
            else if (new_user_btn.Checked)//new user
            {
                if (user_nam_bx.Text != "" && password_bx.Text != "")
                {
                    try
                    {

                        SqlCommand select_user_cmd = connect_sal.CreateCommand();
                        SqlDataAdapter user_adap = new SqlDataAdapter();
                        DataTable user_dt = new DataTable();
                        user_adap.SelectCommand = select_user_cmd;

                        select_user_cmd.CommandText = "SELECT user_name, user_pass FROM user_table WHERE user_name='" + user_nam_bx.Text.Trim() + "' AND user_pass='" + password_bx.Text + "'";
                        user_adap.Fill(user_dt);
                        if (user_dt.Rows.Count != 0)
                        {
                            if (user_dt.Rows[0][0].ToString().Trim() == "admin")
                            {
                                if (new_user_btn.Checked)
                                {
                                    confirm_pass_lbl.Visible = true;
                                    password_confirm_bx.Visible = true;
                                    log_save_btn.Visible = true;
                                    log_in_btn.Visible = false;
                                }
                                else
                                {
                                    confirm_pass_lbl.Visible = false;
                                    password_confirm_bx.Visible = false;
                                    log_save_btn.Visible = false;
                                    log_in_btn.Visible = true;
                                }
                            }

                        }
                        else
                            MessageBox.Show("تأكد من اسم المستخدم وكلمة السر");
                        password_bx.Clear();
                    }
                    catch (Exception g)
                    {
                        MessageBox.Show(g.Message + "دخول");
                    }
                }
                else
                    MessageBox.Show("تأكد من اسم المستخدم وكلمة السر");
            }
        }

        private void log_save_btn_Click(object sender, EventArgs e)
        {
            if (new_user_btn.Checked && password_bx.Text != "" && password_confirm_bx.Text != "" && user_nam_bx.Text != "")
            {

                try
                {
                    SqlCommand select_user_cmd = connect_sal.CreateCommand();
                    SqlDataAdapter user_adap = new SqlDataAdapter();
                    DataTable user_dt = new DataTable();
                    user_adap.SelectCommand = select_user_cmd;

                    select_user_cmd.CommandText = "SELECT * FROM user_table WHERE user_name='" + user_nam_bx.Text.Trim() + "'";
                    user_adap.Fill(user_dt);
                    if (user_dt.Rows.Count != 0)
                    {
                        MessageBox.Show("هذا الاسم تم تخزينه لمستخدم اخر من قضلك اختر مستخدم اخر");
                        user_nam_bx.Clear();
                        password_confirm_bx.Clear();
                        password_bx.Clear();

                    }
                    else
                    {

                        if (password_bx.Text == password_confirm_bx.Text)
                        {
                            SqlCommand insert_new_iser_cmd = connect_sal.CreateCommand();
                            insert_new_iser_cmd.CommandText = "INSERT INTO user_table(user_name,user_pass " + ")VALUES('" + user_nam_bx.Text.Trim() + "','" + password_confirm_bx.Text.Trim() + "')";
                            connect_sal.Open();
                            insert_new_iser_cmd.ExecuteNonQuery();
                            connect_sal.Close();
                            MessageBox.Show("تم ادخال مستخدم جديد");
                            user_nam_bx.Clear();
                            password_bx.Clear();
                            password_confirm_bx.Clear();

                            log_rdbtn.Checked = true;
                            user_nam_bx.Focus();
                        }
                        else
                            MessageBox.Show("كلمتيى السر غير متطابقتين");
                    }
                }
                catch (Exception f)
                {
                    // MessageBox.Show(f.Message + "مستخد جديد");
                }
            }
            else if (chang_pass_rdbtn.Checked && password_bx.Text != "" && password_confirm_bx.Text != "" && user_nam_bx.Text != "")//تغيير كلمة السر
            {
                try
                {
                    SqlCommand select_user_cmd = connect_sal.CreateCommand();
                    SqlDataAdapter user_adap = new SqlDataAdapter();
                    DataTable user_dt = new DataTable();
                    user_adap.SelectCommand = select_user_cmd;

                    select_user_cmd.CommandText = "SELECT * FROM user_table WHERE user_name='" + user_nam_bx.Text.Trim() + "' AND user_pass='" + password_bx.Text.Trim() + "'";
                    user_adap.Fill(user_dt);
                    if (user_dt.Rows.Count != 0)
                    {




                        SqlCommand update_pass_cmd = connect_sal.CreateCommand();
                        update_pass_cmd.CommandText = "UPDATE user_table SET user_pass='" + password_confirm_bx.Text.Trim() + "' WHERE user_name='" + user_nam_bx.Text.Trim() + "'";
                        connect_sal.Open();
                        update_pass_cmd.ExecuteNonQuery();
                        connect_sal.Close();
                        MessageBox.Show("تم تعديل كلمة السر");
                        password_bx.Clear();
                        password_confirm_bx.Clear();
                        log_rdbtn.Checked = true;
                        user_nam_bx.Focus();

                    }
                    else
                        MessageBox.Show("تأكد من كلمة السر واسم المستخدم");
                }
                catch (Exception f)
                {
                    //MessageBox.Show(f.Message + "تعديل كلمة سر");
                }
            }
            else
                MessageBox.Show("من فضلك تاكد من اختيارك وان البيانات سليمة");
        }

        private void log_rdbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (log_rdbtn.Checked)
            {
                log_in_btn.Visible = true;

                confirm_pass_lbl.Visible = false;
                password_confirm_bx.Visible = false;
                log_save_btn.Visible = false;
            }
        }

        private void chang_pass_rdbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (chang_pass_rdbtn.Checked)
            {
                confirm_pass_lbl.Visible = true;
                password_confirm_bx.Visible = true;
                log_save_btn.Visible = true;
                new_pass_lbl.Visible = true;

                log_in_btn.Visible = false;
            }
            else
            {
                confirm_pass_lbl.Visible = false;
                password_confirm_bx.Visible = false;
                log_save_btn.Visible = false;
                new_pass_lbl.Visible = false;

                log_in_btn.Visible = true;
            }
        }

        private void exit_app_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void log_in_frm_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void user_nam_bx_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void log_in_frm_Load(object sender, EventArgs e)
        {
            user_nam_bx.Focus();
        }

       

        private void user_nam_bx_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_bx_KeyDown(object sender, KeyEventArgs e)
        {
            if (log_rdbtn.Checked && e.KeyCode == Keys.Enter)
            {
                log_in_btn.PerformClick();
            }
            else if (chang_pass_rdbtn.Checked && e.KeyCode == Keys.Enter)
                log_save_btn.PerformClick();
            else if (new_user_btn.Checked && e.KeyCode == Keys.Enter)
                log_save_btn.PerformClick();
        }

        private void password_confirm_bx_KeyDown(object sender, KeyEventArgs e)
        {
            if (log_rdbtn.Checked && e.KeyCode == Keys.Enter)
            {
                log_in_btn.PerformClick();
            }
            else if (chang_pass_rdbtn.Checked && e.KeyCode == Keys.Enter)
                log_save_btn.PerformClick();
            else if (new_user_btn.Checked && e.KeyCode == Keys.Enter)
                log_save_btn.PerformClick();
        }

        private void log_in_frm_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void log_in_frm_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
