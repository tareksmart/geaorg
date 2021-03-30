using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.ReportSource;


namespace sales_pro
{
    public partial class sales_fat : Form
    {
        int count;
        double salesMoney;
        SqlConnection con;
        methodes method;
        int selectGV;
        bool selltype;
        string Type;
        string conStr;
        ArrayList ItemsId1, ItemsQua1,REFBill;
        int refBtn,ItSEl;
        double quan=1,PurchPrice;
        EarnCalc EC;
      
        public sales_fat(string printer_name,bool check_status)
        {
            conStr = "Data Source=.\\SQLEXPRESS;Initial Catalog=sales;Integrated Security=True;MultipleActiveResultSets=true";
            con = new SqlConnection(conStr);
            ItemsId1 = new ArrayList(1000);
            ItemsQua1 = new ArrayList(1000);
            REFBill = new ArrayList(100);
          //  BillDateAL = new ArrayList(100);
            count = 0;
            selltype = false;
            selectGV = 0;
            ItSEl = 0;
            method = new methodes();
            refBtn = 0;
            InitializeComponent();
            OperType.SelectedIndex = 0;
            Type="SEL";
            PurchPrice = 0;
            EC = new EarnCalc();
            BillRefundBtn.Enabled = false;
           
             d_p = printer_name;
             status = check_status;
        }
        private string d_p = "";
        private bool status;
        private void AddItemBtn_Click(object sender, EventArgs e)//SellPriceTB
        {
            try
            {
               
                if (ItemFound(Int32.Parse(ItemIdQTB.Text.Trim())) < 0 && Int32.Parse(ItemIdQTB.Text.Trim()) != 0 && double.Parse(QuanTB.Text.Trim()) > 0 && double.Parse(SellPriceTB.Text.Trim()) > 0)
                {
                    if (double.Parse(QuanTB.Text.Trim()) <= double.Parse(RemainTB.Text.Trim()))
                    {

                        if (double.Parse(meth.select_sanf_data_by_barcode_orcode(ItemIdQTB.Text.Trim()).Rows[0][2].ToString()) >= double.Parse(SellPriceTB.Text.Trim()))
                        {
                            if (MessageBox.Show(" لقد تعديت سعر الشراء هل تريد الحفظ", "تحذير", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                            {
                                BillDetailGV.Rows.Add();
                                BillDetailGV.Rows[BillDetailGV.RowCount - 1].Cells[0].Value = BillDetailGV.RowCount.ToString();
                                BillDetailGV.Rows[BillDetailGV.RowCount - 1].Cells[1].Value = ItemIdQTB.Text.Trim();
                                BillDetailGV.Rows[BillDetailGV.RowCount - 1].Cells[2].Value = ItemCB.Text.Trim();
                                BillDetailGV.Rows[BillDetailGV.RowCount - 1].Cells[3].Value = SellPriceTB.Text.Trim();
                                BillDetailGV.Rows[BillDetailGV.RowCount - 1].Cells[4].Value = QuanTB.Text.Trim();
                                BillDetailGV.Rows[BillDetailGV.RowCount - 1].Cells[5].Value = TotalTB.Text.Trim();
                                BillDetailGV.Rows[BillDetailGV.RowCount - 1].Cells[6].Value = discount_bx.Text.Trim();
                                BillDetailGV.Rows[BillDetailGV.RowCount - 1].Cells[7].Value = partener_cmbx.SelectedValue;
                                BillTotalTB.Text = (double.Parse(BillTotalTB.Text) + double.Parse(TotalTB.Text)).ToString();
                            }

                        }
                        else
                        {
                            BillDetailGV.Rows.Add();
                            BillDetailGV.Rows[BillDetailGV.RowCount - 1].Cells[0].Value = BillDetailGV.RowCount.ToString();
                            BillDetailGV.Rows[BillDetailGV.RowCount - 1].Cells[1].Value = ItemIdQTB.Text.Trim();
                            BillDetailGV.Rows[BillDetailGV.RowCount - 1].Cells[2].Value = ItemCB.Text.Trim();
                            BillDetailGV.Rows[BillDetailGV.RowCount - 1].Cells[3].Value = SellPriceTB.Text.Trim();
                            BillDetailGV.Rows[BillDetailGV.RowCount - 1].Cells[4].Value = QuanTB.Text.Trim();
                            BillDetailGV.Rows[BillDetailGV.RowCount - 1].Cells[5].Value = TotalTB.Text.Trim();
                            BillDetailGV.Rows[BillDetailGV.RowCount - 1].Cells[6].Value = discount_bx.Text.Trim();
                            BillDetailGV.Rows[BillDetailGV.RowCount - 1].Cells[7].Value = partener_cmbx.SelectedValue;
                            BillTotalTB.Text = (double.Parse(BillTotalTB.Text) + double.Parse(TotalTB.Text)).ToString();
                        }
                    }
                   
                    else
                        MessageBox.Show("الكميه بالمخزن غير كافيه");
                    
                        
                }
                else
                {
                    if (ItemFound(Int32.Parse(ItemIdQTB.Text.Trim())) >= 0)
                    {
                        MessageBox.Show("موجود من قبل يمكنك تعديل الكميه", "خطأ");
                       
                    }
                    else if (Int32.Parse(ItemIdQTB.Text.Trim()) == 0)
                        MessageBox.Show("ادخل رقم صنف صحيح", "خطأ");
                    else if (ItemFound(Int32.Parse(ItemIdQTB.Text.Trim())) < 0 && ItemCB.SelectedValue.ToString() != ItemIdQTB.Text)
                        MessageBox.Show("ادخل رقم صنف صحيح", "خطأ");
                    else if (double.Parse(QuanTB.Text.Trim()) <= 0)
                        MessageBox.Show("الكميه لابد ان تكون اكبر من 0", "خطأ");
                    else
                        MessageBox.Show("رقم صنف خطأ", "خطأ");

                }
                ItemIdQTB.Text = "";
                //CatCB.SelectedIndex = 0;
                SellPriceTB.Text = "0";
                QuanTB.Text = "1";
                RemainTB.Text = "0";
                sel_sanf_code_bx.Clear();
                BillTo();
            }
            catch(Exception dd)
            {
               // MessageBox.Show(dd.Message);
                ItemIdQTB.Text = "";
                if (CatCB.Items.Count > 0)
                    CatCB.SelectedIndex = 0;
                SellPriceTB.Text = "0";
                QuanTB.Text = "1";
                RemainTB.Text = "0";
                if (ItemIdQTB.Text != "")
                {
                    if (ItemFound(Int32.Parse(ItemIdQTB.Text.Trim())) >= 0)
                        MessageBox.Show("موجود من قبل يمكنك تعديل الكميه", "خطأ");
                    else if (Int32.Parse(ItemIdQTB.Text.Trim()) == 0)
                        MessageBox.Show("ادخل رقم صنف صحيح", "خطأ");
                    else if (double.Parse(QuanTB.Text.Trim()) <= 0)
                        MessageBox.Show("الكميه لابد ان تكون اكبر من 0", "خطأ");
                    else
                        MessageBox.Show("رقم صنف خطأ", "خطأ");
                }
                else
                    MessageBox.Show("ادخل رقم صنف صحيح", "خطأ");
            }

        }

        private void sales_fat_Load(object sender, EventArgs e)
        {
            try
            {
                sel_sanf_code_bx.Focus();
                // TODO: This line of code loads data into the 'billDS.Bill' table. You can move, or remove it, as needed.
                //  this.billTableAdapter.Fill(this.billDS.Bill);
                // TODO: This line of code loads data into the 'agentDS.Agent' table. You can move, or remove it, as needed.
                // TODO: This line of code loads data into the 'itemsTADS.Items' table. You can move, or remove it, as needed.
                this.itemsTableAdapter.Fill(this.itemsTADS.Items);
                // TODO: This line of code loads data into the 'salesDataSet.Category' table. You can move, or remove it, as needed.
                this.categoryTableAdapter.Fill(this.salesDataSet.Category);
                //   this.agentTableAdapter.Fill(this.agentDS.Agent);
                agentBindingSource.Filter = "AgentType='Ag'";
                this.agentTableAdapter.Fill(this.agentDS.Agent);

               partener_cmbx.DisplayMember = "paretener_name";
                partener_cmbx.ValueMember = "partener_id";
                partener_cmbx.DataSource = meth.select_all_partener();

                stuck_bill_num_btn.Text = meth.select_stuck_num().Rows.Count.ToString();
            }
            catch (Exception gg) { MessageBox.Show(gg.Message); }

        }

        private void CatCB_SelectedIndexChanged(object sender, EventArgs e)
        {
           try
           {
                if (CatCB.SelectedValue != null)
                    itemsBindingSource.Filter = "CatId=" + CatCB.SelectedValue;
           }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message);
            }
        }


        private void QuanTB_TextChanged(object sender, EventArgs e)
        {
            Int64 data;
            try
            {
                data = Int64.Parse(QuanTB.Text);
            }
            catch
            {
                if (QuanTB.Text != "")
                {
                    MessageBox.Show("الرجاء ادخال ارقام فقط");
                    QuanTB.Text = "1";
                }

            }
            double price;
            try
            {
                if (refBtn == 0)
                {
                    if (ItemIdQTB.Text.Trim() != "")
                        if (double.Parse(QuanTB.Text.Trim()) <= double.Parse(RemainTB.Text.Trim()))
                        {

                            price = double.Parse(QuanTB.Text.Trim()) * double.Parse(SellPriceTB.Text.Trim());
                            TotalTB.Text = price.ToString();
                            discount_bx.Text = discount_item();
                        }
                        else
                            QuanTB.Text = "1";//RemainTB.Text.Trim();
                }
                else
                {
                    if (double.Parse(QuanTB.Text) < quan)
                    {
                       // warn_lbl.Text = "تم استنفاذ الرصيد من هذا الصنف";
                    }
                  //  else
                      //  warn_lbl.Text = "";
                      //  price = double.Parse(QuanTB.Text) * double.Parse(SellPriceTB.Text.Trim());
                        //TotalTB.Text = price.ToString();
                  //  }
                  //  else
                     //   QuanTB.Text = quan.ToString();
                }
               

            }
            catch
            { }

        }

        private void ItemCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                ItemIdQTB.Text = ItemCB.SelectedValue.ToString();
              //  QuanTB.Text = "1";
                //   TotalTB.Text = "0";
                //  QuanTB.Focus();
            }
            catch { }
        }

        private void ClearItemBtn_Click(object sender, EventArgs e)
        {
            // int counter=BillDetailGV.Rows.Count;
            try
            {

                BillDetailGV.Rows.RemoveAt(selectGV);
                SortDG();
                ItemIdQTB.Text = "";
                //CatCB.SelectedIndex = 0;
                SellPriceTB.Text = "0";
                QuanTB.Text = "1";
                RemainTB.Text = "0";
                RemainTB.Text = "0";
                discount_bx.Clear();
                AddItemBtn.Enabled = true;
                BillTo();
            }
            catch
            {
                ItemIdQTB.Text = "";
                // CatCB.SelectedIndex = 0;
                SellPriceTB.Text = "0";
                QuanTB.Text = "1";
                RemainTB.Text = "0";
                MessageBox.Show(" لم يتم تحديد سجل ليتم حذفه");
            }
            SortDG();
        }
        private void SortDG()
        {
            try
            {
                if (BillDetailGV.Rows.Count > 0)
                    for (int i = 0; i < BillDetailGV.Rows.Count; i++)
                    {
                        BillDetailGV.Rows[i].Cells[0].Value = i + 1;
                    }
            }
            catch { }
        }

        private void BillDetailGV_SelectionChanged(object sender, EventArgs e)
        {
            if (BillDetailGV.SelectedRows.Count == 1)
            {

                ItemIdQTB.Text = BillDetailGV.Rows[Int32.Parse(BillDetailGV.SelectedRows[0].Index.ToString())].Cells[1].Value.ToString();
                SellPriceTB.Text = BillDetailGV.Rows[Int32.Parse(BillDetailGV.SelectedRows[0].Index.ToString())].Cells[3].Value.ToString();
                QuanTB.Text = BillDetailGV.Rows[Int32.Parse(BillDetailGV.SelectedRows[0].Index.ToString())].Cells[4].Value.ToString();
                TotalTB.Text = BillDetailGV.Rows[Int32.Parse(BillDetailGV.SelectedRows[0].Index.ToString())].Cells[5].Value.ToString();
                selectGV = BillDetailGV.SelectedRows[0].Index;
            }
        }

        private void UpdateBillBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ItemIdQTB.Text.Trim() != "" && ItemCB.Text.Trim() != "" && QuanTB.Text.Trim() != "")
                {
                    SqlDataReader Itemread;
                    int temp = ItemFound(Int32.Parse(ItemIdQTB.Text.Trim()));
                    if (ItemIdQTB.Text.Trim() == BillDetailGV.CurrentRow.Cells[1].Value.ToString().Trim())
                    {
                        if (ItemFound(Int32.Parse(ItemIdQTB.Text.Trim())) > -1 && ItemFound(Int32.Parse(ItemIdQTB.Text.Trim())) == selectGV)
                        {
                            if (double.Parse(meth.select_sanf_data_by_barcode_orcode(ItemIdQTB.Text.Trim()).Rows[0][2].ToString()) >= double.Parse(SellPriceTB.Text.Trim()))
                            {
                                if (MessageBox.Show(" لقد تعديت سعر الشراء هل تريد الحفظ", "تحذير", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                                {
                                    BillDetailGV.Rows[selectGV].Cells[0].Value = selectGV + 1;
                                    BillDetailGV.Rows[selectGV].Cells[1].Value = ItemIdQTB.Text.Trim();
                                    BillDetailGV.Rows[selectGV].Cells[2].Value = ItemCB.Text.Trim();
                                    BillDetailGV.Rows[selectGV].Cells[3].Value = SellPriceTB.Text.Trim();
                                    BillDetailGV.Rows[selectGV].Cells[4].Value = QuanTB.Text.Trim();
                                    BillDetailGV.Rows[selectGV].Cells[5].Value = TotalTB.Text.Trim();
                                    BillDetailGV.Rows[selectGV].Cells[6].Value =discount_bx.Text.Trim();
                                    BillTotalTB.Text = (double.Parse(BillTotalTB.Text.Trim()) + double.Parse(TotalTB.Text)).ToString();
                                    string Quan = "Select ItemQuantity From Store  where ItemId= " + ItemIdQTB.Text;
                                    con.Open();
                                    SqlCommand comm = new SqlCommand(Quan, con);
                                    Itemread = comm.ExecuteReader();
                                    Itemread.Read();
                                    RemainTB.Text = Itemread["ItemQuantity"].ToString();
                                    Itemread.Close();
                                    ItemIdQTB.Text = "";
                                    //s  CatCB.SelectedIndex = 0;
                                    SellPriceTB.Text = "0";
                                    QuanTB.Text = "1";
                                    RemainTB.Text = "0";
                                    discount_bx.Clear();
                                    TotalTB.Clear();
                                    con.Close();
                                    BillTo();
                                }
                            }
                            else
                            {
                                BillDetailGV.Rows[selectGV].Cells[0].Value = selectGV + 1;
                                BillDetailGV.Rows[selectGV].Cells[1].Value = ItemIdQTB.Text;
                                BillDetailGV.Rows[selectGV].Cells[2].Value = ItemCB.Text;
                                BillDetailGV.Rows[selectGV].Cells[3].Value = SellPriceTB.Text;
                                BillDetailGV.Rows[selectGV].Cells[4].Value = QuanTB.Text;
                                BillDetailGV.Rows[selectGV].Cells[5].Value = TotalTB.Text;
                                BillDetailGV.Rows[selectGV].Cells[6].Value = discount_bx.Text.Trim();
                                BillTotalTB.Text = (double.Parse(BillTotalTB.Text.Trim()) + double.Parse(TotalTB.Text)).ToString();
                                string Quan = "Select ItemQuantity From Store  where ItemId= " + ItemIdQTB.Text;
                                con.Open();
                                SqlCommand comm = new SqlCommand(Quan, con);
                                Itemread = comm.ExecuteReader();
                                Itemread.Read();
                                RemainTB.Text = Itemread["ItemQuantity"].ToString();
                                Itemread.Close();
                                ItemIdQTB.Text = "";
                                //s  CatCB.SelectedIndex = 0;
                                SellPriceTB.Text = "0";
                                QuanTB.Text = "1";
                                RemainTB.Text = "0";
                                RemainTB.Text = "0";
                                discount_bx.Clear();
                                con.Close();
                                BillTo();
                            }
                        }
                        else
                            MessageBox.Show(" لم يتم تحديد سجل ليتم تعديله");
                    }
                    else
                        MessageBox.Show("يجب اختيار الصنف المراد ارتجاع كمية منه");
                }
                else
                {
                    MessageBox.Show("من فضلك اكمل بيانات الصنف");
                }
            }
            catch
            {
                ItemIdQTB.Text = "";
                // CatCB.SelectedIndex = 0;
                SellPriceTB.Text = "0";
                QuanTB.Text = "1";
                RemainTB.Text = "0";
                AddItemBtn.Enabled = true;
                MessageBox.Show(" لم يتم تحديد سجل ليتم تعديله");
                con.Close();
            }
        }
        int ItemFound(int itemN)
        {
            try
            {
                if (BillDetailGV.Rows.Count > 0)
                    for (int i = 0; i < BillDetailGV.Rows.Count; i++)
                    {
                        if (Int32.Parse(BillDetailGV.Rows[i].Cells[1].Value.ToString()) == itemN)
                        {
                            BillDetailGV.Rows[i].Selected = true;
                            
                            return i;
                        }

                    }
            }
            catch { }
            return -1;
        }

        private void CashCB_CheckedChanged(object sender, EventArgs e)
        {
            if (CashCB.Checked == true)
                CreditCB.Checked = false;
            else
                CreditCB.Checked = true;
        }

        private void CreditCB_CheckedChanged(object sender, EventArgs e)
        {
            if (CreditCB.Checked == true)
            {
                CashCB.Checked = false;
            }
            else
                CashCB.Checked = true;
        }

        private void SaveBillBtn_Click(object sender, EventArgs e)
        {
           
            string selltemp = "";
            double stock;
            BillTo();
          
            DialogResult result;
            if (BillDetailGV.Rows.Count > 0)
            {
                result = MessageBox.Show("هل انت متأكد من حفظ الفاتوره ؟ ", "تحذير", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    if (Int32.Parse(BillIdTB.Text) == 0)
                    {
                       try
                       {
                            if (selltype == true)
                            {
                                selltemp = AgentCB.SelectedValue.ToString();
                                if (CreditCB.Checked == true)
                                {
                                    
                                    if (con.State.ToString() == "Open")
                                        con.Close();
                                  //  MessageBox.Show(con.State.ToString());
                                    con.Open();
                                    SqlCommand agentStock = new SqlCommand("select AgentStock from Agent where AgentId='" + AgentCB.SelectedValue + "'", con);
                                    SqlDataReader reader = agentStock.ExecuteReader();
                                    reader.Read();
                                    if (reader[0] != null)
                                        stock = double.Parse(BillTotalTB.Text.Trim()) + double.Parse(reader[0].ToString());
                                    else
                                        stock = double.Parse(BillTotalTB.Text.Trim());
                                    reader.Close();
                                    SqlCommand agentUp = new SqlCommand("Update Agent set AgentStock='" + stock.ToString() + "' where Agentid='" + AgentCB.SelectedValue + "'", con);
                                    agentUp.ExecuteNonQuery();
                                    string selltemp1 = "insert into AgentDetails(AgentId,AgentStock,AgentMny,AgentDetailDate) values('" +
                                        AgentCB.SelectedValue + "','" + stock.ToString() + "','" + PaidMoneyTB.Text.Trim() + "','" + 
                                        GetDate(DateTime.Now.ToLongDateString()) + "')";
                                    agentUp = new SqlCommand(selltemp1, con);
                                    agentUp.ExecuteNonQuery();
                                   // reader.Close();
                                  //  MessageBox.Show(con.State.ToString());
                                    con.Close();
                                   
                                }
                            }
                            else
                                selltemp = "";
                        }

                        catch (Exception dd)
                        {
                           
                            con.Close();
                            MessageBox.Show(dd.Message+"dd");
                            con.Close();
                        }
                       string Instr1 = "";
                        if (BillDetailGV.Rows.Count > 0)
                        {
                            if (ToAgentRB.Checked == true && CreditCB.Checked == true)
                            {
                                Instr1 = "insert into Bill(BillType,BillPaperNo,BillDate,AgentId,BillNote,BillTotal,s_or_c,partener_id,owner_name) values('SEL','"
                                    + BillNoTB.Value + "','" + GetDate(BillDateTB.Text.Trim()) + "','" + selltemp + "','" + BillNoteTB.Text.Trim()
                                    + "','" + BillTotalTB.Text.Trim() + "','" + "c" + "','" + partener_cmbx.SelectedValue.ToString()+"','"+fat_owner_bx.Text.Trim()+ "')";
                            }
                            else
                            {
                                Instr1 = "insert into Bill(BillType,BillPaperNo,BillDate,AgentId,BillNote,BillTotal,s_or_c,partener_id,owner_name) values('SEL','" 
                                    + BillNoTB.Value + "','" + GetDate(BillDateTB.Text.Trim()) + "','" + selltemp + "','" +
                                    BillNoteTB.Text.Trim() + "','" + BillTotalTB.Text.Trim() + "','" + "s" + "','" + partener_cmbx.SelectedValue.ToString() +"','"+fat_owner_bx.Text.Trim()+ "')";
                            }
                            
                                string Instr2, Quan;
                            string BillId = "Select Max(BillId) from Bill";
                            int billid;
                            SqlCommand UpdStore, getOldQu;
                            SqlCommand comm = new SqlCommand(BillId, con);
                            SqlDataReader StoreQuan1;
                            try
                            {
                                if (con.State == ConnectionState.Closed)
                                    con.Open();
                                SqlCommand sql = new SqlCommand(Instr1, con);
                                sql.ExecuteNonQuery();
                                SqlDataReader Billread = comm.ExecuteReader();
                                Billread.Read();
                                billid = Int32.Parse(Billread[0].ToString());
                                Billread.Close();


                                for (int i = 0; i <= BillDetailGV.Rows.Count - 1; i++)
                                {
                                    Instr2 = "insert into BillDetails(BillId,ItemId,ItemQuantity,ItemPrice,BillDate,partener_id, discount) values('" + billid.ToString() +
                                        "','" + BillDetailGV.Rows[i].Cells[1].Value.ToString() + "','" + BillDetailGV.Rows[i].Cells[4].Value.ToString() +
                                        "','" + BillDetailGV.Rows[i].Cells[3].Value.ToString() + "','" + GetDate(BillDateTB.Text.Trim()) + "','" +
                                        BillDetailGV.Rows[i].Cells[7].Value.ToString() + "','" + BillDetailGV.Rows[i].Cells[6].Value.ToString() + "')";

                                    getOldQu = new SqlCommand("select ItemQuantity from Store where ItemId='" + BillDetailGV.Rows[i].Cells[1].Value.ToString() + "'", con);
                                    StoreQuan1 = getOldQu.ExecuteReader();
                                    StoreQuan1.Read();
                                    Quan = StoreQuan1[0].ToString();
                                    if (double.Parse(Quan) > 0)
                                        sql = new SqlCommand("Update Store set ItemQuantity='" + (double.Parse(StoreQuan1["ItemQuantity"].ToString()) - double.Parse(BillDetailGV.Rows[i].Cells[4].Value.ToString())).ToString() + "' where ItemId='" + BillDetailGV.Rows[i].Cells[1].Value.ToString() + "'", con);
                                    else
                                        sql = new SqlCommand("Update Store set ItemQuantity='" + StoreQuan1["ItemQuantity"].ToString() + "' where ItemId='" + BillDetailGV.Rows[i].Cells[1].Value.ToString() + "'", con);

                                    StoreQuan1.Close();
                                    sql.ExecuteNonQuery();
                                    UpdStore = new SqlCommand("Update Store set ItemQuantity='" + (double.Parse(Quan) - double.Parse(BillDetailGV.Rows[i].Cells[4].Value.ToString())) + "' where ItemId='" + BillDetailGV.Rows[i].Cells[1].Value.ToString() + "'", con);
                                    sql = new SqlCommand(Instr2, con);
                                    sql.ExecuteNonQuery();
                                    UpdStore.ExecuteNonQuery();
                                }
                                BillDetailGV.Rows.Clear();
                                con.Close();
                                MessageBox.Show("تم حفظ الفاتوره بنجاح");
                                RemainMoneyTB.Text = "0";
                                PaidMoneyTB.Text = "0";
                                check_done = 0;
                                if (stuck_b_id_bx.Text.Trim() != "")//انهاء فاتورة معلقة
                                {
                                    meth.finish_stuck_bills(stuck_b_id_bx.Text.Trim());
                                    stuck_b_id_bx.Clear();
                                    stuck_bill_num_btn.Text = meth.select_stuck_num().Rows.Count.ToString();
                                }
                               /* if (DateTime.Now.Day - DateTime.Parse(BillDateTB.Text).Day > 1)
                                    EC.EarnCalcOper(BillDateTB.Text);*/
                                BillDateTB.Text = DateTime.Now.ToShortDateString();
                                BillRemoveBtn_Click(sender, e);
                            }
                            catch (Exception ff) {  con.Close(); MessageBox.Show(ff.Message+" خطأ بالبيانات"); }
                        }
                    }
                }
                else if (result == System.Windows.Forms.DialogResult.No)
                {
                    RemainMoneyTB.Text = "0";
                    PaidMoneyTB.Text = "0";
                    BillDetailGV.Rows.Clear();
                    con.Close();
                    BillDateTB.Text = DateTime.Now.ToShortDateString();

                }
                else
                { }
                
            }

            else
            { MessageBox.Show("ادخل بيانات الفاتوره كاملة"); }
        }
        private int check_done = 0;//لو قيمته بواحد اى تم وضع check ب true
        private void NormSellRB_CheckedChanged(object sender, EventArgs e)
        {
           

            if (BillDetailGV.Rows.Count <= 0)
            {

                if (NormSellRB.Checked)
                {
                    selltype = false;
                    if (ItemIdQTB.Text != "")
                        ItemIdQTB_TextChanged(sender, e);
                }
                else if (ToAgentRB.Checked)
                {
                    try
                    {

                        AgentCB.SelectedIndex = 0;
                        selltype = true;
                        if (ItemIdQTB.Text != "")
                            ItemIdQTB_TextChanged(sender, e);


                    }
                    catch { MessageBox.Show("عفوا لايوجد لديك عملاء من فضلك سجل العملاء اولا من شاشة البيانات الاساسية"); NormSellRB.Checked = true; }
                }



            }
            else
            {
                if (check_done == 0)
                {
                DialogResult result=MessageBox.Show("سوف يتم تغيير نوع عملية البيع هل تريد حفظ الاصناف", "تحذير", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

              
                    if (result == DialogResult.Yes)
                    {
                        if (SaveBillBtn.Enabled == true)
                        {
                            sale_save();
                            check_done = 0;
                        }
                        else
                            MessageBox.Show("هذه الفاتورة محفوظة من قبل");
                    }
                    else if (result == DialogResult.No)
                    {

                        BillDetailGV.Rows.Clear();

                        RemainMoneyTB.Text = "0";
                        PaidMoneyTB.Text = "0";
                        check_done = 0;
                        BillRemoveBtn.PerformClick();
                    }
                    else
                    {
                        check_done = 1;

                        if (NormSellRB.Checked)
                            ToAgentRB.Checked = true;
                        else if (ToAgentRB.Checked)
                            NormSellRB.Checked = true;
                        check_done = 0;
                    }
                }
            }
              

      
        }
        private void sale_save()
        {
            string selltemp = "";
            double stock;
            BillTo();
            if (Int32.Parse(BillIdTB.Text) == 0)
            {
                try
                {
                    if (selltype == true)
                    {
                        selltemp = AgentCB.SelectedValue.ToString();
                        if (CreditCB.Checked == true)
                        {
                            con.Open();
                            SqlCommand agentStock = new SqlCommand("select AgentStock from Agent where AgentId='" + AgentCB.SelectedValue + "'", con);
                            SqlDataReader reader = agentStock.ExecuteReader();
                            reader.Read();
                            if (reader[0] != null)
                                stock = double.Parse(RemainMoneyTB.Text.Trim()) + double.Parse(reader[0].ToString());
                            else
                                stock = double.Parse(RemainMoneyTB.Text.Trim());
                            reader.Close();
                            SqlCommand agentUp = new SqlCommand("Update Agent set AgentStock='" + stock.ToString() + "' where Agentid='" + AgentCB.SelectedValue + "'", con);
                            agentUp.ExecuteNonQuery();
                            string selltemp1 = "insert into AgentDetails(AgentId,AgentStock,AgentMny,AgentDetailDate) values('" + AgentCB.SelectedValue + "','" + stock.ToString() + "','" + PaidMoneyTB.Text.Trim() + "','" + GetDate(DateTime.Now.ToLongDateString()) + "')";
                            agentUp = new SqlCommand(selltemp1, con);
                            agentUp.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                    else
                        selltemp = "";
                }

                catch { con.Close(); }

                if (BillDetailGV.Rows.Count > 0)
                {
                    string Instr1 = "insert into Bill(BillType,BillPaperNo,BillDate,AgentId,BillNote,BillTotal) values('SEL','" + BillNoTB.Value + "','" + GetDate(BillDateTB.Text.Trim()) + "','" + selltemp + "','" + BillNoteTB.Text.Trim() + "','" + BillTotalTB.Text.Trim() + "')";
                    string Instr2, Quan;
                    string BillId = "Select Max(BillId) from Bill";
                    int billid;
                    SqlCommand UpdStore, getOldQu;
                    SqlCommand comm = new SqlCommand(BillId, con);
                    SqlDataReader StoreQuan1;
                    try
                    {
                        if (con.State == ConnectionState.Closed)
                            con.Open();
                        SqlCommand sql = new SqlCommand(Instr1, con);
                        sql.ExecuteNonQuery();
                        SqlDataReader Billread = comm.ExecuteReader();
                        Billread.Read();
                        billid = Int32.Parse(Billread[0].ToString());
                        Billread.Close();


                        for (int i = 0; i <= BillDetailGV.Rows.Count - 1; i++)
                        {
                            Instr2 = "insert into BillDetails(BillId,ItemId,ItemQuantity,ItemPrice,BillDate) values('" + billid.ToString() + "','" + BillDetailGV.Rows[i].Cells[1].Value.ToString() + "','" + BillDetailGV.Rows[i].Cells[4].Value.ToString() + "','" + BillDetailGV.Rows[i].Cells[3].Value.ToString() + "','" + GetDate(BillDateTB.Text.Trim()) + "')";
                            getOldQu = new SqlCommand("select ItemQuantity from Store where ItemId='" + BillDetailGV.Rows[i].Cells[1].Value.ToString() + "'", con);
                            StoreQuan1 = getOldQu.ExecuteReader();
                            StoreQuan1.Read();
                            Quan = StoreQuan1[0].ToString();
                            if (double.Parse(Quan) > 0)
                                sql = new SqlCommand("Update Store set ItemQuantity='" + (double.Parse(StoreQuan1["ItemQuantity"].ToString()) - double.Parse(BillDetailGV.Rows[i].Cells[4].Value.ToString())).ToString() + "' where ItemId='" + BillDetailGV.Rows[i].Cells[1].Value.ToString() + "'", con);
                            else
                                sql = new SqlCommand("Update Store set ItemQuantity='" + StoreQuan1["ItemQuantity"].ToString() + "' where ItemId='" + BillDetailGV.Rows[i].Cells[1].Value.ToString() + "'", con);

                            StoreQuan1.Close();
                            sql.ExecuteNonQuery();
                            UpdStore = new SqlCommand("Update Store set ItemQuantity='" + (double.Parse(Quan) - double.Parse(BillDetailGV.Rows[i].Cells[4].Value.ToString())) + "' where ItemId='" + BillDetailGV.Rows[i].Cells[1].Value.ToString() + "'", con);
                            sql = new SqlCommand(Instr2, con);
                            sql.ExecuteNonQuery();
                            UpdStore.ExecuteNonQuery();
                        }
                        BillDetailGV.Rows.Clear();
                        con.Close();
                        MessageBox.Show("تم حفظ الفاتوره بنجاح");
                        RemainMoneyTB.Text = "0";
                        PaidMoneyTB.Text = "0";
                        check_done = 0;
                       /* if (DateTime.Now.Day - DateTime.Parse(BillDateTB.Text).Day > 1)
                            EC.EarnCalcOper(BillDateTB.Text);*/
                        BillDateTB.Text = DateTime.Now.ToShortDateString();
                        BillRemoveBtn.PerformClick();
                    }
                    catch { con.Close(); MessageBox.Show("خطأ بالبيانات"); }
                }
            }
        }
        private void ToAgentRB_CheckedChanged(object sender, EventArgs e)
        {

          
              
           
        }

        private void PaidMoneyTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                RemainMoneyTB.Text = (double.Parse(BillTotalTB.Text.Trim()) - double.Parse(PaidMoneyTB.Text.Trim())).ToString();
            }
            catch { }
        }

        private void DateRB_CheckedChanged(object sender, EventArgs e)
        {
            /* //OperType_SelectedIndexChanged(sender, e);
             // AgentCHB_CheckedChanged(sender, e);
             if (DateRB.Checked == true&&AgentCHB.Checked==false)
             {
                 //  OperType_SelectedIndexChanged(sender,e);
                 //  billBindingSource.Filter = "BillDate >= '" + FromDateTB.Text.Trim() + "' and BillDate <='" + ToDateTB.Text.Trim() + "'";
                // AgentCHB_CheckedChanged(sender, e);
                 this.billTableAdapter.Fill(this.billDS.Bill, Type, FromDateTB.Text.Trim(), ToDateTB.Text.Trim());

             }
             else if (DateRB.Checked == true && AgentCHB.Checked == true)
             {
                 this.billTableAdapter.FillByDA(this.billDS.Bill, Type, FromDateTB.Text.Trim(), ToDateTB.Text.Trim(),Int32.Parse(AgentQCB.SelectedValue.ToString()));
             }*/

        }

        private void BillCounterRB_CheckedChanged(object sender, EventArgs e)
        {
            /*/ billBindingSource.Filter = " (BillId IN (SELECT  [TOP] (5) [BillId] FROM Bill AS Bill_1))";
            // OperType_SelectedIndexChanged(sender, e);
            //AgentCHB_CheckedChanged(sender, e);
            
            if (BillCounterRB.Checked == true && AgentCHB.Checked == false)
            {

                this.billTableAdapter.FillBy1(this.billDS.Bill,Int32.Parse(BillNoTB.Text.Trim()),Type);
                // AgentCHB_CheckedChanged(sender, e);
            }
            else if (BillCounterRB.Checked == true && AgentCHB.Checked == true)
                this.billTableAdapter.FillByNA(this.billDS.Bill, Int32.Parse(BillNoTB.Text.Trim()), Int32.Parse(AgentQCB.SelectedValue.ToString()), Type);
             * */
        }

        private void FinalBillRB_CheckedChanged(object sender, EventArgs e)
        {
            /*/billBindingSource.Filter = "BillId = (SELECT  max([BillId]) As BillId FROM Bill)";
            // OperType_SelectedIndexChanged(sender, e);
            // AgentCHB_CheckedChanged(sender, e);
            if (FinalBillRB.Checked == true && AgentCHB.Checked == false)
            {


                this.billTableAdapter.FillBy(this.billDS.Bill, Type);

              //  AgentCHB_CheckedChanged(sender, e);
            }
            if (FinalBillRB.Checked == true && AgentCHB.Checked == true)
                this.billTableAdapter.FillByMaxA(this.billDS.Bill, Type, Int32.Parse(AgentQCB.SelectedValue.ToString()));
            */
        }



        private void FromDateTB_ValueChanged(object sender, EventArgs e)
        {
            /*DateRB_CheckedChanged(sender, e);*/
        }

        private void ToDateTB_ValueChanged(object sender, EventArgs e)
        {
            //    DateRB_CheckedChanged(sender, e);
        }

        private void BillNoTB_ValueChanged(object sender, EventArgs e)
        {
            //  BillCounterRB_CheckedChanged(sender, e);
        }

        private void OperType_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (OperType.SelectedIndex == 1)
                Type = "REF";
            else
                Type = "SEL";
            if (AgentCHB.Checked == false)
                billBindingSource.Filter = "AgentId >= 0";
            else
                billBindingSource.Filter = "AgentId ='" + AgentQCB.SelectedValue.ToString() + "'";
            if (DateRB.Checked == true)
            {
                //  billBindingSource.Filter = "BillDate >= '" + FromDateTB.Text.Trim() + "' and BillDate <='" + ToDateTB.Text.Trim() + "'";
                this.billTableAdapter.Fill(this.billDS.Bill, Type, FromDateTB.Text.Trim(), ToDateTB.Text.Trim());
            }
            else if (BillCounterRB.Checked == true)
            {
                this.billTableAdapter.FillBy1(this.billDS.Bill, Int32.Parse(BillNoTB.Text.Trim()), Type);
            }
            else
            {
                FinalBillRB_CheckedChanged(sender, e);
            }*/

        }

        private void BillQDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BillDetailGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           if (BillIdTB.Text.Trim() != "")
            {
               if (Int32.Parse(BillIdTB.Text.Trim()) > 0)
                    ref_num_exp.Expanded = true;
            }
            if (BillDetailGV.SelectedCells.Count == 1 && double.Parse(BillDetailGV.Rows[BillDetailGV.SelectedCells[0].RowIndex].Cells[4].Value.ToString()) > 0)
            {
                try
                {
                    earn_lbl.Text = ((double.Parse(BillDetailGV.CurrentRow.Cells[5].Value.ToString()) -
                        (double.Parse(BillDetailGV.CurrentRow.Cells[4].Value.ToString()) *
                        double.Parse(meth.select_sanf_data_by_barcode_orcode(BillDetailGV.CurrentRow.Cells[1].Value.ToString()).Rows[0][2].ToString()))).ToString());

                    ItemIdQTB.Text = BillDetailGV.Rows[BillDetailGV.SelectedCells[0].RowIndex].Cells[1].Value.ToString();
                    SellPriceTB.Text = BillDetailGV.Rows[BillDetailGV.SelectedCells[0].RowIndex].Cells[3].Value.ToString();
                    QuanTB.Text = BillDetailGV.Rows[BillDetailGV.SelectedCells[0].RowIndex].Cells[4].Value.ToString();

                    quan = QuantityDG(Int32.Parse(BillDetailGV.Rows[BillDetailGV.SelectedCells[0].RowIndex].Cells[1].Value.ToString()));
                    QuanTB.Text = quan.ToString();
                    ref_num_bx.Text = QuanTB.Text;
                    TotalTB.Text = BillDetailGV.Rows[BillDetailGV.SelectedCells[0].RowIndex].Cells[5].Value.ToString();
                    selectGV = BillDetailGV.SelectedCells[0].RowIndex;
                    // AddItemBtn.Enabled = false;
                    //  ItSEl = Int32.Parse(BillDetailGV.Rows[BillDetailGV.SelectedCells[0].RowIndex].Cells[1].Value.ToString());

                    con.Open();
                    SqlCommand getOldQu = new SqlCommand("select ItemQuantity from Store where ItemId='" + BillDetailGV.Rows[BillDetailGV.SelectedCells[0].RowIndex].Cells[1].Value.ToString() + "'", con);
                    SqlDataReader StoreQuan1 = getOldQu.ExecuteReader();
                    StoreQuan1.Read();
                    RemainTB.Text = StoreQuan1[0].ToString();
                    con.Close();
                }
                catch (Exception ff) { MessageBox.Show(ff.Message); con.Close(); }

            }

        }
        private string settel_or_credit(string bill_id)//احضار حالة الفاتورة نقديه ام اجله بكود الفاتورة
        {
            string s_or_c = "";
            try
            {
                SqlCommand select_s_or_c_cmd = con.CreateCommand();
                SqlDataAdapter adap = new SqlDataAdapter();
                DataTable dtb = new DataTable();
                adap.SelectCommand = select_s_or_c_cmd;
                select_s_or_c_cmd.CommandText = "select s_or_c, AgentType, AgentId, BillType from Bill where BillId="+bill_id;
                adap.Fill(dtb);
                s_or_c = dtb.Rows[0][0].ToString().Trim();
            }
            catch (Exception dd)
            {
                MessageBox.Show(dd.Message + " settel_or_credit");
            }
            return s_or_c;
        }
        private void BillQDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;

            if (refBtn == 0 && BillDetailGV.Rows.Count > 0)
            {

                DialogResult result;
                result = MessageBox.Show("هل تريد حفظ الفاتوره الحاليه؟", "Data Not saved", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    SaveBillBtn.PerformClick();
                }
                else if (result == System.Windows.Forms.DialogResult.No)
                {
                    BillDetailGV.Rows.Clear();
                }
            }
            else
                BillDetailGV.Rows.Clear();

            if (BillQDGV.SelectedCells.Count == 1)
            {
                try
                {
                    BillNoteTB.Text = BillQDGV.Rows[BillQDGV.SelectedCells[0].RowIndex].Cells[6].Value.ToString();
                    if (double.Parse(BillQDGV.Rows[BillQDGV.SelectedCells[0].RowIndex].Cells[4].Value.ToString()) > 0)
                    {
                       // AgentCB.SelectedValue = BillQDGV.Rows[BillQDGV.SelectedCells[0].RowIndex].Cells[4].Value;
                        ag_code_bx.Text= BillQDGV.Rows[BillQDGV.SelectedCells[0].RowIndex].Cells[4].Value.ToString();
                        ToAgentRB.Checked = true;
                    }
                    else
                    {
                        ag_code_bx.Text = BillQDGV.Rows[BillQDGV.SelectedCells[0].RowIndex].Cells[4].Value.ToString();
                       // AgentCB.SelectedValue = 0;
                        NormSellRB.Checked = true;
                    }
                    BillDateTB.Text = BillQDGV.Rows[BillQDGV.SelectedCells[0].RowIndex].Cells[3].Value.ToString();
                    BillTotalTB.Text = BillQDGV.Rows[BillQDGV.SelectedCells[0].RowIndex].Cells[5].Value.ToString();
                    BillIdTB.Text = BillQDGV.Rows[BillQDGV.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
                    string s_or_c = "";
                    s_or_c = settel_or_credit(BillQDGV.Rows[BillQDGV.SelectedCells[0].RowIndex].Cells[0].Value.ToString().Trim()).Trim();
                    if (s_or_c == "c")
                        CreditCB.Checked = true;
                    else
                        CashCB.Checked = true;

                    con.Open();
                    string BillDet = "select BillDetails.ItemId,Items.ItemName,BillDetails.ItemPrice,BillDetails.ItemQuantity from BillDetails inner join Items on( Items.ItemId=BillDetails.ItemId and BillDetails.BillId='" + BillQDGV.Rows[BillQDGV.SelectedCells[0].RowIndex].Cells[0].Value.ToString() + "')";
                    SqlCommand comm = new SqlCommand(BillDet, con);
                    SqlDataReader reader = comm.ExecuteReader();
                    //reader.Read();
                    while (reader.Read())
                    {
                        index = ItemFound(Int32.Parse(reader["ItemId"].ToString()));
                        if (index < 0)
                        {
                            BillDetailGV.Rows.Add();
                            BillDetailGV.Rows[BillDetailGV.RowCount - 1].Cells[0].Value = BillDetailGV.RowCount.ToString();
                            BillDetailGV.Rows[BillDetailGV.RowCount - 1].Cells[1].Value = reader["ItemId"].ToString();
                            BillDetailGV.Rows[BillDetailGV.RowCount - 1].Cells[2].Value = reader["ItemName"].ToString();
                            BillDetailGV.Rows[BillDetailGV.RowCount - 1].Cells[3].Value = reader["ItemPrice"].ToString();
                            BillDetailGV.Rows[BillDetailGV.RowCount - 1].Cells[4].Value = reader["ItemQuantity"].ToString();
                            BillDetailGV.Rows[BillDetailGV.RowCount - 1].Cells[5].Value = (double.Parse(reader["ItemPrice"].ToString()) * double.Parse(reader["ItemQuantity"].ToString()));
                            // BillTotalTB.Text.Trim() = (double.Parse(BillTotalTB.Text.Trim()) + double.Parse(TotalTB.Text.Trim())).ToString();
                        }
                        else
                        {
                            BillDetailGV.Rows[index].Cells[4].Value = double.Parse(BillDetailGV.Rows[index].Cells[4].Value.ToString()) + double.Parse(reader["ItemQuantity"].ToString());
                            BillDetailGV.Rows[index].Cells[5].Value = double.Parse(BillDetailGV.Rows[index].Cells[4].Value.ToString()) * double.Parse(BillDetailGV.Rows[index].Cells[3].Value.ToString());
                            if (Int32.Parse(BillDetailGV.Rows[index].Cells[4].Value.ToString()) == 0)
                                BillDetailGV.Rows.RemoveAt(index);
                        }
                    }
                    reader.Close();
                    con.Close();
                    BillTo();
                }
                catch { con.Close(); }
                UpdateBillBtn.Enabled = false;
                AddItemBtn.Enabled = false;
                ClearItemBtn.Enabled = false;
                SaveBillBtn.Enabled = false;
                NormSellRB.Enabled = false;
                ToAgentRB.Enabled = false;
                BillRefundBtn.Enabled = true;

                AgentCB.Enabled = false;
                label18.Visible = true;
                ag_ref_name_bx.Visible = true;
                ag_code_bx.Visible = true;
            }
            refBtn = 1;
            ref_num_exp.Visible = true;
            ref_num_exp.Expanded = false;
        }
        internal string bill_total;
        internal string ag_code;
        private void BillRefundBtn_Click(object sender, EventArgs e)
        {
            DateTime Bdate = DateTime.Now;
            double BTotal = 0;
            string Updstr = "Update  Bill set BillType='REF' where BillId='" + BillIdTB.Text.Trim() + "'";
            string RefData = " Select BillDetails.ItemId,BillDetails.ItemPrice,BillDetails.ItemQuantity,BillDetails.BillDate,Bill.BillTotal  from Bill join BillDetails on  Bill.BillId=BillDetails.BillId and Bill.BillType='REF' and BillDetails.BillId='" + BillIdTB.Text.Trim() + "' and ItemQuantity>0";
            SqlCommand comm;
            SqlCommand getBill = new SqlCommand(RefData, con);
            SqlCommand getOldQu;
            SqlDataReader StoreQuan1;
            SqlDataReader reader;
            SqlConnection con1 = new SqlConnection(conStr);
            string PSelect;
            int profitid = 0;
            salesMoney = 0;
            try
            {
                DialogResult result;
                result = MessageBox.Show("هل انت متأكد من ارتجاع الفاتوره؟ ", "Data Not saved", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    if(con.State==ConnectionState.Closed)
                    con.Open();
                    // con1.Open();
                    SqlCommand sql = new SqlCommand(Updstr, con);
                    sql.ExecuteNonQuery();
                    reader = getBill.ExecuteReader();
                    ItemsId1.Clear();
                    ItemsQua1.Clear();
                    REFBill.Clear();
                    reader.Read();
                    ItemsId1.Add(reader["ItemId"].ToString());

                   

                   // ItemsQua1.Add(reader["ItemQuantity"].ToString());//هنا تسحب الكمية للصنف لاول سجل لو فيه 2 سجل بنفس الصنف يعنى واحد بيع والتانى ارتجاع بالسالب بياخد البيع فقط بكده انا هاسحب الكمية من الجريد
                    ItemsQua1.Add(reader["ItemQuantity"].ToString());
                    REFBill.Add(reader["ItemPrice"].ToString());
                    Bdate = DateTime.Parse(reader["BillDate"].ToString());
                    BTotal = double.Parse(reader["BillTotal"].ToString());
                    while (reader.Read())
                    {
                        ItemsId1.Add(reader["ItemId"].ToString());
                        ItemsQua1.Add(reader["ItemQuantity"].ToString());
                       // MessageBox.Show(reader["ItemQuantity"].ToString());//////////////////////////////////testttttttttttt
                        REFBill.Add(reader["ItemPrice"].ToString());
                    }
                    reader.Close();
                    if (BillDetailGV.Rows.Count > 0)
                    {
                        for (int i = 0; i < BillDetailGV.Rows.Count; i++)//ItemsId1.Count
                        {
                            getOldQu = new SqlCommand("select ItemQuantity from Store where ItemId='" + BillDetailGV.Rows[i].Cells[1].Value.ToString() + "'", con);
                            StoreQuan1 = getOldQu.ExecuteReader();
                            StoreQuan1.Read();
                            if (double.Parse(StoreQuan1[0].ToString()) > 0)
                                sql = new SqlCommand("Update Store set ItemQuantity='" + (Int32.Parse(StoreQuan1["ItemQuantity"].ToString()) + Int32.Parse(BillDetailGV.Rows[i].Cells[4].Value.ToString())).ToString() + "' where ItemId='" + BillDetailGV.Rows[i].Cells[1].Value.ToString() + "'", con);
                            else
                                sql = new SqlCommand("Update Store set ItemQuantity='" +BillDetailGV.Rows[i].Cells[4].Value.ToString() + "' where ItemId='" + BillDetailGV.Rows[i].Cells[1].Value.ToString() + "'", con);

                            StoreQuan1.Close();
                            sql.ExecuteNonQuery();
                        }
                    }

                    reader.Close();
                    if (GetDate(Bdate.ToShortDateString()) != GetDate(DateTime.Now.ToShortTimeString()))
                    {
                       // EC.EarnCalcOper(Bdate.ToShortDateString());
                      

                    }
                    //شاشة الارتجاع لعميل

                    if (BillIdTB.Text.Trim() != "" && ToAgentRB.Checked && settel_or_credit(BillIdTB.Text.Trim())=="c")

                        {
                            if (MessageBox.Show("هل تريد خصم الفاتورة المرتجعه من حساب عميل؟ ", "Data Not saved", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                            {
                                if (Int32.Parse(BillIdTB.Text.Trim()) > 0)
                                {
                                    ag_code = ag_code_bx.Text.Trim();
                                    bill_total = BillTotalTB.Text;
                                    Discount_agent dis_ag_frm = new Discount_agent(ag_code, bill_total);
                                    dis_ag_frm.ShowDialog();
                                }
                            }
                    }
                    MessageBox.Show("تم الارتجاع بنجاح");
                    con.Close();
                    QueryBtn.PerformClick();//لحذف الفاتورة المرتجعه من الاستعلام
                    BillRemoveBtn_Click(sender, e);
                    BillQDGV.Rows.Clear();
                }
            }

            catch (Exception ex)
            {

                con.Close();
                if (ex.Message.Contains("no data is present"))
                    MessageBox.Show("لا يوجد بيانات ليتم ارتجاعها");
                // con1.Close();

            }


        }

        private void ItemRefundBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string Instr1 = "insert into BillDetails(BillId,ItemId,ItemPrice,ItemQuantity,BillDate) values('" + BillIdTB.Text.Trim() + "','" + ItemIdQTB.Text.Trim() + "','" + SellPriceTB.Text.Trim() + "','" + (double.Parse(QuanTB.Text.Trim()) * -1).ToString() + "','" + GetDate(DateTime.Now.ToShortDateString()) + "')";
                string Updstr = "Update Bill set BillTotal='" + (double.Parse(BillTotalTB.Text.Trim()) - double.Parse(TotalTB.Text.Trim())).ToString() + "' where BillId='" + BillIdTB.Text.Trim() + "'";
                DialogResult result;
                if (ItemIdQTB.Text.Trim() == BillDetailGV.CurrentRow.Cells[1].Value.ToString().Trim())
                {
                    if ((ItemIdQTB.Text != "" && ItemIdQTB.Text != "0") && (QuanTB.Text != "" && QuanTB.Text != "0"))
                    {
                        result = MessageBox.Show("هل انت متأكد من ارتجاع هذه الكميه؟ ", "Data Not saved", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                        if (result == System.Windows.Forms.DialogResult.Yes)
                        {
                            SqlCommand UpdStore = new SqlCommand("Update Store set ItemQuantity='" + (double.Parse(QuanTB.Text.Trim()) + double.Parse(RemainTB.Text.Trim())).ToString() + "' where ItemId='" + ItemIdQTB.Text + "'", con);
                            con.Open();
                            SqlCommand sql = new SqlCommand(Instr1, con);
                            sql.ExecuteNonQuery();
                            sql = new SqlCommand(Updstr, con);
                            sql.ExecuteNonQuery();
                            UpdStore.ExecuteNonQuery();
                            con.Close();
                            RefundItem(Int32.Parse(BillIdTB.Text.Trim()));
                            MessageBox.Show("تم الأدخال بنجاح");
                            BillDetailGV.Rows[selectGV].Cells[4].Value = quan - double.Parse(QuanTB.Text.Trim());
                            BillDetailGV.Rows[selectGV].Cells[5].Value = double.Parse(BillDetailGV.Rows[selectGV].Cells[4].Value.ToString()) * double.Parse(BillDetailGV.Rows[selectGV].Cells[3].Value.ToString());
                            BillTo();
                            ItemIdQTB.Text = "";
                            QuanTB.Text = "1";
                            con.Close();
                            QueryBtn.PerformClick();//لحذف الفاتورة المرتجعه من الاستعلام
                            //EC.EarnCalcOper();
                            //    BillRemoveBtn.PerformClick();
                        }
                    }
                    else
                    {
                        if (ItemIdQTB.Text == "" || ItemIdQTB.Text == "0")
                            MessageBox.Show("حدد الصنف المراد ارتجاعه اولا");
                        else if (QuanTB.Text == "" || QuanTB.Text == "0")
                            MessageBox.Show("حدد الكميه المراد ارتجاعها اولا");
                    }
                }
                else
                    MessageBox.Show("يجب اختيار الصنف المراد ارتجاع كمية منه");

            }
            catch { con.Close(); MessageBox.Show("خطأ بالبيانات"); }
        }

        private void BillRemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                AgentCB_SelectedIndexChanged(sender, e);
                DialogResult result;
                if (BillDetailGV.Rows.Count > 0 &&refBtn==0)
                {
                    if (MessageBox.Show("يوجد اصناف بالفاتورة هل تريد مسحها بالفعل ؟؟ ", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        BillDetailGV.Rows.Clear();
                        if (BillQDGV.Rows.Count > 0)
                            BillQDGV.Rows.Clear();
                        BillIdDTB.Text = "";
                        ItemIdQTB.Text = "";
                        BillNoteTB.Text = "";
                        BillTotalTB.Text = "0";
                        TotalTB.Text = "0";
                        QuanTB.Text = "1";
                        PaidMoneyTB.Text = "";
                        RemainTB.Text = "0";
                        BillIdTB.Text = "0";
                        SellPriceTB.Text = "";
                        BillDateTB.Text = DateTime.Now.ToShortDateString();
                        FromDateTB.Text = DateTime.Now.ToShortDateString();
                        ToDateTB.Text = DateTime.Now.ToShortDateString();
                        NormSellRB.Checked = true;
                        AddItemBtn.Enabled = true;
                        UpdateBillBtn.Enabled = true;
                        ClearItemBtn.Enabled = true;
                        SaveBillBtn.Enabled = true;
                        NormSellRB.Enabled = true;
                        ToAgentRB.Enabled = true;
                        check_done = 0;
                        BillRefundBtn.Enabled = false;
                        refBtn = 0;
                        ref_num_exp.Visible = false;
                        ref_num_bx.Text = "";
                        //ref_ag_exp.Visible = false;
                        AgentCB.Enabled = true;
                        label18.Visible = false;
                        ag_ref_name_bx.Visible = false;
                        ag_code_bx.Visible = false;
                        fat_owner_bx.Text = "";
                        discount_bx.Clear();
                    }
                }
                else
                {
                    if (BillDetailGV.Rows.Count > -1)//BillQDGV
                        BillDetailGV.Rows.Clear();
                    check_done = 0;
                    BillIdDTB.Text = "";
                    ItemIdQTB.Text = "";
                    BillNoteTB.Text = "";
                    BillTotalTB.Text = "0";
                    TotalTB.Text = "0";
                    QuanTB.Text = "1";
                    PaidMoneyTB.Text = "";
                    RemainTB.Text = "0";
                    BillIdTB.Text = "0";
                    SellPriceTB.Text = "";
                    BillDateTB.Text = DateTime.Now.ToShortDateString();
                    FromDateTB.Text = DateTime.Now.ToShortDateString();
                    ToDateTB.Text = DateTime.Now.ToShortDateString();
                    NormSellRB.Checked = true;
                    AddItemBtn.Enabled = true;
                    UpdateBillBtn.Enabled = true;
                    ClearItemBtn.Enabled = true;
                    SaveBillBtn.Enabled = true;
                    NormSellRB.Enabled = true;
                    ToAgentRB.Enabled = true;
                    BillRefundBtn.Enabled = false;
                    refBtn = 0;
                    ref_num_exp.Visible = false;
                    ref_num_bx.Text = "";
                    AgentCB.Enabled = true;

                    label18.Visible = false;
                    ag_ref_name_bx.Visible = false;
                    ag_code_bx.Visible = false;
                    fat_owner_bx.Text = "";
                    discount_bx.Clear();
                }
            }
            catch(Exception ss)
            {
                
                BillIdDTB.Text = "";
                ItemIdQTB.Text = "";
                BillNoteTB.Text = "";
                BillTotalTB.Text = "0";
                TotalTB.Text = "";
                QuanTB.Text = "1";
                PaidMoneyTB.Text = "";
                RemainTB.Text = "0";
                BillIdTB.Text = "0";
                SellPriceTB.Text = "";
                BillDateTB.Text = DateTime.Now.ToShortDateString();
                FromDateTB.Text = DateTime.Now.ToShortDateString();
                ToDateTB.Text = DateTime.Now.ToShortDateString();
                NormSellRB.Checked = true;
                AddItemBtn.Enabled = true;
                UpdateBillBtn.Enabled = true;
                ClearItemBtn.Enabled = true;
                SaveBillBtn.Enabled = true;
                NormSellRB.Enabled = true;
                ToAgentRB.Enabled = true;
                refBtn = 0;
                ref_num_exp.Visible = false;
                ref_num_bx.Text = "";
                check_done = 0;
                fat_owner_bx.Text = "";
            }
        }
        private void _delete_btn_jop()
        {
            try
            {
               
                if (BillDetailGV.Rows.Count > 0 && refBtn == 0)
                {
                   
                        BillDetailGV.Rows.Clear();
                        if (BillQDGV.Rows.Count > 0)
                            BillQDGV.Rows.Clear();
                        BillIdDTB.Text = "";
                        ItemIdQTB.Text = "";
                        BillNoteTB.Text = "";
                        BillTotalTB.Text = "0";
                        TotalTB.Text = "0";
                        QuanTB.Text = "1";
                        PaidMoneyTB.Text = "";
                        RemainTB.Text = "0";
                        BillIdTB.Text = "0";
                        SellPriceTB.Text = "";
                        BillDateTB.Text = DateTime.Now.ToShortDateString();
                        FromDateTB.Text = DateTime.Now.ToShortDateString();
                        ToDateTB.Text = DateTime.Now.ToShortDateString();
                        NormSellRB.Checked = true;
                        AddItemBtn.Enabled = true;
                        UpdateBillBtn.Enabled = true;
                        ClearItemBtn.Enabled = true;
                        SaveBillBtn.Enabled = true;
                        NormSellRB.Enabled = true;
                        ToAgentRB.Enabled = true;
                        check_done = 0;
                        BillRefundBtn.Enabled = false;
                        refBtn = 0;
                        ref_num_exp.Visible = false;
                        ref_num_bx.Text = "";
                        //ref_ag_exp.Visible = false;
                        AgentCB.Enabled = true;
                        label18.Visible = false;
                        ag_ref_name_bx.Visible = false;
                        ag_code_bx.Visible = false;
                        fat_owner_bx.Text = "";
                        discount_bx.Clear();
                    
                }
                else
                {
                    if (BillDetailGV.Rows.Count > -1)//BillQDGV
                        BillDetailGV.Rows.Clear();
                    check_done = 0;
                    BillIdDTB.Text = "";
                    ItemIdQTB.Text = "";
                    BillNoteTB.Text = "";
                    BillTotalTB.Text = "0";
                    TotalTB.Text = "0";
                    QuanTB.Text = "1";
                    PaidMoneyTB.Text = "";
                    RemainTB.Text = "0";
                    BillIdTB.Text = "0";
                    SellPriceTB.Text = "";
                    BillDateTB.Text = DateTime.Now.ToShortDateString();
                    FromDateTB.Text = DateTime.Now.ToShortDateString();
                    ToDateTB.Text = DateTime.Now.ToShortDateString();
                    NormSellRB.Checked = true;
                    AddItemBtn.Enabled = true;
                    UpdateBillBtn.Enabled = true;
                    ClearItemBtn.Enabled = true;
                    SaveBillBtn.Enabled = true;
                    NormSellRB.Enabled = true;
                    ToAgentRB.Enabled = true;
                    BillRefundBtn.Enabled = false;
                    refBtn = 0;
                    ref_num_exp.Visible = false;
                    ref_num_bx.Text = "";
                    AgentCB.Enabled = true;

                    label18.Visible = false;
                    ag_ref_name_bx.Visible = false;
                    ag_code_bx.Visible = false;
                    fat_owner_bx.Text = "";
                    discount_bx.Clear();
                }
            }
            catch (Exception ss)
            {

                BillIdDTB.Text = "";
                ItemIdQTB.Text = "";
                BillNoteTB.Text = "";
                BillTotalTB.Text = "0";
                TotalTB.Text = "";
                QuanTB.Text = "1";
                PaidMoneyTB.Text = "";
                RemainTB.Text = "0";
                BillIdTB.Text = "0";
                SellPriceTB.Text = "";
                BillDateTB.Text = DateTime.Now.ToShortDateString();
                FromDateTB.Text = DateTime.Now.ToShortDateString();
                ToDateTB.Text = DateTime.Now.ToShortDateString();
                NormSellRB.Checked = true;
                AddItemBtn.Enabled = true;
                UpdateBillBtn.Enabled = true;
                ClearItemBtn.Enabled = true;
                SaveBillBtn.Enabled = true;
                NormSellRB.Enabled = true;
                ToAgentRB.Enabled = true;
                refBtn = 0;
                ref_num_exp.Visible = false;
                ref_num_bx.Text = "";
                check_done = 0;
                fat_owner_bx.Text = "";
            }
        }
        private void AgentQCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // AgentCHB_CheckedChanged(sender,e);
                if (DateRB.Checked == true && AgentCHB.Checked == true)
                {
                    this.billTableAdapter.FillByDA(this.billDS.Bill, Type, FromDateTB.Text.Trim(), ToDateTB.Text.Trim(), Int32.Parse(AgentCB.SelectedValue.ToString()));
                }
                else if (FinalBillRB.Checked == true && AgentCHB.Checked == true)
                    this.billTableAdapter.FillByMaxA(this.billDS.Bill, Type, Int32.Parse(AgentCB.SelectedValue.ToString()));

                else if (BillCounterRB.Checked == true && AgentCHB.Checked == true)
                {

                    this.billTableAdapter.FillByNA(this.billDS.Bill, Int32.Parse(BillNoTB.Text.Trim()), Int32.Parse(AgentCB.SelectedValue.ToString()), Type);
                    // AgentCHB_CheckedChanged(sender, e);
                }
            }
            catch { }
        }

        private void AgentCHB_CheckedChanged(object sender, EventArgs e)
        {
            // OperType_SelectedIndexChanged(sender, e);

        }

        private void ItemIdQTB_TextChanged(object sender, EventArgs e)
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
            SqlDataReader Itemread2;
            int catid = 0, itemid = 0;
            double sellPrice = 0;
            string ItemId;
            string Quan;
            SqlCommand comm3;

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                if (count == 0 && ItemIdQTB.Text.Trim() != "")
                {
                    ItemId = "Select Items.ItemId,CatId,ItemSellPriceGo,ItemSellPriceKa,ItemPurchPrice,partener_id from Items join ItemDetails on  Items.ItemId=ItemDetails.ItemId and (Items.ItemId= " +
                        ItemIdQTB.Text.Trim() + " or ItemBarcode= " + ItemIdQTB.Text.Trim() + ")";
                    comm3 = new SqlCommand(ItemId, con);

                   
                    Itemread2 = comm3.ExecuteReader();
                    Itemread2.Read();

                    if (Itemread2.HasRows)
                    {
                        
                      
                        catid = Int32.Parse(Itemread2["CatId"].ToString());
                        itemid = Int32.Parse(Itemread2["ItemId"].ToString());
                        PurchPrice = double.Parse(Itemread2["ItemPurchPrice"].ToString());
                        partener_cmbx.SelectedValue = Int32.Parse((Itemread2["partener_id"].ToString()));
                        if (ToAgentRB.Checked == true)
                            sellPrice = double.Parse(Itemread2["ItemSellPriceKa"].ToString());
                        else
                            sellPrice = double.Parse(Itemread2["ItemSellPriceGo"].ToString());
                        count++;
                        Itemread2.Close();
                        ItemIdQTB.Text = itemid.ToString();
                        CatCB.SelectedValue = catid;
                        ItemCB.SelectedValue = itemid;
                       
                        SellPriceTB.Text = sellPrice.ToString();
                        QuanTB_TextChanged(sender, e);
                        //QuanTB.Focus();
                      
                       
                    }
                }
                else
                {
                    CatCB.SelectedValue = catid;
                    ItemCB.SelectedValue = itemid;
                    SellPriceTB.Text = sellPrice.ToString();
                    //QuanTB.Focus();
                    QuanTB_TextChanged(sender, e);
                }
                count = 0;
                try
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    if (ItemIdQTB.Text.Trim() != "")
                    {
                        Quan = "Select ItemQuantity From Store  where ItemId= " + ItemIdQTB.Text.Trim();
                        comm3 = new SqlCommand(Quan, con);
                        Itemread2 = comm3.ExecuteReader();
                        if(Itemread2.HasRows)
                        Itemread2.Read();
                        RemainTB.Text = Itemread2["ItemQuantity"].ToString();

                        Itemread2.Close();
                        
                    }
                    
                    con.Close();
                }
                catch {  RemainTB.Text = "0"; }
                //  con.Close();
                double price = 0;
                if (ItemIdQTB.Text.Trim() != "" && QuanTB.Text.Trim() != "" && RemainTB.Text.Trim() != "")
                    if (double.Parse(QuanTB.Text.Trim()) <= double.Parse(RemainTB.Text.Trim()))
                    {
                        price = double.Parse(QuanTB.Text.Trim()) * double.Parse(SellPriceTB.Text.Trim());
                        TotalTB.Text = price.ToString();
                        //AddItemBtn.PerformClick();
                    }
            }
            catch (Exception ff)
            {
                MessageBox.Show(ff.Message);
                con.Close();
                //  ItemIdQTB.Text = "";
                //CatCB.SelectedIndex = 0;
                SellPriceTB.Text = "0";
                QuanTB.Text = "1";
                RemainTB.Text = "0";
            }
        }
        public string GetDate(string Indate)
        {
            string day, month, year;
            string outDate = "";
            try
            {
                day = (DateTime.Parse(Indate).Day).ToString();
                month = (DateTime.Parse(Indate).Month).ToString();
                year = (DateTime.Parse(Indate).Year).ToString();
                outDate = month + "/" + day + "/" + year;
                return outDate;
            }
            catch { return outDate; }

        }
        private void groupPanel2_Click(object sender, EventArgs e)
        {

        }
        private double QuantityDG(int item)
        {
            try
            {
                double iQ = 0;
                if (BillDetailGV.Rows.Count > 0)
                    for (int i = 0; i < BillDetailGV.Rows.Count; i++)
                    {
                        if (Int32.Parse(BillDetailGV.Rows[i].Cells[1].Value.ToString()) == item)
                        {
                            iQ = iQ + double.Parse(BillDetailGV.Rows[i].Cells[4].Value.ToString());
                        }


                    }
                return iQ;
            }
            catch { return 0; }
        }

        private void BillIdDTB_TextChanged(object sender, EventArgs e)
        {
            Int64 data;
            try
            {
                data = Int64.Parse(BillIdDTB.Text);
            }
            catch
            {
                if (BillIdDTB.Text != "")
                {
                    MessageBox.Show("الرجاء ادخال ارقام فقط");
                    BillIdDTB.Text = "";
                }

            }
        }

        private void sales_fat_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (refBtn == 0 && BillDetailGV.Rows.Count > 0)
            {

                DialogResult result;
                result = MessageBox.Show("هل تريد حفظ الفاتوره الحاليه؟", "Data Not saved", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    SaveBillBtn.PerformClick();
                }

            }
        }

        private void PrintPrevBtn_Click(object sender, EventArgs e)
        {

            PrintPrevsales pps = new PrintPrevsales();
            pps.Show();
            pps.Dock = DockStyle.Fill;

            // pps.MdiParent = this;
            //pps.BringToFront();

            //.SendToBack();
        }

        private void PrintCurrBtn_Click(object sender, EventArgs e)
        {
            Print P;
            if (BillIdTB.Text != "0")
                P = new Print(Int32.Parse(BillIdTB.Text.Trim()));
            else
                P = new Print(0);
            P.Show();
            P.Dock = DockStyle.Fill;
        }
        public void RefundItem(int Bill)
        {
            double salesMony = 0;
            int BillDetailId = 0;
            //DateTime BillDateAL=;
            SqlCommand comm;
            SqlDataReader reader;
            double BTotal = 0;
            string Upd;
            DateTime billorg = DateTime.Now;
            string PSelect = "Select Bill.BillDate As BillOrg,BillDetails.BillDate AS BillRE, BillDetails.BillDetailId  from BillDetails inner join Bill on (Bill.BillId='" + Bill + "') and BillDetails.ItemQuantity<0";
            try
            {
                con.Open();
                comm = new SqlCommand(PSelect, con);
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    if (DateTime.Parse(reader["BillOrg"].ToString()) != DateTime.Parse(reader["BillRE"].ToString()))
                    {
                        BillDetailId = Int32.Parse(reader["BillDetailId"].ToString());
                        billorg = DateTime.Parse(reader["BillOrg"].ToString());
                    }
                }
                reader.Close();
                PSelect = "select distinct BillDetails.ItemID,BillDetails.ItemPrice,BillDetails.ItemQuantity,Items.ItemPurchPrice from Items inner join BillDetails on(BillDetails.BillDetailId='" + BillDetailId.ToString() + "'and BillDetails.ItemID=Items.ItemId)";
                comm = new SqlCommand(PSelect, con);
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    //
                    salesMony = salesMony + double.Parse(reader["ItemQuantity"].ToString()) * (double.Parse(reader["ItemPrice"].ToString()) - double.Parse(reader["ItemPurchPrice"].ToString()));
                }
                reader.Close();
                PSelect = "select  SalesMoney from Profit where ProfitDate='" + GetDate(billorg.ToShortDateString()) + "'";
                comm = new SqlCommand(PSelect, con);
                reader = comm.ExecuteReader();
                reader.Read();
                salesMony = salesMony + double.Parse(reader["SalesMoney"].ToString());
                Upd = "Update Profit set SalesMoney='" + salesMony.ToString() + "' where ProfitDate='" + GetDate(billorg.ToShortDateString()) + "'";
                reader.Close();
                comm = new SqlCommand(Upd, con);
                comm.ExecuteNonQuery();
                con.Close();
            }
            catch { con.Close(); }

        }
        public void BillTo()
        {
            try
            {
                double Bto = 0;
                if (BillDetailGV.Rows.Count > 0)
                    for (int i = 0; i < BillDetailGV.Rows.Count; i++)
                    {

                        Bto = Bto + double.Parse(BillDetailGV.Rows[i].Cells[5].Value.ToString());
                    }
                BillTotalTB.Text = Bto.ToString();
            }
            catch { }
        }

        private void BillDetailGV_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private methodes meth = new methodes();
       

        private void expandablePanel1_Click(object sender, EventArgs e)
        {

        }

        private void AgentQCB_SelectedValueChanged(object sender, EventArgs e)
        {
            /*try
            {
                AgentCHB_CheckedChanged(sender, e);
                if (DateRB.Checked == true && AgentCHB.Checked == true)
                {
                    this.billTableAdapter.FillByDA(this.billDS.Bill, Type, FromDateTB.Text.Trim(), ToDateTB.Text.Trim(), Int32.Parse(AgentQCB.SelectedValue.ToString()));
                    DateRB_CheckedChanged(sender, e);
                }
                else if (FinalBillRB.Checked == true && AgentCHB.Checked == true)
                {
                    this.billTableAdapter.FillByMaxA(this.billDS.Bill, Type, Int32.Parse(AgentQCB.SelectedValue.ToString()));
                    FinalBillRB_CheckedChanged(sender, e);
                }

                else if (BillCounterRB.Checked == true && AgentCHB.Checked == true)
                {

                    this.billTableAdapter.FillByNA(this.billDS.Bill, Int32.Parse(BillNoTB.Text.Trim()), Int32.Parse(AgentQCB.SelectedValue.ToString()), Type);
                    // AgentCHB_CheckedChanged(sender, e);
                    BillCounterRB_CheckedChanged(sender, e);
                }
            }
            catch { }*/
        }
        private void del_fat_zero()//حذف اى فاتورة اجماليها بصفر
        {
            if (BillQDGV.Rows.Count > 0)
            {
                for (int i = 0; i < BillQDGV.Rows.Count; i++)
                {
                    if (BillQDGV.Rows[i].Cells[5].Value.ToString().Trim() == "0")
                        BillQDGV.Rows.RemoveAt(i);
                }
            }
        }
        private void QueryBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (BillIdDTB.Text != "" && bill_id_btn.Checked)
                {
                    this.billTableAdapter.FillBy2(this.billDS.Bill, Int32.Parse(BillIdDTB.Text.Trim()));
                }
                else if (DateRB.Checked == true && AgentCHB.Checked == true)
                {
                    this.billTableAdapter.FillByDA(this.billDS.Bill, Type, FromDateTB.Text.Trim(), ToDateTB.Text.Trim(), Int32.Parse(AgentQCB.SelectedValue.ToString()));
                }
                else if (FinalBillRB.Checked == true && AgentCHB.Checked == true)
                    this.billTableAdapter.FillByMaxA(this.billDS.Bill, Type, Int32.Parse(AgentQCB.SelectedValue.ToString()));
                else if (DateRB.Checked == true && AgentCHB.Checked == false)
                {
                    //  OperType_SelectedIndexChanged(sender,e);
                    //  billBindingSource.Filter = "BillDate >= '" + FromDateTB.Text.Trim() + "' and BillDate <='" + ToDateTB.Text.Trim() + "'";
                    // AgentCHB_CheckedChanged(sender, e);
                    this.billTableAdapter.Fill(this.billDS.Bill, Type, FromDateTB.Text.Trim(), ToDateTB.Text.Trim());

                }
                else if (FinalBillRB.Checked == true && AgentCHB.Checked == false)
                {


                    this.billTableAdapter.FillBy(this.billDS.Bill, Type);

                    //  AgentCHB_CheckedChanged(sender, e);
                }
                else if (BillCounterRB.Checked == true && AgentCHB.Checked == false)
                {

                    this.billTableAdapter.FillBy1(this.billDS.Bill, Int32.Parse(BillNoTB.Text.Trim()), Type);
                    // AgentCHB_CheckedChanged(sender, e);
                }
                else if (BillCounterRB.Checked == true && AgentCHB.Checked == true)
                {

                    this.billTableAdapter.FillByNA(this.billDS.Bill, Int32.Parse(BillNoTB.Text.Trim()), Int32.Parse(AgentQCB.SelectedValue.ToString()), Type);
                    // AgentCHB_CheckedChanged(sender, e);
                }
                BillIdDTB.Text = "";
                del_fat_zero();
            }
            catch { }
        }

        private void ItemIdQTB_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void QuanTB_Click(object sender, EventArgs e)
        {
            QuanTB.Clear();
        }

        private void prnt_btn_Click(object sender, EventArgs e)
        {
           // try
            //{
            int billId = 0;

            if (BillIdTB.Text.Trim() != "")
                billId = int.Parse(BillIdTB.Text.Trim());
            else
                billId = 0;
            Print p = new Print(billId); 
                

                SalesBillCRD SalesRep = new SalesBillCRD();
                SalesSmallBillCRD sales_small_fat = new SalesSmallBillCRD();//فاتورة صغيرة
                ParameterFields SalesParam = new ParameterFields();
                ParameterField BillType = new ParameterField();
                ParameterDiscreteValue BillValue = new ParameterDiscreteValue();
                ParameterField FromDate = new ParameterField();
                ParameterDiscreteValue FromDatevalue = new ParameterDiscreteValue();
                ParameterField ToDate = new ParameterField();
                ParameterDiscreteValue ToDatevalue = new ParameterDiscreteValue();
                ParameterField BillNo = new ParameterField();
                ParameterDiscreteValue BillNovalue = new ParameterDiscreteValue();
                ParameterField RbF = new ParameterField();
                ParameterDiscreteValue RbFvalue = new ParameterDiscreteValue();
                ParameterField BillIdP = new ParameterField();
                ParameterDiscreteValue BillIdPFvalue = new ParameterDiscreteValue();
                ParameterField AgentId = new ParameterField();
                ParameterDiscreteValue AgentIdvalue = new ParameterDiscreteValue();
                BillType.Name = "BillType";
                BillValue.Value = "'SEL'";
                AgentId.Name = "AgentId";
                AgentIdvalue.Value = 0;
                SalesParam.Add(AgentId);
                AgentId.CurrentValues.Add(AgentIdvalue);
                BillType.CurrentValues.Add(BillValue);
                SalesParam.Add(BillType);
                FromDate.Name = "fromDate";
                FromDatevalue.Value = DateTime.Now;
                ToDate.Name = "ToDate";
                ToDatevalue.Value = DateTime.Now;
                RbF.Name = "RbF";
                if (billId != 0)
                    RbFvalue.Value = 3;
                else
                    RbFvalue.Value = 2;
                BillIdP.Name = "BillId";
                BillIdPFvalue.Value = billId;
                SalesParam.Add(BillIdP);
                BillIdP.CurrentValues.Add(BillIdPFvalue);
                FromDate.CurrentValues.Add(FromDatevalue);
                SalesParam.Add(FromDate);
                ToDate.CurrentValues.Add(ToDatevalue);
                SalesParam.Add(ToDate);
                RbF.CurrentValues.Add(RbFvalue);
                SalesParam.Add(RbF);
                SalesParam.Add(BillIdP);
                BillIdP.CurrentValues.Add(BillIdPFvalue);
                BillNo.Name = "BillNo";
                BillNovalue.Value = 3;
                BillNo.CurrentValues.Add(BillNovalue);
                SalesParam.Add(BillNo);
                SalesRep.Refresh();

                p.SalesCRV.ParameterFieldInfo = SalesParam;

                if (A4Btn.Checked)
                {
                    p.SalesCRV.ReportSource = SalesRep;
                    p.SalesCRV.RefreshReport();
                   // SalesRep.PrintToPrinter(1, false, 1, 1);
                    p.SalesCRV.PrintReport();
                }
                else if (smallBtn.Checked)
                {
                    p.SalesCRV.ReportSource = sales_small_fat;
                    p.SalesCRV.RefreshReport();
                    sales_small_fat.PrintOptions.PrinterName = d_p;
                    try
                    {
                        sales_small_fat.PrintToPrinter(1, false, 1, 1);
                    }
                    catch { }
                }
               // SalesRep.PrintOptions.PrinterName = d_p;
               // SalesRep.PrintToPrinter(1, false, 1, 1);
               // p.SalesCRV.PrintReport();
          /*  }
            catch (Exception mm)
            {
                MessageBox.Show(mm.Message);
            }*/
        }

        private void ref_num_bx_TextChanged(object sender, EventArgs e)
        {

            Int64 data;
            try
            {
                data = Int64.Parse(ref_num_bx.Text);
            }
            catch
            {
                if (ref_num_bx.Text != "")
                {
                    MessageBox.Show("الرجاء ادخال ارقام فقط");
                    QuanTB.Text = "1";
                }

            }
            double price;
            try
            {
                if (refBtn == 0)
                {
                    if (double.Parse(ref_num_bx.Text.Trim()) <= double.Parse(RemainTB.Text.Trim()))
                    {
                        price = double.Parse(ref_num_bx.Text.Trim()) * double.Parse(SellPriceTB.Text.Trim());
                        TotalTB.Text = price.ToString();
                    }
                    else
                        ref_num_bx.Text = RemainTB.Text.Trim();
                }
                else
                {
                    if (double.Parse(ref_num_bx.Text) < quan)
                    {
                        price = double.Parse(ref_num_bx.Text) * double.Parse(SellPriceTB.Text.Trim());
                        TotalTB.Text = price.ToString();
                    }
                    else
                        ref_num_bx.Text = quan.ToString();
                }

            }
            catch
            { }
        }

        private void ref_save_btn_Click(object sender, EventArgs e)
        {
            double BT=0;
            try
            {
                BT=double.Parse(BillTotalTB.Text.Trim()) - double.Parse(TotalTB.Text.Trim());
                string Instr1 = "insert into BillDetails(BillId,ItemId,ItemPrice,ItemQuantity,BillDate) values('" + BillIdTB.Text.Trim() + "','" + ItemIdQTB.Text.Trim() + "','" + SellPriceTB.Text.Trim() + "','" + (double.Parse(ref_num_bx.Text.Trim()) * -1).ToString() + "','" + GetDate(DateTime.Now.ToShortDateString()) + "')";
                string Updstr = "Update Bill set BillTotal='" + BT.ToString() + "' where BillId='" + BillIdTB.Text.Trim() + "'";
                string up_ref_bill = "update Bill set BillType='REF' WHERE BillId=" + BillIdTB.Text.Trim();
                DialogResult result;
                //وضع اجمالى الفاتورة ب 1 فى حالة ارتجعت بالكامل لكن صنف صنف ووضعها ب ref
                if (ItemIdQTB.Text.Trim() == BillDetailGV.CurrentRow.Cells[1].Value.ToString().Trim())
                {
                    if ((ItemIdQTB.Text != "" && ItemIdQTB.Text != "0") && (ref_num_bx.Text != "" && ref_num_bx.Text != "0"))
                    {
                        result = MessageBox.Show("هل انت متأكد من ارتجاع هذه الكميه؟ ", "Data Not saved", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                        if (result == System.Windows.Forms.DialogResult.Yes)
                        {
                            SqlCommand UpdStore = new SqlCommand("Update Store set ItemQuantity='" + (double.Parse(ref_num_bx.Text.Trim()) + double.Parse(RemainTB.Text.Trim())).ToString() + "' where ItemId='" + ItemIdQTB.Text + "'", con);
                            con.Open();
                            SqlCommand sql = new SqlCommand(Instr1, con);
                            sql.ExecuteNonQuery();
                            sql = new SqlCommand(Updstr, con);
                            sql.ExecuteNonQuery();
                            UpdStore.ExecuteNonQuery();
                            RefundItem(Int32.Parse(BillIdTB.Text.Trim()));
                            BillDetailGV.Rows[selectGV].Cells[4].Value = quan - double.Parse(ref_num_bx.Text.Trim());
                            BillDetailGV.Rows[selectGV].Cells[5].Value = double.Parse(BillDetailGV.Rows[selectGV].Cells[4].Value.ToString()) * double.Parse(BillDetailGV.Rows[selectGV].Cells[3].Value.ToString());
                            
                            if (BT == 0)
                            {
                                if (con.State == ConnectionState.Closed)
                                    con.Open();
                                sql = new SqlCommand(up_ref_bill, con);
                                sql.ExecuteNonQuery();
                            }
                            con.Close();
                            ItemIdQTB.Text = "";
                          //  QuanTB.Text = "0";
                            check_done = 0;
                            //شاشة الارتجاع لعميل

                            if (BillIdTB.Text.Trim() != "" && ToAgentRB.Checked & BillDetailGV.Rows.Count > 0 && settel_or_credit(BillIdTB.Text.Trim()) == "c")
                            {
                                if (MessageBox.Show("هل تريد خصم المرتجع من حساب عميل؟ ", "Data Not saved", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                                {
                                    if (Int32.Parse(BillIdTB.Text.Trim()) > 0)
                                    {
                                        ag_code = ag_code_bx.Text.Trim();

                                        bill_total = (double.Parse(ref_num_bx.Text.Trim()) * double.Parse(BillDetailGV.CurrentRow.Cells[3].Value.ToString())).ToString();//العدد المرتجع فى سعر الوحده

                                        Discount_agent dis_ag_frm = new Discount_agent(ag_code, bill_total);
                                        dis_ag_frm.ShowDialog();
                                    }
                                }
                            }
                            if (double.Parse(BillDetailGV.Rows[selectGV].Cells[4].Value.ToString()) <= 0)
                                BillDetailGV.Rows.RemoveAt(selectGV);
                            BillTo();
                            if (BillDetailGV.Rows.Count > 0)
                            {
                                result = MessageBox.Show("تم الأرتجاع بنجاح هل تريدارتجاع كميه اخرى؟ ", "Data Not saved", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                                if (result == System.Windows.Forms.DialogResult.Yes)
                                {

                                }
                                else
                                {
                                    BillRemoveBtn.PerformClick();
                                }
                            }
                            else
                            {
                                BillRemoveBtn.PerformClick();
                            }
                         
                        }
                        else if (result == System.Windows.Forms.DialogResult.No)
                        {
                            BillDetailGV.Rows.Clear();
                            RemainMoneyTB.Text = "0";
                            PaidMoneyTB.Text = "0";
                            check_done = 0;
                            BillDateTB.Text = DateTime.Now.ToShortDateString();
                            BillRemoveBtn.PerformClick();
                        }
                    }
                    else
                    {
                        if (ItemIdQTB.Text == "" || ItemIdQTB.Text == "0")
                            MessageBox.Show("حدد الصنف المراد ارتجاعه اولا");
                        else if (ref_num_bx.Text == "" || ref_num_bx.Text == "0")
                            MessageBox.Show("حدد الكميه المراد ارتجاعها اولا");
                    }
                }
                else
                    MessageBox.Show("يجب اختيار الصنف المراد ارتجاع كمية منه");
                QueryBtn.PerformClick();
            }
            catch { con.Close(); MessageBox.Show("خطأ بالبيانات"); }
        }

        private void ref_cancel_btn_Click(object sender, EventArgs e)
        {
            ref_num_exp.Expanded = false;
            ref_num_exp.Visible = false;
        }

        private void QuanTB_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Space)
                //AddItemBtn.PerformClick();
                // if (e.KeyCode == Keys.F5)
                // SaveBillBtn.PerformClick();UpdateBillBtn
            if (e.KeyCode == Keys.F8)
                stuck_bill_btn.PerformClick();
            if (e.KeyCode == Keys.Enter)
            {
                UpdateBillBtn.PerformClick();
                BillDetailGV.CurrentRow.Cells[4].Selected = true;
                sel_sanf_code_bx.Focus();
            }
            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.N)
            {
                sel_sanf_code_bx.Focus();
            }
        }

        private void BillDetailGV_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            
        }

        private void BillDetailGV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F8)
                stuck_bill_btn.PerformClick();
           // if (e.KeyCode == Keys.Delete)
             //   ClearItemBtn.PerformClick();
            if (e.KeyCode == Keys.F5)
                SaveBillBtn.PerformClick();
            if (e.KeyCode == Keys.F3)
                QuanTB.Focus();
            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.S)
            {
                if (BillDetailGV.Rows.Count > 0)
                {
                    if (meth.select_sanf_data_by_barcode_orcode(BillDetailGV.CurrentRow.Cells[1].Value.ToString()).Rows.Count > 0)
                        MessageBox.Show(meth.select_sanf_data_by_barcode_orcode(BillDetailGV.CurrentRow.Cells[1].Value.ToString()).Rows[0][2].ToString());
                }
            }

           // if (e.KeyCode == Keys.F3)
              //  prnt_btn.PerformClick();

            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.N)
            {
                sel_sanf_code_bx.Focus();
            }
        }

        private void ItemIdQTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                //AddItemBtn.PerformClick();
            if (e.KeyCode == Keys.F5)
                SaveBillBtn.PerformClick();

            if (e.KeyCode == Keys.F3)
                prnt_btn.PerformClick();
        }

        private void CatCB_KeyDown(object sender, KeyEventArgs e)
        {
          
            if (e.KeyCode == Keys.F5)
                SaveBillBtn.PerformClick();

            if (e.KeyCode == Keys.F3)
                prnt_btn.PerformClick();
        }

        private void ItemCB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                SaveBillBtn.PerformClick();

            if (e.KeyCode == Keys.F3)
                prnt_btn.PerformClick();
        }

        private void NormSellRB_Click(object sender, EventArgs e)
        {
         
           
        }

        private void ToAgentRB_Click(object sender, EventArgs e)
        {
            
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sel_sanf_code_bx_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void sel_sanf_code_bx_MouseMove(object sender, MouseEventArgs e)
        {
            sel_sanf_code_bx.Focus();
        }

        private void sel_sanf_code_bx_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                Int64 data;
                try
                {
                    data = Int64.Parse(sel_sanf_code_bx.Text);
                }
                catch
                {
                    if (sel_sanf_code_bx.Text != "")
                    {
                        MessageBox.Show("الرجاء ادخال ارقام فقط");
                        sel_sanf_code_bx.Text = "";
                    }


                }
                SqlDataReader Itemread;
                int catid = 0, itemid = 0;
                double sellPrice = 0;
                string ItemId;
                string Quan;
                SqlCommand comm;
                Int64 s_q_code = 0;
                try
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    s_q_code = Int64.Parse(sel_sanf_code_bx.Text.Trim());
                    if (sel_sanf_code_bx.Text.Trim() != "" && s_q_code > 0)
                    {
                        ItemId = "Select Items.ItemId,CatId,ItemSellPriceGo,ItemSellPriceKa,ItemPurchPrice from Items join ItemDetails on  Items.ItemId=ItemDetails.ItemId and (Items.ItemId= " +
                            s_q_code + " or ItemBarcode= " + s_q_code + ")";


                        comm = new SqlCommand(ItemId, con);
                        Itemread = comm.ExecuteReader();
                        Itemread.Read();



                        itemid = Int32.Parse(Itemread["ItemId"].ToString());
                        Itemread.Close();

                        ItemIdQTB.Text = itemid.ToString();
                       // ItemIdQTB_TextChanged(sender, e);


                        AddItemBtn.PerformClick();

                    }
                    else
                        ItemIdQTB.Clear();



                }
                catch (Exception hh)
                {
                    //MessageBox.Show(hh.Message);
                    if (hh.Message.Contains("Invalid attempt to read"))
                    {
                        ItemIdQTB.Clear();
                    }
                    con.Close();

                }
                //  QuanTB.Focus();
            }
            if (e.KeyCode == Keys.F5)
                SaveBillBtn.PerformClick();

            if (e.KeyCode == Keys.F8)
                stuck_bill_btn.PerformClick();
        }

        private void BillNoteTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.N)
            {
                sel_sanf_code_bx.Focus();
            }
            if (e.KeyCode == Keys.F5)
                SaveBillBtn.PerformClick();

           // if (e.KeyCode == Keys.F3)
              //  prnt_btn.PerformClick();
        }

        private void AgentCB_KeyDown(object sender, KeyEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.N)
            {
                sel_sanf_code_bx.Focus();
            }
            if (e.KeyCode == Keys.F5)
                SaveBillBtn.PerformClick();

            if (e.KeyCode == Keys.F3)
                prnt_btn.PerformClick();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
          
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
           
        }

        private void mony_ref_ag_bx_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void AgentCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (AgentCB.Text != "")
                    ag_remain_bx.Text = meth.select_ag_data_bynam_orcode(AgentCB.SelectedValue.ToString(), "null", "Ag").Rows[0][2].ToString();

               // ag_code_bx.Text = AgentCB.SelectedValue.ToString();
            }
            catch (Exception ff)
            {
                MessageBox.Show(ff.Message);
            }
        }

        private void SellPriceTB_TextChanged(object sender, EventArgs e)
        {
            double data;
            try
            {
                data = double.Parse(SellPriceTB.Text);
                 QuanTB_TextChanged( sender,  e);
            }
            catch
            {
                if (SellPriceTB.Text != "")
                {
                    MessageBox.Show("الرجاء ادخال ارقام فقط");
                    SellPriceTB.Text = "";
                }

            }
        }
        private string discount_item()//دالة حساب الخصم
        {
            int kemia = 0;
            double store_sel_price = 0;//سعر البيع من قاعده الباينات
            double screen_sel_pric = 0;//سعر البيع المكتوب بشاشة البيع
            double discount = 0;
            double total_price_item = 0;//اجمالى المبلغ لصنف الواحد
            try
            {
                if (QuanTB.Text.Trim() != "" && SellPriceTB.Text.Trim() != "" && ItemIdQTB.Text.Trim()!="")
                {
                    kemia = int.Parse(QuanTB.Text.Trim());
                    if (NormSellRB.Checked)
                        store_sel_price = double.Parse(meth.select_sanf_data_by_barcode_orcode(ItemIdQTB.Text.Trim()).Rows[0][3].ToString());
                    else
                        store_sel_price = double.Parse(meth.select_sanf_data_by_barcode_orcode(ItemIdQTB.Text.Trim()).Rows[0][4].ToString());

                    screen_sel_pric = double.Parse(SellPriceTB.Text.Trim());
                    total_price_item = double.Parse(TotalTB.Text.Trim());


                    discount = (kemia * store_sel_price) - total_price_item;
                }

            }
            catch (Exception ff)
            {
                MessageBox.Show(ff.Message);
            }
            return discount.ToString();
        }
        private void ag_code_bx_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ag_ref_name_bx.Text = meth.select_ag_data_bynam_orcode(ag_code_bx.Text.Trim(), "null", "Ag").Rows[0][1].ToString();
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message);
            }
        }

        private void RemainTB_MouseHover(object sender, EventArgs e)
        {
          
           
        }

        private void RemainTB_MouseMove(object sender, MouseEventArgs e)
        {
            earn_lbl.Visible = true;
        }

        private void RemainTB_MouseLeave(object sender, EventArgs e)
        {
            earn_lbl.Visible = false;
        }

        private void RemainTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void discount_bx_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_item_btn_Click(object sender, EventArgs e)
        {
            add_item add_item_form = new add_item(status);
            add_item_form.ShowDialog();
           
        }

        private void stuck_bill_btn_Click(object sender, EventArgs e)
        {
            try
            {

                int sel_rdb =0;
                int chbx = 0;
                string ag_selected_value = "";
                if(AgentCB.Text.Trim()!="")
                ag_selected_value = AgentCB.SelectedValue.ToString();
                if (NormSellRB.Checked)
                    sel_rdb = 0;
                else  if (ToAgentRB.Checked)
                    sel_rdb = 1;


                if (CashCB.Checked)
                    chbx = 0;
                else  if (CreditCB.Checked)
                    chbx = 1;

                if (BillDetailGV.Rows.Count > 0)
                {
                if (MessageBox.Show("هل تريد تعليق هذه الفاتورة", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    
                        if (int.Parse(BillIdTB.Text.Trim()) <= 0)
                        {
                            ///ادخال لراسالفقاتورة المعلقه/
                            SqlCommand insert_header_cmd = con.CreateCommand();
                            insert_header_cmd.CommandText = "insert into stuck_header_bill_table(st_b_date , st_chckrdbtn, st_ag_id, st_owner, st_chkbx, st_b_notes" + ")values('" +
                                BillDateTB.Text + "','" + sel_rdb + "','" + ag_selected_value + "','" + fat_owner_bx.Text + "','" + chbx + "','" + BillNoteTB.Text + "')";

                            con.Open();
                            insert_header_cmd.ExecuteNonQuery();
                            con.Close();
                            ///ادخال اصناف///
                            SqlCommand insert_item = con.CreateCommand();
                            for (int i = 0; i < BillDetailGV.Rows.Count; i++)
                            {
                                insert_item.CommandText = "insert into stuck_items_table(st_b_id, st_item_ser, st_item_code, st_item_name, sel_item_price, sel_item_quan, st_item_price_quna, partener_id" + ")values('" +
                                    meth.max_stuck_bill().Rows[0][0].ToString() + "','" +
                                    BillDetailGV.Rows[i].Cells[0].Value.ToString() + "','" +
                                    BillDetailGV.Rows[i].Cells[1].Value.ToString() + "','" +
                                    BillDetailGV.Rows[i].Cells[2].Value.ToString() + "','" +
                                    BillDetailGV.Rows[i].Cells[3].Value.ToString() + "','" +
                                    BillDetailGV.Rows[i].Cells[4].Value.ToString() + "','" +
                                    BillDetailGV.Rows[i].Cells[5].Value.ToString() + "','" +
                                    BillDetailGV.Rows[i].Cells[7].Value.ToString() + "')";

                                con.Open();
                                insert_item.ExecuteNonQuery();
                                con.Close();

                            }
                            MessageBox.Show("تم الحفظ");
                            RemainMoneyTB.Text = "0";
                            PaidMoneyTB.Text = "0";
                            check_done = 0;
                            stuck_bill_num_btn.Text = meth.select_stuck_num().Rows.Count.ToString();
                            BillDateTB.Text = DateTime.Now.ToShortDateString();
                            _delete_btn_jop();
                        }
                        else
                            MessageBox.Show("هذه فاتورة تم تسويتها لايمكن تعليقها");
                    
                }
                }
                else
                    MessageBox.Show("لايوجد فاتورة");

                
            }
            catch(Exception ff)
            {
                MessageBox.Show(ff.Message);
                con.Close();
            }
        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }
        
        private void query_stuck_bill_btn_Click(object sender, EventArgs e)
        {
            try
            {
                query_stuck_bill_form q_s_frm = new query_stuck_bill_form();
               
                if (BillDetailGV.Rows.Count <= 0 )
                {
                   
                    q_s_frm.ShowDialog();
                    if (q_s_frm.bill_stuck_id.Trim() != "" && q_s_frm.bill_stuck_id!=null)
                    {
                        BillDateTB.Text = meth.select_stuck_header_by_code(q_s_frm.bill_stuck_id).Rows[0][1].ToString();
                        fat_owner_bx.Text = meth.select_stuck_header_by_code(q_s_frm.bill_stuck_id).Rows[0][2].ToString();
                        BillNoteTB.Text = meth.select_stuck_header_by_code(q_s_frm.bill_stuck_id).Rows[0][3].ToString();
                        AgentCB.SelectedValue = meth.select_stuck_header_by_code(q_s_frm.bill_stuck_id).Rows[0][5].ToString();

                        if (meth.select_stuck_header_by_code(q_s_frm.bill_stuck_id).Rows[0][4].ToString().Trim() == "0")
                        {
                            NormSellRB.Checked = true;
                        }
                        else if (meth.select_stuck_header_by_code(q_s_frm.bill_stuck_id).Rows[0][4].ToString().Trim() == "1")
                        {
                            ToAgentRB.Checked = true;
                        }

                        if (meth.select_stuck_header_by_code(q_s_frm.bill_stuck_id).Rows[0][6].ToString().Trim() == "0")
                        {
                            CashCB.Checked = true;
                        }
                        else if (meth.select_stuck_header_by_code(q_s_frm.bill_stuck_id).Rows[0][6].ToString().Trim() == "1")
                        {
                            CreditCB.Checked = true;
                        }

                        for (int i = 0; i < meth.select_stuck_item(q_s_frm.bill_stuck_id).Rows.Count; i++)
                        {
                            ItemIdQTB.Text = meth.select_stuck_item(q_s_frm.bill_stuck_id).Rows[i][1].ToString();
                            SellPriceTB.Text = meth.select_stuck_item(q_s_frm.bill_stuck_id).Rows[i][2].ToString();
                            QuanTB.Text = meth.select_stuck_item(q_s_frm.bill_stuck_id).Rows[i][3].ToString();
                            partener_cmbx.SelectedValue = meth.select_stuck_item(q_s_frm.bill_stuck_id).Rows[i][4].ToString();
                            AddItemBtn.PerformClick();
                        }
                        stuck_b_id_bx.Text = q_s_frm.bill_stuck_id;
                    }
                }
                else
                    MessageBox.Show("يوجد فاتورة يجب التعامل معها اولا");

                stuck_bill_num_btn.Text = meth.select_stuck_num().Rows.Count.ToString();
            }
            catch (Exception ff)
            {
                MessageBox.Show(ff.Message);
            }
        }

        private void BillDetailGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (BillDetailGV.Rows.Count > 0)
            {
                if (BillDetailGV.CurrentRow.Cells[8].Selected && int.Parse(BillIdTB.Text) <= 0)
                    ClearItemBtn.PerformClick();
                //else
                   // BillDetailGV.Columns[8].Visible = false;
            }
        }

        private void BillDetailGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BillIdTB_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(BillIdTB.Text) <= 0)
                BillDetailGV.Columns[8].Visible = true;
            else
                BillDetailGV.Columns[8].Visible = false;
        }

        private void smallBtn_CheckedChanged(object sender, EventArgs e)
        {
            //Control Panel\Hardware and Sound\Devices and Printers
           
          //  String PATH = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "control.exe");

           // System.Diagnostics.Process.Start(PATH, "/name Microsoft.DevicesAndPrinters");
            
        }

        private void A4Btn_CheckedChanged(object sender, EventArgs e)
        {

        }

      
        
        
    }
}
