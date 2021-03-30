using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace sales_pro
{
    public partial class update_expire_date_form : Form
    {
        public update_expire_date_form()
        {
            InitializeComponent();
        }
        private methodes meth = new methodes();

        private SqlConnection connect_sal = new SqlConnection("server=.\\SQLEXPRESS;database=sales;integrated security=SSPI");
        private void update_expire_date_form_Load(object sender, EventArgs e)
        {
            company_us_co com = new company_us_co();
            panelEx1.Controls.Clear();
            panelEx1.Controls.Add(com);
            com.Dock = DockStyle.Fill;
        }
    }
}
