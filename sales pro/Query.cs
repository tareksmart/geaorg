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
    public partial class Query : UserControl
    {
        public Query()
        {
            InitializeComponent();
        }

        private void AllCHB_CheckedChanged(object sender, EventArgs e)
        {
            if (AllCHB.Checked == true)
            {
                ItemsCHB.Checked = true;
                BillCHB.Checked = true;
                SalesCHB.Checked = true;
                AgentCHB.Checked = true;
            }

            if (ItemsCHB.Checked == true && BillCHB.Checked == true && SalesCHB.Checked == true && AgentCHB.Checked == true)
            {
                AllCHB.Checked = true;
            }
           

        }

        private void ItemsCHB_CheckedChanged(object sender, EventArgs e)
        {
            if (ItemsCHB.Checked == false )
            {
                AllCHB.Checked = false;
            }
            if (ItemsCHB.Checked == true && BillCHB.Checked == true && SalesCHB.Checked == true&& AgentCHB.Checked==true)
            {
                AllCHB.Checked = true;
            }
        }

        private void BillCHB_CheckedChanged(object sender, EventArgs e)
        {
            if (BillCHB.Checked == false)
            {
                AllCHB.Checked = false;
            }
            if (ItemsCHB.Checked == true && BillCHB.Checked == true && SalesCHB.Checked == true&& AgentCHB.Checked==true)
            {
                AllCHB.Checked = true;
            }
        }

        private void SalesCHB_CheckedChanged(object sender, EventArgs e)
        {
            if (SalesCHB.Checked == false)
            {
                AllCHB.Checked = false;
            }
            if (ItemsCHB.Checked == true && BillCHB.Checked == true && SalesCHB.Checked == true&& AgentCHB.Checked==true)
            {
                AllCHB.Checked = true;
            }
       
        }

        private void AgentCHB_CheckedChanged(object sender, EventArgs e)
        {
             if (AgentCHB.Checked == false)
            {
                AllCHB.Checked = false;
            }
            if (ItemsCHB.Checked == true && BillCHB.Checked == true && SalesCHB.Checked == true&& AgentCHB.Checked==true)
             AllCHB.Checked = true;
        }
        private void SearchTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
