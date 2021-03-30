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
    public partial class addStoreForm : Form
    {
        public addStoreForm()
        {
            InitializeComponent();
        }
        private SqlConnection connect_sal = new SqlConnection("server=.\\SQLEXPRESS;database=sales;integrated security=SSPI");
        private methodes meth = new methodes();
        private void new_btn_Click(object sender, EventArgs e)
        {
            string Instr = "insert into StoreNameTbl(Stname) values('" + company_name_box.Text.Trim() + "')";
            if (company_id_bx.Text.Trim() == "")
            {
                try
                {
                    if (company_name_box.Text.Trim() != "")
                    {
                        connect_sal.Open();
                        SqlCommand sql = new SqlCommand(Instr, connect_sal);
                        sql.ExecuteNonQuery();
                        connect_sal.Close();
                        MessageBox.Show("تم الأدخال بنجاح");
                        SqlCommand selectId = new SqlCommand();
                        comp_q_cmbx.DisplayMember = "Stname";
                        comp_q_cmbx.ValueMember = "STId";
                        comp_q_cmbx.DataSource = meth.select_all_store();
                        com_ClearBtn.PerformClick();
                    }
                    else
                        MessageBox.Show("من فضلك ادخل اسم ألمخزن");
                }
                catch (Exception ex)
                {
                    connect_sal.Close();
                    if (ex.Message.Contains("UNIQUE KEY"))
                        MessageBox.Show(" !!المخزن موجوده من قبل", " خطأ");
                    else
                        MessageBox.Show("الرجاء استكمال جميع البيانات اولا و ادخال البيانات صحيحة وبدون اى علامات");
                }
            }
            else
            {
                if (MessageBox.Show("هذه البيانات تم حفظها من قبل هل تريد تعديلها", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    com_UpdateBtn.PerformClick();

                /* if (CatIdTB.Text == "")
                      MessageBox.Show("الرجاء استكمال جميع لبيانات اولا قبل الحفظ","خطأ");
                  else
                      MessageBox.Show("لا يمكن ادخال بيانات موجوده من قبل لكن يمكنك تعديلها", "خطأ");
                  ClearBtn_Click(sender, e);*/
            }
        }

        private void com_UpdateBtn_Click(object sender, EventArgs e)
        {
            string Updstr = "Update  StoreNameTbl set Stname='" + company_name_box.Text.Trim() + "' where STId=" + company_id_bx.Text.Trim();

            try
            {
                connect_sal.Open();
                SqlCommand sql = new SqlCommand(Updstr, connect_sal);
                sql.ExecuteNonQuery();
                connect_sal.Close();
                MessageBox.Show("تم التعديل بنجاح");
                SqlCommand selectId = new SqlCommand();
                comp_q_cmbx.DisplayMember = "Stname";
                comp_q_cmbx.ValueMember = "STId";
                comp_q_cmbx.DataSource = meth.select_all_store();
                com_ClearBtn.PerformClick();
            }
            catch (Exception ex)
            {

                if (ex.Message.Contains("UNIQUE KEY"))
                    MessageBox.Show(" !المخزن موجود من قبل", " خطأ");
                else if (company_id_bx.Text == "")
                    MessageBox.Show("الرجاء اختيار المخزن المراد تعديل بياناته");
                connect_sal.Close();
            }
        }

        private void comp_q_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comp_q_cmbx.Items.Count > 0)
                {
                    company_id_bx.Text = meth.select_store_by_code(comp_q_cmbx.SelectedValue.ToString()).Rows[0][0].ToString();
                    company_name_box.Text = meth.select_store_by_code(comp_q_cmbx.SelectedValue.ToString()).Rows[0][1].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addStoreForm_Load(object sender, EventArgs e)
        {
            comp_q_cmbx.DisplayMember = "Stname";
            comp_q_cmbx.ValueMember = "STId";
            comp_q_cmbx.DataSource = meth.select_all_store();
            com_ClearBtn.PerformClick();
        }

        private void com_ClearBtn_Click(object sender, EventArgs e)
        {
            company_id_bx.Clear();
            company_name_box.Clear();
        }
    }
}
