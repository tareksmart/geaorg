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
    public partial class wared_screen_form : Form
    {
        public wared_screen_form(bool check_status)
        {
            InitializeComponent();

            status = check_status;
        }
       
        private methodes meth = new methodes();
        private bool status;
       private SqlConnection connect_sal = new SqlConnection("server=.\\SQLEXPRESS;database=sales;integrated security=SSPI");
        //private SqlConnection connect_sal = new SqlConnection("Data Source=SQL5075.site4now.net;Initial Catalog=DB_A693A3_nourmilano;User Id=DB_A693A3_nourmilano_admin;Password=St01158119850");
        private void wared_sanf_code_bx_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Int64 sanf_code = 0;
                
                if (wared_sanf_code_bx.Text.Trim() != "")
                {

                    if (meth.check_for_numreic(wared_sanf_code_bx.Text.Trim()))
                    {
                        sanf_code = Convert.ToInt64(wared_sanf_code_bx.Text.Trim());
                        if (meth.select_sanf_data_by_barcode_orcode(sanf_code.ToString()).Rows.Count > 0)
                        {
                            wared_sanf_code_bx.Text = meth.select_sanf_data_by_barcode_orcode(sanf_code.ToString()).Rows[0][0].ToString();
                            wared_sanf_nam_cmbx.Text = meth.select_sanf_data_by_barcode_orcode(sanf_code.ToString()).Rows[0][1].ToString();
                            wared_purch_pric_bx.Text = meth.select_sanf_data_by_barcode_orcode(sanf_code.ToString()).Rows[0][2].ToString();
                            wared_last_ag_pric_bx.Text = meth.select_sanf_data_by_barcode_orcode(sanf_code.ToString()).Rows[0][4].ToString();
                            wared_cleint_pric_bx.Text = meth.select_sanf_data_by_barcode_orcode(sanf_code.ToString()).Rows[0][3].ToString();

                            wared_tasn_nam_cmbx.SelectedValue = meth.select_tasn_data_bynam_orcode(meth.select_sanf_data_by_barcode_orcode(sanf_code.ToString()).Rows[0][8].ToString().Trim(), "NULL").Rows[0][0].ToString();
                            if(meth.select_item_expire_dates(sanf_code.ToString()).Rows.Count>0)
                            w_it_expir_date.Text = meth.select_item_expire_dates(sanf_code.ToString()).Rows[0][1].ToString();
                        }
                        else
                        {
                            wared_sanf_nam_cmbx.Text = "";
                            wared_tasn_nam_cmbx.Text = "";
                            wared_purch_pric_bx.Clear();
                            wared_last_ag_pric_bx.Clear();
                            wared_cleint_pric_bx.Clear();
                        }


                    }
                    else
                    {
                        //wared_sanf_code_bx.Clear();
                    }
                }
                else
                {
                    wared_sanf_nam_cmbx.Text = "";
                    wared_tasn_nam_cmbx.Text = "";
                    wared_purch_pric_bx.Clear();
                    wared_last_ag_pric_bx.Clear();
                    wared_cleint_pric_bx.Clear();
                }
            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message+"خطأ فى الادخال");
            }
        }

        private void wared_screen_form_Load(object sender, EventArgs e)
        {
             try
            {
               
                ///////
                ////////sanf combo
                wared_tasn_nam_cmbx.DisplayMember = "CatName";
                wared_tasn_nam_cmbx.ValueMember = "CatId";
                wared_tasn_nam_cmbx.DataSource = meth.select_all_tasneef();

                if (meth.select_store_type() == false)
                {
                    groupPanel1.Enabled = false;
                    groupPanel4.Enabled = false;
                }
                else
                {
                    groupPanel1.Enabled = true;
                    groupPanel4.Enabled = true;
                }
            
            }
            catch (Exception kk)
            {
               
                MessageBox.Show(kk.Message);
                connect_sal.Close();
            }
           

            try
            {
                wared_morr_nam_cmbx.DisplayMember = "AgentName";
                wared_morr_nam_cmbx.ValueMember = "AgentId";
                wared_morr_nam_cmbx.DataSource = meth.select_all_mored();

                mor_q_name_cmbx.DisplayMember = "AgentName";
                mor_q_name_cmbx.ValueMember = "AgentId";
                mor_q_name_cmbx.DataSource = meth.select_all_mored();
            }
            catch (Exception kk)
            {
                MessageBox.Show(kk.Message);
            }

            w_def_num();
        }
        private void w_def_num()//دالة تسحب اخر رقم فاتورة وتضيف عليه واحد
        {
            try
            {
                wared_fat_code_bx.Text = "1";
                SqlCommand select_w_f_cmd = connect_sal.CreateCommand();
                SqlDataAdapter select_w_f_adap = new SqlDataAdapter();
                DataTable select_w_f_dtb = new DataTable();
                select_w_f_cmd.CommandText = "select max(BillId) from Bill where BillType='w'";
                select_w_f_adap.SelectCommand = select_w_f_cmd;
                select_w_f_adap.Fill(select_w_f_dtb);
                if (select_w_f_dtb.Rows.Count > 0)
                {
                    wared_fat_code_bx.Text = (Convert.ToInt32(select_w_f_dtb.Rows[0][0].ToString()) + 1).ToString();
                }
                else
                    wared_fat_code_bx.Text = "1";

            }
            catch (Exception kk)
            {
            }
        }
        private void wared_tasn_nam_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                wared_sanf_nam_cmbx.DisplayMember = "ItemName";
                wared_sanf_nam_cmbx.ValueMember = "ItemId";
                if (meth.select_sanf_by_tasn_code(wared_tasn_nam_cmbx.SelectedValue.ToString()).Rows.Count > 0)
                {
                    wared_sanf_nam_cmbx.DataSource = meth.select_sanf_by_tasn_code(wared_tasn_nam_cmbx.SelectedValue.ToString());
                }
                else
                    wared_sanf_nam_cmbx.DataSource = null;


            }
            catch (Exception kk)
            {
                MessageBox.Show(kk.Message);
            }
        }

        private void wared_sanf_nam_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void wared_grid_sort_num()//ترتيب مسلسل جريدوارد
        {
            try
            {
                if (wared_grid.Rows.Count > 0)
                {
                    for (int i = 0; i < wared_grid.Rows.Count; i++)
                    {
                        wared_grid.Rows[i].Cells[0].Value = i + 1;
                    }
                }
            }
            catch (Exception ss)
            {

            }
        }

        private double wared_fat_sum_mny()//دالةاجمالى فاتورة الوارد
        {
            double fatora_mony = 0;
            if (wared_grid.Rows.Count > 0)//جمع الاجمالى الموجود فى الجريد
            {

                try
                {
                    for (int i = 0; i < wared_grid.Rows.Count; i++)
                    {


                        fatora_mony +=
                             Convert.ToDouble(wared_grid.Rows[i].Cells[7].Value.ToString());//العدد مضروب قى سعر الشراء



                    }
                }
                catch (Exception f)
                {
                    MessageBox.Show(" خطا فى ادخال البيانات");
                }
            }
            else
            {


                fatora_mony = 0;


            }
            return fatora_mony;
        }
        private int wared_count=0;
        private void wared_new_sanf_btn_Click(object sender, EventArgs e)
        {
             string row_state = "";
             if (wared_sanf_nam_cmbx.Text != "" && wared_sanf_code_bx.Text.Trim() != "" && wared_purch_pric_bx.Text != "" && wared_last_ag_pric_bx.Text != "" && wared_cleint_pric_bx.Text != "" &&
                 wared_kemia_bx.Text != "" && wared_total_sanf_pric_bx.Text.Trim() != ""&&Int32.Parse(wared_kemia_bx.Text)>0)
             {
                 try
                 {

                     if (wared_grid.Rows.Count > 0)
                     {
                         for (int i = 0; i < wared_grid.Rows.Count; i++)
                         {
                             if (wared_grid.Rows[i].Cells[1].Value.ToString().Trim() == wared_sanf_code_bx.Text.Trim())
                             {
                                 row_state = "true";
                             }
                             
                        
                         }
                     }

                     if (row_state != "true")
                     {
                         if (meth.select_sanf_data_by_barcode_orcode(wared_sanf_code_bx.Text.Trim()).Rows.Count > 0)
                         {
                             if (w_it_expir_date.Value.Subtract(DateTime.Now.Date).TotalDays >= 1 && expire_date_chkbx.Checked)
                             {
                               

                                 wared_grid.Rows.Add(1);

                                 wared_grid.Rows[wared_count].Cells[0].Value = wared_grid.Rows.Count.ToString();

                                 wared_grid.Rows[wared_count].Cells[1].Value = wared_sanf_code_bx.Text;//الصنف



                                 wared_grid.Rows[wared_count].Cells[2].Value = wared_sanf_nam_cmbx.Text;//
                                 wared_grid.Rows[wared_count].Cells[3].Value = wared_purch_pric_bx.Text;//
                                 wared_grid.Rows[wared_count].Cells[4].Value = wared_last_ag_pric_bx.Text;//

                                 wared_grid.Rows[wared_count].Cells[5].Value = wared_cleint_pric_bx.Text;
                                 wared_grid.Rows[wared_count].Cells[6].Value = wared_kemia_bx.Text;

                                 wared_grid.Rows[wared_count].Cells[7].Value = wared_total_sanf_pric_bx.Text;
                                 wared_grid.Rows[wared_count].Cells[8].Value = warn_lim_num.Value;

                                 if (expire_date_chkbx.Checked)
                                 {
                                     wared_grid.Rows[wared_count].Cells[9].Value = w_it_expir_date.Text;
                                 }

                                 wared_count = wared_grid.Rows.Count;


                                 wared_sanf_nam_cmbx.Text = "";
                                 wared_sanf_code_bx.Clear();
                                 wared_purch_pric_bx.Clear();

                                 wared_last_ag_pric_bx.Clear();
                                 wared_cleint_pric_bx.Clear();
                                 wared_kemia_bx.Clear();
                                 wared_total_sanf_pric_bx.Clear();
                                 w_sanf_q_code_bx.Clear();
                             }
                             else
                                 MessageBox.Show("لايمكن ادخال تاريخ صلاحية اقل من او يساوى تاريخ اليوم");
                         }
                         else
                             MessageBox.Show("كود الصنف" + wared_sanf_code_bx.Text + " ليس له اى بيانات فى قاعدة البيانات");


                     }
                    else
                         MessageBox.Show(" لايمكن ادخال صنف موجود بالفعل هل تريد تعديله ");

                     wared_grid_sort_num();//
                     wared_total_bx.Text = wared_fat_sum_mny().ToString();//جمع اجمالى الفاتورة


                 }
                 catch (Exception dd)
                 {
                     MessageBox.Show(" خطا فى ادخال البيانات");
                 }
             }
             else
                 MessageBox.Show(" يجب ادخال البيانات كاملة والكميه اكبر من الصفر");
        }

        private void wared_kemia_bx_TextChanged(object sender, EventArgs e)
        {
            

            try
            {
                if (meth.check_for_numreic(wared_kemia_bx.Text.Trim()))
                {
                    if (wared_kemia_bx.Text.Trim() != "" && wared_purch_pric_bx.Text.Trim() != "")
                    {
                        wared_total_sanf_pric_bx.Text = (Convert.ToDouble(wared_purch_pric_bx.Text.Trim()) * Convert.ToDouble(wared_kemia_bx.Text)).ToString();


                    }
                }
                else
                    wared_kemia_bx.Clear();
            }
            catch (Exception yy)
            {
                MessageBox.Show(" خطا فى ادخال البيانات");
            }
        }

        private void wared_purch_pric_bx_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (meth.check_for_numreic(wared_purch_pric_bx.Text.Trim()))
                {
                }
                else
                {
                    wared_purch_pric_bx.Clear();
                }
            }
            catch { }


            try
            {
                if (meth.check_for_numreic(wared_kemia_bx.Text.Trim()))
                {
                    if (wared_kemia_bx.Text.Trim() != "" && wared_purch_pric_bx.Text.Trim() != "")
                    {
                        wared_total_sanf_pric_bx.Text = (Convert.ToDouble(wared_purch_pric_bx.Text.Trim()) * Convert.ToDouble(wared_kemia_bx.Text)).ToString();


                    }
                }
                else
                    wared_kemia_bx.Clear();
            }
            catch (Exception yy)
            {
                MessageBox.Show(" خطا فى ادخال البيانات");
            }
        }

        private void wared_up_sanf_btn_Click(object sender, EventArgs e)
        {
            if (wared_sanf_nam_cmbx.Text != "" && wared_sanf_code_bx.Text != "" && wared_purch_pric_bx.Text != "" &&
                wared_last_ag_pric_bx.Text != "" && wared_cleint_pric_bx.Text != "" &&
                  wared_kemia_bx.Text != "" && wared_total_sanf_pric_bx.Text.Trim() != "" && wared_grid.Rows.Count > 0 )
            {
                try
                {
                    if (Int32.Parse(wared_kemia_bx.Text) > 0)
                    {
                        if (wared_sanf_code_bx.Text.Trim() == wared_grid.CurrentRow.Cells[1].Value.ToString())
                        {
                            if (w_it_expir_date.Value.Subtract(DateTime.Now.Date).TotalDays <= 1 && expire_date_chkbx.Checked)
                            {
                                MessageBox.Show("لايمكن ادخال تاريخ صلاحية اقل من او يساوى تاريخ اليوم");
                            }
                            else
                            {
                                wared_grid.CurrentRow.Cells[3].Value = wared_purch_pric_bx.Text;//
                                wared_grid.CurrentRow.Cells[4].Value = wared_last_ag_pric_bx.Text;//

                                wared_grid.CurrentRow.Cells[5].Value = wared_cleint_pric_bx.Text;
                                wared_grid.CurrentRow.Cells[6].Value = wared_kemia_bx.Text;

                                wared_grid.CurrentRow.Cells[7].Value = wared_total_sanf_pric_bx.Text;
                                wared_grid.CurrentRow.Cells[8].Value = warn_lim_num.Value;
                                if (expire_date_chkbx.Checked)
                                    wared_grid.CurrentRow.Cells[9].Value = w_it_expir_date.Text;

                                wared_grid_sort_num();//
                                wared_total_bx.Text = wared_fat_sum_mny().ToString();//جمع اجمالى الفاتورة


                                wared_sanf_code_bx.Clear();
                                wared_sanf_nam_cmbx.Text = "";
                                wared_purch_pric_bx.Clear();
                                wared_last_ag_pric_bx.Clear();

                                wared_cleint_pric_bx.Clear();
                                wared_kemia_bx.Clear();
                                wared_total_sanf_pric_bx.Clear();
                                warn_lim_num.Value = 3;
                            }
                        }
                        else
                            MessageBox.Show("من فضلك اختر الصنف المراد تعديله");
                    }
                    else
                        MessageBox.Show("يجب ان تكون الكميه اكبر من الصفر");
                }
                catch (Exception j)
                {
                    MessageBox.Show(" خطا فى ادخال البيانات");
                }
            }
            else
                MessageBox.Show("يجب اختيار صنف مدخل بالفاتورة وتعديل بياناته ");
        }

        private void wared_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (w_quer_grid.Rows.Count > 0)
                {
                    if (ref_num_exp.Visible == false)
                    {
                        ref_num_exp.Visible = true;
                        ref_num_exp.Expanded = true;
                    }
                   /* else if (ref_num_exp.Visible == true)
                    {
                        ref_num_exp.Expanded = false;
                        ref_num_exp.Visible = false;

                    }
                    else
                    {
                        ref_num_exp.Visible = false;
                        ref_num_exp.Expanded = false;
                    }*/
                   // ref_num_bx.Text = wared_grid.CurrentRow.Cells[6].Value.ToString();
                }
                else
                {
                    if (wared_grid.Rows.Count > 0)
                    {
                        wared_sanf_code_bx.Text = wared_grid.CurrentRow.Cells[1].Value.ToString();

                        wared_sanf_nam_cmbx.Text = wared_grid.CurrentRow.Cells[2].Value.ToString();

                        wared_purch_pric_bx.Text = wared_grid.CurrentRow.Cells[3].Value.ToString();

                        wared_last_ag_pric_bx.Text = wared_grid.CurrentRow.Cells[4].Value.ToString();

                        wared_cleint_pric_bx.Text = wared_grid.CurrentRow.Cells[5].Value.ToString();

                        wared_kemia_bx.Text = wared_grid.CurrentRow.Cells[6].Value.ToString();

                        wared_total_sanf_pric_bx.Text = wared_grid.CurrentRow.Cells[7].Value.ToString();
                        warn_lim_num.Value =Convert.ToDecimal( wared_grid.CurrentRow.Cells[8].Value);
                    }
                }
            }
            catch (Exception ff)
            {
                //MessageBox.Show(ff.Message + "اظهار سجل");
            }
        }

        private void wared_del_sanf_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (wared_sanf_code_bx.Text != "" && wared_grid.Rows.Count > 0)
                {
                    if (wared_sanf_code_bx.Text.Trim() == wared_grid.CurrentRow.Cells[1].Value.ToString())
                    {

                        //MessageBox.Show( " حذف صنف");
                        wared_grid.Rows.Remove(wared_grid.CurrentRow);




                        if (wared_grid.Rows.Count > 0)
                            wared_count = wared_grid.Rows.Count;
                        else
                            wared_count = 0;

                        wared_grid_sort_num();//
                        wared_total_bx.Text = wared_fat_sum_mny().ToString();//جمع اجمالى الفاتورة


                        wared_sanf_nam_cmbx.Text = "";
                        wared_sanf_code_bx.Clear();
                        wared_purch_pric_bx.Clear();

                        wared_last_ag_pric_bx.Clear();
                        wared_cleint_pric_bx.Clear();
                        wared_kemia_bx.Clear();
                        wared_total_sanf_pric_bx.Clear();
                        warn_lim_num.Value = 3;


                    }
                }
                else
                    MessageBox.Show("من فضلك اختر الصنف المراد حذفه");
            }
            catch (Exception ff)
            {
                MessageBox.Show(" خطا فى ادخال البيانات");
            }
        }

        private void wared_last_ag_pric_bx_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (meth.check_for_numreic(wared_last_ag_pric_bx.Text.Trim()))
                {
                }
                else
                {
                    wared_last_ag_pric_bx.Clear();
                }
            }
            catch { }
        }

        private void wared_cleint_pric_bx_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (meth.check_for_numreic(wared_cleint_pric_bx.Text.Trim()))
                {
                }
                else
                {
                    wared_cleint_pric_bx.Clear();
                }
            }
            catch { }
        }

        private void wared_save_fat_btn_Click(object sender, EventArgs e)
        {
            try
            {

                if (wared_grid.Rows.Count > 0 && wared_fat_code_bx.Text != "" && wared_morr_nam_cmbx.Text.Trim()!="")
                    {
                    DialogResult result=MessageBox.Show("هل انت متأكد من حفظ الفاتورة", "تحذير", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            try
                            {
                                string fatora_code = "";
                                ///////////ادخال اجمالى الفاتورة//////////////
                                SqlCommand insert_fatora_total_cmd = connect_sal.CreateCommand();

                                insert_fatora_total_cmd.CommandText = "INSERT INTO Bill(BillType, BillPaperNo, BillDate, AgentType, AgentId, BillTotal, BillNote" +
                                    ")VALUES('" +

                                    "w" + "','" + wared_fat_code_bx.Text + "','" + wared_fat_date.Text + "',' m" + "'," +

                                    meth.select_ag_data_bynam_orcode("NULL", wared_morr_nam_cmbx.Text.Trim(),"m").Rows[0][0].ToString() +

                                    "," + wared_total_bx.Text + ",'" + wared_notes_bx.Text + "')";
                               
                                connect_sal.Open();
                                insert_fatora_total_cmd.ExecuteNonQuery();
                                connect_sal.Close();

                                
                                //////////////////////////////////**//***/***///****/**/*/*//*/*/*/*/*//////////////////////////////////////احضار كود الفاتورة/////
                                SqlCommand select_fatora_code_cmd = connect_sal.CreateCommand();
                                DataTable fatora_code_dtb = new DataTable();
                                SqlDataAdapter fatora_code_adap = new SqlDataAdapter();
                                fatora_code_adap.SelectCommand = select_fatora_code_cmd;
                                select_fatora_code_cmd.CommandText = "SELECT MAX(BillId) FROM Bill";
                                fatora_code_adap.Fill(fatora_code_dtb);

                                if (fatora_code_dtb.Rows.Count > 0)
                                    fatora_code = fatora_code_dtb.Rows[0][0].ToString();


                                /////////////ادخال الاصناف////////////////////
                                SqlCommand insert_fatora_sanf = connect_sal.CreateCommand();
                                SqlCommand update_limit_store = connect_sal.CreateCommand();
                                for (int i = 0; i < wared_grid.Rows.Count; i++)//SELECT MAX(fatora_code) FROM fatora_table
                                {

                                    insert_fatora_sanf.CommandText = "INSERT INTO BillDetails(BillId ,ItemID ,ItemQuantity ,ItemPrice ,BillDate, item_ag_price, item_cust_price"
                                    +
                                    ")VALUES('" +
                                        fatora_code + "','" + wared_grid.Rows[i].Cells[1].Value.ToString() + "','" +

                                        wared_grid.Rows[i].Cells[6].Value.ToString() + "','" +

                                        wared_grid.Rows[i].Cells[3].Value.ToString() + "','" + wared_fat_date.Text + "','" + wared_grid.Rows[i].Cells[4].Value.ToString() +
                                        "','" + wared_grid.Rows[i].Cells[5].Value.ToString()
                                       + "')";

                                    connect_sal.Open();
                                    insert_fatora_sanf.ExecuteNonQuery();
                                    connect_sal.Close();
                                    //تعديل حد المخزن للصنف
                                    update_limit_store.CommandText = "update Store set WarnLimit=" + wared_grid.Rows[i].Cells[8].Value.ToString() + " where ItemId="+
                                       wared_grid.Rows[i].Cells[1].Value.ToString();
                                    connect_sal.Open();
                                    update_limit_store.ExecuteNonQuery();
                                    connect_sal.Close();
                                    //////////////////////////
                                    meth.update_sanf_prices(wared_grid.Rows[i].Cells[1].Value.ToString().Trim(),

                                        wared_grid.Rows[i].Cells[3].Value.ToString(), wared_grid.Rows[i].Cells[5].Value.ToString(),

                                        wared_grid.Rows[i].Cells[6].Value.ToString(),
                                        wared_grid.Rows[i].Cells[4].Value.ToString());//تعديل الصنف باسعار جديدة

                                    //////////////////
                                    meth.update_store_plus(wared_grid.Rows[i].Cells[1].Value.ToString().Trim(), wared_grid.Rows[i].Cells[6].Value.ToString().Trim()

                                       );//تعديل الصنف بالزيادة المحزن
                                    ////////////////////////////////

                                    if (wared_grid.Rows[i].Cells[9].Value!=null)//تسجيل صلاحية صنف
                                    {
                                        meth.insert_expire_item_date(wared_grid.Rows[i].Cells[1].Value.ToString().Trim(), wared_grid.Rows[i].Cells[9].Value.ToString().Trim(),
                                            fatora_code, "9");
                                    }
                                }
                                wared_grid_sort_num();//مسلسل
                                // add_masareef(fatora_date.Text, fatora_total_price_bx.Text, "فاتورة توريد", fatora_code, user_nam_lbl.Text);//دالة اضافة مصاريف

                                meth.add_mny_imp_account(wared_morr_nam_cmbx.SelectedValue.ToString(), wared_total_bx.Text);
                                
                                MessageBox.Show("تم الحفظ");
                                clear_wared_bx();
                                wared_sanf_code_bx.Focus();
                                wared_count = 0;
                                w_def_num();
                            }
                            catch (Exception g)
                            {
                                MessageBox.Show(g.Message+"خطأ فى ادخال البيانات,يجب ادخال البيانات بدون اى علامات");

                                connect_sal.Close();
                            }
                        }
                        else if (result == DialogResult.No)
                        {
                            clear_wared_bx();
                            wared_sanf_code_bx.Focus();
                            wared_count = 0;
                        }
                        
                    }
                    else
                        MessageBox.Show("من فضلك ادخل بيانات الفاتورة كاملا وصحيحة");
                
            }
            catch (Exception ss)
            {
               // MessageBox.Show(ss.Message+" known probleme26");
            }
        }
        private void clear_wared_bx()
        {
            wared_cleint_pric_bx.Clear();
            wared_count = 0;
            wared_fat_code_bx.Clear();
            wared_grid.Rows.Clear();
            wared_kemia_bx.Clear();
            wared_last_ag_pric_bx.Clear();
            wared_notes_bx.Clear();
            wared_purch_pric_bx.Clear();
            wared_quer_fat_code_bx.Clear();
            wared_sanf_code_bx.Clear();
            wared_sanf_nam_cmbx.Text = "";
            wared_total_bx.Clear();
            wared_total_sanf_pric_bx.Clear();

            wared_new_sanf_btn.Enabled = true;
            wared_del_sanf_btn.Enabled = true;
            wared_up_sanf_btn.Enabled = true;
            wared_save_fat_btn.Enabled = true;
            w_quer_grid.Columns.Clear();
            warn_lim_num.Value = 3;
            wared_morr_nam_cmbx.Enabled = true;
        }
        private void wared_fat_code_bx_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (meth.check_for_numreic(wared_fat_code_bx.Text.Trim()))
                {
                }
                else
                {
                    wared_fat_code_bx.Clear();
                }
            }
            catch { }
        }

        private void wared_clear_btn_Click(object sender, EventArgs e)
        {
            if (wared_grid.Rows.Count > 0)
            {
                if (MessageBox.Show("هل تريد مسح الاصناف الموجوده", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    wared_cleint_pric_bx.Clear();
                    wared_count = 0;
                    wared_fat_code_bx.Clear();
                    wared_grid.Rows.Clear();
                    wared_kemia_bx.Clear();
                    wared_last_ag_pric_bx.Clear();
                    wared_notes_bx.Clear();
                    wared_purch_pric_bx.Clear();
                    wared_quer_fat_code_bx.Clear();
                    wared_sanf_code_bx.Clear();
                    wared_sanf_nam_cmbx.Text = "";
                    wared_total_bx.Clear();
                    wared_total_sanf_pric_bx.Clear();

                    wared_new_sanf_btn.Enabled = true;
                    wared_del_sanf_btn.Enabled = true;
                    wared_up_sanf_btn.Enabled = true;
                    wared_save_fat_btn.Enabled = true;
                    w_quer_grid.Columns.Clear();
                    warn_lim_num.Value = 3;
                    w_def_num();
                    wared_fat_date.Text = DateTime.Now.ToShortDateString();
                    wared_quer_fat_search_btn.PerformClick();
                    bill_w_id_bx.Clear();
                    wared_morr_nam_cmbx.Enabled = true;
                }
            }
            else
            {
                wared_fat_date.Text = DateTime.Now.ToShortDateString();
                wared_new_sanf_btn.Enabled = true;
                wared_del_sanf_btn.Enabled = true;
                wared_up_sanf_btn.Enabled = true;
                wared_save_fat_btn.Enabled = true;
                warn_lim_num.Value = 3;
                w_def_num();
                wared_quer_fat_search_btn.PerformClick();
                wared_morr_nam_cmbx.Enabled = false;
            }

        }

        private void wared_kemia_bx_ImeModeChanged(object sender, EventArgs e)
        {
            
        }

        private void wared_kemia_bx_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void wared_purch_pric_bx_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void wared_last_ag_pric_bx_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void wared_cleint_pric_bx_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void wared_screen_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (wared_save_fat_btn.Enabled == true)
            {
                if (wared_grid.Rows.Count > 0)
                {
                    if (MessageBox.Show("هل تريد حفظ هذه الاصناف", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        wared_save_fat_btn.PerformClick();
                    }
                    else
                        clear_wared_bx();
                }
            }
        }

        private void wared_quer_fat_search_btn_Click(object sender, EventArgs e)
        {
            if (expandablePanel1.Expanded == true)
            {
                if (wared_grid.Rows.Count > 0)
                {
                    DialogResult re = MessageBox.Show(" هل تريد حفظ الاصناف الموجوده فى جدول الاصناف", "تحذير", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (re == DialogResult.Yes)
                    {
                        wared_save();
                    }
                    else if (re == DialogResult.No)
                    {
                        wared_grid.Rows.Clear();
                        //wared_fat_code_bx.Clear();
                        clear_wared_bx();
                    }
                }
            }
            try
            {
                if (mor_all_fat_chkbx.Checked == false && mor_q_name_cmbx.SelectedIndex>=0)
                {
                    SqlCommand select_ward_fat = connect_sal.CreateCommand();
                    SqlDataAdapter fat_adap = new SqlDataAdapter();
                    DataTable fat_dtb = new DataTable();
                    fat_adap.SelectCommand = select_ward_fat;


                    select_ward_fat.CommandText = "select BillId, BillPaperNo, BillDate from Bill where BillDate between '" +

                            wared_quer_fat_start_date.Text + "' and '" + w_quer_end_date.Text + "' and BillType='w' and AgentId=" + mor_q_name_cmbx.SelectedValue.ToString();



                    fat_adap.Fill(fat_dtb);
                    w_quer_grid.Columns.Clear();
                    fat_dtb.Columns[0].ColumnName = "كود مسلسل الفاتورة";
                    fat_dtb.Columns[1].ColumnName = "كود الفاتورة";
                    fat_dtb.Columns[2].ColumnName = "تاريخ الفاتورة";


                    w_quer_grid.DataSource = fat_dtb;
                    w_quer_grid.Columns[0].Visible = false;
                }
                else
                {
                    SqlCommand select_ward_fat = connect_sal.CreateCommand();
                    SqlDataAdapter fat_adap = new SqlDataAdapter();
                    DataTable fat_dtb = new DataTable();
                    fat_adap.SelectCommand = select_ward_fat;


                    select_ward_fat.CommandText = "select BillId, BillPaperNo, BillDate from Bill where BillDate between '" +

                            wared_quer_fat_start_date.Text + "' and '" + w_quer_end_date.Text + "' and BillType='w'";



                    fat_adap.Fill(fat_dtb);
                    w_quer_grid.Columns.Clear();
                    fat_dtb.Columns[0].ColumnName = "كود مسلسل الفاتورة";
                    fat_dtb.Columns[1].ColumnName = "كود الفاتورة";
                    fat_dtb.Columns[2].ColumnName = "تاريخ الفاتورة";


                    w_quer_grid.DataSource = fat_dtb;
                    w_quer_grid.Columns[0].Visible = false;
                }
            }
            catch (Exception dd)
            {
                MessageBox.Show(" خطا فى ادخال البيانات");
            }
        }

        private void wared_quer_fat_code_bx_TextChanged(object sender, EventArgs e)
        {

           
        }
        private void wared_save()
        {
            try
            {

                if (wared_grid.Rows.Count > 0 && wared_fat_code_bx.Text != "" && wared_morr_nam_cmbx.Text.Trim() != "")
                {
                   
                        try
                        {
                            string fatora_code = "";
                            ///////////ادخال اجمالى الفاتورة//////////////
                            SqlCommand insert_fatora_total_cmd = connect_sal.CreateCommand();

                            insert_fatora_total_cmd.CommandText = "INSERT INTO Bill(BillType, BillPaperNo, BillDate, AgentType, AgentId, BillTotal, BillNote" +
                                ")VALUES('" +

                                "w" + "','" + wared_fat_code_bx.Text + "','" + wared_fat_date.Text + "',' m" + "'," +

                                meth.select_ag_data_bynam_orcode("NULL", wared_morr_nam_cmbx.Text.Trim(),"m").Rows[0][0].ToString() +

                                "," + wared_total_bx.Text + ",'" + wared_notes_bx.Text + "')";

                            connect_sal.Open();
                            insert_fatora_total_cmd.ExecuteNonQuery();
                            connect_sal.Close();


                            //////////////////////////////////**//***/***///****/**/*/*//*/*/*/*/*//////////////////////////////////////احضار كود الفاتورة/////
                            SqlCommand select_fatora_code_cmd = connect_sal.CreateCommand();
                            DataTable fatora_code_dtb = new DataTable();
                            SqlDataAdapter fatora_code_adap = new SqlDataAdapter();
                            fatora_code_adap.SelectCommand = select_fatora_code_cmd;
                            select_fatora_code_cmd.CommandText = "SELECT MAX(BillId) FROM Bill";
                            fatora_code_adap.Fill(fatora_code_dtb);

                            if (fatora_code_dtb.Rows.Count > 0)
                                fatora_code = fatora_code_dtb.Rows[0][0].ToString();


                            /////////////ادخال الاصناف////////////////////
                            SqlCommand insert_fatora_sanf = connect_sal.CreateCommand();
                            SqlCommand update_limit_store = connect_sal.CreateCommand();
                            for (int i = 0; i < wared_grid.Rows.Count; i++)//SELECT MAX(fatora_code) FROM fatora_table
                            {

                                insert_fatora_sanf.CommandText = "INSERT INTO BillDetails(BillId ,ItemID ,ItemQuantity ,ItemPrice ,BillDate"
                                +
                                ")VALUES('" +
                                    fatora_code + "','" + wared_grid.Rows[i].Cells[1].Value.ToString() + "','" +

                                    wared_grid.Rows[i].Cells[6].Value.ToString() + "','" +

                                    wared_grid.Rows[i].Cells[3].Value.ToString() + "','" + wared_fat_date.Text

                                   + "')";

                                connect_sal.Open();
                                insert_fatora_sanf.ExecuteNonQuery();
                                connect_sal.Close();
                                //تعديل حد المخزن للصنف
                                update_limit_store.CommandText = "update Store set WarnLimit=" + wared_grid.Rows[i].Cells[8].Value.ToString() + " where ItemId=" +
                                   wared_grid.Rows[i].Cells[1].Value.ToString();
                                connect_sal.Open();
                                update_limit_store.ExecuteNonQuery();
                                connect_sal.Close();
                                //////////////////////////
                                meth.update_sanf_prices(wared_grid.Rows[i].Cells[1].Value.ToString().Trim(),

                                    wared_grid.Rows[i].Cells[3].Value.ToString(), wared_grid.Rows[i].Cells[5].Value.ToString(),

                                    wared_grid.Rows[i].Cells[6].Value.ToString(),
                                    wared_grid.Rows[i].Cells[4].Value.ToString());//تعديل الصنف باسعار جديدة

                                //////////////////
                                meth.update_store_plus(wared_grid.Rows[i].Cells[1].Value.ToString().Trim(), wared_grid.Rows[i].Cells[6].Value.ToString().Trim()

                                   );//تعديل الصنف بالزيادة المحزن
                                ////////////////////////////////


                            }
                            wared_grid_sort_num();//مسلسل
                            // add_masareef(fatora_date.Text, fatora_total_price_bx.Text, "فاتورة توريد", fatora_code, user_nam_lbl.Text);//دالة اضافة مصاريف

                            meth.add_mny_imp_account(wared_morr_nam_cmbx.SelectedValue.ToString(), wared_total_bx.Text);

                            MessageBox.Show("تم الحفظ");
                            clear_wared_bx();
                            wared_sanf_code_bx.Focus();
                            wared_count = 0;

                        }
                        catch (Exception g)
                        {
                            MessageBox.Show(g.Message + "خطأ فى ادخال البيانات,يجب ادخال البيانات بدون اى علامات");

                            connect_sal.Close();
                        }
                   

                }
                else
                    MessageBox.Show("من فضلك ادخل بيانات الفاتورة كاملا وصحيحة");

            }
            catch (Exception ss)
            {
                // MessageBox.Show(ss.Message+" known probleme26");
            }
        }
        private void w_quer_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (w_quer_grid.Rows.Count > 0)
                {
                    if (w_quer_grid.CurrentRow.Cells[0].Value.ToString() != "")
                    {

                        int dt_count = 0;
                        double kemia = 0;
                        wared_grid.Rows.Clear();

                        SqlCommand select_fat_data_cmd = connect_sal.CreateCommand();
                        SqlDataAdapter fat_data_adap = new SqlDataAdapter();
                        DataTable fat_data_dtb = new DataTable();

                        fat_data_adap.SelectCommand = select_fat_data_cmd;//

                        select_fat_data_cmd.CommandText = "SELECT BillPaperNo, BillDetails.ItemID ,sum(ItemQuantity)," +

                            " ItemPrice, Bill.BillDate, AgentId, BillNote, item_ag_price, item_cust_price"+

                            " FROM Bill join BillDetails on Bill.BillId=BillDetails.BillId WHERE " +

                            "  Bill.BillId=" + w_quer_grid.CurrentRow.Cells[0].Value.ToString() +

                            " and BillType='w'  group by BillDetails.BillId,BillPaperNo,Bill.BillDate,AgentId,BillNote,BillDetails.ItemID,ItemPrice,item_ag_price, item_cust_price;";

                        fat_data_adap.Fill(fat_data_dtb);



                        if (fat_data_dtb.Rows.Count != 0)
                        {
                            wared_notes_bx.Text = fat_data_dtb.Rows[0][6].ToString();
                            wared_fat_code_bx.Text = fat_data_dtb.Rows[0][0].ToString();
                            wared_fat_date.Text = fat_data_dtb.Rows[0][4].ToString();
                            wared_morr_nam_cmbx.Text = meth.select_mor_by_name_or_code(fat_data_dtb.Rows[0][5].ToString(), "NULL").Rows[0][1].ToString();
                            dt_count = fat_data_dtb.Rows.Count;
                            for (int fat_row = 0; fat_row < dt_count; fat_row++)
                            {

                                  wared_grid.Rows.Add(1);
                                    wared_fat_code_bx.Text = fat_data_dtb.Rows[fat_row][0].ToString();


                                    wared_grid.Rows[fat_row].Cells[1].Value = fat_data_dtb.Rows[fat_row][1].ToString();

                                    wared_grid.Rows[fat_row].Cells[2].Value = meth.select_sanf_data_by_barcode_orcode(fat_data_dtb.Rows[fat_row][1].ToString()).Rows[0][1].ToString();

                                    wared_grid.Rows[fat_row].Cells[3].Value = fat_data_dtb.Rows[fat_row][3].ToString();
                                    wared_grid.Rows[fat_row].Cells[6].Value = fat_data_dtb.Rows[fat_row][2].ToString();

                                    wared_grid.Rows[fat_row].Cells[7].Value =
                                        Convert.ToDouble(wared_grid.Rows[fat_row].Cells[6].Value.ToString()) * Convert.ToDouble(wared_grid.Rows[fat_row].Cells[3].Value.ToString());

                                    wared_grid.Rows[fat_row].Cells[4].Value = fat_data_dtb.Rows[fat_row][7].ToString();//ag price
                                    wared_grid.Rows[fat_row].Cells[5].Value = fat_data_dtb.Rows[fat_row][8].ToString();//customer price
                            }
                           /* if (wared_grid.Rows.Count > 0)
                            {
                                for (int i = 0; i < wared_grid.Rows.Count; i++)//لحذف السجل اللى بالسالب واى كود صنف مثله
                                {
                                    for (int y = 0; y < wared_grid.Rows.Count; y++)
                                    {
                                        if ((int.Parse(wared_grid.Rows[i].Cells[6].Value.ToString())) + (int.Parse(wared_grid.Rows[y].Cells[6].Value.ToString())) == 0)
                                        {

                                                wared_grid.Rows.Remove(wared_grid.Rows[y]);
                                                wared_grid.Rows.Remove(wared_grid.Rows[i]);
                                            
                                        }
                                        if ((int.Parse(wared_grid.Rows[i].Cells[1].Value.ToString())) == (int.Parse(wared_grid.Rows[y].Cells[1].Value.ToString())))
                                        {
                                            kemia = double.Parse(wared_grid.Rows[i].Cells[6].Value.ToString()) + double.Parse(wared_grid.Rows[y].Cells[6].Value.ToString());
                                            wared_grid.Rows[i].Cells[6].Value = kemia;
                                            ///wared_grid.Rows.Remove(wared_grid.Rows[y]);
                                        }
                                    }
                                }
                            }*/
                            wared_grid_sort_num();
                            wared_total_bx.Text = wared_fat_sum_mny().ToString();//جمع اجمالى الفاتورة
                            bill_w_id_bx.Text = w_quer_grid.CurrentRow.Cells[0].Value.ToString();



                            wared_new_sanf_btn.Enabled = false;
                            wared_del_sanf_btn.Enabled = false;
                            wared_up_sanf_btn.Enabled = false;
                            wared_save_fat_btn.Enabled = false;
                            wared_morr_nam_cmbx.Enabled = false;

                        }

                    }
                    else
                        MessageBox.Show("من فضلك استعلم اولا");
                }
            }
            catch (Exception dd)
            {
                MessageBox.Show(dd.Message+" خطا فى ادخال البيانات");
            }
        }

        private void expandablePanel1_ExpandedChanged(object sender, DevComponents.DotNetBar.ExpandedChangeEventArgs e)
        {
           
        }

        private void wared_ref_fat_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string store_state = "";
                DataTable store_data_dtb2 = new DataTable();
                double num_from_grid = 0;
                double num_frm_store = 0;

                DialogResult re = MessageBox.Show("هل انت متأكد من ارتجاع الفاتورة", "تحذير", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                SqlCommand update_sanf_w_cmd =connect_sal.CreateCommand();
                if (wared_grid.Rows.Count > 0 && w_quer_grid.Rows.Count > 0)
                {
                    if (re == DialogResult.Yes)
                    {
                        try
                        {

                            ////////////خصم من المخزن كمية الفاتورة الملغاه/////////
                            for (int y = 0; y < wared_grid.Rows.Count; y++)
                            {

                                store_state = meth.update_store_minus(wared_grid.Rows[y].Cells[1].Value.ToString(), wared_grid.Rows[y].Cells[6].Value.ToString());


                                if (store_state != "true")
                                {

                                    break;

                                }
                                meth.update_store_plus(wared_grid.Rows[y].Cells[1].Value.ToString(), wared_grid.Rows[y].Cells[6].Value.ToString());
                            }
                            ///////////////////////////////////////////////////
                            if (store_state == "true")
                            {
                                string remain_mony = "";

                                remain_mony = meth.minus_mny_imp_account(wared_morr_nam_cmbx.SelectedValue.ToString(), wared_total_bx.Text.Trim());//خصم فاتورة التوريد من الحساب المتبقى للمورد


                                SqlCommand update_fat_del_cmd = connect_sal.CreateCommand();

                                update_fat_del_cmd.CommandText = "UPDATE Bill SET BillType='" + "ref" +
                                    "' WHERE BillId=" + bill_w_id_bx.Text.Trim();
                                connect_sal.Open();
                                update_fat_del_cmd.ExecuteNonQuery();
                                connect_sal.Close();

                                for (int col = 0; col < wared_grid.Rows.Count; col++)
                                {
                                    meth.update_sanf_prices_after_ref_fat(wared_grid.Rows[col].Cells[1].Value.ToString());//تعديل سعر الشراء بعد ارتجاع فاتورة

                                    store_state = meth.update_store_minus(wared_grid.Rows[col].Cells[1].Value.ToString(), wared_grid.Rows[col].Cells[6].Value.ToString());


                                }


                                MessageBox.Show("تم الغاء الفاتورة بكود " + w_quer_grid.CurrentRow.Cells[1].Value.ToString());

                                clear_wared_bx();
                                w_def_num();
                                wared_fat_date.Text = DateTime.Now.ToShortDateString();
                            }
                        }
                        catch (Exception ff)
                        {
                            MessageBox.Show(ff.Message+" خطا فى ادخال البيانات");
                            connect_sal.Close();
                        }
                    }
                    else if (re == DialogResult.No)
                    {
                        clear_wared_bx();
                        w_def_num();
                    }
                    

                }
                else
                    MessageBox.Show(" لايوجد فاتورة للارتجاع");
            }
            catch (Exception ss)
            {
                MessageBox.Show("known probleme29");
            }
        }

        private void groupPanel2_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void ref_sub_btn_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxItem1_Click(object sender, EventArgs e)
        {

        }

        private void ref_cancel_btn_Click(object sender, EventArgs e)
        {
            if (ref_num_exp.Visible == false)
            {
                ref_num_exp.Visible = true;
                ref_num_exp.Expanded = true;
            }
            else if (ref_num_exp.Visible == true)
            {
                ref_num_exp.Expanded = false;
                ref_num_exp.Visible = false;

            }
            else
            {
                ref_num_exp.Visible = false;
                ref_num_exp.Expanded = false;
            }
        }

        private void ref_num_bx_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (meth.check_for_numreic(ref_num_bx.Text.Trim()))
                {
                }
                else
                {
                    ref_num_bx.Clear();
                }
            }
            catch { }
           
        }

        private void ref_save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string store_state = "";
                if (ref_num_bx.Text.Trim() != "")
                {
                    if (MessageBox.Show("هل تريد ارتجاع العدد المدخل", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (Convert.ToDouble(ref_num_bx.Text.Trim()) <= Convert.ToDouble(wared_grid.CurrentRow.Cells[6].Value.ToString()))
                        {
                            store_state = meth.update_store_minus(wared_grid.CurrentRow.Cells[1].Value.ToString(), ref_num_bx.Text.Trim());//خصم من المخزن

                            if (store_state == "true")
                            {
                                meth.minus_mny_imp_account(wared_morr_nam_cmbx.SelectedValue.ToString(), (Convert.ToDouble(ref_num_bx.Text.Trim()) *

                                    Convert.ToDouble(wared_grid.CurrentRow.Cells[3].Value.ToString())).ToString());//خصم من حساب المورد

                                wared_grid.CurrentRow.Cells[6].Value = Convert.ToDouble(wared_grid.CurrentRow.Cells[6].Value.ToString()) - Convert.ToDouble(ref_num_bx.Text.Trim());

                                wared_grid.CurrentRow.Cells[7].Value = Convert.ToDouble(wared_grid.CurrentRow.Cells[6].Value.ToString()) *

                                    Convert.ToDouble(wared_grid.CurrentRow.Cells[3].Value.ToString());
                                wared_total_bx.Text = wared_fat_sum_mny().ToString();//جمع اجمالى الفاتورة

                                SqlCommand update_bill_cmd = connect_sal.CreateCommand();
                                //SqlCommand update_bill_details_cmd = connect_sal.CreateCommand();
                                SqlCommand insert_ref_num_cmd = connect_sal.CreateCommand();
                                if (Convert.ToDouble(wared_grid.CurrentRow.Cells[6].Value.ToString()) == 0)
                                {
                                    meth.update_sanf_prices_after_ref_fat(wared_grid.CurrentRow.Cells[1].Value.ToString());
                                    /////اضافة سجل بالعدد المرتجع بالسالب
                                    insert_ref_num_cmd.CommandText = "insert into BillDetails (BillId, ItemID, ItemQuantity, ItemPrice, BillDate,item_ag_price,item_cust_price" + ")values(" +

                                        bill_w_id_bx.Text.Trim() + "," + wared_grid.CurrentRow.Cells[1].Value.ToString() +

                                        "," + (Convert.ToDouble(ref_num_bx.Text) * -1) + "," +

                                        wared_grid.CurrentRow.Cells[3].Value.ToString() + ",'" +
                                        wared_fat_date.Text + "','" + wared_grid.CurrentRow.Cells[4].Value.ToString() + "','" + wared_grid.CurrentRow.Cells[5].Value.ToString() + "')";
                                    connect_sal.Open();
                                    insert_ref_num_cmd.ExecuteNonQuery();
                                    connect_sal.Close();
                                }
                                else if (Convert.ToDouble(wared_grid.CurrentRow.Cells[6].Value.ToString()) > 0)
                                {

                                    /////اضافة سجل بالعدد المرتجع بالسالب
                                    insert_ref_num_cmd.CommandText = "insert into BillDetails (BillId, ItemID, ItemQuantity, ItemPrice, BillDate,item_ag_price,item_cust_price" + ")values(" +

                                        bill_w_id_bx.Text.Trim() + "," + wared_grid.CurrentRow.Cells[1].Value.ToString() +

                                        "," + (Convert.ToDouble(ref_num_bx.Text) * -1) + "," +

                                        wared_grid.CurrentRow.Cells[3].Value.ToString() + ",'" +
                                        wared_fat_date.Text + "','" + wared_grid.CurrentRow.Cells[4].Value.ToString() + "','" + wared_grid.CurrentRow.Cells[5].Value.ToString() + "')";
                                    connect_sal.Open();
                                    insert_ref_num_cmd.ExecuteNonQuery();
                                    connect_sal.Close();
                                }
                                if (double.Parse(wared_total_bx.Text.Trim()) > 0)
                                {
                                    update_bill_cmd.CommandText = " update Bill set BillTotal=" + wared_total_bx.Text +
                                        " where BillId=" + bill_w_id_bx.Text.Trim();
                                    connect_sal.Open();
                                    update_bill_cmd.ExecuteNonQuery();
                                    connect_sal.Close();
                                }
                                else
                                {
                                    update_bill_cmd.CommandText = " update Bill set BillTotal=" + wared_total_bx.Text + ", BillType='" + "ref'" +
                                       " where BillId=" + bill_w_id_bx.Text.Trim();
                                    connect_sal.Open();
                                    update_bill_cmd.ExecuteNonQuery();
                                    connect_sal.Close();
                                }
                                ref_num_bx.Clear();
                                wared_fat_date.Text = DateTime.Now.ToShortDateString();
                                if (wared_grid.Rows.Count > 0)
                                {
                                    if (int.Parse(wared_grid.CurrentRow.Cells[6].Value.ToString()) <= 0)
                                        wared_grid.Rows.Remove(wared_grid.CurrentRow);
                                }
                                if (wared_grid.Rows.Count > 0 )
                                {
                                    if (MessageBox.Show("هل تريد ارتجاع اصناف اخرى", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                                    {
                                        ref_cancel_btn.PerformClick();
                                        clear_wared_bx();
                                        wared_sanf_code_bx.Focus();
                                        
                                    }
                                }

                            }
                        }
                        else
                            MessageBox.Show("عفوا يجب ان يكون العدد الجديد اقل من او يساوى العدد القديم");
                    }
                }
                else
                    MessageBox.Show("من فضلك ادخل العدد المطلوب ارتجاعه");
                w_def_num();
                wared_quer_fat_search_btn.PerformClick();
            }
    catch (Exception dd)
            {
                MessageBox.Show(dd.Message+" خطا فى ادخال البيانات");
                connect_sal.Close();
            }
        }

        private void wared_sanf_code_bx_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void wared_grid_Enter(object sender, EventArgs e)
        {
           
        }

        private void wared_grid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
          
        }

        private void wared_grid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                wared_save_fat_btn.PerformClick();
            }
            if (Control.ModifierKeys==Keys.Control && e.KeyCode == Keys.N)
            {
                w_sanf_q_code_bx.Focus();
            }
        }

        private void wared_sanf_code_bx_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void wared_fat_code_bx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                wared_new_sanf_btn.PerformClick();
            }

            if (e.KeyCode == Keys.F5)
            {
                wared_save_fat_btn.PerformClick();
            }

            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.N)
            {
                w_sanf_q_code_bx.Focus();
            }
        }

        private void wared_total_sanf_pric_bx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                wared_save_fat_btn.PerformClick();
            }
        }

        private void warn_lim_num_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                wared_save_fat_btn.PerformClick();
            }
            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.N)
            {
                w_sanf_q_code_bx.Focus();
            }
        }

        private void wared_notes_bx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                wared_save_fat_btn.PerformClick();
            }
            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.N)
            {
                w_sanf_q_code_bx.Focus();
            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void w_sanf_q_code_bx_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void w_sanf_q_code_bx_MouseMove(object sender, MouseEventArgs e)
        {
            w_sanf_q_code_bx.Focus();
        }

        private void w_sanf_q_code_bx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    Int64 sanf_code = 0;

                    if (w_sanf_q_code_bx.Text.Trim() != "")
                    {

                        if (meth.check_for_numreic(w_sanf_q_code_bx.Text.Trim()))
                        {
                            sanf_code = Convert.ToInt64(w_sanf_q_code_bx.Text.Trim());
                            if (meth.select_sanf_data_by_barcode_orcode(sanf_code.ToString()).Rows.Count > 0 && sanf_code > 0 && sanf_code.ToString().Trim().Length<7)
                            {
                                wared_sanf_code_bx.Text = sanf_code.ToString();
                                w_sanf_q_code_bx.Clear();
                            }
                            else if (meth.select_sanf_data_by_barcode(sanf_code.ToString()).Rows.Count > 0 && sanf_code > 0 && sanf_code.ToString().Trim().Length > 7)
                            {
                                wared_sanf_code_bx.Text = meth.select_sanf_data_by_barcode(sanf_code.ToString()).Rows[0][0].ToString().Trim();
                                w_sanf_q_code_bx.Clear();
                            }
                            else
                            {
                                wared_sanf_nam_cmbx.Text = "";
                                wared_tasn_nam_cmbx.Text = "";
                                wared_purch_pric_bx.Clear();
                                wared_last_ag_pric_bx.Clear();
                                wared_cleint_pric_bx.Clear();
                                wared_sanf_code_bx.Clear();
                            }


                        }
                        else
                        {
                            //wared_sanf_code_bx.Clear();
                        }
                    }
                    else
                    {
                        wared_sanf_nam_cmbx.Text = "";
                        wared_tasn_nam_cmbx.Text = "";
                        wared_purch_pric_bx.Clear();
                        wared_last_ag_pric_bx.Clear();
                        wared_cleint_pric_bx.Clear();
                        wared_sanf_code_bx.Clear();
                    }
                }
                catch (Exception d)
                {
                    MessageBox.Show("خطأ فى الادخال");
                }
            }

            if (e.KeyCode == Keys.F5)
            {
                wared_save_fat_btn.PerformClick();
            }
            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.N)
            {
                w_sanf_q_code_bx.Focus();
            }

        }

        private void wared_screen_form_KeyDown(object sender, KeyEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.N)
            {
                w_sanf_q_code_bx.Focus();
            }

            if (e.KeyCode == Keys.Space)
            {
                wared_new_sanf_btn.PerformClick();
            }

            if (e.KeyCode == Keys.F5)
            {
                wared_save_fat_btn.PerformClick();
            }
        }

        private void wared_kemia_bx_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                wared_new_sanf_btn.PerformClick();
            }

            if (e.KeyCode == Keys.F5)
            {
                wared_save_fat_btn.PerformClick();
            }
            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.N)
            {
                w_sanf_q_code_bx.Focus();
            }
        }

        private void wared_cleint_pric_bx_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                wared_new_sanf_btn.PerformClick();
            }

            if (e.KeyCode == Keys.F5)
            {
                wared_save_fat_btn.PerformClick();
            }
            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.N)
            {
                w_sanf_q_code_bx.Focus();
            }
        }

        private void wared_last_ag_pric_bx_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                wared_new_sanf_btn.PerformClick();
            }

            if (e.KeyCode == Keys.F5)
            {
                wared_save_fat_btn.PerformClick();
            }
            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.N)
            {
                w_sanf_q_code_bx.Focus();
            }
        }

        private void wared_tasn_nam_cmbx_KeyDown(object sender, KeyEventArgs e)
        {
          

            if (e.KeyCode == Keys.F5)
            {
                wared_save_fat_btn.PerformClick();
            }
            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.N)
            {
                w_sanf_q_code_bx.Focus();
            }
        }

        private void wared_sanf_nam_cmbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    wared_sanf_nam_cmbx.ValueMember = "ItemId";

                    if (wared_sanf_nam_cmbx.Text != "")
                    {



                        if (meth.select_sanf_data_by_barcode_orcode(wared_sanf_nam_cmbx.SelectedValue.ToString()).Rows.Count > 0)
                        {
                            wared_sanf_code_bx.Text = meth.select_sanf_data_by_barcode_orcode(wared_sanf_nam_cmbx.SelectedValue.ToString()).Rows[0][0].ToString();
                            wared_sanf_nam_cmbx.Text = meth.select_sanf_data_by_barcode_orcode(wared_sanf_nam_cmbx.SelectedValue.ToString()).Rows[0][1].ToString();
                            wared_purch_pric_bx.Text = meth.select_sanf_data_by_barcode_orcode(wared_sanf_nam_cmbx.SelectedValue.ToString()).Rows[0][2].ToString();
                            wared_last_ag_pric_bx.Text = meth.select_sanf_data_by_barcode_orcode(wared_sanf_nam_cmbx.SelectedValue.ToString()).Rows[0][4].ToString();
                            wared_cleint_pric_bx.Text = meth.select_sanf_data_by_barcode_orcode(wared_sanf_nam_cmbx.SelectedValue.ToString()).Rows[0][3].ToString();



                        }


                    }
                    else
                    {
                        wared_sanf_nam_cmbx.Text = "";

                        wared_purch_pric_bx.Clear();
                        wared_last_ag_pric_bx.Clear();
                        wared_cleint_pric_bx.Clear();
                    }
                }
                catch (Exception d)
                {
                    MessageBox.Show(" خطا فى ادخال البيانات");
                }

            }

            if (e.KeyCode == Keys.F5)
            {
                wared_save_fat_btn.PerformClick();
            }
            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.N)
            {
                w_sanf_q_code_bx.Focus();
            }
        }

        private void wared_purch_pric_bx_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                wared_new_sanf_btn.PerformClick();
            }

            if (e.KeyCode == Keys.F5)
            {
                wared_save_fat_btn.PerformClick();
            }
            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.N)
            {
                w_sanf_q_code_bx.Focus();
            }
        }

        private void w_quer_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void search_quer_w_btn_Click(object sender, EventArgs e)
        {
            if (expandablePanel1.Expanded == true)
            {
                if (wared_grid.Rows.Count > 0)
                {
                    DialogResult re = MessageBox.Show(" هل تريد حفظ الاصناف الموجوده فى جدول الاصناف", "تحذير", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (re == DialogResult.Yes)
                    {
                        wared_save();
                    }
                    else if (re == DialogResult.No)
                    {
                        wared_grid.Rows.Clear();
                        // wared_fat_code_bx.Clear();
                        clear_wared_bx();
                    }
                }
            }
            try
            {
                try
                {
                    if (meth.check_for_numreic(wared_quer_fat_code_bx.Text.Trim()))
                    {
                    }
                    else
                    {
                        wared_quer_fat_code_bx.Clear();
                    }
                }
                catch { }
                if (wared_quer_fat_code_bx.Text != "")
                {
                    SqlCommand select_ward_fat = connect_sal.CreateCommand();
                    SqlDataAdapter fat_adap = new SqlDataAdapter();
                    DataTable fat_dtb = new DataTable();
                    fat_adap.SelectCommand = select_ward_fat;


                    select_ward_fat.CommandText = "select BillId, BillPaperNo, BillDate from Bill where " +

                              " BillType='w' and BillPaperNo=" + wared_quer_fat_code_bx.Text.Trim();



                    fat_adap.Fill(fat_dtb);
                    w_quer_grid.Columns.Clear();
                    fat_dtb.Columns[0].ColumnName = "كود مسلسل الفاتورة";
                    fat_dtb.Columns[1].ColumnName = "كود الفاتورة";
                    fat_dtb.Columns[2].ColumnName = "تاريخ الفاتورة";


                    w_quer_grid.DataSource = fat_dtb;
                    w_quer_grid.Columns[0].Visible = false;
                    wared_quer_fat_code_bx.Clear();
                }
                else
                    w_quer_grid.Columns.Clear();
            }
            catch (Exception dd)
            {
                MessageBox.Show(" خطا فى ادخال البيانات");
            }
        }

        private void expandablePanel1_Click(object sender, EventArgs e)
        {

        }

        private void wared_sanf_nam_cmbx_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
                wared_sanf_nam_cmbx.ValueMember = "ItemId";

                if (wared_sanf_nam_cmbx.Text != "")
                {

                    wared_sanf_code_bx.Text = wared_sanf_nam_cmbx.SelectedValue.ToString();

                 /*   if (meth.select_sanf_data_by_barcode_orcode(wared_sanf_nam_cmbx.SelectedValue.ToString()).Rows.Count > 0)
                    {
                        wared_sanf_code_bx.Text = meth.select_sanf_data_by_barcode_orcode(wared_sanf_nam_cmbx.SelectedValue.ToString()).Rows[0][0].ToString();
                        wared_sanf_nam_cmbx.Text = meth.select_sanf_data_by_barcode_orcode(wared_sanf_nam_cmbx.SelectedValue.ToString()).Rows[0][1].ToString();
                        wared_purch_pric_bx.Text = meth.select_sanf_data_by_barcode_orcode(wared_sanf_nam_cmbx.SelectedValue.ToString()).Rows[0][2].ToString();
                        wared_last_ag_pric_bx.Text = meth.select_sanf_data_by_barcode_orcode(wared_sanf_nam_cmbx.SelectedValue.ToString()).Rows[0][4].ToString();
                        wared_cleint_pric_bx.Text = meth.select_sanf_data_by_barcode_orcode(wared_sanf_nam_cmbx.SelectedValue.ToString()).Rows[0][3].ToString();


                    }*/


                }
                else
                {
                    wared_sanf_nam_cmbx.Text = "";

                    wared_purch_pric_bx.Clear();
                    wared_last_ag_pric_bx.Clear();
                    wared_cleint_pric_bx.Clear();
                }
            }
            catch (Exception d)
            {
                MessageBox.Show(" خطا فى ادخال البيانات");
            }
        }

        private void add_item_btn_Click(object sender, EventArgs e)
        {
            add_item add_item_form = new add_item(status);
            add_item_form.ShowDialog();
        }

        private void wared_tasn_nam_cmbx_DropDownClosed(object sender, EventArgs e)
        {
           
        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void groupPanel4_Click(object sender, EventArgs e)
        {

        }

        private void querBtn_Click(object sender, EventArgs e)
        {
            StoreReqQuery srFrm=new StoreReqQuery();
            srFrm.ShowDialog();
        }

        
    }
}
