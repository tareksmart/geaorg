using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sales_pro
{
    public partial class AgentBD : UserControl
    {
        SqlConnection con;
        string AGType;
        public AgentBD(string Agtype)
        {
            string conStr = "Data Source=.\\SQLEXPRESS;Initial Catalog=sales;Integrated Security=True";
            AGType = Agtype;
            
            con = new SqlConnection(conStr);
            InitializeComponent();
            if (Agtype == "m")
            {
                AgColabel.Text = "كود المورد";
                AgentNameLabel.Text = "اسم المورد";
                AgentEXPanel.TitleText ="استعلام عن بيانات مورد";
            }
        }
        private methodes meth = new methodes();
        private void AgentInsertBtn_Click(object sender, EventArgs e)
        {
            string Instr;
            if (AgentTeleNoTB.Text == "")
                Instr = "insert into Agent(AgentName,Agentstock,AgentType,AgentAddr,AgentTele,AgentNotes) values('" +
                    AgentNameTB.Text.Trim() + "','0','" + AGType + "','" + AgentAddrTB.Text.Trim() + "',null,'" + AgentNotesTB.Text.Trim() + "')";
            else
                Instr = "insert into Agent(AgentName,Agentstock,AgentType,AgentAddr,AgentTele,AgentNotes) values('" +
                    AgentNameTB.Text.Trim() + "','0','" + AGType + "','" + AgentAddrTB.Text.Trim() + "','" + AgentTeleNoTB.Text.Trim() + "','" + AgentNotesTB.Text.Trim() + "')";
            try
            {
                if (AgentIdTB.Text.Trim() == "")
                {
                    if (AgentNameTB.Text.Trim() != "")
                    {
                        if (meth.select_ag_data_bynam_orcode("NULL", AgentNameTB.Text.Trim(), AGType).Rows.Count <= 0)
                        {
                            con.Open();
                            SqlCommand sql = new SqlCommand(Instr, con);
                            sql.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("تم الأدخال بنجاح");
                            
                        }
                        else
                        {
                            MessageBox.Show("هذا الاسم موجود من قبل");
                        }
                        SqlCommand selectId = new SqlCommand();
                        agentBindingSource.Filter = "AgentType='" + AGType + "'";
                        agentTableAdapter.Fill(this.agentDS.Agent);
                        AgentClearBtn_Click(sender, e);
                    }
                    else
                        MessageBox.Show(" الرجاء ادخال البيانات صحيحة");
                }
                else
                {
                   if(MessageBox.Show("هذه البيانات تم حفظها من قبل هل تريد تعديلها","تحذير",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
                       AgentUpdateBtn.PerformClick();
                }
            }
            catch (Exception ex)
            {
                con.Close();
                if (ex.Message.Contains("UNIQUE KEY") || ex.Message.Contains("duplicate"))
                    MessageBox.Show("لا يمكن ادخال بيانات موجوده من قبل لكن يمكنك تعديلها ", "خطأ");
                else
                    MessageBox.Show("يجب ادخال البيانات صحيحة وبدون اى علامات", "خطأ");
            }
        }

        private void AgentBD_Load(object sender, EventArgs e)
        {
            try
            {
                AgentNameTB.Focus();
                groupPanel1.Text = "اضافة "+AgentNameLabel.Text.Substring(3,7);

                agentBindingSource.Filter = "AgentType='" + AGType + "'";
                this.agentTableAdapter.Fill(this.agentDS.Agent);
                AgentClearBtn.PerformClick();
            }
            catch { AgentClearBtn.PerformClick(); }
        }

        private void AgentUpdateBtn_Click(object sender, EventArgs e)
        {
            string Updstr;
            if (AgentTeleNoTB.Text == "")
                Updstr = "Update  Agent set AgentName='" + AgentNameTB.Text.Trim() + "',AgentAddr='" + AgentAddrTB.Text.Trim() + "',AgentNotes='" + AgentNotesTB.Text.Trim() + "' where AgentId='" + AgentIdTB.Text.Trim() + "'";
            else
                Updstr = "Update  Agent set AgentName='" + AgentNameTB.Text.Trim() + "',AgentAddr='" + AgentAddrTB.Text.Trim() + "',AgentTele='" + AgentTeleNoTB.Text.Trim() + "',AgentNotes='" + AgentNotesTB.Text.Trim() + "' where AgentId='" + AgentIdTB.Text.Trim() + "'";
            if (AgentIdTB.Text != "")
            {
                try
                {
                  //  if (meth.select_ag_data_bynam_orcode("NULL", AgentNameTB.Text.Trim(), AGType).Rows.Count <= 0)
                  //  {
                        con.Open();
                        SqlCommand sql = new SqlCommand(Updstr, con);
                        sql.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("تم التعديل بنجاح ");
                   // }
                   // else
                      //  MessageBox.Show("هذا الاسم موجود من قبل");
                    SqlCommand selectId = new SqlCommand();
                    agentBindingSource.Filter = "AgentType='" + AGType + "'";
                    agentTableAdapter.Fill(this.agentDS.Agent);
                    AgentClearBtn_Click(sender, e);
                }
                catch (Exception ex)
                {
                    con.Close();
                    if (AgentIdTB.Text == "")
                        MessageBox.Show("الرجاء اختيار العميل اوالمورد المراد تعديل بياناته");
                    else if (ex.Message.Contains("UNIQUE KEY") || ex.Message.Contains("duplicate"))
                        MessageBox.Show("لا يمكن ادخال بيانات موجوده من قبل", "خطأ");
                }
            }
            else
                MessageBox.Show("الرجاء اختيار العميل اوالمورد المراد تعديل بياناته");
        }

        private void AgentClearBtn_Click(object sender, EventArgs e)
        {
            AgentIdTB.Text = "";
            AgentNameTB.Text = "";
            AgentAddrTB.Text = "";
            AgentTeleNoTB.Text = "";
            AgentNotesTB.Text = "";
        }

        private void AgentCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string data;
            SqlDataReader reader;
            SqlCommand comm;
            try
            {
                con.Open();
                data = "select * from Agent where AgentId='" + AgentCB.SelectedValue.ToString() + "'";
                comm = new SqlCommand(data, con);
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    //agentBindingSource.Filter = "AgentId='" + AgentCB.SelectedValue+"'";
                    AgentIdTB.Text = reader["AgentId"].ToString();
                    AgentNameTB.Text = reader["AgentName"].ToString();
                    AgentAddrTB.Text = reader["AgentAddr"].ToString();
                    AgentTeleNoTB.Text = reader["AgentTele"].ToString();
                    AgentNotesTB.Text = reader["AgentNotes"].ToString();
                }
                reader.Close();
                con.Close();
            }
            catch { con.Close(); }
        }

        private void AgentTeleNoTB_TextChanged(object sender, EventArgs e)
        {
            Int64 data;
            try
            {
                data = Int64.Parse(AgentTeleNoTB.Text.Trim());
            }
            catch
            {
                if (AgentTeleNoTB.Text.Trim() != "")
                {
                    MessageBox.Show("الرجاء ادخال ارقام فقط");
                    AgentTeleNoTB.Text = "";
                }

            }
        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void AgentNameTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                AgentInsertBtn.PerformClick();
        }

        private void AgentTeleNoTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                AgentInsertBtn.PerformClick();
        }

        private void AgentAddrTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                AgentInsertBtn.PerformClick();
        }

        private void AgentNotesTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                AgentInsertBtn.PerformClick();
        }
    }
}
