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
    public partial class report2_form : Form
    {
        public report2_form()
        {
            InitializeComponent();
        }
        private methodes meth = new methodes();
        private void report2_form_Load(object sender, EventArgs e)
        {
            ag_name_cmbx.DisplayMember = "AgentName";
            ag_name_cmbx.ValueMember = "AgentId";

         
            if (meth.select_all_agent().Rows.Count > 0)
            {
                ag_name_cmbx.DataSource = meth.select_all_agent();
              
            }
            parte_cmbx.DisplayMember = "paretener_name";
            parte_cmbx.ValueMember = "partener_id";
            parte_cmbx.DataSource = meth.select_all_partener();

         

        }

        private void earn_lnklbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                repoerts_form mor_rp_form = new repoerts_form();

                pay_agent_period p_mor_rp = new pay_agent_period();


                ParameterFields mor_params = new ParameterFields();
                //////////mor name/////////////
                ParameterField mor_name_par = new ParameterField();
                ParameterDiscreteValue mor_nam_dis = new ParameterDiscreteValue();
                mor_nam_dis.Value = 0;
                mor_name_par.Name = "ag_id";
                if (ag_name_cmbx.Text.Trim() != "")
                    mor_nam_dis.Value = ag_name_cmbx.SelectedValue.ToString();



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
                mor_start_dat_dis.Value = ag_start_date.Text;

                mor_start_dat_par.CurrentValues.Add(mor_start_dat_dis);
                mor_params.Add(mor_start_dat_par);
                ///////////////////////////////////////////////////////////end date//////////////
                ParameterField mor_end_dat_par = new ParameterField();
                ParameterDiscreteValue mor_end_dat_dis = new ParameterDiscreteValue();

                mor_end_dat_par.Name = "end_date";
                mor_end_dat_dis.Value = ag_end_date.Text;

                mor_end_dat_par.CurrentValues.Add(mor_end_dat_dis);
                mor_params.Add(mor_end_dat_par);
                ////////////////////////////////////////////////////////////////////////////////////////
                mor_rp_form.rep_crst.ParameterFieldInfo = mor_params;
                mor_rp_form.rep_crst.ReportSource = p_mor_rp;

                mor_rp_form.ShowDialog();

            }
            catch (Exception ff)
            {
                MessageBox.Show(ff.Message + " طباعة تقرير حسابات عميل");
            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                repoerts_form rp_form = new repoerts_form();
                ParameterFields pars = new ParameterFields();
                spent_rep er_rp = new spent_rep();

                ParameterField start_field_par = new ParameterField();
                ParameterDiscreteValue start_dis = new ParameterDiscreteValue();
                start_field_par.Name = "start_date";
                start_dis.Value = mass_start_date.Text;
                start_field_par.CurrentValues.Add(start_dis);
                pars.Add(start_field_par);




                ParameterField end_field_par = new ParameterField();
                ParameterDiscreteValue end_dis = new ParameterDiscreteValue();
                end_field_par.Name = "end_date";
                end_dis.Value = mass_end_date.Text;
                end_field_par.CurrentValues.Add(end_dis);
                pars.Add(end_field_par);

                rp_form.rep_crst.ReportSource = er_rp;

                rp_form.rep_crst.ParameterFieldInfo = pars;
                er_rp.Refresh();
                rp_form.ShowDialog();
            }
            catch (Exception dd) { MessageBox.Show(dd.Message); }
        }
        private repoerts_form report_frm = new repoerts_form();
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                report_frm.WindowState = FormWindowState.Normal;

                grd_nawks_rp_ less_rp = new grd_nawks_rp_();
                ParameterFields less_params = new ParameterFields();



                //////////////////////////////////////////////////////////////////////////////////////////////////////less sanf num
                ParameterField less_par = new ParameterField();
                ParameterDiscreteValue less_dis = new ParameterDiscreteValue();

                less_par.Name = "sanf_num_par";
                less_dis.Value = rep_sanf_num_bx.Value;

                less_par.CurrentValues.Add(less_dis);
                less_params.Add(less_par);
                ///////////////////////////////////////////////////////////end date//////////////

                report_frm.rep_crst.ParameterFieldInfo = less_params;
                report_frm.rep_crst.ReportSource = less_rp;
                report_frm.rep_crst.Refresh();
                report_frm.ShowDialog();

            }
            catch (Exception ff)
            {
                MessageBox.Show(ff.Message + " طباعة تقرير عدد اقل");
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                repoerts_form rp_form = new repoerts_form();
                ParameterFields pars = new ParameterFields();
                mony_store er_rp = new mony_store();

                ParameterField start_field_par = new ParameterField();
                ParameterDiscreteValue start_dis = new ParameterDiscreteValue();
                start_field_par.Name = "start_date";
                start_dis.Value = s_m_start_date.Text;
                start_field_par.CurrentValues.Add(start_dis);
                pars.Add(start_field_par);




                ParameterField end_field_par = new ParameterField();
                ParameterDiscreteValue end_dis = new ParameterDiscreteValue();
                end_field_par.Name = "end_date";
                end_dis.Value = s_m_end_date.Text;
                end_field_par.CurrentValues.Add(end_dis);
                pars.Add(end_field_par);

                rp_form.rep_crst.ReportSource = er_rp;

                rp_form.rep_crst.ParameterFieldInfo = pars;
                er_rp.Refresh();
                rp_form.ShowDialog();
            }
            catch (Exception dd) { MessageBox.Show(dd.Message); }
        }

        private void sels_of_part_lnklbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                repoerts_form rp_form = new repoerts_form();
                ParameterFields pars = new ParameterFields();
                sels_partener_rep sel_par_rp = new sels_partener_rep();

                ParameterField part_id_par = new ParameterField();
                ParameterDiscreteValue part_id_dis = new ParameterDiscreteValue();
                part_id_par.Name = "parte_id";
                if (parte_cmbx.Text != "")
                    part_id_dis.Value = parte_cmbx.SelectedValue.ToString();
                else
                    part_id_dis.Value = 0;
                part_id_par.CurrentValues.Add(part_id_dis);
                pars.Add(part_id_par);

                ParameterField tas_id_par = new ParameterField();
                ParameterDiscreteValue tas_id_dis = new ParameterDiscreteValue();
                tas_id_par.Name = "tasneef_id";
                if (tasneef_cmbx.SelectedIndex>=0)
                    tas_id_dis.Value = tasneef_cmbx.SelectedValue.ToString();
                else
                    tas_id_dis.Value = 0;
                tas_id_par.CurrentValues.Add(tas_id_dis);
                pars.Add(tas_id_par);


                ParameterField type_s_par = new ParameterField();
                ParameterDiscreteValue type_s_dis = new ParameterDiscreteValue();
                type_s_par.Name = "type_of_serach";
                if (sels_part_about_cmbx.SelectedIndex == 0)
                    type_s_dis.Value = 0;
                else if(sels_part_about_cmbx.SelectedIndex == 1)
                    type_s_dis.Value = 1;
                else
                    type_s_dis.Value = 2;
                type_s_par.CurrentValues.Add(type_s_dis);
                pars.Add(type_s_par);

                ParameterField start_field_par = new ParameterField();
                ParameterDiscreteValue start_dis = new ParameterDiscreteValue();
                start_field_par.Name = "start_date";
                start_dis.Value = sels_parte_start_date.Text;
                start_field_par.CurrentValues.Add(start_dis);
                pars.Add(start_field_par);




                ParameterField end_field_par = new ParameterField();
                ParameterDiscreteValue end_dis = new ParameterDiscreteValue();
                end_field_par.Name = "end_date";
                end_dis.Value = sels_part_end_date.Text;
                end_field_par.CurrentValues.Add(end_dis);
                pars.Add(end_field_par);

                ParameterField comp_field_par = new ParameterField();
                ParameterDiscreteValue comp_dis = new ParameterDiscreteValue();
                comp_field_par.Name = "compant_par";
                if (company_cmbx.Text.Trim() != "")
                    comp_dis.Value = company_cmbx.SelectedValue.ToString();
                else
                    comp_dis.Value = "0";
                comp_field_par.CurrentValues.Add(comp_dis);
                pars.Add(comp_field_par);
                rp_form.rep_crst.ReportSource = sel_par_rp;

                rp_form.rep_crst.ParameterFieldInfo = pars;
                sel_par_rp.Refresh();
                rp_form.ShowDialog();
            }
            catch (Exception dd) { MessageBox.Show(dd.Message); }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void sels_part_about_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (sels_part_about_cmbx.SelectedIndex == 0)
                {
                    tasneef_cmbx.DisplayMember = "CatName";
                    tasneef_cmbx.ValueMember = "CatId";
                    tasneef_cmbx.DataSource = meth.select_all_tasneef();
                    tasneef_cmbx.Visible = true;
                    company_cmbx.Visible = false;

                }
                else if (sels_part_about_cmbx.SelectedIndex == 1)
                {
                    company_cmbx.DisplayMember = "com_name";
                    company_cmbx.ValueMember = "com_id";
                    company_cmbx.DataSource = meth.select_all_company();

                    tasneef_cmbx.Visible = false;
                    company_cmbx.Visible = true;
                }
                else
                {
                    tasneef_cmbx.Text ="";
                    company_cmbx.Text = "";
                }
            }
            catch (Exception dd) { MessageBox.Show(dd.Message); }
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                repoerts_form rp_form = new repoerts_form();
                ParameterFields pars = new ParameterFields();
                item_analysis i_anal_rp = new item_analysis();


                ParameterField start_field_par = new ParameterField();
                ParameterDiscreteValue start_dis = new ParameterDiscreteValue();
                start_field_par.Name = "start_date";
                start_dis.Value = anal_start_date.Text;
                start_field_par.CurrentValues.Add(start_dis);
                pars.Add(start_field_par);


                ParameterField it_id_field_par = new ParameterField();
                ParameterDiscreteValue it_id_dis = new ParameterDiscreteValue();
                it_id_field_par.Name = "item_id";
              
                    if (anal_sanf_cod_bx.Text.Trim()!="")
                        it_id_dis.Value = anal_sanf_cod_bx.Text.Trim();
                    else
                        it_id_dis.Value = 1;
               
                it_id_field_par.CurrentValues.Add(it_id_dis);
                pars.Add(it_id_field_par);




                ParameterField end_field_par = new ParameterField();
                ParameterDiscreteValue end_dis = new ParameterDiscreteValue();
                end_field_par.Name = "end_date";
                end_dis.Value = anal_end_date.Text;
                end_field_par.CurrentValues.Add(end_dis);
                pars.Add(end_field_par);

                rp_form.rep_crst.ReportSource = i_anal_rp;

                rp_form.rep_crst.ParameterFieldInfo = pars;
                i_anal_rp.Refresh();
                rp_form.ShowDialog();
            }
            catch (Exception dd) { MessageBox.Show(dd.Message); }
        }

        private void anal_sanf_cod_bx_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int.Parse(anal_sanf_cod_bx.Text.Trim());
                   
            }
            catch (Exception hh)
            {
                MessageBox.Show("ارقام فقط");
                anal_sanf_cod_bx.Clear();
            }
        }
    }
}
