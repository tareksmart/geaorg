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
    public partial class Discount_agent : Form
    {
        public Discount_agent(string ag_code, string bill)
        {
            InitializeComponent();
            bill_total = bill;
            ag_code2 = ag_code;
        }
       private string bill_total;
       private string ag_code2;
        private methodes meth = new methodes();
        private void confirm_btn_Click(object sender, EventArgs e)
        {
            try
            {
              
                if (mony_ref_ag_bx.Text.Trim() != "")
                {
                    meth.minus_mny_ag_account(ag_code2, mony_ref_ag_bx.Text.Trim());//خصم من العميل
                    MessageBox.Show("تم الخصم بنجاح");
                }

                this.Close();
            }
            catch (Exception dd)
            {
                MessageBox.Show(dd.Message);
            }
        }

        private void mony_ref_ag_bx_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (meth.check_for_numreic(mony_ref_ag_bx.Text.Trim()))
                {
                }
                else
                {
                    mony_ref_ag_bx.Clear();
                }
            }
            catch { }
        }

        private void Discount_agent_Load(object sender, EventArgs e)
        {
            mony_ref_ag_bx.Text = bill_total;
        }
    }
}
