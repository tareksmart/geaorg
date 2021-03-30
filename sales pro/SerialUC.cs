using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sales_pro
{
    public partial class SerialUC : UserControl
    {
        public SerialUC()
        {
            InitializeComponent();
            
        }

        private void SerialUC_Load(object sender, EventArgs e)
        {

        }
        public string testpass
        {
            get { return SerialTB.Text; }
        }
    }
}
