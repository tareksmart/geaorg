using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace sales_pro
{
    public partial class barcode_frm : Form
    {
        public barcode_frm(string printer_name)
        {
            InitializeComponent();
            p_name = printer_name;
        }
        private string p_name = "";
        private SqlConnection connect_sal = new SqlConnection("server=.\\SQLEXPRESS;database=sales;integrated security=SSPI");
        private methodes meth = new methodes();
        private void bar_sanf_cod_bx_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Int64 sanf_code = 0;

                if (bar_sanf_cod_bx.Text.Trim() != "")
                {

                    if (meth.check_for_numreic(bar_sanf_cod_bx.Text.Trim()))
                    {
                        sanf_code = Convert.ToInt64(bar_sanf_cod_bx.Text.Trim());
                        if (meth.select_sanf_data_by_barcode_orcode(sanf_code.ToString()).Rows.Count > 0)
                        {
                            bar_sanf_cod_bx.Text = meth.select_sanf_data_by_barcode_orcode(sanf_code.ToString()).Rows[0][0].ToString();

                            bar_sanf_name_cmbx.Text = meth.select_sanf_data_by_barcode_orcode(sanf_code.ToString()).Rows[0][1].ToString();

                            bar_code_bx.Text = meth.select_sanf_data_by_barcode_orcode(sanf_code.ToString()).Rows[0][7].ToString();

                            bar_tasn_name_cmbx.Text = meth.select_tasn_data_bynam_orcode(meth.select_sanf_data_by_barcode_orcode(sanf_code.ToString()).Rows[0][8].ToString(), "NULL").Rows[0][1].ToString();


                        }
                        else
                        {
                            bar_sanf_name_cmbx.Text = "";
                          //  bar_sanf_cod_bx.Clear();
                            bar_code_bx.Clear();
                            bar_tasn_name_cmbx.Text = "";
                        }


                    }
                    else
                        bar_sanf_cod_bx.Clear();
                }
                else
                {
                    bar_sanf_name_cmbx.Text = "";
                    bar_sanf_cod_bx.Clear();
                    bar_code_bx.Clear();
                    bar_tasn_name_cmbx.Text = "";
                }
            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
            }
        }

        private void bar_tasn_name_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void bar_sanf_name_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void barcode_frm_Load(object sender, EventArgs e)
        {
            bar_type_cmbx.SelectedIndex = 0;
            /*
            try
            {
                bar_tasn_name_cmbx.Items.Clear();
                for (int i = 0; i < meth.select_all_tasneef().Rows.Count; i++)
                {
                    bar_tasn_name_cmbx.Items.Add(meth.select_all_tasneef().Rows[i][1].ToString());
                }
            }
            catch (Exception kk)
            {
            }*/
            bar_tasn_name_cmbx.ValueMember = "CatId";
            bar_tasn_name_cmbx.DisplayMember = "CatName";
            bar_tasn_name_cmbx.DataSource = meth.select_all_tasneef();
        }

        private void bar_pic_num_bx_TextChanged(object sender, EventArgs e)
        {
           
        }
        private int bar_count=0;
        private void bar_save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (  bar_pic_num_bx.Text != "")
                {
                    if (bar_type_cmbx.SelectedIndex == 0 && bar_sanf_cod_bx.Text.Trim() != "" && bar_sanf_name_cmbx.Text.Trim() != "")
                    {
                        bar_grid.Rows.Add(1);

                        bar_grid.Rows[bar_count].Cells[0].Value = bar_sanf_cod_bx.Text.Trim();

                        bar_grid.Rows[bar_count].Cells[1].Value = bar_sanf_name_cmbx.Text;//الصنف

                        bar_grid.Rows[bar_count].Cells[2].Value = bar_pic_num_bx.Text.Trim();

                        bar_count = bar_grid.Rows.Count;
                        bar_sanf_cod_bx.Clear();
                        bar_code_bx.Clear();
                        bar_tasn_name_cmbx.Text = "";
                        bar_sanf_name_cmbx.Text = "";
                    }
                    else if (bar_type_cmbx.SelectedIndex == 1 && bar_tasn_name_cmbx.Text != "")
                    {
                        if (meth.select_sanf_by_tasneef(bar_tasn_name_cmbx.Text.Trim()).Rows.Count > 0)
                        {
                            int i = 0;

                            for (i = 0; i < meth.select_sanf_by_tasn_code(bar_tasn_name_cmbx.SelectedValue.ToString()).Rows.Count; i++)
                            {

                                bar_grid.Rows.Add(1);
                                bar_grid.Rows[bar_count].Cells[0].Value = meth.select_sanf_by_tasn_code(bar_tasn_name_cmbx.SelectedValue.ToString()).Rows[i][1].ToString();
                                bar_grid.Rows[bar_count].Cells[1].Value = meth.select_sanf_by_tasn_code(bar_tasn_name_cmbx.SelectedValue.ToString()).Rows[i][0].ToString();
                                bar_grid.Rows[bar_count].Cells[2].Value = bar_pic_num_bx.Text;
                                bar_count = bar_count + 1;
                            }
                        }
                        bar_count = bar_grid.Rows.Count;
                        bar_sanf_cod_bx.Clear();
                        bar_code_bx.Clear();
                        bar_tasn_name_cmbx.Text = "";
                        bar_sanf_name_cmbx.Text = "";
                    }
                    else
                        MessageBox.Show("من  فضلك ادخل بيانات الطباعه صحيحة");
                }
                else
                    MessageBox.Show("يجب ادخال عدد الملصقات");
            }
            catch (Exception n)
            {
                MessageBox.Show(n.Message);
            }
        }

        private void show_bef_prnt_btn_Click(object sender, EventArgs e)
        {
            try
            {
               
                    SqlCommand delete_cmd = connect_sal.CreateCommand();
                    delete_cmd.CommandText = "delete from barcode_table";
                    connect_sal.Open();
                    delete_cmd.ExecuteNonQuery();
                    connect_sal.Close();


                    SqlCommand insert_bar_cmd = connect_sal.CreateCommand();
                    if (bar_grid.Rows.Count > 0)
                    {
                        string bar = "";

                        for (int i = 0; i < bar_grid.Rows.Count; i++)
                        {
                            for (int count = 0; count < Convert.ToInt32(bar_grid.Rows[i].Cells[2].Value.ToString()); count++)
                            {


                                bar = "*" + bar_grid.Rows[i].Cells[0].Value.ToString() + "*";


                                insert_bar_cmd.CommandText = "insert into barcode_table(sanf_code_b, sanf_code, price, sanf_name, qat_pric" +
                                    ")values('" + bar + "','" +
                                    bar_grid.Rows[i].Cells[0].Value.ToString() + "','" +

                                    meth.select_sanf_data_by_barcode_orcode(bar_grid.Rows[i].Cells[0].Value.ToString().Trim()).Rows[0][3].ToString() + "','" +
                                    meth.select_sanf_data_by_barcode_orcode(bar_grid.Rows[i].Cells[0].Value.ToString().Trim()).Rows[0][1].ToString() + "','" +
                                    meth.select_sanf_data_by_barcode_orcode(bar_grid.Rows[i].Cells[0].Value.ToString().Trim()).Rows[0][4].ToString() +

                                    "')";
                                connect_sal.Open();
                                insert_bar_cmd.ExecuteNonQuery();
                                connect_sal.Close();
                            }
                        }
                        if (a4_compl_rdbnt.Checked)
                        {
                            repoerts_form report_frm = new repoerts_form();
                            bar_rp br = new bar_rp();



                            report_frm.rep_crst.ReportSource = br;
                           
                            br.Refresh();
                            report_frm.rep_crst.ExportReport();
                            report_frm.ShowDialog();
                        }
                        else if (a4_splited_rdbtn.Checked)
                        {
                            repoerts_form report_frm = new repoerts_form();
                            barcode br2 = new barcode();

                            
                            
                            report_frm.rep_crst.ReportSource = br2;
                            //CrystalDecisions.Shared.ExportOptions op = new ExportOptions();
                           // op.ExportFormatOptions = CrystalDecisions.Shared.ExportOptions.CreateHTMLFormatOptions();
                           // op.ExportFormatType = CrystalDecisions.Shared.ExportFormatType.HTML40;
                            
                            br2.Refresh();
                          //  br2.Export(op); //.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.HTML40, "1");
                           

                            report_frm.ShowDialog();
                        }
                }
               
            }
            catch (Exception dd)
            {
                MessageBox.Show(dd.Message);
                connect_sal.Close();
            }
        }

        private void bar_prnt_btn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand delete_cmd = connect_sal.CreateCommand();
                delete_cmd.CommandText = "delete from barcode_table";
                connect_sal.Open();
                delete_cmd.ExecuteNonQuery();
                connect_sal.Close();


                SqlCommand insert_bar_cmd = connect_sal.CreateCommand();
                if (bar_grid.Rows.Count > 0)
                {
                    string bar = "";
                    for (int i = 0; i < bar_grid.Rows.Count; i++)
                    {
                        for (int count = 0; count < Convert.ToInt32(bar_grid.Rows[i].Cells[2].Value.ToString()); count++)
                        {

                            bar = "*0000" + bar_grid.Rows[i].Cells[0].Value.ToString() + "*";


                            insert_bar_cmd.CommandText = "insert into barcode_table(sanf_code_b, sanf_code, price, sanf_name, qat_pric" +
                                ")values('" + bar + "','" +
                                bar_grid.Rows[i].Cells[0].Value.ToString() + "','" +

                                meth.select_sanf_data_by_barcode_orcode(bar_grid.Rows[i].Cells[0].Value.ToString().Trim()).Rows[0][3].ToString() + "','" +
                                meth.select_sanf_data_by_barcode_orcode(bar_grid.Rows[i].Cells[0].Value.ToString().Trim()).Rows[0][1].ToString() + "','" +
                                meth.select_sanf_data_by_barcode_orcode(bar_grid.Rows[i].Cells[0].Value.ToString().Trim()).Rows[0][4].ToString() +

                                "')";
                            connect_sal.Open();
                            insert_bar_cmd.ExecuteNonQuery();
                            connect_sal.Close();
                        }
                    }
                    if (a4_compl_rdbnt.Checked)
                    {
                        repoerts_form report_frm = new repoerts_form();
                        bar_rp br = new bar_rp();
                        PageMargins margins;

                        // Get the PageMargins structure and set the 
                        // margins for the report.

                        margins = br.PrintOptions.PageMargins;
                        margins.bottomMargin = 0;
                        margins.leftMargin = 0;
                        margins.rightMargin = 0;
                        margins.topMargin = 0
                            ;
                        // Apply the page margins.
                        br.PrintOptions.ApplyPageMargins(margins);

                        // Select the printer.
                        br.PrintOptions.PrinterName = p_name.Trim();// "HP LaserJet Professional P1102";
                        /* PrinterSettings p_s=new PrinterSettings();
                         //p_s.PrinterName = "HP LaserJet Professional P1102";
                         p_s.PrinterName = "HP LaserJet Professional P1102";
                         PaperSize s=new PaperSize();
                  
                  
                         PageSettings ps=new PageSettings();

                       float ds=0;
                       //  ps.PaperSize.RawKind = ps.PaperSize.PaperName;
                       ds= ps.HardMarginY-1;
                      // MessageBox.Show(ds.ToString());
                         ps.Margins.Top = 0;
                         ps.Margins.Bottom = 0;
                   
                         ps.Margins.Right = 0;
                         ps.Margins.Left = 0;*/


                        //  report_frm.rep_crst.ReportSource = br;
                        br.Refresh();

                        //////////////
                        // br.PrintToPrinter(p_s,ps,false);
                        ////////////////////////
                        if (copy_n_bx.Text.Trim() != "")
                        {
                            br.PrintToPrinter(Int32.Parse(copy_n_bx.Text.Trim()), true, 1, 1);
                            bar_grid.Rows.Clear();
                        }
                        else
                            MessageBox.Show("من فضلك ادخل عدد النسخ");
                    }
                    else if (a4_splited_rdbtn.Checked)
                    {
                        repoerts_form report_frm = new repoerts_form();
                        barcode br = new barcode();
                        PageMargins margins;

                        // Get the PageMargins structure and set the 
                        // margins for the report.

                      /*  margins = br.PrintOptions.PageMargins;
                        margins.bottomMargin = 0;
                        margins.leftMargin = 0;
                        margins.rightMargin = 0;
                        margins.topMargin = 1300;
                        // Apply the page margins.
                       // br.PrintOptions.ApplyPageMargins(margins);

                        // Select the printer.
                        br.PrintOptions.PrinterName = p_name.Trim();// "HP LaserJet Professional P1102";
                     
                        br.Refresh();

                        //////////////
                        // br.PrintToPrinter(p_s,ps,false);
                        ////////////////////////
                        if (copy_n_bx.Text.Trim() != "")
                        {
                            br.PrintToPrinter(Int32.Parse(copy_n_bx.Text.Trim()), true, 1, 1);
                            bar_grid.Rows.Clear();
                        }
                        else
                            MessageBox.Show("من فضلك ادخل عدد النسخ");*/
                        br.Refresh();
                        br.ExportToDisk(ExportFormatType.PortableDocFormat, "2.pdf");

                        string path = "2.pdf"; //<- your path here.
                        if (path.EndsWith(".pdf"))
                        {
                            if (File.Exists(path))
                            {
                                ProcessStartInfo info = new ProcessStartInfo();
                                info.Verb = "open";
                               
                                info.FileName = path;
                                info.CreateNoWindow = true;
                                info.WindowStyle = ProcessWindowStyle.Hidden;
                                Process p = new Process();
                                p.StartInfo = info;
                                p.Start();
                              /*  p.WaitForInputIdle();
                                System.Threading.Thread.Sleep(6000);
                                if (false == p.CloseMainWindow())
                                    p.Kill();*/
                            }
                        }
                    }
                   
                }
            }
            catch (Exception dd)
            {
                MessageBox.Show(dd.Message);
                connect_sal.Close();
            }
           
        }

        private void bar_grid_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            bar_count = bar_grid.Rows.Count;
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void copy_n_bx_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (meth.check_for_numreic(copy_n_bx.Text.Trim()))
                {
                }
                else
                {
                    copy_n_bx.Clear();
                    copy_n_bx.Text = "1";
                }
            }
            catch { }
        }

        private void bar_type_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void bar_sanf_cod_bx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                bar_save_btn.PerformClick();
            }
        }

        private void bar_pic_num_bx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                bar_save_btn.PerformClick();
            }
        }

        private void bar_code_bx_TextChanged(object sender, EventArgs e)
        {

        }

        private void bar_tasn_name_cmbx_DropDownClosed(object sender, EventArgs e)
        {

            try
            { ///////
                ////////sanf combo

                /*  SqlCommand select_item_nam_cmd = connect_sal.CreateCommand();

                  select_item_nam_cmd.CommandText = "SELECT ItemName, ItemId FROM Items WHERE CatId =" +

                   bar_tasn_name_cmbx.SelectedValue.ToString().Trim();
                  connect_sal.Open();
                  SqlDataReader reader = select_item_nam_cmd.ExecuteReader();

                  bar_sanf_name_cmbx.Items.Clear();

                  while (reader.Read())
                  {
                      bar_sanf_name_cmbx.Items.Add(reader[0]);

                  }

                  reader.Close();

                  connect_sal.Close();*/
                bar_sanf_name_cmbx.ValueMember = "ItemId";
                bar_sanf_name_cmbx.DisplayMember = "ItemName";
                bar_sanf_name_cmbx.DataSource = meth.select_sanf_by_tasn_code(bar_tasn_name_cmbx.SelectedValue.ToString().Trim());
            }
            catch (Exception kk)
            {
                connect_sal.Close();
                MessageBox.Show("خطأ فى ادخال البيانات");
            }
        }

        private void bar_sanf_name_cmbx_DropDownClosed(object sender, EventArgs e)
        {
            try
            {


                if (bar_sanf_name_cmbx.Text != "")
                {

                    // if (meth.select_sanf_data_by_name(bar_sanf_name_cmbx.Text.Trim()).Rows.Count > 0)
                    //   {
                    bar_sanf_cod_bx.Text = bar_sanf_name_cmbx.SelectedValue.ToString();
                    bar_code_bx.Text = meth.select_sanf_data_by_barcode_orcode(bar_sanf_name_cmbx.SelectedValue.ToString()).Rows[0][7].ToString();

                    //}

                }
                else
                {

                    bar_sanf_cod_bx.Clear();
                    bar_code_bx.Clear();

                }
            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
            }
        }
    }
}
