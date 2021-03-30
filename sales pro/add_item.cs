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
    public partial class add_item : Form
    {
        public add_item(bool check_status)
        {
            InitializeComponent();
            status = check_status;
        }
        private bool status;
        private void add_item_Load(object sender, EventArgs e)
        {
            ItemBD SB = new ItemBD(status);
            ADDpanel.Controls.Clear();
            ADDpanel.Controls.Add(SB);
            SB.Dock = DockStyle.Fill;
        }
    }
}
