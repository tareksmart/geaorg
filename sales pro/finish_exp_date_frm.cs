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
    public partial class finish_exp_date_frm : Form
    {
        public finish_exp_date_frm()
        {
            InitializeComponent();
        }
        private SqlConnection con = new SqlConnection("server=.\\SQLEXPRESS;database=sales;integrated security=SSPI");
        private methodes meth = new methodes();
        private void finish_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (finish_expire_date_bx.Value.Subtract(DateTime.Now.Date).TotalDays < 1)
                {
                    if (finish_ex_item_id_bx.Text.Trim() != "")
                    {
                        SqlCommand update_expir_cmd = con.CreateCommand();
                        update_expir_cmd.CommandText = "update expire_item_table set ex_it_date_flag='29' where expire_id=" +
                            op_code_bx.Text.Trim();

                        con.Open();
                        update_expir_cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("تم");
                        op_code_bx.Clear();
                        finish_ex_item_id_bx.Clear();
                        finish_ex_item_name_bx.Clear();

                        this.Close();
                    }
                }
                else if (MessageBox.Show("صلاحية هذا الصنف لم تنتهى بعد هل تريد الاستمرار", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (finish_ex_item_id_bx.Text.Trim() != "")
                    {
                        SqlCommand update_expir_cmd = con.CreateCommand();
                        update_expir_cmd.CommandText = "update expire_item_table set ex_it_date_flag='29' where expire_id=" +
                            op_code_bx.Text.Trim();

                        con.Open();
                        update_expir_cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("تم");
                        op_code_bx.Clear();
                        finish_ex_item_id_bx.Clear();
                        finish_ex_item_name_bx.Clear();

                        this.Close();
                    }
                }
                else
                    this.Close();
            }
            catch (Exception dd)
            {
                MessageBox.Show(dd.Message);
                con.Close();

            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void finish_exp_date_frm_Load(object sender, EventArgs e)
        {

        }

        private void finish_ex_item_id_bx_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
