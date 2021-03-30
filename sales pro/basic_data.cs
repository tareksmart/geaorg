using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sales_pro
{
    public partial class basic_data : Form
    {
        public basic_data(bool check_status)
        {
            InitializeComponent();
             status = check_status;
           
        }
       // private SqlConnection connect_per = new SqlConnection("server=.\\SQLEXPRESS;database=pro;integrated security=SSPI");
       // private method_class meth = new method_class();
        private bool status;

        private void basic_data_Load(object sender, EventArgs e)
        {
            try
            {
             //   ItemBtn.PerformClick();
            }
            catch (Exception hh) { MessageBox.Show(hh.Message); }
            
        }
        private void CatBtn_Click(object sender, EventArgs e)
        {
            this.Refresh();
            CategoryBD SB = new CategoryBD();
            ADDpanel.Controls.Clear();
            ADDpanel.Controls.Add(SB);
            SB.Dock = DockStyle.Fill;
        }

        private void ItemBtn_Click(object sender, EventArgs e)
        {
           
            ItemBD SB = new ItemBD(status);
            ADDpanel.Controls.Clear();
            ADDpanel.Controls.Add(SB);
            SB.Dock = DockStyle.Fill;
        }

        private void AgentBtn_Click(object sender, EventArgs e)
        {
            AgentBD SB = new AgentBD("Ag");
            ADDpanel.Controls.Clear();
            ADDpanel.Controls.Add(SB);
            SB.Dock = DockStyle.Fill;
        }

        private void ImportBtn_Click(object sender, EventArgs e)
        {
            AgentBD SB = new AgentBD("m");
            ADDpanel.Controls.Clear();
            ADDpanel.Controls.Add(SB);
            SB.Dock = DockStyle.Fill;
        }

        private void groupPanel2_Click(object sender, EventArgs e)
        {

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comp_add_screen_Click(object sender, EventArgs e)
        {
            company_us_co cm = new company_us_co();
            ADDpanel.Controls.Clear();
            ADDpanel.Controls.Add(cm);
            cm.Dock = DockStyle.Fill;
        }

    }
}
