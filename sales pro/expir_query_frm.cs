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
    public partial class expir_query_frm : Form
    {
        public expir_query_frm()
        {
            InitializeComponent();
        }
        private SqlConnection con = new SqlConnection("server=.\\SQLEXPRESS;database=sales;integrated security=SSPI");
        private methodes meth = new methodes();
        private int i = 0;
        private void expir_query_frm_Load(object sender, EventArgs e)
        {
            try///تصنيفات
            {
                k_tasn_nam_cmbx.DisplayMember = "CatName";
                k_tasn_nam_cmbx.ValueMember = "CatId";
                if (meth.select_all_tasneef().Rows.Count > 0)//item_cat_q_cmbx
                {
                    k_tasn_nam_cmbx.DataSource = meth.select_all_tasneef();
                   

                }

                company_nam_cmbx.DisplayMember = "com_name";
                company_nam_cmbx.ValueMember = "com_id";
                company_nam_cmbx.DataSource =meth.select_all_company();
            }
            catch (Exception ff)
            {
                MessageBox.Show(ff.Message);
            }
        }

        private void k_sanf_q_code_bx_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {

                if (e.KeyCode == Keys.Enter)
                {
                     Int64 sanf_code = 0;

                     if (k_sanf_q_code_bx.Text.Trim() != "")
                        {

                            if (meth.check_for_numreic(k_sanf_q_code_bx.Text.Trim()))
                            {
                                sanf_code = Convert.ToInt64(k_sanf_q_code_bx.Text.Trim());
                                if (meth.select_sanf_data_by_barcode_orcode(sanf_code.ToString()).Rows.Count > 0 && sanf_code > 0 && sanf_code.ToString().Trim().Length < 7)
                                {
                                    k_it_id_bx.Text = sanf_code.ToString();
                                    k_sanf_q_code_bx.Clear();
                                }
                                else if (meth.select_sanf_data_by_barcode(sanf_code.ToString()).Rows.Count > 0 && sanf_code > 0 && sanf_code.ToString().Trim().Length > 7)
                                {
                                    k_it_id_bx.Text = meth.select_sanf_data_by_barcode(sanf_code.ToString()).Rows[0][0].ToString().Trim();
                                    k_sanf_q_code_bx.Clear();
                                }
                                else
                                {
                                    k_tasn_nam_cmbx.Text = "";
                                    k_sanf_nam_cmbx.Text = "";
                                    remain_kem_bx.Clear();
                                }


                            }
                            else
                            {
                                //wared_sanf_code_bx.Clear();
                            }
                        }
                        else
                        {
                            k_tasn_nam_cmbx.Text = "";
                            k_sanf_nam_cmbx.Text = "";
                            remain_kem_bx.Clear();
                        }
                   
                }
            }
            catch (Exception dd)
            {
                MessageBox.Show(dd.Message);
            }
        }

        private void k_tasn_nam_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void k_sanf_nam_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void item_query_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (k_it_id_bx.Text.Trim() != "")
                {
                    sels_q_grid.Columns.Clear();
                    SqlCommand select_item_expi_cmd = con.CreateCommand();

                    SqlDataAdapter store_adap = new SqlDataAdapter();
                    DataTable dtb = new DataTable();
                    store_adap.SelectCommand = select_item_expi_cmd;
                    //MessageBox.Show(dd.Message);
                    
                    
                        select_item_expi_cmd.CommandText = "SELECT  expire_id as 'كود العملية',expire_item_id as 'ID',"+
                            
                            "ItemName as 'اسم الصنف', ((DATEDIFF(dd,getdate(),expire_date))/30)" +

                            " as 'الفترة المتبقية بالشهر تقريبا' ,(DATEDIFF(dd,getdate(),expire_date)) as 'الفترة المتبقية باليوم', expire_date as 'تاريخ الانتهاء',com_name as 'الشركة المنتجة'" +


                            "   FROM expire_item_table join (Items join (ItemDetails join company_table on ItemDetails.item_comp_id=company_table.com_id) on Items.ItemId=ItemDetails.ItemId)" 
                            +" on expire_item_table.expire_item_id=Items.ItemId "+
                            " WHERE  ex_it_date_flag <>'29' and expire_item_id=" + k_it_id_bx.Text.Trim();

                        store_adap.Fill(dtb);
                    
                    sels_q_grid.DataSource = dtb;
                   // dtb.Rows.Clear();
                }
            }
            catch (Exception dd)
            {
                MessageBox.Show(dd.Message);
            }
        }

        private void expir_items_query_btn_Click(object sender, EventArgs e)
        {
            try
            {
                wait_frm w = new wait_frm();
                w.Show();
                sels_q_grid.Columns.Clear();
               
                string messag = "";
                int i = 0;
                if (sels_q_grid.Columns.Count <= 0)
                {
                    sels_q_grid.Columns.Add("5", "كودالعملية");
                    sels_q_grid.Columns.Add("1", "ID");
                    sels_q_grid.Columns.Add("2", "اسم الصنف");
                    sels_q_grid.Columns.Add("3", "المدة المتبقية باليوم");
                    sels_q_grid.Columns.Add("7", "المدة المتبقية بالشهر تقريبا");
                    sels_q_grid.Columns.Add("4", "تاريخ الانتهاء");
                    sels_q_grid.Columns.Add("5", "المتبقى");
                    sels_q_grid.Columns.Add("6", "الشركة المنتجة");
                }
                if (meth.expire_date_less_what_day(90).Rows.Count > 0)
                {
                    for (int row = 0; row < meth.expire_date_less_what_day(90).Rows.Count; row++)
                    {
                        if (Convert.ToInt32(meth.expire_date_less_what_day(90).Rows[row][0].ToString()) <=

                            90 )
                        {
                          
                            sels_q_grid.DataSource = null;
                            sels_q_grid.Rows.Add(1);


                            sels_q_grid.Rows[i].Cells[0].Value = meth.expire_date_less_what_day(90).Rows[row][4].ToString();

                            sels_q_grid.Rows[i].Cells[1].Value = meth.expire_date_less_what_day(90).Rows[row][2].ToString();

                            sels_q_grid.Rows[i].Cells[2].Value = meth.expire_date_less_what_day(90).Rows[row][1].ToString();

                            sels_q_grid.Rows[i].Cells[3].Value = meth.expire_date_less_what_day(90).Rows[row][0].ToString();

                            sels_q_grid.Rows[i].Cells[4].Value = (Int32.Parse(meth.expire_date_less_what_day(90).Rows[row][0].ToString()) / 30).ToString();

                            sels_q_grid.Rows[i].Cells[5].Value = meth.expire_date_less_what_day(90).Rows[row][3].ToString();

                            if (meth.select_sanf_data_store(meth.expire_date_less_what_day(90).Rows[row][2].ToString()).Rows.Count > 0)
                            sels_q_grid.Rows[i].Cells[6].Value =
                                meth.select_sanf_data_store(meth.expire_date_less_what_day(90).Rows[row][2].ToString()).Rows[0][1].ToString();

                            sels_q_grid.Rows[i].Cells[7].Value = meth.expire_date_less_what_day(90).Rows[row][5].ToString();
                            i = i + 1;
                        }


                    }
                }
                w.Close();


            }
            catch (Exception dd)
            {
                MessageBox.Show(dd.Message+" خطا فى ادخال البيانات");
            }
        }

        private void sels_q_grid_DoubleClick(object sender, EventArgs e)
        {
            try
            {
              /*  finish_exp_date_frm k_frm = new finish_exp_date_frm();

                if (sels_q_grid.Rows.Count > 0)
                {
                    k_frm.op_code_bx.Text = sels_q_grid.CurrentRow.Cells[0].Value.ToString();

                    k_frm.finish_ex_item_id_bx.Text = sels_q_grid.CurrentRow.Cells[1].Value.ToString();

                    k_frm.finish_ex_item_name_bx.Text = sels_q_grid.CurrentRow.Cells[2].Value.ToString();
                   // MessageBox.Show(k_frm.finish_expire_date_bx.Text+"  forma");
                   // MessageBox.Show( DateTime.Parse(sels_q_grid.CurrentRow.Cells[5].Value.ToString()).ToShortDateString() + "  from grid");
                    k_frm.finish_expire_date_bx.Text =DateTime.Parse(sels_q_grid.CurrentRow.Cells[5].Value.ToString()).ToShortDateString();

                    k_frm.ShowDialog();

                

                }*/
            }
            catch (Exception dd)
            {
                MessageBox.Show(dd.Message + "88");
            }
        }
       // private q_item_form query_it = new q_item_form();
        private void item_qu_btn_Click(object sender, EventArgs e)
        {
            try
            {
             //   query_it.ShowDialog();

             //   k_it_id_bx.Text = query_it.pub_item_id;

               // query_it.pub_item_id = "";
              //  k_sanf_q_code_bx.Focus();

            }
            catch { }
        }

        private void k_it_id_bx_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Int64 sanf_code = 0;

                if (k_it_id_bx.Text.Trim() != "")
                {

                    if (meth.check_for_numreic(k_it_id_bx.Text.Trim()))
                    {
                        sanf_code = Convert.ToInt64(k_it_id_bx.Text.Trim());
                        if (meth.select_sanf_data_by_barcode_orcode(sanf_code.ToString()).Rows.Count > 0)
                        {
                            k_it_id_bx.Text = meth.select_sanf_data_by_barcode_orcode(sanf_code.ToString()).Rows[0][0].ToString();
                            k_sanf_nam_cmbx.Text = meth.select_sanf_data_by_barcode_orcode(sanf_code.ToString()).Rows[0][1].ToString();
                            if (meth.select_sanf_data_store(sanf_code.ToString()).Rows.Count > 0)
                                remain_kem_bx.Text = meth.select_sanf_data_store(sanf_code.ToString()).Rows[0][1].ToString();
                            else
                                MessageBox.Show("لم يسجل بالمخزن كبيان");
                            k_tasn_nam_cmbx.Text = meth.select_tasn_data_bynam_orcode(meth.select_sanf_data_by_barcode_orcode(sanf_code.ToString()).Rows[0][8].ToString().Trim(), "NULL").Rows[0][1].ToString();
                        }
                        else
                        {
                            k_sanf_nam_cmbx.Text = "";
                            remain_kem_bx.Text = "";
                            k_tasn_nam_cmbx.Text = "";//.Clear();
                            
                        }


                    }
                    else
                    {
                        //wared_sanf_code_bx.Clear();
                    }
                }
                else
                {
                    k_sanf_nam_cmbx.Text = "";
                    remain_kem_bx.Text = "";
                    k_tasn_nam_cmbx.Text = "";//.Clear();
                }
            }
            catch (Exception d)
            {
                MessageBox.Show("خطأ فى الادخال");
            }
        }

        private void k_sanf_q_code_bx_TextChanged(object sender, EventArgs e)
        {

        }

        private void sels_q_grid_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void item_expire_finish_btn_Click(object sender, EventArgs e)
        {
            try
            {
                wait_frm w = new wait_frm();
                w.Show();
                sels_q_grid.Columns.Clear();

                string messag = "";
                int i = 0;
                if (sels_q_grid.Columns.Count <= 0)
                {
                    sels_q_grid.Columns.Add("0", "كودالعملية");
                    sels_q_grid.Columns.Add("1", "ID");
                    sels_q_grid.Columns.Add("2", "اسم الصنف");
                    sels_q_grid.Columns.Add("3", "المدة المتبقية باليوم");
                  
                    sels_q_grid.Columns.Add("5", "تاريخ الانتهاء");
                    sels_q_grid.Columns.Add("4", "المتبقى");
                    sels_q_grid.Columns.Add("6", "الشركة المنتجة");
                }
                if (meth.expire_date_less_what_day(0).Rows.Count > 0)
                {
                    for (int row = 0; row < meth.expire_date_less_what_day(0).Rows.Count; row++)
                    {
                        if (Convert.ToInt32(meth.expire_date_less_what_day(0).Rows[row][0].ToString()) <=

                            1 )
                        {

                            sels_q_grid.DataSource = null;
                            sels_q_grid.Rows.Add(1);


                            sels_q_grid.Rows[i].Cells[0].Value = meth.expire_date_less_what_day(0).Rows[row][4].ToString();

                            sels_q_grid.Rows[i].Cells[1].Value = meth.expire_date_less_what_day(0).Rows[row][2].ToString();

                            sels_q_grid.Rows[i].Cells[2].Value = meth.expire_date_less_what_day(0).Rows[row][1].ToString();

                            sels_q_grid.Rows[i].Cells[3].Value = meth.expire_date_less_what_day(0).Rows[row][0].ToString();

                            sels_q_grid.Rows[i].Cells[5].Value = DateTime.Parse(meth.expire_date_less_what_day(0).Rows[row][3].ToString()).ToShortDateString();

                            sels_q_grid.Rows[i].Cells[4].Value =
                               meth.select_sanf_data_store(meth.expire_date_less_what_day(0).Rows[row][2].ToString());

                            sels_q_grid.Rows[i].Cells[6].Value = meth.expire_date_less_what_day(0).Rows[row][5].ToString();
                            i = i + 1;
                        }


                    }
                }

                w.Close();

            }
            catch (Exception dd)
            {
                MessageBox.Show(dd.Message + " خطا فى ادخال البيانات");
            }
        }

        private void labelX1_Click(object sender, EventArgs e)
        {

        }

        private void finish_expire_selected_item_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (sels_q_grid.SelectedRows.Count > 0)
                {
                    if(MessageBox.Show("سوف يتم انهاء كل صلاحيات الصنف المحددة", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        for (int i = 0; i < sels_q_grid.SelectedRows.Count; i++)
                        {
                            if (DateTime.Parse(sels_q_grid.SelectedRows[i].Cells[5].Value.ToString()).Subtract(DateTime.Now.Date).TotalDays < 1)
                            {

                                SqlCommand update_expir_cmd = con.CreateCommand();
                                update_expir_cmd.CommandText = "update expire_item_table set ex_it_date_flag='29' where expire_id=" +
                                   sels_q_grid.SelectedRows[i].Cells[0].Value.ToString();

                                con.Open();
                                update_expir_cmd.ExecuteNonQuery();
                                con.Close();

                            }
                            else
                            {
                                
                                if (MessageBox.Show("لم تنتهى بعد هل تريد الاستمرار   " + sels_q_grid.SelectedRows[i].Cells[2].Value.ToString() + " صلاحية هذا الصنف ", "تحذير", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                                {
                                    if (sels_q_grid.SelectedRows.Count > 0)
                                    {
                                        SqlCommand update_expir_cmd = con.CreateCommand();
                                        update_expir_cmd.CommandText = "update expire_item_table set ex_it_date_flag='29' where expire_id=" +
                                           sels_q_grid.SelectedRows[i].Cells[0].Value.ToString();

                                        con.Open();
                                        update_expir_cmd.ExecuteNonQuery();
                                        con.Close();
                                    }
                                    else
                                        MessageBox.Show("لاتوجد سجلات محددة");

                                }
                                else
                                {
                                    break;
                                }
                            }
                           
                        }
                        MessageBox.Show("تم");
                        sels_q_grid.Columns.Clear();
                    }
                   
                   
                }
            }
            catch (Exception dd)
            {
                MessageBox.Show(dd.Message);
                con.Close();

            }
        }

        private void finish_expire_all_item_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (sels_q_grid.Rows.Count > 0)
                {
                    if (MessageBox.Show("سوف يتم انهاء كل صلاحيات الصنف المحددة", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        for (int i = 0; i < sels_q_grid.Rows.Count; i++)
                        {
                            if (DateTime.Parse(sels_q_grid.Rows[i].Cells[5].Value.ToString()).Subtract(DateTime.Now.Date).TotalDays < 1)
                            {

                                SqlCommand update_expir_cmd = con.CreateCommand();
                                update_expir_cmd.CommandText = "update expire_item_table set ex_it_date_flag='29' where expire_id=" +
                                   sels_q_grid.Rows[i].Cells[0].Value.ToString();

                                con.Open();
                                update_expir_cmd.ExecuteNonQuery();
                                con.Close();

                            }
                            else if (MessageBox.Show("لم تنتهى بعد هل تريد الاستمرار  " + sels_q_grid.Rows[i].Cells[2].Value.ToString() + " صلاحية هذا الصنف ", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {

                                SqlCommand update_expir_cmd = con.CreateCommand();
                                update_expir_cmd.CommandText = "update expire_item_table set ex_it_date_flag='29' where expire_id=" +
                                   sels_q_grid.Rows[i].Cells[0].Value.ToString();

                                con.Open();
                                update_expir_cmd.ExecuteNonQuery();
                                con.Close();

                            }
                            else
                            {
                                break;
                            }

                        }
                        MessageBox.Show("تم");
                        sels_q_grid.Columns.Clear();
                    }


                }
            }
            catch (Exception dd)
            {
                MessageBox.Show(dd.Message);
                con.Close();

            }
        }

        private void k_tasn_nam_cmbx_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void k_sanf_nam_cmbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                if (company_nam_cmbx.Text.Trim() != "")
                {
                    sels_q_grid.Columns.Clear();
                    company_nam_cmbx.ValueMember = "com_id";
                    SqlCommand select_cmd = con.CreateCommand();
                    SqlDataAdapter adap = new SqlDataAdapter();
                    DataTable dtb = new DataTable();
                    adap.SelectCommand = select_cmd;
                    select_cmd.CommandText = "SELECT expire_id as 'كود العملية',expire_item_id as 'ID',ItemName as 'الصنف',DATEDIFF(dd, getdate()," +
                        "expire_date)/30 as 'المتبقى بالشهر تقريبا',DATEDIFF(dd, getdate(),expire_date) as 'المتبقى باليوم'," +
                        "expire_date as 'تاريخ الانتهاء' ,com_name as 'الشركة المنتجة'" +
                        "  FROM expire_item_table join (Items join (ItemDetails join company_table on ItemDetails.item_comp_id=company_table.com_id) on Items.ItemId=ItemDetails.ItemId) on expire_item_table.expire_item_id=Items.ItemId " + " where com_id=" +
                        company_nam_cmbx.SelectedValue.ToString() + " and DATEDIFF(dd, getdate(),expire_date)<=" + day_num.Value.ToString() +
                        " and ex_it_date_flag <>29";
                    wait_frm w_frm = new wait_frm();
                    w_frm.Show();
                    adap.Fill(dtb);
                   
                    sels_q_grid.DataSource = dtb;
                    w_frm.Close();
                }


            }
            catch (Exception dd)
            {
                MessageBox.Show(dd.Message);
            }
        }

        private void sels_q_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void k_tasn_nam_cmbx_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
                k_sanf_nam_cmbx.DataSource = null;
                k_sanf_nam_cmbx.DisplayMember = "ItemName";
                k_sanf_nam_cmbx.ValueMember = "ItemId";
                k_sanf_nam_cmbx.DataSource = meth.select_sanf_by_tasn_code(k_tasn_nam_cmbx.SelectedValue.ToString());


            }
            catch (Exception kk)
            {
                MessageBox.Show(kk.Message);
            }
        }

        private void k_sanf_nam_cmbx_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
                k_sanf_nam_cmbx.ValueMember = "ItemId";

                if (k_sanf_nam_cmbx.Text != "")
                {



                    if (meth.select_sanf_data_by_barcode_orcode(k_sanf_nam_cmbx.SelectedValue.ToString()).Rows.Count > 0)
                    {
                        k_it_id_bx.Text = k_sanf_nam_cmbx.SelectedValue.ToString();
                        // remain_kem_bx.Text = meth.select_sanf_data_store(k_sanf_nam_cmbx.SelectedValue.ToString()).Rows[0][1].ToString();


                    }


                }
                else
                {
                    k_sanf_nam_cmbx.Text = "";
                    remain_kem_bx.Text = "";
                    k_tasn_nam_cmbx.Text = "";//.Clear();
                }
            }
            catch (Exception d)
            {
                MessageBox.Show(" خطا فى ادخال البيانات");
            }
        }
    }
}
