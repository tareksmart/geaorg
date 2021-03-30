using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sales_pro
{
    public partial class spent_form : Form
    {
        public spent_form()
        {
            InitializeComponent();
        }
        private methodes meth = new methodes();

        private SqlConnection connect_sal = new SqlConnection("server=.\\SQLEXPRESS;database=sales;integrated security=SSPI");
        private void spent_mny_bx_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (meth.check_for_numreic(spent_mny_bx.Text.Trim()))
                {
                }
                else
                {
                    spent_mny_bx.Clear();
                }
            }
            catch { }
        }

        private void spent_new_btn_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (spent_op_code_bx.Text.Trim() == "")
                {
                    if (spent_mny_bx.Text.Trim() != "")
                    {
                        SqlCommand insert_spent_cmd = connect_sal.CreateCommand();
                        insert_spent_cmd.CommandText = "insert into spent_table(spent_date , spent_mny, spent_bian" + ")values('" +
                            spent_date.Text + "'," + spent_mny_bx.Text.Trim() + ",'" + spent_bian_bx.Text.Trim() + "')";

                        connect_sal.Open();
                        insert_spent_cmd.ExecuteNonQuery();
                        connect_sal.Close();

                        MessageBox.Show("تم الحفظ");
                        spent_clear_bx_btn.PerformClick();

                    }
                    else
                    {
                        MessageBox.Show("من فضلك ادخل المبلغ");
                        spent_mny_bx.Clear();
                    }
                }
                else
                    MessageBox.Show("لايمكن حفظ عملية سابقا");
            }
            catch (Exception hh)
            {
                MessageBox.Show("خطأ فى ادخال البيانات,يجب ادخال البيانات بدون اى علامات");
                connect_sal.Close();
            }
        }

        private void spent_clear_bx_btn_Click(object sender, System.EventArgs e)
        {
            spent_op_code_bx.Clear();
            spent_bian_bx.Clear();
            spent_mny_bx.Clear();
            spent_quer_grid.Columns.Clear();
            spent_date.Text = DateTime.Now.ToShortDateString();
        }

        private void spent_quer_exe_btn_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (spent_op_code_bx.Text.Trim() != "" || spent_mny_bx.Text.Trim() != "")
                {

                    if (MessageBox.Show("يوجد بيانات مدخلة هل تريد حفظها", "تحذير", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        spent_new_btn.PerformClick();
                    }
                    else
                        spent_clear_bx_btn.PerformClick();

                }
            }
            catch { }
            try
            {
                SqlCommand select_spent_cmd = connect_sal.CreateCommand();
                DataTable spent_dtb = new DataTable();
                SqlDataAdapter spent_adap = new SqlDataAdapter();
                spent_adap.SelectCommand = select_spent_cmd;

                select_spent_cmd.CommandText = "select spent_id, spent_date, spent_mny, spent_bian from spent_table" +

                    " where  spent_date between '" + spent_quer_start_date.Text + "' and '" + spent_quer_end_date.Text +

                    "' and spent_flag<>'del' ";

                  

                spent_adap.Fill(spent_dtb);

                spent_dtb.Columns[0].ColumnName = "كود عملية الصرف";
                spent_dtb.Columns[1].ColumnName = "تاريخ الصرف";
                spent_dtb.Columns[2].ColumnName = " المبلغ";

                spent_dtb.Columns[3].ColumnName = "بيان المبلغ";
                spent_quer_grid.DataSource = spent_dtb;
            }
            catch (Exception hh)
            {
                MessageBox.Show(hh.Message);

            }
        }

        private void spent_quer_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void spent_del_btn_Click(object sender, System.EventArgs e)
        {
            if (spent_op_code_bx.Text != "")
            {
                try
                {


                    SqlCommand update_pay_cmd = connect_sal.CreateCommand();

                    update_pay_cmd.CommandText = "UPDATE spent_table SET spent_flag='del'" +
                        " WHERE spent_id=" + spent_op_code_bx.Text.Trim();
                    connect_sal.Open();
                    int rows = update_pay_cmd.ExecuteNonQuery();
                    connect_sal.Close();

                    spent_clear_bx_btn.PerformClick();
                    MessageBox.Show("تم الحفظ");

                }
                catch (Exception g)
                {
                    MessageBox.Show(g.Message);
                    connect_sal.Close();
                }
            }
            else
            {
                MessageBox.Show("من فضلك استعلم عن المبلغ المراد الغاءه");
                spent_mny_bx.Clear();
            }
        }

        private void spent_quer_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (spent_quer_grid.Rows.Count > 0)
                {


                    spent_op_code_bx.Text = spent_quer_grid.CurrentRow.Cells[0].Value.ToString();

                    spent_date.Text = spent_quer_grid.CurrentRow.Cells[1].Value.ToString();

                    spent_mny_bx.Text = spent_quer_grid.CurrentRow.Cells[2].Value.ToString();

                    spent_bian_bx.Text = spent_quer_grid.CurrentRow.Cells[3].Value.ToString();


                }

            }
            catch (Exception hh)
            {
                MessageBox.Show(hh.Message);

            }
        }

        private void spent_up_btn_Click(object sender, System.EventArgs e)
        {
            if (spent_op_code_bx.Text != "")
            {
                try
                {


                    SqlCommand update_pay_cmd = connect_sal.CreateCommand();

                    update_pay_cmd.CommandText = "UPDATE spent_table SET spent_mny=" + spent_mny_bx.Text + ", spent_bian='" + spent_bian_bx.Text.Trim() + "'" +
                        " WHERE spent_id=" + spent_op_code_bx.Text.Trim();
                    connect_sal.Open();
                    int rows = update_pay_cmd.ExecuteNonQuery();
                    connect_sal.Close();

                    spent_clear_bx_btn.PerformClick();
                    MessageBox.Show("تم الحفظ");

                }
                catch (Exception g)
                {
                    MessageBox.Show("خطأ فى ادخال البيانات,يجب ادخال البيانات بدون اى علامات");
                    connect_sal.Close();
                }
            }
            else
            {
                MessageBox.Show("من فضلك استعلم عن المبلغ المراد تعديلها");
                spent_mny_bx.Clear();
            }
        }

        private void spent_form_Load(object sender, System.EventArgs e)
        {

        }

        private void spent_quer_exp_ExpandedChanging(object sender, DevComponents.DotNetBar.ExpandedChangeEventArgs e)
        {
            if (spent_quer_exp.Expanded == false)
            {
               
            }
        }

        private void spent_mny_bx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                spent_new_btn.PerformClick();
        }

        private void spent_bian_bx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                spent_new_btn.PerformClick();
        }

        private void exit_btn_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        
    }
}
