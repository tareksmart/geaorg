using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Data.SqlClient;
namespace sales_pro
{
    public partial class reports_screen_form : Form
    {
        public reports_screen_form()
        {
            InitializeComponent();
        }
        private methodes meth = new methodes();
        private SqlConnection connect_sal = new SqlConnection("server=.\\SQLEXPRESS;database=sales;integrated security=SSPI");
        private void reports_screen_form_Load(object sender, EventArgs e)
        {
            query_choice_cmbx.SelectedIndex = 0;
            try
            {

                mor_name_cmbx.DisplayMember = "AgentName";
                mor_name_cmbx.ValueMember = "AgentId";
                    mor_name_cmbx.DataSource=meth.select_all_mored();

                    company_cmbx.DisplayMember = "com_name";
                    company_cmbx.ValueMember = "com_id";
                    company_cmbx.DataSource = meth.select_all_company();

                    partener_cmbx.DisplayMember = "paretener_name";
                    partener_cmbx.ValueMember = "partener_id";
                    partener_cmbx.DataSource = meth.select_all_partener();

            }
            catch (Exception kk)
            {
            }

            try
            {
                grd_sanf_nam_by_tasn_bx.Items.Clear();
                grd_tasn_bx.Items.Clear();
                for (int i = 0; i < meth.select_all_tasneef().Rows.Count; i++)
                {
                    grd_sanf_nam_by_tasn_bx.Items.Add(meth.select_all_tasneef().Rows[i][1].ToString());
                    grd_tasn_bx.Items.Add(meth.select_all_tasneef().Rows[i][1].ToString());
                }
                grd_sanf_nam_by_tasn_bx.SelectedIndex = 0;
                grd_tasn_bx.SelectedIndex = 0;
            }
            catch (Exception kk)
            {
            }
        }

        private void mor_acc_rep_lnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                repoerts_form mor_rp_form = new repoerts_form();

                pay_ag_period p_mor_rp = new pay_ag_period();

               
                ParameterFields mor_params = new ParameterFields();
                //////////mor name/////////////
                ParameterField mor_name_par = new ParameterField();
                ParameterDiscreteValue mor_nam_dis = new ParameterDiscreteValue();
                mor_nam_dis.Value = 0;
                mor_name_par.Name = "mor_id";
                if (mor_name_cmbx.Text.Trim() != "")
                    mor_nam_dis.Value = meth.select_mor_by_name_or_code(mor_name_cmbx.SelectedValue.ToString(),"NULL").Rows[0][0];



                mor_name_par.CurrentValues.Add(mor_nam_dis);
                mor_params.Add(mor_name_par);
                /////////////////////////////////////////////////////choice////////
                ParameterField choice_par = new ParameterField();
                ParameterDiscreteValue choice_dis = new ParameterDiscreteValue();

                choice_par.Name = "choice_par";
                if (query_choice_cmbx.SelectedIndex == 0)
                {
                    choice_dis.Value = 1;
                }
                else
                    choice_dis.Value = 0;
               

                choice_par.CurrentValues.Add(choice_dis);
                mor_params.Add(choice_par);

                //////////////////////////////////////////////////////////////////////////////////////////////////////start date
                ParameterField mor_start_dat_par = new ParameterField();
                ParameterDiscreteValue mor_start_dat_dis = new ParameterDiscreteValue();

                mor_start_dat_par.Name = "start_date";
                mor_start_dat_dis.Value = mor_acc_start_date.Text;

                mor_start_dat_par.CurrentValues.Add(mor_start_dat_dis);
                mor_params.Add(mor_start_dat_par);
                ///////////////////////////////////////////////////////////end date//////////////
                ParameterField mor_end_dat_par = new ParameterField();
                ParameterDiscreteValue mor_end_dat_dis = new ParameterDiscreteValue();

                mor_end_dat_par.Name = "end_date";
                mor_end_dat_dis.Value = mor_acc_end_date.Text;

                mor_end_dat_par.CurrentValues.Add(mor_end_dat_dis);
                mor_params.Add(mor_end_dat_par);
                ////////////////////////////////////////////////////////////////////////////////////////
                mor_rp_form.rep_crst.ParameterFieldInfo = mor_params;
                mor_rp_form.rep_crst.ReportSource = p_mor_rp;

                mor_rp_form.ShowDialog();

            }
            catch (Exception ff)
            {
                MessageBox.Show(ff.Message + " طباعة تقرير حسابات مورد");
            }
        }

        private void grd_sanf_nam_by_tasn_bx_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            { ///////
                ////////sanf combo

                SqlCommand select_item_nam_cmd = connect_sal.CreateCommand();

                select_item_nam_cmd.CommandText = "SELECT ItemName, ItemId FROM Items WHERE CatId =" +

                  meth.select_tasn_data_bynam_orcode("NULL", grd_sanf_nam_by_tasn_bx.Text.Trim()).Rows[0][0].ToString();

                connect_sal.Open();
                SqlDataReader reader = select_item_nam_cmd.ExecuteReader();

                grd_sanf_nam_bx.Items.Clear();

                while (reader.Read())
                {
                    grd_sanf_nam_bx.Items.Add(reader[0]);

                }

                reader.Close();

                connect_sal.Close();
            }
            catch (Exception kk)
            {
                connect_sal.Close();
                MessageBox.Show("خطأ فى ادخال البيانات");
            }
        }

        private void gard_stor_rp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                repoerts_form rp_form = new repoerts_form();
                rp_form.WindowState = FormWindowState.Normal;
                grd_rp sanf_rem_rp = new grd_rp();
                ParameterFields sanf_rem_params = new ParameterFields();

                ParameterField rem_choic_par = new ParameterField();
                ParameterField rem_value_par = new ParameterField();
                ParameterField sanf_name_par = new ParameterField();


                ParameterDiscreteValue rem_choic_dis = new ParameterDiscreteValue();
                ParameterDiscreteValue rem_value_dis = new ParameterDiscreteValue();
                ParameterDiscreteValue sanf_name_dis = new ParameterDiscreteValue();
                rem_choic_dis.Value = 0;
                rem_value_dis.Value = 0;
                sanf_name_dis.Value = 0;

                rem_choic_par.Name = "remain_choic_par";
                rem_value_par.Name = "sanf_search_value";
                sanf_name_par.Name = "sanf_name_par";



                Int64 sanf_code = 0;
                if (gard_sanf_code_rdbtn.Checked && grd_sanf_cod_bx.Text.Trim()!="")//كود الصنف
                {
                   
                    rem_choic_dis.Value = 0;
                    sanf_code = Int64.Parse(grd_sanf_cod_bx.Text.Trim());
                    if (meth.select_sanf_data_by_barcode_orcode(sanf_code.ToString()).Rows.Count > 0)
                        rem_value_dis.Value = meth.select_sanf_data_by_barcode_orcode(sanf_code.ToString()).Rows[0][0].ToString();
                    else
                        MessageBox.Show("لايوجد صنف بهذا الكود");

                    grd_sanf_cod_bx.Clear();
                }
                if (gard_sanf_name_rdbtn.Checked)//اسم الصنف
                {
                    if (grd_sanf_nam_bx.Text.Trim() != "")
                    {

                        rem_choic_dis.Value = 1;
                        sanf_name_dis.Value = grd_sanf_nam_bx.Text.Trim();



                    }
                    else
                        MessageBox.Show("من فضلك ادخل اسم الصنف");
                }
                if (gard_tasn_rdbtn.Checked)//كود القسم
                {
                    if (grd_tasn_bx.Text.Trim() != "")
                    {
                        rem_choic_dis.Value = 2;
                        rem_value_dis.Value = meth.select_tasn_data_bynam_orcode("NULL",grd_tasn_bx.Text.Trim()).Rows[0][0].ToString();


                    }

                    else
                        MessageBox.Show("من فضلك ادخل التصنيف");
                }
                if (gard_all_rdbtn.Checked)//الكل
                {
                    rem_choic_dis.Value = 3;
                    rem_value_dis.Value = 0;


                }
                if (company_chbtn.Checked)//الشركه
                {
                    rem_choic_dis.Value = 4;
                    rem_value_dis.Value = company_cmbx.SelectedValue.ToString()
                        ;


                }

                rem_choic_par.CurrentValues.Add(rem_choic_dis);
                rem_value_par.CurrentValues.Add(rem_value_dis);
                sanf_name_par.CurrentValues.Add(sanf_name_dis);

                sanf_rem_params.Add(rem_choic_par);
                sanf_rem_params.Add(rem_value_par);
                sanf_rem_params.Add(sanf_name_par);


                rp_form.rep_crst.ParameterFieldInfo = sanf_rem_params;
                rp_form.rep_crst.ReportSource = sanf_rem_rp;

                sanf_rem_rp.Refresh();
                rp_form.ShowDialog();
            }
            catch (Exception ff)
            {
                MessageBox.Show(ff.Message);
            }
        }

        private void grd_sanf_cod_bx_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (meth.check_for_numreic(grd_sanf_cod_bx.Text.Trim()))
                {
                }
                else
                {
                    grd_sanf_cod_bx.Clear();
                }
            }
            catch { }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void earn_lnklbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                try
                {
                    partener_cmbx.DisplayMember = "paretener_name";
                    partener_cmbx.ValueMember = "partener_id";
                    string datelastday;
                    total_earn ec = new total_earn();
                   /// datelastday = (Int32.Parse(DateTime.Now.Day.ToString()) - 1).ToString();
                    //datelastday = datelastday + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();
                    if (earn_all_part_rdbtn.Checked)
                        ec.EarnCalcOper(earn_start_date.Text, earn_end_date.Text, "");
                    else
                        ec.EarnCalcOper(earn_start_date.Text, earn_end_date.Text, partener_cmbx.SelectedValue.ToString());

                }
                catch (Exception ff)
                {
                    MessageBox.Show(ff.Message);
                }

                repoerts_form rp_form = new repoerts_form();
                ParameterFields pars = new ParameterFields();
                earn_rp er_rp=new earn_rp();
                earn_partener_rp e_part = new earn_partener_rp();

                ParameterField start_field_par = new ParameterField();
                ParameterDiscreteValue start_dis = new ParameterDiscreteValue();
                start_field_par.Name = "start_date";
                start_dis.Value = earn_start_date.Text;
                start_field_par.CurrentValues.Add(start_dis);
                pars.Add(start_field_par);




                ParameterField end_field_par = new ParameterField();
                ParameterDiscreteValue end_dis = new ParameterDiscreteValue();
                end_field_par.Name = "end_date";
                end_dis.Value = earn_end_date.Text;
                end_field_par.CurrentValues.Add(end_dis);
                pars.Add(end_field_par);

             
                if (earn_all_part_rdbtn.Checked)
                {
                    rp_form.rep_crst.ReportSource = er_rp;

                    rp_form.rep_crst.ParameterFieldInfo = pars;
                    er_rp.Refresh();
                    rp_form.ShowDialog();
                }
                else
                {
                    ParameterField part_id_par = new ParameterField();
                    ParameterDiscreteValue part_id_dis = new ParameterDiscreteValue();
                    part_id_par.Name = "partener_name";
                    part_id_dis.Value = partener_cmbx.Text;
                    part_id_par.CurrentValues.Add(part_id_dis);
                    pars.Add(part_id_par);
                    rp_form.rep_crst.ReportSource = e_part;

                    rp_form.rep_crst.ParameterFieldInfo = pars;
                    e_part.Refresh();
                    rp_form.ShowDialog();
                }
            }
            catch(Exception ss)
            {
                MessageBox.Show(ss.Message);
            }
        }

        private void printSalesPriv1_Load(object sender, EventArgs e)
        {

        }

        private void end_warn_item_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (grd_sanf_cod_bx.Text.Trim() != "")
                {
                    if (meth.select_sanf_data_by_barcode_orcode(grd_sanf_cod_bx.Text.Trim()).Rows.Count > 0)
                    {
                        //تعديل حد المخزن للصنف
                        SqlCommand update_limit_store = connect_sal.CreateCommand();
                        update_limit_store.CommandText = "update Store set WarnLimit=0 where ItemId=" +
                           grd_sanf_cod_bx.Text.Trim();
                        connect_sal.Open();
                        update_limit_store.ExecuteNonQuery();
                        connect_sal.Close();
                        MessageBox.Show("تم");
                        grd_sanf_cod_bx.Clear();
                    }
                    else
                        MessageBox.Show("لايوجد صنف بهذا الكود");
                }
                else
                    MessageBox.Show("ادخل كود الصنف");
            }
            catch (Exception ff)
            {
                MessageBox.Show(ff.Message);
            }
        }

        private void groupPanel4_Click(object sender, EventArgs e)
        {

        }
    }
}
