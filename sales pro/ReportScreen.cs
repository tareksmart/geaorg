using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sales_pro
{
    public partial class ReportScreen : Form
    {
        public ReportScreen()
        {
            InitializeComponent();
            PrintSalesPriv pps = new PrintSalesPriv();
            this.Controls.Add(pps);

        }

        private void ReportScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
