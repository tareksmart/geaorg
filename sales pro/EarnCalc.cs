using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
namespace sales_pro
{
    class EarnCalc
    {
        SqlConnection con;
        ArrayList Items;
        double salesMony,spentMony;
        public EarnCalc()
        {
            string conStr = "Data Source=.\\SQLEXPRESS;Initial Catalog=sales;Integrated Security=True";
            con = new SqlConnection(conStr);
            Items = new ArrayList(1000);
            salesMony = 0;
            spentMony = 0;
        }
        public void EarnCalcOper(string Date)
        {
            salesMony = 0;
            spentMony = 0;            
            try
            {
                string ItemId = "select distinct BillDetails.ItemID,Items.ItemPurchPrice from Items"+
                    " inner join BillDetails on(BillDetails.BillId in (select Bill.BillId from Bill where BillType not in ('w','REF') and BillDate='"
                    + GetDate(Date) + "' and AgentId>0 ) and BillDetails.ItemID=Items.ItemId)";

                con.Open();
                Items.Clear();
                SqlCommand comm = new SqlCommand(ItemId, con);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {

                    Items.Add(reader["ItemId"].ToString());
                    Items.Add(reader["ItemPurchPrice"].ToString());
                }
                reader.Close();
               // con.Close();
                for (int i = 0; i < Items.Count; i++)
                {
                    ItemId = "select sum(BillDetails.ItemQuantity) as quantity,sum(ItemPrice*BillDetails.ItemQuantity)As price from BillDetails where ItemId='" + Items[i].ToString() +
                        "' and BillDetails.BillId in (select Bill.BillId from Bill where BillType not in ('w','REF') and BillDate='"
                        + GetDate(Date) + "'and AgentId>0 )";
                   // con.Open();
                    comm = new SqlCommand(ItemId, con);
                    reader = comm.ExecuteReader();
                    while (reader.Read())
                    {
                        i++;
                        try 
                        {
                           // salesMony = salesMony + double.Parse(reader["quantity"].ToString()) * (double.Parse(reader["price"].ToString()) -
                               // double.Parse(Items[i].ToString()));

                            salesMony = salesMony+((double.Parse(reader["price"].ToString())-(double.Parse(reader["quantity"].ToString())*double.Parse(Items[i].ToString()))));
                        }
                        catch { reader.Close(); }
                    }
                    reader.Close();
                }
                reader.Close();
                Items.Clear();
                ItemId = "select distinct BillDetails.ItemID,Items.ItemPurchPrice from Items"+
                    " inner join BillDetails on(BillDetails.BillId in (select Bill.BillId from Bill where BillType not in ('w','REF') and BillDate='" +
                    GetDate(Date) + "' and AgentId=0) and BillDetails.ItemID=Items.ItemId)";

               // con.Open();
                 comm = new SqlCommand(ItemId, con);
                 reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    Items.Add(reader["ItemId"].ToString());
                    Items.Add(reader["ItemPurchPrice"].ToString());
                }
                reader.Close();
               
                for (int i = 0; i < Items.Count; i++)
                {
                    ItemId = "select sum(BillDetails.ItemQuantity) as quantity,sum(ItemPrice*BillDetails.ItemQuantity)As price from BillDetails where ItemId='" + Items[i].ToString() +
                        "' and BillDetails.BillId in (select Bill.BillId from Bill where BillType not in ('w','REF') and BillDate='" + GetDate(Date) + "' and AgentId=0)";
                    //con.Open();
                    comm = new SqlCommand(ItemId, con);
                    reader = comm.ExecuteReader();
                    while (reader.Read())
                    {
                        i++;
                        try
                        {
                            //salesMony = salesMony + double.Parse(reader["quantity"].ToString()) * (double.Parse(reader["price"].ToString()) - double.Parse(Items[i].ToString()));


                            salesMony = salesMony + ((double.Parse(reader["price"].ToString()) - (double.Parse(reader["quantity"].ToString()) * double.Parse(Items[i].ToString()))));
                       
                        }
                        catch
                        {
                            reader.Close();
                        }
                    }
                    reader.Close();
                }
              //  reader.Close();
                ItemId = "select SUM(spent_mny) AS spentmny from spent_table where spent_table.spent_date='" + GetDate(Date) + "' and spent_table.spent_flag = 'n'";
                //con.Open();
                comm = new SqlCommand(ItemId, con);
                reader = comm.ExecuteReader();
                try
                {
                    while (reader.Read())
                        spentMony = spentMony + double.Parse(reader[0].ToString());
                    reader.Close();
                }
                catch { reader.Close(); }
                string insrt = "Insert into Profit (SalesMoney,SpentMoney,ProfitDate) values('" + salesMony.ToString() + "','" + spentMony.ToString() + "','" + GetDate(Date) + "')";
                string Upd = "Update Profit set SalesMoney='" + salesMony.ToString() + "',SpentMoney='" + spentMony + "' where ProfitDate='" + GetDate(Date) + "'";
                try
                {
                    comm = new SqlCommand(insrt, con);
                    comm.ExecuteNonQuery();
                }
                catch
                {
                    comm = new SqlCommand(Upd, con);
                    comm.ExecuteNonQuery();
                }

                con.Close();

            }
            catch { con.Close(); }
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
   
    }

}
