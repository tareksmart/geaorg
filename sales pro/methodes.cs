using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Management;

namespace sales_pro
{

    class methodes
    {
        private SqlConnection connect_sal = new SqlConnection("server=.\\SQLEXPRESS;database=sales;integrated security=SSPI");
        //private SqlConnection connect_sal = new SqlConnection("Data Source=SQL5075.site4now.net;Initial Catalog=DB_A693A3_nourmilano;User Id=DB_A693A3_nourmilano_admin;Password=St01158119850");
        public DataTable select_all_tasneef()//سحب كل بيانات التصنيف
        {
            DataTable tas_data_dtb = new DataTable();

            try
            {
                SqlCommand tas_data_cmd = connect_sal.CreateCommand();
                SqlDataAdapter tasn_adap = new SqlDataAdapter();

                tasn_adap.SelectCommand = tas_data_cmd;
                tas_data_cmd.CommandText = "SELECT CatId, CatName, Notes FROM Category ";



                tasn_adap.Fill(tas_data_dtb);

            }
            catch (Exception rr)
            {
                MessageBox.Show(rr.Message);
            }
            return tas_data_dtb;
        }

        internal DataTable select_all_company()//سحب كل بيانات الشركات
        {
            DataTable com_data_dtb = new DataTable();

            try
            {
                ///سحب كل بيانات الشركات
                ///
                SqlCommand com_data_cmd = connect_sal.CreateCommand();
                SqlDataAdapter com_adap = new SqlDataAdapter();

                com_adap.SelectCommand = com_data_cmd;
                com_data_cmd.CommandText = "SELECT com_id, com_name FROM company_table ";



                com_adap.Fill(com_data_dtb);

            }
            catch (Exception rr)
            {
                MessageBox.Show(rr.Message);
            }
            return com_data_dtb;
        }
        internal DataTable select_all_store()//سحب كل بيانات المخازن
        {
            DataTable com_data_dtb = new DataTable();

            try
            {
                ///سحب كل بيانات الشركات
                ///
                SqlCommand com_data_cmd = connect_sal.CreateCommand();
                SqlDataAdapter com_adap = new SqlDataAdapter();

                com_adap.SelectCommand = com_data_cmd;
                com_data_cmd.CommandText = "SELECT STId, Stname FROM StoreNameTbl";



                com_adap.Fill(com_data_dtb);

            }
            catch (Exception rr)
            {
                MessageBox.Show(rr.Message);
            }
            return com_data_dtb;
        }
        internal DataTable select_company_by_code(string com_id)//سحب بيان شكركه بكودها
        {
            DataTable com_data_dtb = new DataTable();

            try
            {
                ///سحب بيان شكركه بكودها
                ///
                SqlCommand com_data_cmd = connect_sal.CreateCommand();
                SqlDataAdapter com_adap = new SqlDataAdapter();

                com_adap.SelectCommand = com_data_cmd;
                com_data_cmd.CommandText = "SELECT com_id, com_name FROM company_table where com_id=" + com_id;



                com_adap.Fill(com_data_dtb);

            }
            catch (Exception rr)
            {
                MessageBox.Show(rr.Message);
            }
            return com_data_dtb;
        }
        internal DataTable select_store_by_code(string st_id)//سحب بيان مخزن بكودها
        {
            DataTable com_data_dtb = new DataTable();

            try
            {
                ///سحب بيان شكركه بكودها
                ///
                SqlCommand com_data_cmd = connect_sal.CreateCommand();
                SqlDataAdapter com_adap = new SqlDataAdapter();

                com_adap.SelectCommand = com_data_cmd;
                com_data_cmd.CommandText = "SELECT STId, Stname FROM StoreNameTbl where STId=" + st_id;



                com_adap.Fill(com_data_dtb);

            }
            catch (Exception rr)
            {
                MessageBox.Show(rr.Message);
            }
            return com_data_dtb;
        }
        public DataTable select_tasn_data_bynam_orcode(string tas_code, string tas_nam)//سحب بيانات تصنيف بالاسم او بالكود
        {
            DataTable tas_data_dtb = new DataTable();

            try
            {
                SqlCommand tas_data_cmd = connect_sal.CreateCommand();
                SqlDataAdapter tasn_adap = new SqlDataAdapter();

                tasn_adap.SelectCommand = tas_data_cmd;
                tas_data_cmd.CommandText = "SELECT CatId, CatName, Notes FROM Category WHERE CatId =" +

                   tas_code + " OR CatName LIKE '" + tas_nam + "'";

                tasn_adap.Fill(tas_data_dtb);

            }
            catch (Exception rr)
            {
                MessageBox.Show(rr.Message);
            }
            return tas_data_dtb;
        }

        public DataTable select_sanf_by_tasn_code(string tasneef_code)//سحب الاصناف بكود القسم
        {
            DataTable tas_data_dtb = new DataTable();

            try
            {
                SqlCommand tas_data_cmd = connect_sal.CreateCommand();
                SqlDataAdapter tasn_adap = new SqlDataAdapter();

                tasn_adap.SelectCommand = tas_data_cmd;
                tas_data_cmd.CommandText = "SELECT ItemName, ItemId FROM Items WHERE CatId =" +

                 tasneef_code;

                tasn_adap.Fill(tas_data_dtb);

            }
            catch (Exception rr)
            {
                MessageBox.Show(rr.Message);
            }
            return tas_data_dtb;
        }

        public DataTable select_sanf_by_tasneef(string tasneef_nam)//سحب الاصناف بالقسم
        {
            DataTable tas_data_dtb = new DataTable();

            try
            {
                SqlCommand tas_data_cmd = connect_sal.CreateCommand();
                SqlDataAdapter tasn_adap = new SqlDataAdapter();

                tasn_adap.SelectCommand = tas_data_cmd;
                tas_data_cmd.CommandText = "SELECT ItemName, ItemId FROM Items WHERE CatId =" +

                  select_tasn_data_bynam_orcode("NULL", tasneef_nam).Rows[0][0].ToString();

                tasn_adap.Fill(tas_data_dtb);

            }
            catch (Exception rr)
            {
                MessageBox.Show(rr.Message);
            }
            return tas_data_dtb;
        }
        ///<summary>
        ///
        /// سحب بيانات صنف  او بالكود
        /// 
        ///SELECT Items.ItemId, ItemName, ItemPurchPrice, ItemSellPriceGo\\n
        /// " ItemSellPriceKa, ItemModel, ItemNotes, ItemBarcode, CatId, item_comp_id"
        ///  " FROM Items join ItemDetails on Items.ItemId=ItemDetails.ItemId WHERE Items.ItemId ="
        ///</summary>;
      
        public DataTable select_sanf_data_by_barcode_orcode(string sanf_code)//سحب بيانات صنف بالاسم او بالكود
        {
            DataTable sanf_data_dtb = new DataTable();

            try
            {

                SqlCommand sanf_data_cmd = connect_sal.CreateCommand();
                SqlDataAdapter sanf_adap = new SqlDataAdapter();

                sanf_adap.SelectCommand = sanf_data_cmd;

                sanf_data_cmd.CommandText = "SELECT Items.ItemId, ItemName, ItemPurchPrice, ItemSellPriceGo," +

                    " ItemSellPriceKa, ItemModel, ItemNotes, ItemBarcode, CatId, item_comp_id" +

                    " FROM Items join ItemDetails on Items.ItemId=ItemDetails.ItemId WHERE Items.ItemId =" +

                   sanf_code.Trim();
               
                sanf_adap.Fill(sanf_data_dtb);

            }
            catch (Exception rr)
            {
                MessageBox.Show(rr.Message);
            }
            return sanf_data_dtb;
        }
        public DataTable select_sanf_data_by_barcode(string sanf_code)//سحب بيانات صنف باركود
        {
            DataTable sanf_data_dtb = new DataTable();

            try
            {

                SqlCommand sanf_data_cmd = connect_sal.CreateCommand();
                SqlDataAdapter sanf_adap = new SqlDataAdapter();

                sanf_adap.SelectCommand = sanf_data_cmd;

                sanf_data_cmd.CommandText = "SELECT Items.ItemId, ItemName, ItemPurchPrice, ItemSellPriceGo," +

                    " ItemSellPriceKa, ItemModel, ItemNotes, ItemBarcode, CatId, item_comp_id" +

                    " FROM Items join ItemDetails on Items.ItemId=ItemDetails.ItemId WHERE ItemDetails.ItemBarcode =" +

                   sanf_code.Trim();

                sanf_adap.Fill(sanf_data_dtb);

            }
            catch (Exception rr)
            {
                MessageBox.Show(rr.Message);
            }
            return sanf_data_dtb;
        }
        public DataTable select_sanf_data_by_name(string sanf_nam)//سحب بيانات صنف بالاسم 
        {
            DataTable sanf_data_dtb = new DataTable();

            try
            {

                SqlCommand sanf_data_cmd = connect_sal.CreateCommand();
                SqlDataAdapter sanf_adap = new SqlDataAdapter();

                sanf_adap.SelectCommand = sanf_data_cmd;

                sanf_data_cmd.CommandText = "SELECT Items.ItemId, ItemName, ItemPurchPrice, ItemSellPriceGo," +

                    " ItemSellPriceKa, ItemModel, ItemNotes, ItemBarcode, CatId" +

                    " FROM Items full outer join ItemDetails on Items.ItemId=ItemDetails.ItemId WHERE Items.ItemName like'" +

                   sanf_nam.Trim() + "'";

                sanf_adap.Fill(sanf_data_dtb);

            }
            catch (Exception rr)
            {
                MessageBox.Show(rr.Message);
            }
            return sanf_data_dtb;
        }
        public bool check_for_numreic(string number)//فحص بيانات رقمية
        {
            bool state = true;
            try
            {
                if(number!="")
                Convert.ToDouble(number);
            }
            catch (Exception dd)
            {
                MessageBox.Show("يجب ان تكون البيانات المدخله رقمية");
                state = false;
            }
            return state;
        }

        /// <summary>
        ///  "SELECT ItemId,ItemQuantity FROM Store " +
          ///          "WHERE ItemId=" + sanf_code;
        /// </summary>
        /// <param name="sanf_code"></param>
        /// <returns></returns>

        public DataTable select_sanf_data_store(string sanf_code)//سحب عدد صنف وكوده من المخزن
        {

            DataTable check_dtb = new DataTable();
            SqlCommand select_sanf_store_cmd =connect_sal.CreateCommand();
            DataTable stora_dtb = new DataTable();
            try
            {


                SqlDataAdapter store_adap = new SqlDataAdapter();
                store_adap.SelectCommand = select_sanf_store_cmd;

                select_sanf_store_cmd.CommandText = "SELECT ItemId,ItemQuantity FROM Store " +
                    "WHERE ItemId=" + sanf_code;

                store_adap.Fill(stora_dtb);
                if (stora_dtb.Rows.Count > 0)
                    check_dtb = stora_dtb;

            }
            catch (Exception g)
            {
                MessageBox.Show(g.Message + "دالة سحب  الصنف من المخزن");
            }

            return check_dtb;
        }
        /////////////////

        public void add_sanf_to_store(string sanf_code, string sanf_kemia)//اضافة جديد للمخزن
        {
            try
            {
                DataTable selected_sanf_dtb = new DataTable();
                selected_sanf_dtb = select_sanf_data_store(sanf_code);
                if (selected_sanf_dtb.Rows.Count <= 0)
                {
                    try
                    {
                        SqlCommand insert_sanf_store = connect_sal.CreateCommand();
                        insert_sanf_store.CommandText = "INSERT INTO Store(ItemId,ItemQuantity " + ")VALUES(" +
                           sanf_code + "," + sanf_kemia + ")";
                        connect_sal.Open();
                        insert_sanf_store.ExecuteNonQuery();
                        connect_sal.Close();

                    }
                    catch (Exception h)
                    {
                        throw new Exception(h.Message + "اضافة صنف");
                    }
                }
            }
            catch (Exception ss)
            {
                MessageBox.Show(ss.Message+"known probleme27");
            }
        }

        ////////////////////////
        public string update_store_minus(string sanf_code, string sanf_kemia)//تعديل المخزن بالسالب
        {

            string stora_mns_state = "";
            DataTable selected_sanf_dtb = new DataTable();
            selected_sanf_dtb = select_sanf_data_store(sanf_code);
            int sanf_num_table = 0;
            int sanf_num_new = 0;
            int total = 0;
            if (selected_sanf_dtb.Rows.Count > 0)
            {
                try
                {
                    sanf_num_table = Convert.ToInt32(selected_sanf_dtb.Rows[0][1].ToString());//from database
                    sanf_num_new = Convert.ToInt32(sanf_kemia);


                    SqlCommand update_sanf_store_cmd = connect_sal.CreateCommand();
                    // MessageBox.Show("sanf_num_table " + sanf_num_table.ToString() + " sanf_num_new " + sanf_num_new.ToString());
                    if (sanf_num_table >= sanf_num_new)
                    {

                        total = sanf_num_table - sanf_num_new;
                        update_sanf_store_cmd.CommandText = "UPDATE Store SET ItemQuantity=" + total.ToString() + " WHERE ItemId=" + sanf_code;
                        connect_sal.Open();


                        int rows = update_sanf_store_cmd.ExecuteNonQuery();

                        connect_sal.Close();
                        stora_mns_state = "true";
                    }
                    else
                    {
                        MessageBox.Show("عفوا لايوجد كمية كافية من   " +select_sanf_data_by_barcode_orcode(sanf_code).Rows[0][1].ToString());

                        stora_mns_state = "false";
                    }
                }
                catch (Exception g)
                {
                    MessageBox.Show(g.Message + "عفوا لايوجد كمية كافية من الصنف او لم يتم تسجيله  ");
                    connect_sal.Close();
                }

            }
            // else
            //MessageBox.Show("عفوا لايوجد كمية كافية من الصنف");
            return stora_mns_state;
        }
        /////////////////////
        public void update_store_kemia(string sanf_code,string kemia)
        {
        
            try
            {

                SqlCommand update_sanf_store_cmd = connect_sal.CreateCommand();
                update_sanf_store_cmd.CommandText = "UPDATE Store SET ItemQuantity=" + kemia + " WHERE ItemId=" + sanf_code;
                connect_sal.Open();


                int rows = update_sanf_store_cmd.ExecuteNonQuery();

                connect_sal.Close();
            }
            catch (Exception ff)
            {
                MessageBox.Show(ff.Message);
            }
        }
        public void update_store_plus(string sanf_code, string sanf_kemia)//تعدبل المخزن بالزيادة
        {
            try
            {

                DataTable selected_sanf_dtb = new DataTable();
                selected_sanf_dtb = select_sanf_data_store(sanf_code);

                int sanf_num_table = 0;
                int sanf_num_new = 0;
                int total = 0;
                if (selected_sanf_dtb.Rows.Count > 0)
                {

                    try
                    {
                        sanf_num_table = Convert.ToInt32(selected_sanf_dtb.Rows[0][1].ToString());//from database
                        sanf_num_new = Convert.ToInt32(sanf_kemia);
                        total = sanf_num_table + sanf_num_new;

                        SqlCommand update_sanf_store_cmd = connect_sal.CreateCommand();

                        update_sanf_store_cmd.CommandText = "UPDATE Store SET ItemQuantity=" + total.ToString() +
                            " WHERE ItemId=" + sanf_code;
                        connect_sal.Open();
                        int rows = update_sanf_store_cmd.ExecuteNonQuery();
                        connect_sal.Close();
                    }
                    catch (Exception g)
                    {
                        MessageBox.Show(g.Message);
                        connect_sal.Close();
                    }
                }
                else//فى حالة عدم وجود للصنف فى المخزن يتم اضافته
                {
                    add_sanf_to_store(sanf_code, sanf_kemia);
                }

            }
            catch (Exception ss)
            {
                MessageBox.Show("known probleme28");
            }
        }

        /////////////
        public DataTable select_all_mored()//سحب كل بيانات مورد
        {
            DataTable mor_data_dtb = new DataTable();

            try
            {
                SqlCommand tas_data_cmd = connect_sal.CreateCommand();
                SqlDataAdapter tasn_adap = new SqlDataAdapter();

                tasn_adap.SelectCommand = tas_data_cmd;
                tas_data_cmd.CommandText = "SELECT  AgentName, AgentId FROM Agent where AgentType='m' ";



                tasn_adap.Fill(mor_data_dtb);

            }
            catch (Exception rr)
            {
                MessageBox.Show(rr.Message);
            }
            return mor_data_dtb;
        }

        public DataTable select_all_agent()//سحب كل بيانات عميل
        {
            DataTable mor_data_dtb = new DataTable();

            try
            {
                SqlCommand tas_data_cmd = connect_sal.CreateCommand();
                SqlDataAdapter tasn_adap = new SqlDataAdapter();

                tasn_adap.SelectCommand = tas_data_cmd;
                tas_data_cmd.CommandText = "SELECT AgentId, AgentName FROM Agent where AgentType='Ag' ";



                tasn_adap.Fill(mor_data_dtb);

            }
            catch (Exception rr)
            {
                MessageBox.Show(rr.Message);
            }
            return mor_data_dtb;
        }
        /////////////
        ///////////////
        public DataTable select_ag_data_bynam_orcode(string ag_code, string ag_nam,string ag_type)//سحب بيانات عميل او مورد بالاسم او بالكود
        {
            DataTable ag_data_dtb = new DataTable();

            try
            {
                SqlCommand ag_data_cmd =connect_sal.CreateCommand();
                SqlDataAdapter ag_adap = new SqlDataAdapter();

                ag_adap.SelectCommand = ag_data_cmd;
                ag_data_cmd.CommandText = "SELECT AgentId, AgentName ,AgentStock FROM Agent WHERE AgentId =" +

                   ag_code + " OR AgentName LIKE '" + ag_nam + "' and AgentType='" + ag_type.Trim()+"'";

                ag_adap.Fill(ag_data_dtb);

            }
            catch (Exception rr)
            {
                MessageBox.Show(rr.Message);
            }
            return ag_data_dtb;
        }
        ///////////
        public void update_sanf_prices(string sanf_code, string sanf_purch_price, string sanf_sel_pric,

            string sanf_num, string sanf_kat_pric)//دالة تعديل اسعار الاصناف
        {

            try
            {
                double sanf_purch_frm_tabl = 0;
                double sanf_purch_new = 0;
                double sanf_num_frm_stor_tabl = 0;
                double sanf_new_purch_result = 0;
                double purch_pric_tarh = 0;
                double sanf_total_num;
                sanf_purch_new = Convert.ToDouble(sanf_purch_price);//سعر الشراء من المستخدم

                DataTable store_sanf_dtb = new DataTable();
                store_sanf_dtb = select_sanf_data_store(sanf_code);

                ///سعر الشراء القديم من جدول الاصناف قبل اضافة الفاتورة الجديدة
                SqlCommand select_sanf_frm_sanf_tab_cmd = connect_sal.CreateCommand();
                DataTable sanf_dtb = new DataTable();
                SqlDataAdapter sanf_adap = new SqlDataAdapter();
                sanf_adap.SelectCommand = select_sanf_frm_sanf_tab_cmd;
                select_sanf_frm_sanf_tab_cmd.CommandText = "SELECT ItemId, ItemPurchPrice FROM Items WHERE ItemId=" + sanf_code;
                sanf_adap.Fill(sanf_dtb);

                if (sanf_dtb.Rows.Count > 0)
                {
                    sanf_purch_frm_tabl = Convert.ToDouble(sanf_dtb.Rows[0][1].ToString());//سعر الشراء من جدول الاصناف القديم
                }

                // MessageBox.Show("store " + store_sanf_dtb.Rows.Count.ToString() + " sanf purch " + sanf_purch_frm_tabl.ToString());
                double sanf_new_price = 0;
                if (store_sanf_dtb.Rows.Count > 0 && sanf_purch_frm_tabl != 0)
                {
                    try
                    {
                        if (double.Parse(store_sanf_dtb.Rows[0][1].ToString()) >= 0)
                            sanf_num_frm_stor_tabl = Convert.ToDouble(store_sanf_dtb.Rows[0][1].ToString());// فى المخزن عدد الصنف المتبقى
                        else
                            sanf_num_frm_stor_tabl = 0;


                        sanf_new_price = ((sanf_purch_frm_tabl * sanf_num_frm_stor_tabl) + (sanf_purch_new * Convert.ToDouble(sanf_num))) /
                            (sanf_num_frm_stor_tabl + Convert.ToDouble(sanf_num));//المعــــــــــــــــــــــــــادلة(عدد قديم*سعر قديم+عددجديد*سعرجديد/مجموع العددين) ن

                       
                        SqlCommand update_sanf_dep_pric = connect_sal.CreateCommand();

                        update_sanf_dep_pric.CommandText = "UPDATE Items SET ItemPurchPrice=" + Math.Round(sanf_new_price,2) +
                            ",ItemSellPriceGo=" + sanf_sel_pric + ",ItemSellPriceKa=" + sanf_kat_pric + ",item_old_purch_price=" + sanf_purch_frm_tabl.ToString() +
                            "  WHERE ItemId=" + sanf_code;
                        connect_sal.Open();
                        update_sanf_dep_pric.ExecuteNonQuery();
                        connect_sal.Close();
                    }
                    catch (Exception n)
                    {
                        MessageBox.Show(n.Message + "تعديل سعر الصنف معادلات33333");
                        connect_sal.Close();
                    }
                }
                else
                {
                    try
                    {


                        ///////////////
                        SqlCommand update_sanf_dep_pric = connect_sal.CreateCommand();
                        update_sanf_dep_pric.CommandText = "UPDATE Items SET ItemPurchPrice=" + sanf_purch_price + ",ItemSellPriceGo=" + sanf_sel_pric +
                            ",ItemSellPriceKa=" + sanf_kat_pric + ",item_old_purch_price='0'" +
                            " WHERE ItemId=" + sanf_code;
                        connect_sal.Open();
                        update_sanf_dep_pric.ExecuteNonQuery();
                        connect_sal.Close();
                    }
                    catch (Exception fff)
                    {
                        MessageBox.Show(fff.Message + "تغيير اسعار");
                        connect_sal.Close();
                    }
                }


            }
            catch (Exception dd)
            {
                MessageBox.Show("تعديل اسعار اصناف" + dd.Message);
                connect_sal.Close();
            }

        }

        /////////////
        public string add_mny_imp_account(string mor_code, string mony)//اضافة مبلغ لمورد
        {
            double result_mny = 0;
            try
            {

                SqlCommand imp_mny = connect_sal.CreateCommand();
                SqlDataAdapter imp_mny_adap = new SqlDataAdapter();
                DataTable ag_mny_dtb = new DataTable();
                imp_mny_adap.SelectCommand = imp_mny;
                imp_mny.CommandText = "SELECT AgentStock FROM Agent WHERE AgentId = '" + mor_code + "' and AgentType='m'";
                imp_mny_adap.Fill(ag_mny_dtb);

                result_mny = Convert.ToDouble(ag_mny_dtb.Rows[0][0].ToString()) + Convert.ToDouble(mony);

                SqlCommand update_imp_mny_cmd = connect_sal.CreateCommand();
                update_imp_mny_cmd.CommandText = "UPDATE Agent SET AgentStock=" + result_mny.ToString() +
                    " WHERE  AgentId ='" + mor_code + "' and AgentType='m'";
                connect_sal.Open();
                update_imp_mny_cmd.ExecuteNonQuery();
                connect_sal.Close();
            }
            catch (Exception h)
            {
                MessageBox.Show(h.Message + " اضاقة مبلغ مورد");
                connect_sal.Close();
            }
            return result_mny.ToString();
        }
        public string add_mny_ag_account(string ag_id, string mony)//اضافة مبلغ لعميل
        {
            double result_mny = 0;
            try
            {

                SqlCommand imp_mny = connect_sal.CreateCommand();
                SqlDataAdapter imp_mny_adap = new SqlDataAdapter();
                DataTable ag_mny_dtb = new DataTable();
                imp_mny_adap.SelectCommand = imp_mny;
                imp_mny.CommandText = "SELECT AgentStock FROM Agent WHERE AgentId = " + ag_id + " and AgentType='Ag'";
                imp_mny_adap.Fill(ag_mny_dtb);

                result_mny = Convert.ToDouble(ag_mny_dtb.Rows[0][0].ToString()) + Convert.ToDouble(mony);

                SqlCommand update_imp_mny_cmd = connect_sal.CreateCommand();

                update_imp_mny_cmd.CommandText = "UPDATE Agent SET AgentStock=" + result_mny.ToString() +
                    " WHERE  AgentId =" + ag_id + " and AgentType='Ag'";
                connect_sal.Open();
                update_imp_mny_cmd.ExecuteNonQuery();
                connect_sal.Close();
            }
            catch (Exception h)
            {
                MessageBox.Show(h.Message + " اضاقة مبلغ مورد");
                connect_sal.Close();
            }
            return result_mny.ToString();
        }
        public string minus_mny_imp_account(string mot_code, string mony)//خصم مبلغ لمورد
        {
            // string state = "";
            double result_mny = 0;
            try
            {


                SqlCommand imp_mny = connect_sal.CreateCommand();
                SqlDataAdapter imp_mny_adap = new SqlDataAdapter();
                DataTable ag_mny_dtb = new DataTable();
                imp_mny_adap.SelectCommand = imp_mny;
                imp_mny.CommandText = "SELECT AgentStock FROM Agent WHERE AgentId ='" + mot_code + "' and AgentType='m'";
                imp_mny_adap.Fill(ag_mny_dtb);
                //if (mony <= Convert.ToDouble(ag_mny_dtb.Rows[0][0].ToString()))
                // {
                result_mny = Convert.ToDouble(ag_mny_dtb.Rows[0][0].ToString()) - Convert.ToDouble(mony);
                SqlCommand update_imp_mny_cmd = connect_sal.CreateCommand();
                update_imp_mny_cmd.CommandText = "UPDATE Agent SET AgentStock='" + result_mny.ToString() +
                    "' WHERE  AgentId ='" + mot_code + "' and AgentType='m'";

                connect_sal.Open();
                update_imp_mny_cmd.ExecuteNonQuery();
                connect_sal.Close();
                


            }
            catch (Exception h)
            {
                // state = "false";
                MessageBox.Show(h.Message + " طرح مبلغ مورد");
                connect_sal.Close();
            }
            return result_mny.ToString();
        }

        public string minus_mny_ag_account(string ag_id, string mony)//خصم مبلغ لعميل
        {
            // string state = "";
            double result_mny = 0;
            try
            {


                SqlCommand imp_mny = connect_sal.CreateCommand();
                SqlDataAdapter imp_mny_adap = new SqlDataAdapter();
                DataTable ag_mny_dtb = new DataTable();
                imp_mny_adap.SelectCommand = imp_mny;
                imp_mny.CommandText = "SELECT AgentStock FROM Agent WHERE AgentId =" + ag_id;
                imp_mny_adap.Fill(ag_mny_dtb);
                //if (mony <= Convert.ToDouble(ag_mny_dtb.Rows[0][0].ToString()))
                // {
                result_mny = Convert.ToDouble(ag_mny_dtb.Rows[0][0].ToString()) - Convert.ToDouble(mony);
                SqlCommand update_imp_mny_cmd = connect_sal.CreateCommand();

                update_imp_mny_cmd.CommandText = "UPDATE Agent SET AgentStock=" + result_mny.ToString() +
                    " WHERE  AgentId =" + ag_id;

                connect_sal.Open();
                update_imp_mny_cmd.ExecuteNonQuery();
                connect_sal.Close();



            }
            catch (Exception h)
            {
                // state = "false";
                MessageBox.Show(h.Message + " طرح مبلغ عميل");
                connect_sal.Close();
            }
            return result_mny.ToString();
        }
        /////////////
        public DataTable select_mor_by_name_or_code(string mor_code, string mor_name)//سحب بيانات مورد بالكود 
        {
            DataTable mor_data = new DataTable();
            try
            {
                SqlCommand imp_nam_cmd = connect_sal.CreateCommand();
                SqlDataAdapter imp_adap = new SqlDataAdapter();
                DataTable impp_dtb = new DataTable();
                imp_adap.SelectCommand = imp_nam_cmd;

                imp_nam_cmd.CommandText = "SELECT AgentId, AgentName, AgentStock FROM Agent WHERE AgentType ='m' and AgentId=" + mor_code + " or AgentName like'" + mor_name+"'";

                imp_adap.Fill(impp_dtb);
                if (impp_dtb.Rows.Count > 0)
                    mor_data = impp_dtb;
            }
            catch (Exception h)
            {
                MessageBox.Show(h.Message + " سحب اسم مورد");
                connect_sal.Close();
            }
            return mor_data;

        }

        /////////
        public void update_sanf_prices_after_ref_fat(string sanf_cod)//ارتجاع سعر تجارى قديم بعد ارتجاع فاتورة
        {
            try
            {
                
                SqlCommand select_purch_old_price_cmd =connect_sal.CreateCommand();
                DataTable old_pu_dtb = new DataTable();
                SqlDataAdapter ol_pu_adap = new SqlDataAdapter();
                ol_pu_adap.SelectCommand = select_purch_old_price_cmd;

                select_purch_old_price_cmd.CommandText = "SELECT item_old_purch_price FROM Items WHERE ItemId=" + sanf_cod;

                ol_pu_adap.Fill(old_pu_dtb);

                SqlCommand update_dep_pur_cmd = connect_sal.CreateCommand();
                if (Double.Parse(old_pu_dtb.Rows[0][0].ToString()) > 0)
                {
                    connect_sal.Open();
                    update_dep_pur_cmd.CommandText = "UPDATE Items SET ItemPurchPrice=" + old_pu_dtb.Rows[0][0].ToString() + " where ItemId=" + sanf_cod;
                    update_dep_pur_cmd.ExecuteNonQuery();
                    connect_sal.Close();
                }
            }
            catch (Exception hh)
            {
                MessageBox.Show(hh.Message + " تغيير الاسعار بعد ارتجاع فاتورة");
                connect_sal.Close();
            }

        }
        /////////////
        public DataTable select_user_data(string user_code,string user_name)
        {
            DataTable user_data_dtb = new DataTable();

            try
            {
                SqlCommand user_data_cmd = connect_sal.CreateCommand();
                SqlDataAdapter user_adap = new SqlDataAdapter();

                user_adap.SelectCommand = user_data_cmd;
                user_data_cmd.CommandText = "SELECT user_code, user_name FROM user_table WHERE user_code =" +

                   user_code + " OR user_name LIKE '" + user_name + "'";

                user_adap.Fill(user_data_dtb);

            }
            catch (Exception rr)
            {
                MessageBox.Show(rr.Message);
            }
            return user_data_dtb;
        }
        public void backup_database()
        {
            SqlCommand command = connect_sal.CreateCommand();
            command.CommandText = "BACKUP DATABASE sales to disk='d:\\sales.bk' WITH INIT";
            try
            {
                connect_sal.Open();
                command.ExecuteNonQuery();
                connect_sal.Close();
                MessageBox.Show(" تم النسخ بنجاح");

            }
            catch (SqlException ex)
            {
                if (ex.ToString().Contains("does not exist"))
                {
                    MessageBox.Show("لايمكن عمل نسخة احتياطية لان قاعدة البيانات غير متصلة");

                }
                else if (ex.ToString().Contains(" The server was not found or was not accessible."))
                {
                    MessageBox.Show("الخادم غير موجود او موقوف");

                }
                else
                    MessageBox.Show(ex.ToString());
                connect_sal.Close();


            }
        }

        public void check_periorty()
        {
            string m_id = "";
            try
            {
                // using (System.Management.ManagementClass theClass = new System.Management.ManagementClass("Win32_BaseBoard"))
                using (System.Management.ManagementClass theClass = new System.Management.ManagementClass("Win32_Processor"))
                {
                    using (System.Management.ManagementObjectCollection theCollectionOfResults = theClass.GetInstances())
                    {
                        foreach (System.Management.ManagementObject currentResult in theCollectionOfResults)
                        {

                            m_id = currentResult["ProcessorId"].ToString();


                        }
                    }
                }

                // MessageBox.Show(m_id);
                SqlCommand select_mo_id_cmd = connect_sal.CreateCommand();
                DataTable mo_id_dtb = new DataTable();
                SqlDataAdapter mo_id_adap = new SqlDataAdapter();
                mo_id_adap.SelectCommand = select_mo_id_cmd;
                select_mo_id_cmd.CommandText = "SELECT m_ser FROM chk_ser_table";
                mo_id_adap.Fill(mo_id_dtb);
                //MessageBox.Show(m_id + " " + mo_id_dtb.Rows[0][0].ToString().Trim());
                if (mo_id_dtb.Rows.Count > 0)
                {
                    if (m_id.Trim() == mo_id_dtb.Rows[0][0].ToString().Trim())
                    {

                    }
                    else
                    {
                        MessageBox.Show("هذا البرنامج غير صالح لهذا الجهاز", "تحـــــــــــذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        Application.Exit();
                    }
                }
                else
                {
                    try
                    {
                        SqlCommand insert_ser_cmd = connect_sal.CreateCommand();
                        insert_ser_cmd.CommandText = "INSERT INTO chk_ser_table(m_ser)VALUES('" + m_id + "')";
                        connect_sal.Open();
                        insert_ser_cmd.ExecuteNonQuery();
                        connect_sal.Close();
                    }
                    catch (Exception nn)
                    {
                        MessageBox.Show(nn.Message + "inset chk");
                        connect_sal.Close();
                    }
                }
            }
            catch (Exception ff)
            {
                MessageBox.Show(ff.Message + "chk");
                connect_sal.Close();
                Application.Exit();
            }

        }

        public void test_pro()
        {
            try
            {
                SqlCommand select_sel_count_cmd = connect_sal.CreateCommand();
                SqlDataAdapter count_adap = new SqlDataAdapter();
                DataTable count_dtb = new DataTable();
                select_sel_count_cmd.CommandText = "SELECT COUNT(BillId) FROM Bill";
                count_adap.SelectCommand = select_sel_count_cmd;
                count_adap.Fill(count_dtb);
                if (count_dtb.Rows.Count > 0)
                {
                    if (Convert.ToInt32(count_dtb.Rows[0][0].ToString()) >= 500)
                    {
                        MessageBox.Show("عفوا لقد نفذت مدة اختبار البرنامج", "صلاحية البرنامج", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Application.Exit();
                    }
                }
            }
            catch (Exception dd)
            {
                MessageBox.Show(dd.Message
                    );
            }
        }
         
        ///<summary>
        ///سحب كل الشركاء
        ///"SELECT partener_id, paretener_name FROM partener_table";
        ///</summary>
        public DataTable select_all_partener()
        {
            DataTable part_data_dtb = new DataTable();

            try
            {
                ///
                //سحب كل الشركاء
                ///
                SqlCommand part_data_cmd = connect_sal.CreateCommand();
                SqlDataAdapter part_adap = new SqlDataAdapter();

                part_adap.SelectCommand = part_data_cmd;

                part_data_cmd.CommandText = "SELECT partener_id, paretener_name FROM partener_table";

                 

                part_adap.Fill(part_data_dtb);

            }
            catch (Exception rr)
            {
                MessageBox.Show(rr.Message);
            }
            return part_data_dtb;
        }

       
        internal void insert_expire_item_date(string item_id, string item_date, string ex_bill_id, string ex_it_date_flag)
        {
            try
            {
                SqlCommand select_item_expi_cmd = connect_sal.CreateCommand();
                DataTable dtb = new DataTable();
                SqlDataAdapter store_adap = new SqlDataAdapter();
                // MessageBox.Show("DateTime.Parse(item_date)" + DateTime.Parse(item_date).ToShortDateString()  + " getdate(item_date)= " + GetDate(item_date));
                store_adap.SelectCommand = select_item_expi_cmd;

                select_item_expi_cmd.CommandText = "SELECT expire_id, expire_date, ex_bill_id FROM expire_item_table " +

                    "WHERE expire_item_id=" + item_id + " and expire_date like Convert(DATE,'" + item_date + "') and ex_it_date_flag <> 29";

                store_adap.Fill(dtb);
                // MessageBox.Show(dtb.Rows.Count.ToString());
                if (dtb.Rows.Count <= 0)
                {
                    SqlCommand insert_ex_date_cmd = connect_sal.CreateCommand();
                    insert_ex_date_cmd.CommandText = "insert into expire_item_table(expire_item_id, expire_date, ex_bill_id, ex_it_date_flag" +

                        ")values('" + item_id + "','" +GetDate_expire(item_date) + "','" + ex_bill_id + "'," + ex_it_date_flag + ")";

                    connect_sal.Open();
                    insert_ex_date_cmd.ExecuteNonQuery();
                    connect_sal.Close();
                }
            }
            catch (Exception dd)
            {
                MessageBox.Show(dd.Message);
                connect_sal.Close();
            }
        }
        public string GetDate_expire(string Indate)
        {
            string day, month, year;
            string outDate = "";
            try
            {
                day = (DateTime.Parse(Indate).Day).ToString(); ;
                month = (DateTime.Parse(Indate).Month).ToString();
                year = (DateTime.Parse(Indate).Year).ToString();
                outDate = year + "-" + month + "-" + day;
                return outDate;
            }
            catch { return outDate; }

        }

        internal void del_expire_item_date(string expire_id)
        {
            try
            {
                SqlCommand del_ex_date_cmd = connect_sal.CreateCommand();

                del_ex_date_cmd.CommandText = "update expire_item_table set ex_it_date_flag='29' where expire_id=" + expire_id;

                connect_sal.Open();
                del_ex_date_cmd.ExecuteNonQuery();
                connect_sal.Close();
            }
            catch (Exception dd)
            {
                MessageBox.Show(dd.Message);
                connect_sal.Close();
            }
        }
        /// <summary>
        ///  "SELECT expire_id, expire_date, ex_bill_id FROM expire_item_table "
        /// </summary>
        /// <param name="item_code"></param>
        /// <returns></returns>
        internal DataTable select_item_expire_dates(string item_code)//سحب تاريخ صلاحيات صنف
        {


            SqlCommand select_item_expi_cmd = connect_sal.CreateCommand();
            DataTable dtb = new DataTable();
            try
            {

                SqlDataAdapter store_adap = new SqlDataAdapter();

                store_adap.SelectCommand = select_item_expi_cmd;

                select_item_expi_cmd.CommandText = "SELECT expire_id, expire_date, ex_bill_id FROM expire_item_table " +

                    "WHERE expire_item_id=" + item_code + " and ex_it_date_flag <>29 order by expire_id asc";

                store_adap.Fill(dtb);


            }
            catch (Exception g)
            {
                MessageBox.Show(g.Message + "تاريخ صلاحية");
            }

            return dtb;
        }
        /// <summary>
        ///"SELECT partener_id, paretener_name FROM partener_table where partener_id=" + part_id;
        /// </summary>
        /// <returns></returns>
       
        internal DataTable select_partener(string part_id)
        {
            DataTable part = new DataTable();
            try
            {
                SqlCommand select_part_cmd = connect_sal.CreateCommand();
                SqlDataAdapter part_adap = new SqlDataAdapter();

                part_adap.SelectCommand = select_part_cmd;

                select_part_cmd.CommandText = "SELECT partener_id, paretener_name FROM partener_table where partener_id=" + part_id;



                part_adap.Fill(part);
            }
            catch (Exception g)
            {
                MessageBox.Show(g.Message + "all partenr");
            }
            return part;
        }
        /// <summary>
        /// SELECT  DATEDIFF(dd, getdate(),expire_date),ItemName, expire_item_id, expire_date, expire_id,com_name  
        /// </summary>
        /// <returns></returns>
        internal DataTable account_expire_date()//حساب المدة المتبقية للاصناف
        {
            DataTable dtb = new DataTable();
            try
            {
                SqlCommand select_item_expi_cmd = connect_sal.CreateCommand();

                SqlDataAdapter store_adap = new SqlDataAdapter();

                store_adap.SelectCommand = select_item_expi_cmd;

                select_item_expi_cmd.CommandText = "SELECT  DATEDIFF(dd, getdate(),expire_date),ItemName, expire_item_id, expire_date, expire_id,com_name" +

                    "   FROM expire_item_table join (Items join (ItemDetails join company_table on ItemDetails.item_comp_id=company_table.com_id) on Items.ItemId=ItemDetails.ItemId) on expire_item_table.expire_item_id=Items.ItemId" +

                    " and ex_it_date_flag <>29";

                store_adap.Fill(dtb);


            }
            catch (Exception g)
            {
                MessageBox.Show(g.Message + "account_expire_date");
            }
            return dtb;

        }
        /// <summary>
        ///SELECT expire_id, expire_item_id, expire_date, ex_bill_id FROM expire_item_table where DATEDIFF(dd, getdate(),expire_date) <=30 and ex_it_date_flag <>29
        /// </summary>
        /// <returns></returns>
        internal DataTable expire_date_less_7()
        {
            DataTable dtb = new DataTable();
            try
            {
                SqlCommand select_item_expi_cmd = connect_sal.CreateCommand();

                SqlDataAdapter store_adap = new SqlDataAdapter();

                store_adap.SelectCommand = select_item_expi_cmd;

                select_item_expi_cmd.CommandText = "SELECT expire_id, expire_item_id, expire_date, ex_bill_id FROM expire_item_table where DATEDIFF(dd, getdate(),expire_date) <=7 and ex_it_date_flag <>29";

                store_adap.Fill(dtb);


            }
            catch (Exception g)
            {
                MessageBox.Show(g.Message + "account_expire_date less 7");
            }
            return dtb;

        }
        internal DataTable expire_date_less_what_day(int num_day)
        {
            DataTable dtb = new DataTable();
            try
            {
                SqlCommand select_item_expi_cmd = connect_sal.CreateCommand();

                SqlDataAdapter store_adap = new SqlDataAdapter();

                store_adap.SelectCommand = select_item_expi_cmd;

                select_item_expi_cmd.CommandText = "SELECT  DATEDIFF(dd, getdate(),expire_date),ItemName, expire_item_id, expire_date, expire_id,com_name" +

                    "   FROM expire_item_table join (Items join (ItemDetails join company_table on ItemDetails.item_comp_id=company_table.com_id) on Items.ItemId=ItemDetails.ItemId) on expire_item_table.expire_item_id=Items.ItemId" +

                    " and ex_it_date_flag <>29 and DATEDIFF(dd, getdate(),expire_date)<" + num_day.ToString().Trim();
                store_adap.Fill(dtb);


            }
            catch (Exception g)
            {
                MessageBox.Show(g.Message + "account_expire_date less num of day");
            }
            return dtb;

        }
        /// <summary>
        /// select max(stuck_bill_id) from stuck_header_bill_table
        /// للحصول على اخر رقم فى الفاتورة المعلقة
        /// </summary>
        /// <returns></returns>
        internal DataTable max_stuck_bill()
        {
            DataTable dtb=new DataTable();
            try
            {
                SqlCommand select_max = connect_sal.CreateCommand();
                SqlDataAdapter adp = new SqlDataAdapter();
                adp.SelectCommand = select_max;
                select_max.CommandText = "select max(stuck_bill_id) from stuck_header_bill_table";
                adp.Fill(dtb);
            }
            catch (Exception g)
            {

            }
            return dtb;
        }
        /// <summary>
        /// بيانات راس فاتورةمعلقة
        /// "select stuck_bill_id as 'ID', st_b_date as 'التاريخ', st_owner as
        /// 'صاحب الفاتورة',st_b_notes as 'ملاحظات' from stuck_header_bill_table where st_b_type=0";
        /// </summary>
        /// <returns></returns>
        internal DataTable select_stuck_header(string num)
        {
            DataTable dtb = new DataTable();
            try
            {
                SqlCommand select = connect_sal.CreateCommand();
                SqlDataAdapter adp = new SqlDataAdapter();
                select.CommandText = "select top("+num+") stuck_bill_id as 'ID', st_b_date as 'التاريخ',"+
                    " st_owner as 'صاحب الفاتورة',st_b_notes as 'ملاحظات' from stuck_header_bill_table where st_b_type=0 order by stuck_bill_id desc";
                adp.SelectCommand = select;
                adp.Fill(dtb);
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message);
            }
            return dtb;
        }

        /// <summary>
        /// بيانات راس فاتورةمعلقة بكود الفاتورة
        /// "select stuck_bill_id , st_b_date ,"+
        ///" st_owner ,st_b_notes,st_chckrdbtn,st_ag_id, st_chkbx from stuck_header_bill_table where st_b_type=0 and stuck_bill_id="
        /// </summary>
        /// <returns></returns>
        internal DataTable select_stuck_header_by_code(string s_b_id)
        {
            DataTable dtb = new DataTable();
            try
            {
                SqlCommand select = connect_sal.CreateCommand();
                SqlDataAdapter adp = new SqlDataAdapter();
                select.CommandText = "select stuck_bill_id , st_b_date ,"+
                    " st_owner ,st_b_notes,st_chckrdbtn,st_ag_id, st_chkbx from stuck_header_bill_table where st_b_type=0 and stuck_bill_id=" + s_b_id;
                adp.SelectCommand = select;
                adp.Fill(dtb);
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message);
            }
            return dtb;
        }

        /// <summary>
        /// عدد الفواتيرالمعلقه
        /// "select stuck_bill_id , st_b_date ,"+
        ///" st_owner ,st_b_notes,st_chckrdbtn,st_ag_id, st_chkbx from stuck_header_bill_table where st_b_type=0
        /// </summary>
        /// <returns></returns>
        internal DataTable select_stuck_num()
        {
            DataTable dtb = new DataTable();
            try
            {
                SqlCommand select = connect_sal.CreateCommand();
                SqlDataAdapter adp = new SqlDataAdapter();
                select.CommandText = "select stuck_bill_id , st_b_date ," +
                    " st_owner ,st_b_notes,st_chckrdbtn,st_ag_id, st_chkbx from stuck_header_bill_table where st_b_type=0";
                adp.SelectCommand = select;
                adp.Fill(dtb);
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message);
            }
            return dtb;
        }
        /// <summary>
        /// بيانات السلع المعلقه
        /// "select st_item_b_id, st_item_code, sel_item_price,
        /// sel_item_quan, partener_id from stuck_items_table where st_b_id="
        /// </summary>
        /// <param name="stuck_bill_id"></param>
        /// <returns></returns>
        internal DataTable select_stuck_item(string stuck_bill_id)
        {
            DataTable dtb = new DataTable();
            try
            {
                SqlCommand select = connect_sal.CreateCommand();
                SqlDataAdapter adp = new SqlDataAdapter();
                select.CommandText = "select st_item_b_id, st_item_code, sel_item_price, sel_item_quan, partener_id from stuck_items_table where st_b_id=" + stuck_bill_id;
                adp.SelectCommand = select;
                adp.Fill(dtb);
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message);
            }
            return dtb;
        }
        /// <summary>
        /// انهاء فاتورة معلقة بكودها
        /// </summary>
        /// <param name="stuck_bill_id"></param>
        internal void finish_stuck_bills(string stuck_bill_id)
        {
            try
            {
                SqlCommand update_cmd = connect_sal.CreateCommand();
                update_cmd.CommandText = "update stuck_header_bill_table set st_b_type=1 where stuck_bill_id=" + stuck_bill_id;
                connect_sal.Open();
                update_cmd.ExecuteNonQuery();
                connect_sal.Close();
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message);
            }
        }
        internal void update_store_req_flag(string orderId,string stReqFlag)//تعديل طلب الصرف 0 جديد 1 تم بالفرعى 2 تم الالغاء3تم التسويه
        {
            try
            {
                SqlCommand update_cmd = connect_sal.CreateCommand();
                update_cmd.CommandText = "update SpentStReqTbl set SpentStReqStatus=" + stReqFlag + " where SpentStReqId=" + orderId;
                connect_sal.Open();
                update_cmd.ExecuteNonQuery();
                connect_sal.Close();
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message);
            }
        }
        /// <summary>
        /// الاستعلام عن طلبات المخزن المخزن المعلقة اللى حالتها0
        /// </summary>
        /// <returns></returns>
        internal DataTable select_stuck_store_req()
        {
            DataTable dtb = new DataTable();
            try
            {
                SqlCommand select = connect_sal.CreateCommand();
                SqlDataAdapter adp = new SqlDataAdapter();
                select.CommandText = "select * from SpentStReqTbl where SpentStReqStatus=0";
                adp.SelectCommand = select;
                adp.Fill(dtb);
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message);
            }
            return dtb;
        }

        internal bool select_store_type()
        {
            bool type=true;
            DataTable dtb = new DataTable();
            try
            {
                SqlCommand select = connect_sal.CreateCommand();
                SqlDataAdapter adp = new SqlDataAdapter();
                select.CommandText = "select type from storeTypeTable";
                adp.SelectCommand = select;
                adp.Fill(dtb);
                if (dtb.Rows.Count <= 0)
                {
                    type = false;
                    MessageBox.Show("لم يتم تسجيل مخزن");
                }
                else
                {
                    if (dtb.Rows[0][0].ToString().Trim() == "2")
                        type = false;//فرعى
                }

            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message);
            }
            return type;
        }
       
    }
}
