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
    public partial class expire_warn : Form
    {
        public expire_warn()
        {
            InitializeComponent();
        }
        private SqlConnection con = new SqlConnection("server=.\\SQLEXPRESS;database=sales;integrated security=SSPI");
        private methodes meth = new methodes();
        private void expire_warn_Load(object sender, EventArgs e)
        {
            try
            {
                int grid_row = 0;
                for (int i = 0; i < meth.expire_date_less_7().Rows.Count ;i++ )
                {
                   
                        expire_warn_grid.Rows.Add();
                        expire_warn_grid.Rows[grid_row].Cells[0].Value = meth.account_expire_date().Rows[i][2].ToString();
                        expire_warn_grid.Rows[grid_row].Cells[1].Value = meth.account_expire_date().Rows[i][1].ToString();
                        expire_warn_grid.Rows[grid_row].Cells[2].Value = meth.account_expire_date().Rows[i][3].ToString();
                        expire_warn_grid.Rows[grid_row].Cells[3].Value = meth.account_expire_date().Rows[i][5].ToString();
                        grid_row++;
                       // MessageBox.Show("!!!!يوجد اصناف صلاحيتها اقل من 7 ايام","تحذير",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    
                }
                if (expire_warn_grid.Rows.Count <= 0)
                    this.Close();
            }
            catch (Exception ff)
            {
                MessageBox.Show(ff.Message);
            }
        }
    }
}
