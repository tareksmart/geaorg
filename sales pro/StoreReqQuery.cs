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
using System.Xml.Serialization;
using System.Data.SqlTypes;
using System.Collections;

namespace sales_pro
{
    public partial class StoreReqQuery : Form
    {
        public StoreReqQuery()
        {
            InitializeComponent();
        }
        private SqlConnection connect_online = new SqlConnection("Data Source=SQL5075.site4now.net;Initial Catalog=DB_A693A3_nourmilano;User Id=DB_A693A3_nourmilano_admin;Password=St01158119850;MultipleActiveResultSets=true");
        
        private void StoreReqQuery_Load(object sender, EventArgs e)
        {

        }
        private void select_stuck_req_store()
        {
            try
            {
                string header;
                header = "select storeHeadTbl from XmlTable where storeTypeReq=0";

                connect_online.Open();
                connect_sal.Open();
                SqlCommand selectCmd = connect_online.CreateCommand();
                SqlCommand c = connect_sal.CreateCommand();
                DataTable dtb = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter();
                selectCmd.CommandText = header;
                adp.SelectCommand = selectCmd;
                adp.Fill(dtb);
                //XmlReader reader ;

                for (int i = 0; i < dtb.Rows.Count; i++)
                {
                    ReqGrid.Rows.Add();
                    c.CommandText = "declare @x xml set @x ='" + dtb.Rows[i][0].ToString() + "' " +
"select @x.value('/SpentStReqTbl[1]/SpentStReqId[1]/SpentStReqId[1]','int')," +
"@x.value('/SpentStReqTbl[1]/SpentStReqId[1]/SpentStReqDate[1]','nchar(15)')," +
"@x.value('/SpentStReqTbl[1]/SpentStReqId[1]/SpentStReqStoreId[1]','nchar(2)'),@x.value('/SpentStReqTbl[1]/SpentStReqId[1]/SpentStReqUserId[1]','nchar(20)')," +
"@x.value('/SpentStReqTbl[1]/SpentStReqId[1]/SpentStReqNotes[1]','nvarchar(100)'),@x.value('/SpentStReqTbl[1]/SpentStReqId[1]/SpentStReqStatus[1]','nchar(2)')";
                    SqlDataReader rdr = c.ExecuteReader();
                    rdr.Read();
                    //MessageBox.Show(rdr[0].ToString());

                    ReqGrid.Rows[i].Cells[0].Value = rdr[0];
                    ReqGrid.Rows[i].Cells[1].Value = rdr[1];
                    ReqGrid.Rows[i].Cells[2].Value = rdr[2];
                    ReqGrid.Rows[i].Cells[3].Value = rdr[3];
                    ReqGrid.Rows[i].Cells[4].Value = rdr[4];
                    ReqGrid.Rows[i].Cells[5].Value = rdr[5];
                    //ReqGrid.Rows[col].Cells[1].Value = value;
                    //xmlDs=(DataSet)arr;//.ReadXml(salesReaderXml);
                    rdr.Close();

                }

            
                connect_online.Close();
                connect_sal.Close();

            }
            catch (Exception ff)
            {
                if (ff.Message.Contains("A transport-level error has occurred when receiving results from the server"))
                {

                    MessageBox.Show("خطا اتصال!!");


                }
                else if (ff.Message.Contains("A network-related or instance-specific error"))
                {

                    MessageBox.Show("خطا اتصال!!");


                }
                else
                {
                    MessageBox.Show(ff.Message);


                }
              
                connect_online.Close();
            }
        }
        public SqlTransaction sTrans; 
        private void reqStoreDetails(string order_id)
        {
            try
            {
                string header;
                header = "select sqlReqDetails,items,itemDetails,itemExpire,itemCat,Company from xmlItemsTable where storeReqId="+order_id;

                bool trans_complet = true;
                String BillId = "";
              
                SqlCommand insert_cmd = connect_sal.CreateCommand();
                connect_online.Open();
                connect_sal.Open();
                sTrans = connect_sal.BeginTransaction();
                sTrans.Save("save_point");
                insert_cmd.Transaction = sTrans;
               
                SqlCommand selectCmd = connect_online.CreateCommand();
                SqlCommand c = connect_sal.CreateCommand();
                c.Transaction = sTrans;
                DataTable dtb = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter();
                selectCmd.CommandText = header;
                adp.SelectCommand = selectCmd;
                adp.Fill(dtb);

               
                for (int i = 0; i < dtb.Rows.Count; i++)
                {
                    //تفاصيل الطلب
                    c.CommandText = "declare @x xml set @x ='" + dtb.Rows[i][0].ToString() + "' " +
"select @x.value('/SpentStReqDetailsTbl[1]/SpentStReqDetailsHeadId[1]/SpentReqDetailsItemId[1]','int')," +
"@x.value('/SpentStReqDetailsTbl[1]/SpentStReqDetailsHeadId[1]/SpentStReqDetailsQuan[1]','int')";

                    SqlDataReader rdrReqDet = c.ExecuteReader();
                    
                    rdrReqDet.Read();
                    rdrReqDet.Close();
                    //الاصناف
                    c.CommandText = "declare @y xml set @y ='" + dtb.Rows[i][1].ToString() + "' " +
"select @y.value('/Items[1]/ItemId[1]/ItemId[1]','int')," +
"@y.value('/Items[1]/ItemId[1]/CatId[1]','int'),@y.value('/Items[1]/ItemId[1]/ItemName[1]'," +
"'nvarchar(50)'),@y.value('/Items[1]/ItemId[1]/ItemPurchPrice[1]','real'),@y.value('/Items[1]/ItemId[1]/ItemSellPriceGo[1]','real')" +
",@y.value('/Items[1]/ItemId[1]/ItemSellPriceKa[1]','real')";

                    SqlDataReader rdrItems = c.ExecuteReader();

                    rdrItems.Read();
                    ArrayList itemsArr = new ArrayList();
                    itemsArr.Add(rdrItems[0]);
                    itemsArr.Add(rdrItems[1]);
                    itemsArr.Add(rdrItems[2]);
                    itemsArr.Add(rdrItems[3]);
                    itemsArr.Add(rdrItems[4]);
                    itemsArr.Add(rdrItems[5]);
                  
                    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    //insert item
                    try
                    {
                        insert_cmd.CommandText = "insert into Items(ItemId, CatId, ItemName, ItemPurchPrice, ItemSellPriceGo, ItemSellPriceKa" + ")values(" +
                             rdrItems[0].ToString() + "," + rdrItems[1].ToString() + ",'" + rdrItems[2].ToString() + "',"
                             + rdrItems[3].ToString() + "," + rdrItems[4].ToString() + "," +
                              rdrItems[5].ToString() + ")";

                        rdrItems.Close();
                        insert_cmd.ExecuteNonQuery();
                       
                    }
                    catch (Exception w)
                    {
                        if (w.Message.Contains("Cannot insert duplicate key"))
                        {
                            SqlCommand updateOnlineCmd = connect_sal.CreateCommand();
                            updateOnlineCmd.Transaction = sTrans;

                            updateOnlineCmd.CommandText = "update Items set CatId='" + itemsArr[1].ToString() + "',ItemName='" + itemsArr[2].ToString() +

                                "',ItemPurchPrice='" + itemsArr[3].ToString() +

                                "',ItemSellPriceGo='" + itemsArr[4].ToString() +

                                "',ItemSellPriceKa='" + itemsArr[5].ToString() +

                                "' where ItemId=" + itemsArr[0].ToString();
                           
                            updateOnlineCmd.ExecuteNonQuery();
                           
                        }
                        else
                        {
                            MessageBox.Show(w.Message);
                            sTrans.Rollback("save_point");
                            trans_complet = false;
                          
                            connect_online.Close();
                            connect_sal.Close();
                           
                        }
                    }
                   
                    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    // تفاصيل الاصناف
                    c.CommandText = "declare @y xml set @y ='" + dtb.Rows[i][2].ToString() + "' " +
"select @y.value('/ItemDetails[1]/ItemId[1]/ItemId[1]','int')," +
"@y.value('/ItemDetails[1]/ItemId[1]/ItemModel[1]','nvarchar(50)'),@y.value('/ItemDetails[1]/ItemId[1]/ItemNotes[1]'," +
"'nvarchar(100)'),@y.value('/ItemDetails[1]/ItemId[1]/ItemBarcode[1]','bigint'),@y.value('/ItemDetails[1]/ItemId[1]/item_comp_id[1]','int')";


                    SqlDataReader rdrItemsDeta = c.ExecuteReader();

                    rdrItemsDeta.Read();
                    ArrayList itemsDetailsArr = new ArrayList();
                    itemsDetailsArr.Add(rdrItemsDeta[0]);
                    itemsDetailsArr.Add(rdrItemsDeta[1]);
                    itemsDetailsArr.Add(rdrItemsDeta[2]);
                    itemsDetailsArr.Add(rdrItemsDeta[3]);
                    itemsDetailsArr.Add(rdrItemsDeta[4]);
                   
                    try
                    {
                       

                    
                        insert_cmd.CommandText = "insert into ItemDetails( ItemId, ItemModel, ItemNotes, ItemBarcode, item_comp_id" + ")values('" +
                             itemsDetailsArr[0].ToString() + "','" + itemsDetailsArr[1].ToString() + "','" + itemsDetailsArr[2].ToString() + "','" +
                             itemsDetailsArr[3].ToString() + "','" + itemsDetailsArr[4].ToString() + "')";

                        rdrItemsDeta.Close();
                        insert_cmd.ExecuteNonQuery();
                        //MessageBox.Show("item detail inserted");
                    }
                    catch (Exception w)
                    {
                        if (w.Message.Contains("Cannot insert duplicate key"))
                        {
                            SqlCommand updateOnlineCmd = connect_sal.CreateCommand();
                            updateOnlineCmd.Transaction = sTrans;

                            rdrItemsDeta.Read();
                            updateOnlineCmd.CommandText = "update ItemDetails set ItemModel='" + itemsDetailsArr[1].ToString() +
                                "',ItemBarcode='" + itemsDetailsArr[3].ToString() +

                                "',item_comp_id='" + itemsDetailsArr[4].ToString() +


                                " where ItemId=" + itemsDetailsArr[0].ToString();
                            updateOnlineCmd.ExecuteNonQuery();
                            MessageBox.Show("itemdeta updated");
                        }
                        else
                        {
                            MessageBox.Show(w.Message);
                            sTrans.Rollback("save_point");
                            trans_complet = false;
                            rdrItemsDeta.Close();
                            connect_online.Close();
                            connect_sal.Close();
                            //trans.Rollback("savePoint");
                        }
                    }
                   
                    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    // item expire
                    c.CommandText = "declare @y xml set @y ='" + dtb.Rows[i][3].ToString() + "' " +
"select @y.value('/expire_item_table[1]/expire_item_id[1]/expire_item_id[1]','int')," +
"@y.value('/expire_item_table[1]/expire_item_id[1]/expire_date[1]','nchar(15)'),@y.value('/expire_item_table[1]/expire_item_id[1]/ex_it_date_flag[1]','int'),"+
"@y.value('/expire_item_table[1]/expire_item_id[1]/ex_bill_id[1]','int')";

                    SqlDataReader rdrItemsExpire = c.ExecuteReader();

                    rdrItemsExpire.Read();
                    ArrayList itemsExpArr = new ArrayList();
                    itemsExpArr.Add(rdrItemsExpire[0]);
                    itemsExpArr.Add(rdrItemsExpire[1]);
                    itemsExpArr.Add(rdrItemsExpire[2]);
                    itemsExpArr.Add(rdrItemsExpire[3]);
                    rdrItemsExpire.Close();

                    try
                    {

                        insert_cmd.CommandText = "insert into expire_item_table( expire_item_id, expire_date, ex_it_date_flag,ex_bill_id" + ")values('" +
                             itemsExpArr[0].ToString() + "','" + itemsExpArr[1].ToString() + "','" + itemsExpArr[2].ToString() + "','" + itemsExpArr[3].ToString() + "')";


                        insert_cmd.ExecuteNonQuery();
                        //MessageBox.Show("item exp inserted");
                    }
                    catch (Exception w)
                    {
                        if (w.Message.Contains("Cannot insert duplicate key"))
                        {
                            
                        }
                        else
                        {
                            MessageBox.Show(w.Message);
                            sTrans.Rollback("save_point");
                            trans_complet = false;
                            rdrItemsDeta.Close();
                            connect_online.Close();
                            connect_sal.Close();
                            //trans.Rollback("savePoint");
                        }
                    }
                    rdrItemsExpire.Close();
                    // category
                    c.CommandText = "declare @y xml set @y ='" + dtb.Rows[i][4].ToString() + "' " +"select @y.value('/Category[1]/CatId[1]/CatId[1]','int')," +
"@y.value('/Category[1]/CatId[1]/CatName[1]','nvarchar(30)')";



                    SqlDataReader rdrItemsCatrdr = c.ExecuteReader();

                    rdrItemsCatrdr.Read();
                    ArrayList catArr = new ArrayList();
                    catArr.Add(rdrItemsCatrdr[0]);
                    catArr.Add(rdrItemsCatrdr[1]);
                    rdrItemsCatrdr.Close();
                    try
                    {

                        insert_cmd.CommandText = "insert into Category( CatId,CatName" + ")values(" + catArr[0].ToString() + ",'" + catArr[1].ToString() + "')";
                        insert_cmd.ExecuteNonQuery();
                        MessageBox.Show("cat inserted");
                    }
                    catch (Exception w)
                    {
                        if (w.Message.Contains("Cannot insert duplicate key"))
                        {


                            SqlCommand updateOnlineCmd = connect_sal.CreateCommand();
                            updateOnlineCmd.Transaction = sTrans;
                            updateOnlineCmd.CommandText = "update Category set CatName='" + catArr[1].ToString() + "' where CatId=" + catArr[0].ToString();
                            updateOnlineCmd.ExecuteNonQuery();
                           
                        }
                        else
                        {
                            MessageBox.Show(w.Message);
                            sTrans.Rollback("save_point");
                            trans_complet = false;
                            rdrItemsCatrdr.Close();
                            connect_online.Close();
                            connect_sal.Close();
                            //trans.Rollback("savePoint");
                        }
                    }
                    rdrItemsCatrdr.Close();
                    // company
                    c.CommandText = "declare @y xml set @y ='" + dtb.Rows[i][5].ToString() + "' " + "select @y.value('/company_table[1]/com_id[1]/com_id[1]','int')," +
"@y.value('/company_table[1]/com_id[1]/com_name[1]','nvarchar(30)')";

                    SqlDataReader rdrItemsComprdr = c.ExecuteReader();

                    rdrItemsComprdr.Read();
                    ArrayList compArr = new ArrayList();
                    compArr.Add(rdrItemsComprdr[0]);
                    compArr.Add(rdrItemsComprdr[1]);
                    rdrItemsComprdr.Close();
                    try
                    {

                        insert_cmd.CommandText = "insert into company_table( com_id,com_name" + ")values('" + compArr[0].ToString() + "','" + compArr[1].ToString() + "')";
                        insert_cmd.ExecuteNonQuery();
                       
                    }
                    catch (Exception w)
                    {
                        if (w.Message.Contains("Cannot insert duplicate key"))
                        {
                            SqlCommand updateOnlineCmd = connect_sal.CreateCommand();
                            updateOnlineCmd.Transaction = sTrans;
                            updateOnlineCmd.CommandText = "update company_table set com_name='" + compArr[1].ToString() + "' where com_id=" + compArr[0].ToString();
                            updateOnlineCmd.ExecuteNonQuery();
                           
                        }
                        else
                        {
                            MessageBox.Show(w.Message);
                            sTrans.Rollback("save_point");
                            trans_complet = false;
                            rdrItemsComprdr.Close();
                            connect_online.Close();
                            connect_sal.Close();
                            //trans.Rollback("savePoint");
                        }
                    }
                    rdrItemsComprdr.Close();

                }
                    


                connect_online.Close();
                connect_sal.Close();

            }
            catch (Exception ff)
            {
                if (ff.Message.Contains("A transport-level error has occurred when receiving results from the server"))
                {

                    MessageBox.Show("خطا اتصال!!");


                }
                else if (ff.Message.Contains("A network-related or instance-specific error"))
                {

                    MessageBox.Show("خطا اتصال!!");


                }
                else
                {
                    MessageBox.Show(ff.Message);


                }
               
                connect_online.Close();
            }
        }
    
        private void select_req_items(string orderId)
        {
            try
            {
                string header, stDetails;
                header = "select storeHeadTbl,sqlReqDetails from XmlTable where storeTypeReq=0";
                stDetails = "select sqlReqDetails,itemCat,items from  xmlItemsTable";
                connect_online.Open();
                SqlCommand selectCmd = connect_online.CreateCommand();
                DataSet xmlDs = new DataSet();
                DataTable dtb = new DataTable();
                //XmlReader reader ;
                selectCmd.CommandText = stDetails;
                //reader = selectCmd.ExecuteXmlReader();

                //xmlDtb.ReadXml(reader);

                //selectCmd.CommandText = stDetails;
                //reader = selectCmd.ExecuteXmlReader();

                //xmlDtb.ReadXml(reader);

                //reader.Close();
                //connect_online.Close();

                //ReqGrid.DataSource = xmlDtb.Tables[0];
                SqlDataReader salesReaderData = selectCmd.ExecuteReader();
                int row = 0;
                int col = 0;
                string element = "";
                string value = "";

                ReqGrid.Rows.Clear();
                salesReaderData.Read();

                while (salesReaderData.Read())
                {
                    if (row >= 3)
                    {
                        //MessageBox.Show(row.ToString());
                        row = 0;
                    }
                    SqlXml salesXML =
  salesReaderData.GetSqlXml(2);


                    XmlReader salesReaderXml = salesXML.CreateReader();
                    salesReaderXml.MoveToContent();
                    salesReaderXml.Read();


                    //ReqGrid.Rows.Add();
                    while (salesReaderXml.Read())
                    {

                        if (salesReaderXml.NodeType == XmlNodeType.Element)
                        {


                            element = salesReaderXml.LocalName;
                            //ReqGrid.Columns.Add(element, element);

                            salesReaderXml.Read();
                            value = salesReaderXml.Value;

                            MessageBox.Show("داخل xml " + element + " : " + value);
                            ReqGrid.Rows.Add();
                            ReqGrid.Rows[col].Cells[0].Value = element;
                            ReqGrid.Rows[col].Cells[1].Value = value;
                            //xmlDs=(DataSet)arr;//.ReadXml(salesReaderXml);
                            col++;
                        }
                        //MessageBox.Show("خارج xml " + element + " : " + value);
                    }
                    row++;
                }
                connect_online.Close();

                //ReqGrid.DataSource = xmlDs.Tables[0];
            }
            catch (Exception ff)
            {
                MessageBox.Show(ff.Message);
                connect_online.Close();
            }
        }
        private void stuqQueryBtn_Click(object sender, EventArgs e)
        {
            select_stuck_req_store();
        }
        private SqlConnection connect_sal = new SqlConnection("server=.\\SQLEXPRESS;database=sales;integrated security=SSPI");
        private void buttonX1_Click(object sender, EventArgs e)
        {
           
        }

        private void ReqGrid_DoubleClick(object sender, EventArgs e)
        {
            if (ReqGrid.Rows.Count > 0)
            {
                reqStoreDetails(ReqGrid.CurrentRow.Cells[0].Value.ToString());
            }
        }
    }
}
