using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.Xml;

namespace sales_pro
{
    public partial class storeForm : Form
    {
        public storeForm(bool check_status,string userName)
        {
            InitializeComponent();
            status = check_status;
            user = userName;
        }
        private bool status;
        private string user;
        private SqlConnection connect_sal = new SqlConnection("server=.\\SQLEXPRESS;database=sales;integrated security=SSPI");
        private methodes meth = new methodes();
        private void add_item_btn_Click(object sender, EventArgs e)
        {
            add_item add_item_form = new add_item(status);
            add_item_form.ShowDialog();
            
        }

        private void add_store_btn_Click(object sender, EventArgs e)
        {
            addStoreForm adSt = new addStoreForm();
            adSt.ShowDialog();
            wared_store_cmbx.DisplayMember = "Stname";
            wared_store_cmbx.ValueMember = "STId";
            wared_store_cmbx.DataSource = meth.select_all_store();
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
                            if (meth.select_sanf_data_by_barcode_orcode(sanf_code.ToString()).Rows.Count > 0 && sanf_code > 0 && sanf_code.ToString().Trim().Length < 7)
                            {
                                wared_sanf_code_bx.Text = sanf_code.ToString();
                                wared_kemia_bx.Focus();
                                w_sanf_q_code_bx.Clear();
                            }
                            else if (meth.select_sanf_data_by_barcode(sanf_code.ToString()).Rows.Count > 0 && sanf_code > 0 && sanf_code.ToString().Trim().Length > 7)
                            {
                                wared_sanf_code_bx.Text = meth.select_sanf_data_by_barcode(sanf_code.ToString()).Rows[0][0].ToString().Trim();
                                wared_kemia_bx.Focus();
                                w_sanf_q_code_bx.Clear();
                            }
                            else
                            {
                                wared_sanf_nam_cmbx.Text = "";
                                wared_tasn_nam_cmbx.Text = "";

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

                        wared_sanf_code_bx.Clear();
                    }
                }
                catch (Exception d)
                {
                    MessageBox.Show("خطأ فى الادخال");
                }
            }
        }

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
                            remainBX.Text = meth.select_sanf_data_store(sanf_code.ToString()).Rows[0][1].ToString();


                            wared_tasn_nam_cmbx.SelectedValue = meth.select_tasn_data_bynam_orcode(meth.select_sanf_data_by_barcode_orcode(sanf_code.ToString()).Rows[0][8].ToString().Trim(), "NULL").Rows[0][0].ToString();
                            if (meth.select_item_expire_dates(sanf_code.ToString()).Rows.Count > 0)
                                expireDateBx.Text = meth.select_item_expire_dates(sanf_code.ToString()).Rows[0][1].ToString();
                        }
                        else
                        {
                            wared_sanf_nam_cmbx.Text = "";
                            wared_tasn_nam_cmbx.Text = "";
                            wared_kemia_bx.Text = "0";
                            remainBX.Text = "0";

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
                    wared_kemia_bx.Text = "0";
                    remainBX.Text = "0";

                }
            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message + "خطأ فى الادخال");
            }
        }

        private void storeForm_Load(object sender, EventArgs e)
        {
            wared_store_cmbx.DisplayMember = "Stname";
            wared_store_cmbx.ValueMember = "STId";
            wared_store_cmbx.DataSource = meth.select_all_store();

            try
            {

                ///////
                ////////sanf combo
                wared_tasn_nam_cmbx.DisplayMember = "CatName";
                wared_tasn_nam_cmbx.ValueMember = "CatId";
                wared_tasn_nam_cmbx.DataSource = meth.select_all_tasneef();

                stuck_bill_num_btn.Text = meth.select_stuck_store_req().Rows.Count.ToString();//عدد الطلبات المعلقة للمخزن

            }
            catch (Exception kk)
            {

                MessageBox.Show(kk.Message);
                connect_sal.Close();
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

        private void w_sanf_q_code_bx_TextChanged(object sender, EventArgs e)
        {
            int data;
            try
            {
                data = int.Parse(w_sanf_q_code_bx.Text);
            }
            catch
            {
                if (w_sanf_q_code_bx.Text != "")
                {
                    MessageBox.Show("الرجاء ادخال ارقام فقط");
                    w_sanf_q_code_bx.Text = "";
                }

            }
        }

        private void wared_kemia_bx_TextChanged(object sender, EventArgs e)
        {
            int data;
            try
            {
                data = int.Parse(wared_kemia_bx.Text);
                if (int.Parse(remainBX.Text) < int.Parse(wared_kemia_bx.Text))
                    wared_kemia_bx.Text = "0";
            }
            catch
            {
                if (wared_kemia_bx.Text != "")
                {
                    MessageBox.Show("الرجاء ادخال ارقام فقط");
                    wared_kemia_bx.Text = "";
                }

            }
        }

        private void wared_sanf_nam_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                wared_sanf_nam_cmbx.ValueMember = "ItemId";

                if (wared_sanf_nam_cmbx.Text != "")
                {



                    if (meth.select_sanf_data_by_barcode_orcode(wared_sanf_nam_cmbx.SelectedValue.ToString()).Rows.Count > 0)
                    {
                        wared_sanf_code_bx.Text = meth.select_sanf_data_by_barcode_orcode(wared_sanf_nam_cmbx.SelectedValue.ToString()).Rows[0][0].ToString();





                    }


                }
                else
                {
                    wared_sanf_nam_cmbx.Text = "";


                }
            }
            catch (Exception d)
            {
                MessageBox.Show(" خطا فى ادخال البيانات");
            }
        }
        //private void add_quan(int row_index)
        //{
        //    try
        //    {
        //        if (wared_sanf_code_bx.Text.Trim() != "" && wared_kemia_bx.Text.Trim() != "")
        //        {





        //            wared_kemia_bx.Text = (int.Parse(stReqItems_grid.Rows[row_index].Cells[3].Value.ToString()) + 1).ToString();
        //            stReqItems_grid.Rows[row_index].Cells[3].Value = wared_kemia_bx.Text;
        //            //BillDetailGV.Rows[row_index].Cells[0].Value = row_index + 1;
        //            //BillDetailGV.Rows[row_index].Cells[1].Value = meth.select_sanf_data_by_serial_desc(serial_item_bx.Text.Trim()).Rows[0][0].ToString(); ;
        //            //BillDetailGV.Rows[row_index].Cells[2].Value = meth.select_sanf_data_by_serial_desc(serial_item_bx.Text.Trim()).Rows[0][1].ToString();
        //            //BillDetailGV.Rows[row_index].Cells[3].Value = SellPriceTB.Text;
        //            //BillDetailGV.Rows[row_index].Cells[4].Value = QuanTB.Text;
        //            //BillDetailGV.Rows[row_index].Cells[5].Value = TotalTB.Text;
        //            //BillDetailGV.Rows[row_index].Cells[6].Value = discount_bx.Text.Trim();
        //            //BillTotalTB.Text = (double.Parse(BillTotalTB.Text.Trim()) + double.Parse(TotalTB.Text)).ToString();
        //            /*  string Quan = "Select ItemQuantity From Store  where ItemId= " + ItemIdQTB.Text;
        //              con.Open();
        //              SqlCommand comm = new SqlCommand(Quan, con);
        //              Itemread = comm.ExecuteReader();
        //              Itemread.Read();*/
        //            //RemainTB.Text = meth.select_sanf_data_by_serial_desc(serial_item_bx.Text.Trim()).Rows[0][13].ToString(); ;
        //            // Itemread.Close();
        //            wared_sanf_code_bx.Text = "";
        //            //s  CatCB.SelectedIndex = 0;

        //            //QuanTB.Text = "1";

        //            //RemainTB.Text = "0";

        //            connect_sal.Close();




        //        }
        //        else
        //        {
        //            MessageBox.Show("من فضلك اكمل بيانات الصنف");
        //        }
        //    }
        //    catch
        //    {
        //        wared_sanf_code_bx.Text = "";

        //        wared_kemia_bx.Text = "1";
        //        RemainTB.Text = "0";
        //        AddItemBtn.Enabled = true;

        //        connect_sal.Close();
        //    }
        //}
        private int wared_count = 0;
        private void wared_new_sanf_btn_Click(object sender, EventArgs e)
        {
            if (wared_sanf_nam_cmbx.Text != "" && wared_sanf_code_bx.Text.Trim() != "" &&
                wared_kemia_bx.Text != "" && Int32.Parse(wared_kemia_bx.Text) > 0)
            {
             try
                 { 
                 string row_state = "";
                
                     if (stReqItems_grid.Rows.Count > 0)
                     {
                         for (int i = 0; i < stReqItems_grid.Rows.Count; i++)
                         {
                             if (stReqItems_grid.Rows[i].Cells[1].Value.ToString().Trim() == wared_sanf_code_bx.Text.Trim())
                             {
                                 wared_kemia_bx.Text = (int.Parse(stReqItems_grid.Rows[i].Cells[3].Value.ToString()) + int.Parse(wared_kemia_bx.Text )).ToString();
                                 stReqItems_grid.Rows[i].Cells[3].Value = wared_kemia_bx.Text;
                                 wared_count = stReqItems_grid.Rows.Count;


                                 wared_sanf_nam_cmbx.Text = "";
                                 wared_sanf_code_bx.Clear();

                                 wared_kemia_bx.Clear();

                                 w_sanf_q_code_bx.Clear();
                                 row_state = "true";
                             }
                             
                        
                         }
                     }

                     if (row_state != "true")
                     {
                         if (meth.select_sanf_data_by_barcode_orcode(wared_sanf_code_bx.Text.Trim()).Rows.Count > 0)
                         {
                            
                               

                                 stReqItems_grid.Rows.Add(1);

                                 stReqItems_grid.Rows[wared_count].Cells[0].Value = stReqItems_grid.Rows.Count.ToString();

                                 stReqItems_grid.Rows[wared_count].Cells[1].Value = wared_sanf_code_bx.Text;//الصنف



                                 stReqItems_grid.Rows[wared_count].Cells[2].Value = wared_sanf_nam_cmbx.Text;//
                                
                                 stReqItems_grid.Rows[wared_count].Cells[3].Value = wared_kemia_bx.Text;

                               

                                 wared_count = stReqItems_grid.Rows.Count;


                                 wared_sanf_nam_cmbx.Text = "";
                                 wared_sanf_code_bx.Clear();
                               
                                 wared_kemia_bx.Clear();
                               
                                 w_sanf_q_code_bx.Clear();
                             
                         }
                         else
                             MessageBox.Show("كود الصنف" + wared_sanf_code_bx.Text + " ليس له اى بيانات فى قاعدة البيانات");


                     }
                   

                     wared_grid_sort_num();//
                    


                 }
                 catch (Exception dd)
                 {
                     MessageBox.Show(" خطا فى ادخال البيانات");
                 }
        
             }
             else
                 MessageBox.Show(" يجب ادخال البيانات كاملة والكميه اكبر من الصفر");
        }
    
        
        private void wared_grid_sort_num()//ترتيب مسلسل جريدوارد
        {
            try
            {
                if (stReqItems_grid.Rows.Count > 0)
                {
                    for (int i = 0; i < stReqItems_grid.Rows.Count; i++)
                    {
                        stReqItems_grid.Rows[i].Cells[0].Value = i + 1;
                    }
                }
            }
            catch (Exception ss)
            {

            }
        }

        private void wared_del_sanf_btn_Click(object sender, EventArgs e)
        {
            
               
        }

        private void wared_clear_btn_Click(object sender, EventArgs e)
        {
            if (stReqItems_grid.Rows.Count > 0)
            {
                if (MessageBox.Show("هل تريد مسح الاصناف الموجوده", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                 
                    wared_count = 0;
                    wared_fat_code_bx.Clear();
                    stReqItems_grid.Rows.Clear();
                    wared_kemia_bx.Clear();
                  
                    wared_notes_bx.Clear();
                  
                    wared_quer_fat_code_bx.Clear();
                    wared_sanf_code_bx.Clear();
                    wared_sanf_nam_cmbx.Text = "";
                 

                    wared_new_sanf_btn.Enabled = true;
                  
                    wared_save_fat_btn.Enabled = true;
                    w_quer_grid.Columns.Clear();

                    wared_fat_code_bx.Text = "0";
                    wared_fat_date.Text = DateTime.Now.ToShortDateString();
                    wared_quer_fat_search_btn.PerformClick();

                    wared_store_cmbx.Enabled = true;
                }
            }
            else
            {
                wared_fat_date.Text = DateTime.Now.ToShortDateString();
                wared_new_sanf_btn.Enabled = true;
               
              
                wared_save_fat_btn.Enabled = true;
               
                wared_quer_fat_search_btn.PerformClick();
                wared_store_cmbx.Enabled = false;
            }
        }

        private void stReqItems_grid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (stReqItems_grid.Rows.Count > 0)
            {
                if (stReqItems_grid.CurrentRow.Cells[4].Selected && int.Parse(wared_fat_code_bx.Text) <= 0)
                {
                    stReqItems_grid.Rows.Remove(stReqItems_grid.CurrentRow);
                    if (stReqItems_grid.Rows.Count > 0)
                        wared_count = stReqItems_grid.Rows.Count;
                    else
                        wared_count = 0;

                    wared_grid_sort_num();
                }
                //else
                // BillDetailGV.Columns[8].Visible = false;
            }
        }

        private void w_sanf_q_code_bx_MouseHover(object sender, EventArgs e)
        {
            w_sanf_q_code_bx.Focus();
        }

        private void wared_kemia_bx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                wared_new_sanf_btn.PerformClick();
            }
        }

        private void sentReqBtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (stReqItems_grid.Rows.Count > 0 && wared_fat_code_bx.Text != "" && wared_store_cmbx.Text.Trim() != "")
                {
                    DialogResult result = MessageBox.Show("هل انت متأكد من حفظ الطلب", "تحذير", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            bool settelment=false;
                             DialogResult result2 = MessageBox.Show("هل تريد تسوية الطلب من المخزن الرئيسى ", "تسويه فورية", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                             if (result2 == DialogResult.Yes)
                             {
                                 settelment = true;
                             }
                            string fatora_code = "";
                            ///////////ادخال اجمالى الفاتورة//////////////
                            SqlCommand insert_fatora_total_cmd = connect_sal.CreateCommand();

                            insert_fatora_total_cmd.CommandText = "INSERT INTO SpentStReqTbl(SpentStReqDate, SpentStReqStoreId, SpentStReqUserId, SpentStReqNotes" +
                                ")VALUES('" +

                                wared_fat_date.Text + "','" + wared_store_cmbx.SelectedValue.ToString()+ "','" +

                               user+"','"+ wared_notes_bx.Text + "')";

                            connect_sal.Open();
                            insert_fatora_total_cmd.ExecuteNonQuery();
                            connect_sal.Close();


                            //////////////////////////////////**//***/***///****/**/*/*//*/*/*/*/*//////////////////////////////////////احضار كود الفاتورة/////
                            SqlCommand select_fatora_code_cmd = connect_sal.CreateCommand();
                            DataTable fatora_code_dtb = new DataTable();
                            SqlDataAdapter fatora_code_adap = new SqlDataAdapter();
                            fatora_code_adap.SelectCommand = select_fatora_code_cmd;
                            select_fatora_code_cmd.CommandText = "SELECT MAX(SpentStReqId) FROM SpentStReqTbl";
                            fatora_code_adap.Fill(fatora_code_dtb);

                            if (fatora_code_dtb.Rows.Count > 0)
                                fatora_code = fatora_code_dtb.Rows[0][0].ToString();


                            /////////////ادخال الاصناف////////////////////
                            SqlCommand insert_fatora_sanf = connect_sal.CreateCommand();
                            
                            for (int i = 0; i < stReqItems_grid.Rows.Count; i++)//SELECT MAX(fatora_code) FROM fatora_table
                            {

                                insert_fatora_sanf.CommandText = "INSERT INTO SpentStReqDetailsTbl(SpentStReqDetailsHeadId ,SpentReqDetailsItemId ,SpentStReqDetailsQuan"
                                +
                                ")VALUES('" +
                                    fatora_code + "','" + stReqItems_grid.Rows[i].Cells[1].Value.ToString() + "','" +

                                    stReqItems_grid.Rows[i].Cells[3].Value.ToString() + "')";

                                connect_sal.Open();
                                insert_fatora_sanf.ExecuteNonQuery();
                                connect_sal.Close();

                                if (settelment)
                                {
                                    meth.update_store_minus(stReqItems_grid.Rows[i].Cells[1].Value.ToString(), stReqItems_grid.Rows[i].Cells[3].Value.ToString());
                                    meth.update_store_req_flag(fatora_code, "3");
                                }

                                insert_req_items_online(stReqItems_grid.Rows[i].Cells[1].Value.ToString(),fatora_code);
                            }
                            insert_req_order_online(fatora_code);
                            wared_grid_sort_num();//مسلسل

                         
                            MessageBox.Show("تم الحفظ");
                           
                            wared_sanf_code_bx.Focus();
                            wared_count = 0;
                            wared_clear_btn.PerformClick();
                        }
                        catch (Exception g)
                        {
                            MessageBox.Show(g.Message + "خطأ فى ادخال البيانات,يجب ادخال البيانات بدون اى علامات");

                            connect_sal.Close();
                        }
                    }
                    else if (result == DialogResult.No)
                    {
                        wared_clear_btn.PerformClick();
                        wared_sanf_code_bx.Focus();
                        wared_count = 0;
                    }

                }
                else
                    MessageBox.Show("من فضلك ادخل بيانات الطلب كاملا وصحيحة");

            }
            catch (Exception ss)
            {
                // MessageBox.Show(ss.Message+" known probleme26");
            }
        }
        private SqlConnection connect_online = new SqlConnection("Data Source=SQL5075.site4now.net;Initial Catalog=DB_A693A3_nourmilano;User Id=DB_A693A3_nourmilano_admin;Password=St01158119850;MultipleActiveResultSets=true");
        //private void insert_req_online(string stOrderId)
        //{
        //    try
        //    {
        //        DataTable dt = new DataTable();
                    
        //                SqlCommand select_item_expi_cmd =connect_sal.CreateCommand();

        //                SqlDataAdapter store_adap = new SqlDataAdapter();

        //                store_adap.SelectCommand = select_item_expi_cmd;
        //                SqlCommand insertOnCmd = connect_online.CreateCommand();
        //                var doc_par = insertOnCmd.Parameters.Add("@doc", SqlDbType.Xml);
                       
        //                string spentStoreReqHead, spentStoreReqDetails;

        //                spentStoreReqHead = "select * from SpentStReqTbl where SpentStReqId=" + stOrderId + " for xml path('SpentStReqId') ,root('SpentStReqTbl')";
                       

        //                select_item_expi_cmd.CommandText = spentStoreReqHead;
                      
        //                store_adap.Fill(dt);

                        
        //        var doc_spentHead=XDocument.Parse(dt.Rows[0][0].ToString());
        //        doc_par.Value = doc_spentHead.CreateReader();
        //        insertOnCmd.CommandText = "insert into XmlTable(storeHeadTbl) values (@doc)";
        //                connect_online.Open();
        //                insertOnCmd.ExecuteNonQuery();
        //                connect_online.Close();
                

        //                MessageBox.Show("تم الارسال");
        //    }
        //    catch (Exception ss)
        //    {
        //         MessageBox.Show(ss.Message+" known probleme26");
        //    }
        //}
        private void insert_req_items_online( string itemId,string orderId)
        {
            try
            {
                DataTable dt = new DataTable();

                SqlCommand select_item_expi_cmd = connect_sal.CreateCommand();
                SqlCommand insertOnCmd = connect_online.CreateCommand();
                var orderId_par = insertOnCmd.Parameters.Add("@orderId", SqlDbType.Int);
                var doc_reqDetPar = insertOnCmd.Parameters.Add("@docReqDet", SqlDbType.Xml);
                var doc_itemsPar = insertOnCmd.Parameters.Add("@docItems", SqlDbType.Xml);
                var doc_itemDetailPar = insertOnCmd.Parameters.Add("@docItemDetail", SqlDbType.Xml);
                var doc_catPar = insertOnCmd.Parameters.Add("@docCat", SqlDbType.Xml);
                var doc_companyPar = insertOnCmd.Parameters.Add("@docCompany", SqlDbType.Xml);
                var doc_ExpirePar = insertOnCmd.Parameters.Add("@docExpire", SqlDbType.Xml);
                SqlDataAdapter store_adap = new SqlDataAdapter();

                store_adap.SelectCommand = select_item_expi_cmd;

                string  items, itemsDetail, cat, itemExpire, company,spentReqDetails;

               

                spentReqDetails = "select * from SpentStReqDetailsTbl where SpentStReqDetailsHeadId=" + orderId +
                    " for xml path('SpentStReqDetailsHeadId') ,root('SpentStReqDetailsTbl')";//
                items = "select * from Items where ItemId=" + itemId + " for xml path('ItemId') ,root('Items')";
                itemsDetail = "select * from ItemDetails " +
                    " where ItemId=" + itemId + " for xml path('ItemId') ,root('ItemDetails')";
                cat = "select Category.CatId, CatName from Category join Items on Category.CatId=Items.CatId where ItemId=" + itemId+
                    " for xml path('CatId') ,root('Category')";
                company = "select com_id,com_name from company_table join ItemDetails on com_id=ItemDetails.item_comp_id where ItemId=" + itemId+
                    " for xml path('com_id') ,root('company_table')";
                itemExpire = "select * from expire_item_table  where expire_item_id=" + itemId + " for xml path('expire_item_id') ,root('expire_item_table')";
                /////order id

                orderId_par.Value = orderId;
                ///////req details
                select_item_expi_cmd.CommandText = spentReqDetails;

                store_adap.Fill(dt);
                var doc_reqD = XDocument.Parse(dt.Rows[0][0].ToString());
              
                doc_reqDetPar.Value = doc_reqD.CreateReader();
                ///////items
                select_item_expi_cmd.CommandText = items;

                store_adap.Fill(dt);
                var doc_items = XDocument.Parse(dt.Rows[1][0].ToString());

                doc_itemsPar.Value = doc_items.CreateReader();
                ///////itemsDetails
                select_item_expi_cmd.CommandText = itemsDetail;

                store_adap.Fill(dt);
                var doc_items_details = XDocument.Parse(dt.Rows[2][0].ToString());

                doc_itemDetailPar.Value = doc_items_details.CreateReader();
                ///////cat
                select_item_expi_cmd.CommandText = cat;

                store_adap.Fill(dt);
                var doc_cat = XDocument.Parse(dt.Rows[3][0].ToString());

                doc_catPar.Value = doc_cat.CreateReader();
                ///////company
                select_item_expi_cmd.CommandText = company;

                store_adap.Fill(dt);
                var doc_company = XDocument.Parse(dt.Rows[4][0].ToString());

                doc_companyPar.Value = doc_company.CreateReader();
                ///////itemExpire
                select_item_expi_cmd.CommandText = itemExpire;

                store_adap.Fill(dt);
                var doc_itemExpire = XDocument.Parse(dt.Rows[5][0].ToString());//dt.Rows[6][0].ToString()

                doc_ExpirePar.Value = doc_itemExpire.CreateReader();

                insertOnCmd.CommandText = "insert into xmlItemsTable(sqlReqDetails,items,itemDetails,itemExpire,itemCat,Company,storeReqId) values" +
                    " (@docReqDet,@docItems,@docItemDetail,@docExpire,@docCat,@docCompany,@orderId)";
                connect_online.Open();
                insertOnCmd.ExecuteNonQuery();
                connect_online.Close();

              

               
             
                MessageBox.Show("تم الارسال");
            }
            catch (Exception ss)
            {
                MessageBox.Show(ss.Message + " known probleme26");
            }
        }
        private void insert_req_order_online(string orderId)
        {
            try
            {
                DataTable dt = new DataTable();

                SqlCommand select_item_expi_cmd = connect_sal.CreateCommand();
                SqlCommand insertOnCmd = connect_online.CreateCommand();
                var doc_par = insertOnCmd.Parameters.Add("@doc", SqlDbType.Xml);
               
                SqlDataAdapter store_adap = new SqlDataAdapter();

                store_adap.SelectCommand = select_item_expi_cmd;

                string  spentStoreReqHead;

                spentStoreReqHead = "select * from SpentStReqTbl where SpentStReqId=" + orderId +
                    " for xml path('SpentStReqId') ,root('SpentStReqTbl')";//

               

                select_item_expi_cmd.CommandText = spentStoreReqHead;

                store_adap.Fill(dt);
                var doc_reqH = XDocument.Parse(dt.Rows[0][0].ToString());

                doc_par.Value = doc_reqH.CreateReader();
               
                store_adap.Fill(dt);
               

                insertOnCmd.CommandText = "insert into XmlTable(storeHeadTbl) values" +
                    " (@doc)";
                connect_online.Open();
                insertOnCmd.ExecuteNonQuery();
                connect_online.Close();





                MessageBox.Show("تم الارسال");
            }
            catch (Exception ss)
            {
                MessageBox.Show(ss.Message + " known probleme26");
            }
        }
        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
           
        }
    }


}