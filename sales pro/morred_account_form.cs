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
    public partial class morred_account_form : Form
    {
        public morred_account_form()
        {
            InitializeComponent();
        }
        private methodes meth = new methodes();

        private SqlConnection connect_sal = new SqlConnection("server=.\\SQLEXPRESS;database=sales;integrated security=SSPI");
        private void morred_account_form_Load(object sender, EventArgs e)
        {
            try
            {

                mor_pay_name_cmbx.DisplayMember = "AgentName";
                mor_pay_name_cmbx.ValueMember = "AgentId";
                mor_pay_quer_nam_cmbx.DisplayMember = "AgentName";
                mor_pay_quer_nam_cmbx.ValueMember = "AgentId";
                    mor_pay_name_cmbx.DataSource=meth.select_all_mored();
                    mor_pay_quer_nam_cmbx.DataSource=meth.select_all_mored();
             
            }
            catch (Exception kk)
            {
                MessageBox.Show(kk.Message + " morred_account_form_Load");
            }
        }

        private void mor_pay_name_cmbx_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (mor_pay_name_cmbx.Text != "")
            {
                mor_pay_remain_bx.Text = meth.select_mor_by_name_or_code("NULL", mor_pay_name_cmbx.Text.Trim()).Rows[0][2].ToString();
            }
        }

        private void mor_pay_mny_bx_TextChanged(object sender, System.EventArgs e)
        {
            try
            {
                if (meth.check_for_numreic(mor_pay_mny_bx.Text.Trim()))
                {
                }
                else
                {
                    mor_pay_mny_bx.Clear();
                }
            }
            catch { }
        }

        private void mor_pay_clear_bx_btn_Click(object sender, System.EventArgs e)
        {
            mor_pay_mny_bx.Clear();
           
            mor_pay_notes_bx.Clear();
            mor_pay_mny_bx.Enabled = true;
            pay_op_code_bx.Clear();
            mor_pay_quer_grid.Columns.Clear();
            mor_pay_date.Text = DateTime.Now.ToShortDateString();
        }

        private void mor_pay_new_btn_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (pay_op_code_bx.Text == "")
                {
                    if (mor_pay_mny_bx.Text.Trim() != "" && mor_pay_name_cmbx.Text.Trim()!="")
                    {
                        string result = "";
                        result=meth.minus_mny_imp_account(mor_pay_name_cmbx.SelectedValue.ToString(), mor_pay_mny_bx.Text.Trim());
                        SqlCommand insert_mor_pay_cmd = connect_sal.CreateCommand();

                        insert_mor_pay_cmd.CommandText = "insert into AgentDetails(AgentId, AgentStock, AgentMny, AgentNotes, AgentDetailDate, ag_mor_flag" + ")values(" +

                            mor_pay_name_cmbx.SelectedValue.ToString() + "," + result+ "," + mor_pay_mny_bx.Text + ",'"

                            + mor_pay_notes_bx.Text + "','" + mor_pay_date.Text + "','m" + "')";
                        connect_sal.Open();
                        insert_mor_pay_cmd.ExecuteNonQuery();
                        connect_sal.Close();
                       
                        if (meth.select_mor_by_name_or_code("NULL", mor_pay_name_cmbx.Text.Trim()).Rows.Count > 0)
                        {
                            mor_pay_remain_bx.Text = meth.select_mor_by_name_or_code(mor_pay_name_cmbx.SelectedValue.ToString(),"NULL").Rows[0][2].ToString();
                        }
                        MessageBox.Show("تم الحفظ");
                        mor_pay_clear_bx_btn.PerformClick();

                    }
                    else
                    {
                        MessageBox.Show("من فضلك ادخل بيانات التوريد صحيحه");
                        mor_pay_mny_bx.Clear();
                    }
                }
                else
                    MessageBox.Show("لايمكن حفظ عملية سابقا");
            }
            catch(Exception dd)
            {
                MessageBox.Show(dd.Message+"خطأ فى ادخال البيانات,يجب ادخال البيانات بدون اى علامات");
                connect_sal.Close();
            }
        }

        private void mor_pay_quer_exe_btn_Click(object sender, System.EventArgs e)
        {
           
                if (pay_op_code_bx.Text.Trim() != "" || mor_pay_mny_bx.Text.Trim() != "")
                {

                    if (MessageBox.Show("يوجد بيانات مدخلة هل تريد حفظها", "تحذير", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        mor_pay_new_btn.PerformClick();
                    }
                    else
                        mor_pay_clear_bx_btn.PerformClick();

                }
            
            try
            {
                if (mor_pay_quer_nam_cmbx.Text != "")
                {
                    SqlCommand select_ag_dis_cmd = connect_sal.CreateCommand();
                    DataTable pay_dtb = new DataTable();
                    SqlDataAdapter pay_adap = new SqlDataAdapter();
                    pay_adap.SelectCommand = select_ag_dis_cmd;

                    select_ag_dis_cmd.CommandText = "select AgentDetailId,AgentDetailDate, AgentMny, AgentNotes from AgentDetails" +

                        " where  AgentDetailDate between '" + mor_pay_quer_start_date.Text + "' and '" + mor_pay_end_date.Text +

                        "' and del_flag<>'del' and ag_mor_flag='m' and AgentId=" +

                       meth.select_mor_by_name_or_code("NULL", mor_pay_quer_nam_cmbx.Text.Trim()).Rows[0][0].ToString();

                    pay_adap.Fill(pay_dtb);

                    pay_dtb.Columns[0].ColumnName = "كود عملية الخصم";
                    pay_dtb.Columns[1].ColumnName = "تاريخ التوريد";
                    pay_dtb.Columns[2].ColumnName = " المبلغ";

                    pay_dtb.Columns[3].ColumnName = "ملاحظات";
                    mor_pay_quer_grid.DataSource = pay_dtb;
                }
            }
            catch (Exception hh)
            {
                MessageBox.Show(hh.Message);

            }
        }

        private void mor_pay_quer_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (mor_pay_quer_grid.Rows.Count > 0)
                {
                    mor_pay_name_cmbx.Text = mor_pay_quer_nam_cmbx.Text;

                    pay_op_code_bx.Text = mor_pay_quer_grid.CurrentRow.Cells[0].Value.ToString();

                    mor_pay_date.Text = mor_pay_quer_grid.CurrentRow.Cells[1].Value.ToString();

                    mor_pay_mny_bx.Text = mor_pay_quer_grid.CurrentRow.Cells[2].Value.ToString();

                    mor_pay_notes_bx.Text = mor_pay_quer_grid.CurrentRow.Cells[3].Value.ToString();

                  
                }

            }
            catch (Exception hh)
            {
                MessageBox.Show(hh.Message);

            }
        }

        private void mor_pay_del_btn_Click(object sender, System.EventArgs e)
        {
            if (pay_op_code_bx.Text != "")
            {
                try
                {

                    meth.add_mny_imp_account(mor_pay_name_cmbx.SelectedValue.ToString(), mor_pay_mny_bx.Text);

                    SqlCommand update_pay_cmd = connect_sal.CreateCommand();

                    update_pay_cmd.CommandText = "UPDATE AgentDetails SET del_flag='del'" +
                        " WHERE AgentDetailId=" + pay_op_code_bx.Text.Trim() + " and ag_mor_flag='m'";

                    connect_sal.Open();
                    int rows = update_pay_cmd.ExecuteNonQuery();
                    connect_sal.Close();
                    mor_pay_remain_bx.Text = meth.select_mor_by_name_or_code(mor_pay_name_cmbx.SelectedValue.ToString(), "NULL").Rows[0][2].ToString();
                    mor_pay_clear_bx_btn.PerformClick();
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
                mor_pay_mny_bx.Clear();
            }
        }

        private void pay_op_code_bx_TextChanged(object sender, System.EventArgs e)
        {
           
        }

        private void mor_acc_updat_btn_Click(object sender, System.EventArgs e)
        {
            if (pay_op_code_bx.Text != "")
            {

                try
                {

                  

                    if (mor_pay_mny_bx.Text.Trim() != "")
                    {


                       
                        ////اولا الغاء المبلغ/
                        if (mor_pay_quer_grid.Rows.Count > 0)
                            meth.add_mny_imp_account(mor_pay_name_cmbx.SelectedValue.ToString(), mor_pay_quer_grid.CurrentRow.Cells[2].Value.ToString());

                        SqlCommand delete_pay_cmd = connect_sal.CreateCommand();

                        delete_pay_cmd.CommandText = "delete from AgentDetails" +
                            " WHERE AgentDetailId=" + pay_op_code_bx.Text.Trim() + " and ag_mor_flag='m'";

                        connect_sal.Open();
                        int rows = delete_pay_cmd.ExecuteNonQuery();
                        connect_sal.Close();
                        meth.minus_mny_imp_account(mor_pay_name_cmbx.SelectedValue.ToString(), mor_pay_mny_bx.Text.Trim());//خصم من المورد
                        if (meth.select_mor_by_name_or_code(mor_pay_name_cmbx.SelectedValue.ToString(),"NULL").Rows.Count > 0)
                        {
                            mor_pay_remain_bx.Text = meth.select_mor_by_name_or_code(mor_pay_name_cmbx.SelectedValue.ToString(),"NULL").Rows[0][2].ToString();
                        }

                        if (meth.select_mor_by_name_or_code(mor_pay_name_cmbx.SelectedValue.ToString(),"NULL").Rows.Count > 0)
                        {
                            mor_pay_remain_bx.Text = meth.select_mor_by_name_or_code(mor_pay_name_cmbx.SelectedValue.ToString(),"NULL").Rows[0][2].ToString();
                        }

                        ////////ثانيا اضافة الجديد اى خصمه من حساب المورد////
                        SqlCommand insert_mor_pay_cmd = connect_sal.CreateCommand();

                        insert_mor_pay_cmd.CommandText = "insert into AgentDetails(AgentId, AgentStock, AgentMny, AgentNotes, AgentDetailDate, ag_mor_flag" + ")values(" +

                             mor_pay_name_cmbx.SelectedValue.ToString() + "," + mor_pay_remain_bx.Text + "," + mor_pay_mny_bx.Text + ",'"

                            + mor_pay_notes_bx.Text + "','" + mor_pay_date.Text + "','m" + "')";
                        connect_sal.Open();
                        insert_mor_pay_cmd.ExecuteNonQuery();
                        connect_sal.Close();

                        MessageBox.Show("تم الحفظ");
                        mor_pay_clear_bx_btn.PerformClick();

                    }
                    else
                    {
                        MessageBox.Show("من فضلك ادخل المبلغ");
                        mor_pay_mny_bx.Clear();
                    }


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
                mor_pay_mny_bx.Clear();
            }
        }

        private void mor_pay_exp_ExpandedChanging(object sender, DevComponents.DotNetBar.ExpandedChangeEventArgs e)
        {
           
        }

        private void mor_pay_mny_bx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                mor_pay_new_btn.PerformClick();
        }

        private void mor_pay_notes_bx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                mor_pay_new_btn.PerformClick();
        }

        private void exit_btn_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void recalc_mor_btn_Click(object sender, System.EventArgs e)
        {
            try
            {
                double remain = 0;
                double mor_sels = 0;
                double mor_pays = 0;
                //سحب مبيعات مورد/////////////
                SqlCommand select_sum_sels_ag_cmd = connect_sal.CreateCommand();
                DataTable dtb1 = new System.Data.DataTable();
                SqlDataAdapter adap1 = new SqlDataAdapter();
                adap1.SelectCommand = select_sum_sels_ag_cmd;

                select_sum_sels_ag_cmd.CommandText = "select SUM(BillTotal) from Bill where  BillType='w' AND BillDate BETWEEN  '" + recalc_start_date.Text + "' and '" +
                    recalc_end_date.Text + "' and AgentId=" + mor_pay_name_cmbx.SelectedValue.ToString();

                adap1.Fill(dtb1);
                if (dtb1.Rows.Count > 0)
                {
                    if (dtb1.Rows[0][0].ToString().Trim() != "")
                        mor_sels = double.Parse(dtb1.Rows[0][0].ToString());
                }

                //سحب مدفوعات مورد/////////////
                SqlCommand select_sum_pays_ag_cmd = connect_sal.CreateCommand();
                DataTable dtb2 = new System.Data.DataTable();
                SqlDataAdapter adap2 = new SqlDataAdapter();
                adap2.SelectCommand = select_sum_pays_ag_cmd;

                select_sum_pays_ag_cmd.CommandText = "SELECT SUM(Agentmny) from AgentDetails where ag_mor_flag ='m' and del_flag ='n' and AgentDetailDate between'" + recalc_start_date.Text + "' and '" +
                    recalc_end_date.Text + "' and AgentId=" + mor_pay_name_cmbx.SelectedValue.ToString();

                adap2.Fill(dtb2);
                if (dtb2.Rows.Count > 0)
                {
                    if (dtb2.Rows[0][0].ToString().Trim() != "")
                        mor_pays = double.Parse(dtb2.Rows[0][0].ToString());
                }

                remain = mor_sels - mor_pays;
                SqlCommand update_cmd = connect_sal.CreateCommand();
                update_cmd.CommandText = "update Agent set AgentStock=" + remain.ToString() + " where AgentId=" + mor_pay_name_cmbx.SelectedValue.ToString();
                if (MessageBox.Show("هل تريد تعديل حفظ هذاالرصيد" + "  " + remain.ToString(), "الرصيد المتبقى", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    connect_sal.Open();
                    update_cmd.ExecuteNonQuery();
                    connect_sal.Close();
                    MessageBox.Show("لقد تم تعديل الرصيد المتبقى للمورد  " + mor_pay_name_cmbx.Text);
                }
            }
            catch (Exception hh)
            {
                MessageBox.Show(hh.Message);

            }
        }

        private void recalc_mor_chbx_CheckedChanged(object sender, System.EventArgs e)
        {
            if (recalc_mor_chbx.Checked)
            {
                recalc_end_date.Visible = true;
                recalc_start_date.Visible = true;
                recalc_mor_btn.Visible = true;
                label9.Visible = true;
            }
            else
            {
                recalc_end_date.Visible = false;
                recalc_start_date.Visible = false;
                recalc_mor_btn.Visible = false;
                label9.Visible = false;
            }
        }
    }
}
