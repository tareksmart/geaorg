using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.ReportSource;

namespace sales_pro
{
    public partial class query_stuck_bill_form : Form
    {
        public query_stuck_bill_form()
        {
            InitializeComponent();
        }
        private methodes meth = new methodes();
        
        private SqlConnection connect_sal = new SqlConnection("server=.\\SQLEXPRESS;database=sales;integrated security=SSPI");
     
        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void query_btn_Click(object sender, EventArgs e)
        {
            q_grid.DataSource = meth.select_stuck_header(last_stuck_num.Value.ToString());
        }

        private void query_stuck_bill_form_Load(object sender, EventArgs e)
        {

        }
        internal string bill_stuck_id="";
        private void q_grid_DoubleClick(object sender, EventArgs e)
        {
            if (q_grid.Rows.Count > 0)
            {
                bill_stuck_id = q_grid.CurrentRow.Cells[0].Value.ToString();
                this.Close();
            }
        }

        private void query_stuck_bill_form_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void finish_selected_btn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand update_cmd = connect_sal.CreateCommand();
                if (q_grid.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("سوف يتم انهاء كل الفواتير المعلقه  المحددة", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        for (int i = 0; i < q_grid.SelectedRows.Count; i++)
                        {
                           
                            meth.finish_stuck_bills(q_grid.SelectedRows[i].Cells[0].Value.ToString());
                        }
                        query_btn.PerformClick();
                    }
                }
            }
            catch (Exception ff)
            {
                MessageBox.Show(ff.Message);
                connect_sal.Close();
            }
        }

        private void finish_all_btn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand update_cmd = connect_sal.CreateCommand();
                if (q_grid.Rows.Count > 0)
                {
                    if (MessageBox.Show("سوف يتم انهاء كل الفواتير المعلقه  ", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        for (int i = 0; i < q_grid.Rows.Count; i++)
                        {
                           
                            meth.finish_stuck_bills(q_grid.Rows[i].Cells[0].Value.ToString());
                        }
                        query_btn.PerformClick();
                    }
                }
            }
            catch (Exception ff)
            {
                MessageBox.Show(ff.Message);
                connect_sal.Close();
            }
        }
    }
}
