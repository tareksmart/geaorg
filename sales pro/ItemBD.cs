using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sales_pro
{
    public partial class ItemBD : UserControl
    {
        int count;
        SqlConnection con;
        public ItemBD(bool check_status)
        {
            string conStr = "Data Source=.\\SQLEXPRESS;Initial Catalog=sales;Integrated Security=True";
            con = new SqlConnection(conStr);
            count = 0;

            InitializeComponent();
            HideCHB.Enabled = check_status;
           
        }
        private methodes meth = new methodes();
        private void ItemInsertBtn_Click(object sender, EventArgs e)
        {
            string Instr1 = "insert into Items(ItemName,CatId,ItemPurchPrice,ItemSellPriceGo,ItemSellPriceKa) values('" 
                
                + ItemNameTB.Text + "','" + CatIdCB.SelectedValue + "','" + PurchPriceTB.Value.ToString() + "','" +
                
                GomlaPriceTB.Value.ToString() + "','" + KatPriceTB.Value.ToString() + "')";

            string Instr2;
            string ItemId = "Select Max(ItemId) from Items";
            SqlCommand comm = new SqlCommand(ItemId, con);
            double bar ;
            if (ItemBarCodeTB.Text != "")
                bar = double.Parse(ItemBarCodeTB.Text);
            else
                bar = -1;
            
            if ( ItemNameTB.Text != "" && ItemFound(bar) < 0)
            {
                try
                {
                    if (ItemIdTB.Text.Trim() == "")
                    {
                        if (expire_date.Value.Subtract(DateTime.Now.Date).TotalDays <= 1)
                        {
                            MessageBox.Show("لايمكن ادخال تاريخ صلاحية اقل من او يساوى تاريخ اليوم");
                        }
                        else
                        {
                            if (con.State == ConnectionState.Closed)
                                con.Open();
                            SqlCommand sql = new SqlCommand(Instr1, con);
                            sql.ExecuteNonQuery();

                            SqlDataReader Itemread = comm.ExecuteReader();
                            Itemread.Read();

                            ItemIdTB.Text = Itemread[0].ToString();

                            Instr2 = "insert into ItemDetails(ItemId,ItemModel,ItemNotes,ItemBarCode,item_comp_id, partener_id) values('" +
                                ItemIdTB.Text.Trim() + "','" + ItemModelTB.Text.Trim() + "','" + ItemNoteTB.Text.Trim() + "','" +
                                ItemBarCodeTB.Text + "','" + company_cmbx.SelectedValue.ToString() +"','"+partener_cmbx.SelectedValue.ToString()+ "')";

                            sql = new SqlCommand(Instr2, con);


                            // expire_date.Value.AddYears( DateTime.Now.Year+1);

                            Itemread.Close();
                            sql.ExecuteNonQuery();
                            con.Close();
                            meth.update_store_plus(ItemIdTB.Text.Trim(), sanf_store_num.Value.ToString());//اضافة العدد للمخزن
                            meth.insert_expire_item_date(ItemIdTB.Text.Trim(), expire_date.Text, "", "9");//تخين تاريخ الصلاحية
                            MessageBox.Show("تم الأدخال بنجاح");
                            // categoryTableAdapter.Fill(this.salesDataSet.Category);
                            itemsTableAdapter.Fill(this.itemsTADS.Items);
                            ItemClear_Click(sender, e);
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("هذه البيانات تم حفظها من قبل هل تريد تعديلها", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            con.Close();
                            ItemUpdateBtn.PerformClick();
                        }
                       
                    }
                }
                catch(Exception ex)
                {
                    con.Close();
                //    if (ItemFound(double.Parse(ItemBarCodeTB.Text)) > 0)
                 //       MessageBox.Show("الباركود موجود لصنف اخر");
                   if (ex.Message.Contains("UNIQUE KEY"))
                        MessageBox.Show("بيانات موجوده لصنف اخر");
                   else
                       MessageBox.Show("يجب ادخال البيانات صحيحة وبدون اى علامات");
                }
            }
            else
            {
                try
                {
                    if (ItemFound(double.Parse(ItemBarCodeTB.Text)) > 0 && ItemIdTB.Text == "")
                        MessageBox.Show("الباركود موجود لصنف اخر");
                    else if (ItemIdTB.Text != "")
                    {
                        if (MessageBox.Show("هذه البيانات تم حفظها من قبل هل تريد تعديلها", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            ItemUpdateBtn_Click(sender, e);
                    }
                    else
                        MessageBox.Show("الرجاء استكمال جميع البيانات اولا و ادخال البيانات صحيحة وبدون اى علامات");

                    ItemClear_Click(sender, e);
                }
                catch (Exception ex)
                {
                    //    if (ItemFound(double.Parse(ItemBarCodeTB.Text)) > 0)
                    //        MessageBox.Show("الباركود موجود لصنف اخر");
                    if (ex.Message.Contains("UNIQUE KEY"))
                        MessageBox.Show("بيانات موجوده من قبل");
                    else
                        MessageBox.Show("الرجاء استكمال جميع البيانات اولا");
                    ItemClear_Click(sender, e);
                } 
            }
        }

        private void ItemClear_Click(object sender, EventArgs e)
        {
            ItemIdTB.Text = "";
            ItemNameTB.Text = "";
            ItemNoteTB.Text = "";
            PurchPriceTB.Text = "0";
            GomlaPriceTB.Text = "0";
            sanf_store_num.Text = "0";
            KatPriceTB.Text = "0";
            ItemModelTB.Text = "";
            ItemBarCodeTB.Text = "";
            ItemIdQTB.Text = "";
            ItemNameTB.Focus();
            expire_item_grid.Columns.Clear();
        }

        private void CatCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                itemsBindingSource.Filter = "CatId=" + CatCB.SelectedValue;
                itemsTableAdapter.Fill(this.itemsTADS.Items);
                //    this.itemsTableAdapter.Fill(itemsTADS.Items); 
            }
            catch { }
        }



        private void ItemUpdateBtn_Click(object sender, EventArgs e)
        {
            string Updstr = "Update Items set ItemName='" +
                ItemNameTB.Text.Trim() + "',CatId='" + CatIdCB.SelectedValue + "' where ItemId=" + ItemIdTB.Text.Trim();

            string Updstr1 = "Update Items set ItemName='" +
                ItemNameTB.Text.Trim() + "',CatId='" + CatIdCB.SelectedValue + "',ItemPurchPrice='" + PurchPriceTB.Value.ToString() +
                "',ItemSellPriceGo='" + GomlaPriceTB.Value.ToString() + "',ItemSellPriceKa='" + KatPriceTB.Value.ToString() + "' where ItemId=" + ItemIdTB.Text.Trim();

            string Updstr2 = "Update ItemDetails set ItemModel='" +
                ItemModelTB.Text.Trim() + "',ItemNotes='" + ItemNoteTB.Text.Trim() +
                "',ItemBarCode='" + ItemBarCodeTB.Text.Trim() +"',item_comp_id='"+company_cmbx.SelectedValue.ToString()+"',partener_id='"+partener_cmbx.SelectedValue.ToString()+
                "' where ItemId=" + ItemIdTB.Text.Trim();
            try
            {
                con.Close();
                if (ItemIdTB.Text.Trim() != "")
                {
                    if (ItemNameTB.Text.Trim() != "" && CatIdCB.Text.Trim() != "")
                    {
                       
                            if (HideCHB.Checked == false)
                            {
                                con.Open();
                                SqlCommand sql = new SqlCommand(Updstr, con);
                                sql.ExecuteNonQuery();
                                sql = new SqlCommand(Updstr2, con);
                                sql.ExecuteNonQuery();
                                con.Close();


                                MessageBox.Show("تم التعديل بنجاح");
                                // categoryTableAdapter.Fill(this.salesDataSet.Category);
                                itemsTableAdapter.Fill(this.itemsTADS.Items);
                                itemDetailsTableAdapter.Fill(this.itemDS1.ItemDetails);
                                ItemClear_Click(sender, e);
                            }
                            else
                            {
                                con.Open();
                                SqlCommand sql = new SqlCommand(Updstr1, con);
                                sql.ExecuteNonQuery();
                                sql = new SqlCommand(Updstr2, con);
                                sql.ExecuteNonQuery();
                                con.Close();

                                meth.update_store_kemia(ItemIdTB.Text.Trim(), sanf_store_num.Value.ToString());//تعديل مباشر للمخزن
                                MessageBox.Show("تم التعديل بنجاح");
                                // categoryTableAdapter.Fill(this.salesDataSet.Category);
                                itemsTableAdapter.Fill(this.itemsTADS.Items);
                                itemDetailsTableAdapter.Fill(this.itemDS1.ItemDetails);
                                ItemClear_Click(sender, e);
                            }
                        
                    }
                    else
                        MessageBox.Show("يجب ادخال البيانات");
                }
                else
                    MessageBox.Show("استعلم عن الصنف اولا");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
                if (ex.Message.Contains("UNIQUE KEY"))
                    MessageBox.Show("بيانات موجوده من قبل");
                else if(ItemIdQTB.Text=="")
                    MessageBox.Show("الرجاء الأستعلام عن الصنف المراد تعديله اولا");
            }
        }

        private void HideCHB_CheckedChanged(object sender, EventArgs e)
        {
            if (HideCHB.Checked == true)
            {
                PurchPriceTB.Show();
                GomlaPriceTB.Show();
                KatPriceTB.Show();
                sanf_store_num.Show();
                label7.Show();
                label12.Show();
                label13.Show();
                label11.Show();
            }
            else
            {
               

                PurchPriceTB.Hide();
                GomlaPriceTB.Hide();
                KatPriceTB.Hide();
                sanf_store_num.Hide();
                label7.Hide();
                label12.Hide();
                label13.Hide();
                label11.Hide();
            }
        }

        private void ItemIdQTB_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void ItemBD_Load(object sender, EventArgs e)
        {
            try
            {
                categoryTableAdapter.Fill(this.salesDataSet.Category);
                itemDetailsTableAdapter.Fill(this.itemDS1.ItemDetails);
                itemsTableAdapter.Fill(this.itemsTADS.Items);
                company_cmbx.DisplayMember = "com_name";
                company_cmbx.ValueMember = "com_id";
                company_cmbx.DataSource = meth.select_all_company();

                partener_cmbx.DisplayMember = "paretener_name";
                partener_cmbx.ValueMember = "partener_id";
                partener_cmbx.DataSource = meth.select_all_partener();
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
            }
           // ItemCB.SelectedIndex = 0;
          /*  CatCB.DataSource = this.salesDataSet.Category;
            CatCB.ValueMember = "CatId";
            CatCB.DisplayMember = "CatName";

            ItemCB.DataSource = this.itemsTADS.Items;
            ItemCB.ValueMember = "ItemId";
            ItemCB.DisplayMember = "ItemName";*/
        }

        private void ItemCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ItemCB.Text.Trim() != "")
                {
                    if (Int32.Parse(ItemCB.SelectedValue.ToString()) >= 0)
                        FillTextBoxes(Int32.Parse(ItemCB.SelectedValue.ToString()));
                }
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message);
            }
            

        }
        public void FillTextBoxes(int Item)
        {
            try
            {
                int ind = 0;
                if (con.State.ToString() == "Open")
                    con.Close();
                con.Open();
                string ItemId = "Select Items.ItemId,ItemName,ItemPurchPrice,ItemSellPriceGo,ItemSellPriceKa,ItemModel,ItemNotes,ItemBarCode,partener_id,item_comp_id from Items join ItemDetails on  Items.ItemId=ItemDetails.ItemId and Items.ItemId='" + Item.ToString() + "'";
                SqlCommand comm = new SqlCommand(ItemId, con);
                SqlDataReader Itemread = comm.ExecuteReader();
                // Itemread.Read();

                while (Itemread.Read())
                {
                    // if (Int32.Parse(itemsTADS.Tables[0].Rows[0]["ItemId"].ToString()) == Int32.Parse(ItemCB.SelectedValue.ToString()))
                    // {
                    ItemIdTB.Text = Itemread["ItemId"].ToString().Trim();
                    ItemNameTB.Text = Itemread["ItemName"].ToString().Trim();
                    PurchPriceTB.Text = Itemread["ItemPurchPrice"].ToString().Trim();
                    GomlaPriceTB.Text = Itemread["ItemSellPriceGo"].ToString().Trim();
                    KatPriceTB.Text = Itemread["ItemSellPriceKa"].ToString().Trim();
                    ItemModelTB.Text = Itemread["ItemModel"].ToString().Trim();
                    ItemNoteTB.Text = Itemread["ItemNotes"].ToString().Trim();
                    ItemBarCodeTB.Text = Itemread["ItemBarCode"].ToString().Trim();
                    CatIdCB.SelectedIndex = CatCB.SelectedIndex;
                   // ItemIdQTB.Text = Itemread["ItemId"].ToString().Trim();
                    if( meth.select_sanf_data_store(Item.ToString()).Rows.Count>0)
                    sanf_store_num.Text= meth.select_sanf_data_store(Item.ToString()).Rows[0][1].ToString();
                    partener_cmbx.SelectedValue = Itemread["partener_id"].ToString().Trim();
                    company_cmbx.SelectedValue = Itemread["item_comp_id"].ToString().Trim();
                    // }company_cmbx
                    //ind++;
                }

                Itemread.Close();
                con.Close();
                expire_item_grid.DataSource = meth.select_item_expire_dates(Item.ToString());
                expire_item_grid.Columns[0].Visible = false;
                expire_item_grid.Columns[2].Visible = false;
                // ItemBarCodeTB.Text = itemsTADS.Tables[0].Rows[i]["ItemBarCode"].ToString();

                
            }
            catch(Exception mm)
            {
                MessageBox.Show(mm.Message);
                con.Close();
            }
        }
        int ItemFound(double itemN)
        {
            SqlCommand comm;
            SqlDataReader Itemread;
            string getbar = "select ItemBarCode from ItemDetails where ItemBarcode='" + itemN + "'";
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                comm = new SqlCommand(getbar, con);
                Itemread = comm.ExecuteReader();
                while (Itemread.Read())
                {
                    Itemread.Close();
                    return 1;
                }
                Itemread.Close();
                con.Close();
            }
            catch { con.Close(); }
            return -1;
        }

        private void ItemBarCodeTB_TextChanged(object sender, EventArgs e)
        {
            Int64 data;
            try
            {
                data = Int64.Parse(ItemBarCodeTB.Text);
            }
            catch
            {
                if (ItemBarCodeTB.Text != "")
                {
                    MessageBox.Show("الرجاء ادخال ارقام فقط");
                    ItemBarCodeTB.Text = "";
                }

            }
        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void ItemBarCodeTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ShiftKey)
                ItemInsertBtn.PerformClick();
        }

        private void ItemNameTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ItemInsertBtn.PerformClick();
        }

        private void CatIdCB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ItemInsertBtn.PerformClick();
        }

        private void ItemModelTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ItemInsertBtn.PerformClick();
        }

        private void ItemNoteTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ItemInsertBtn.PerformClick();
        }

        private void GomlaPriceTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ItemInsertBtn.PerformClick();
        }

        private void sanf_store_num_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ItemInsertBtn.PerformClick();
        }

        private void expire_item_grid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if(expire_item_grid.Rows.Count>0)
                if (MessageBox.Show("هل تريد حذف الصلاحيه المحدده  لهذا الصنف", "تحذير", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    meth.del_expire_item_date(expire_item_grid.CurrentRow.Cells[0].Value.ToString());

                    expire_item_grid.DataSource = meth.select_item_expire_dates(ItemIdQTB.Text.Trim());
                    expire_item_grid.Columns[0].Visible = false;
                    expire_item_grid.Columns[2].Visible = false;
                }
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (expire_item_grid.Rows.Count > 0)
            {
                if (ItemIdTB.Text.Trim() != "")
                {
                    meth.del_expire_item_date(expire_item_grid.CurrentRow.Cells[0].Value.ToString());
                    meth.insert_expire_item_date(ItemIdTB.Text.Trim(), expire_up_date.Text, "", "9");
                    expire_item_grid.CurrentRow.Cells[1].Value = expire_up_date.Text;

                    update_expire_date_exp.Expanded = false;
                    update_expire_date_exp.Visible = false;
                }
            }
        }

        private void expire_item_grid_DoubleClick(object sender, EventArgs e)
        {
            if (expire_item_grid.Rows.Count > 0)
            {
                update_expire_date_exp.Visible = true;
                update_expire_date_exp.Expanded = true;
            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            update_expire_date_exp.Expanded = false;
            update_expire_date_exp.Visible = false;
        }

        private void expire_item_grid_MouseUp(object sender, MouseEventArgs e)
        {
           
        }

        private void expire_item_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           // toolTip1.SetToolTip(expire_item_grid,"لحذف صلاحية حدد واضغط زرار حذف لتعديل تاريخ صلاحية دبل كليك");
        }

        private void add_com_btn_Click(object sender, EventArgs e)
        {
            update_expire_date_form up = new update_expire_date_form();
            up.ShowDialog();
             ItemBD_Load( sender,  e);
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void ItemIdQTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Int64 data;
                try
                {
                    data = Int64.Parse(ItemIdQTB.Text);
                }
                catch
                {
                    if (ItemIdQTB.Text != "")
                    {
                        MessageBox.Show("الرجاء ادخال ارقام فقط");
                        ItemIdQTB.Text = "";
                    }

                }

                int catid = 0, itemid = 0, sellPrice = 0;
                string ItemId;
                string Quan;
                SqlCommand comm;
                SqlDataReader Itemread;

                /*try
                  {
                       con.Open();
                      if(count==0)
                      {
                       ItemId = "Select Items.ItemId,CatId,ItemSellPriceGo,ItemSellPriceKa from Items join ItemDetails on (Items.ItemId=ItemDetails.ItemId) and ( Items.ItemId= " + ItemIdQTB.Text.Trim() + " or ItemBarcode= " + ItemIdQTB.Text.Trim() + ")";
                       comm = new SqlCommand(ItemId, con);
                       Itemread = comm.ExecuteReader();
                       while(Itemread.Read())
                       {
                
                       CatCB.SelectedValue = Itemread["CatId"].ToString();
                       //CatCB_SelectedIndexChanged(sender, e);
                       itemsBindingSource.Filter = "CatId='" + CatCB.SelectedValue.ToString() + "' and ItemId='" + Itemread["ItemId"].ToString() + "'";
                       itemsTableAdapter.Fill(itemsTADS.Items);
                       ItemIdQTB.Text = Itemread["ItemId"].ToString();
                       //ItemCB.SelectedValue = Itemread["ItemId"].ToString();
                       ItemCB_SelectedIndexChanged(sender, e);
               
                       }
                       Itemread.Close();
                       //count = 0;
                       con.Close();
                   }
                   catch { con.Close(); }*/
                try
                {
                    Int64 s_q_code = 0;
                    s_q_code = Int64.Parse(ItemIdQTB.Text.Trim());
                    con.Open();

                    if (count == 0 && ItemIdQTB.Text != "")
                    {
                        ItemId = "Select Items.ItemId,CatId,ItemSellPriceGo,ItemSellPriceKa from Items join ItemDetails on  Items.ItemId=ItemDetails.ItemId and (Items.ItemId= "
                            + s_q_code + " or ItemBarcode= " + s_q_code + ")";
                        comm = new SqlCommand(ItemId, con);
                        Itemread = comm.ExecuteReader();

                        Itemread.Read();
                        if (Itemread.HasRows)
                       {
                            itemid = Int32.Parse(Itemread["ItemId"].ToString());
                            catid = Int32.Parse(Itemread["CatId"].ToString());
                            
                            FillTextBoxes(itemid);
                            expire_item_grid.DataSource = meth.select_item_expire_dates(ItemIdQTB.Text.Trim());
                            expire_item_grid.Columns[0].Visible = false;
                            expire_item_grid.Columns[2].Visible = false;
                            count++;
                            Itemread.Close();
                            ItemIdQTB.Text = itemid.ToString();
                            CatCB.SelectedValue = catid;
                            ItemCB.SelectedValue = itemid;

                            FillTextBoxes(itemid);
                        }

                        //SellPriceTB.Text = sellPrice.ToString();

                        //QuanTB.Focus();
                    }
                    else
                    {
                        CatCB.SelectedValue = catid;
                        ItemCB.SelectedValue = itemid;
                        FillTextBoxes(itemid);
                        // SellPriceTB.Text = sellPrice.ToString();
                        //QuanTB.Focus();
                    }
                    count = 0;
                    con.Close();
                }
                catch (Exception dd)
                {
                    MessageBox.Show(dd.Message);
                    con.Close();
                }
            }
        }
    }
}
