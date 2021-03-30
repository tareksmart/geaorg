using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;


namespace sales_pro
{
    public partial class CategoryBD : UserControl
    {
        SqlConnection con;
        public CategoryBD()
        {
            string conStr = "Data Source=.\\SQLEXPRESS;Initial Catalog=sales;Integrated Security=True";
            con = new SqlConnection(conStr);
            InitializeComponent();
        }

        private void CategoryBD_Load(object sender, EventArgs e)
        {
            CatNameTB.Focus();
            try
            {
                categoryTableAdapter.Fill(salesDataSet.Category);
            }
            catch { }
        }
        private void InsertBtn_Click(object sender, EventArgs e)
        {
            string Instr = "insert into Category(CatName,Notes) values('" + CatNameTB.Text.Trim() + "','" + CatNotesTB.Text.Trim() + "')";
            if (CatIdTB.Text.Trim() == "")
            {
                try
                {
                    if (CatNameTB.Text.Trim() != "")
                    {
                        con.Open();
                        SqlCommand sql = new SqlCommand(Instr, con);
                        sql.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("تم الأدخال بنجاح");
                        SqlCommand selectId = new SqlCommand();
                        categoryTableAdapter.Fill(this.salesDataSet.Category);
                        ClearBtn_Click(sender, e);
                    }
                    else
                        MessageBox.Show("من فضلك ادخل التصنيف");
                }
                catch(Exception ex )
                {
                    con.Close();
                    if (ex.Message.Contains("UNIQUE KEY"))
                        MessageBox.Show(" !!القسم موجود من قبل"," خطأ");
                    else
                        MessageBox.Show("الرجاء استكمال جميع البيانات اولا و ادخال البيانات صحيحة وبدون اى علامات");
                }
            }
            else
            {
                if (MessageBox.Show("هذه البيانات تم حفظها من قبل هل تريد تعديلها", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    UpdateBtn.PerformClick();

              /* if (CatIdTB.Text == "")
                    MessageBox.Show("الرجاء استكمال جميع لبيانات اولا قبل الحفظ","خطأ");
                else
                    MessageBox.Show("لا يمكن ادخال بيانات موجوده من قبل لكن يمكنك تعديلها", "خطأ");
                ClearBtn_Click(sender, e);*/
            }
        }

        private void CategoryCBSelectedIndexChanged(object sender, EventArgs e)
        {
            string data;
            SqlDataReader reader;
            SqlCommand comm;
            try
            {
                con.Open();
                data = "select * from Category where CatId='" + CategoryCB.SelectedValue.ToString() + "'";
                comm = new SqlCommand(data, con);
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    CatIdTB.Text = reader["CatId"].ToString();
                    CatNameTB.Text = reader["CatName"].ToString();
                    CatNotesTB.Text = reader["Notes"].ToString();
                }
                reader.Close();
                con.Close();
            }
            catch { con.Close(); }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            CatIdTB.Text = "";
            CatNameTB.Text = "";
            CatNotesTB.Text = "";
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string Updstr = "Update  Category set CatName='" + CatNameTB.Text.Trim() + "',Notes='" + CatNotesTB.Text.Trim() + "' where CatId=" + CatIdTB.Text.Trim();

            try
            {
                con.Open();
                SqlCommand sql = new SqlCommand(Updstr, con);
                sql.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("تم التعديل بنجاح");
                SqlCommand selectId = new SqlCommand();
                categoryTableAdapter.Fill(salesDataSet.Category);
                ClearBtn_Click(sender, e);
            }
            catch(Exception ex) 
            {
               
                if (ex.Message.Contains("UNIQUE KEY"))
                    MessageBox.Show(" !!القسم موجود من قبل", " خطأ");
                else if(CatIdTB.Text=="")
                    MessageBox.Show("الرجاء اختيار القسم المراد تعديل بياناته");
                con.Close();
            }

        }

        private void CatNameTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                InsertBtn.PerformClick();
        }

        private void CatNotesTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                InsertBtn.PerformClick();
        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

    }
}
