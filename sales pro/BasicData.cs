using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace sales_pro
{
    public partial class BasicData : UserControl
    {
        SqlConnection con;
        public BasicData()
        {
             string conStr = "Data Source=.\\SQLEXPRESS;Initial Catalog=sales;Integrated Security=True";
            con=new SqlConnection(conStr);
            InitializeComponent();
          //  AddSerialPanel.Controls.Add(new SerialUC());
            //ItemSerialPanel.Controls.Add(new SerialUC());
           // ItemTabPanel.Controls.Add(new ItemBD());
            //CatTabPanl.Controls.Add(new CategoryBD());
           // AgentTabPanel.Controls.Add(new AgentBD());
            try
            {
           //     this.categoryTableAdapter.Fill(salesDataSet.Category);
            }
            catch { }
           
        }

        private void SerialAddPanel_Click(object sender, EventArgs e)
        {
            SerialUC we = new SerialUC();
            //ItemNameTB.Text = we.testpass;
        }

        private void ItemSerialPanel_Click(object sender, EventArgs e)
        {
            
        }

        private void ItemTabPanel_Click(object sender, EventArgs e)
        {
           // ItemBD IBD = new ItemBD();

        }
       /* public string testpass
        {
           // set { this.ItemNameTB.Text = value; }
        }*/
        private void BasicDataTab_Click(object sender, EventArgs e)
        {

        }
        private void buttonX3_Click(object sender, EventArgs e)
        {
            //SerialUC we = new SerialUC();
          //  ItemNameTB.Text = we.testpass;
        }

        private void CatTabPanl_Click(object sender, EventArgs e)
        {

        }

        private void AgentTabPanel_Click(object sender, EventArgs e)
        {

        }

        private void CatBtn_Click(object sender, EventArgs e)
        {
            CategoryBD SB = new CategoryBD();
            ADDpanel.Controls.Clear();
            ADDpanel.Controls.Add(SB);
            SB.Dock = DockStyle.Fill;    
        }

        private void ItemBtn_Click(object sender, EventArgs e)
        {
          /*  ItemBD SB = new ItemBD();
            ADDpanel.Controls.Clear();
            ADDpanel.Controls.Add(SB);
            SB.Dock = DockStyle.Fill; */   
        }

        private void AgentBtn_Click(object sender, EventArgs e)
        {
           AgentBD SB = new AgentBD("Ag");
            ADDpanel.Controls.Clear();
            ADDpanel.Controls.Add(SB);
            SB.Dock = DockStyle.Fill;    
        }

       
    }
}
