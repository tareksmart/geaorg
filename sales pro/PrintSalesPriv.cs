using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.ReportSource;
using CrystalDecisions.CrystalReports;
using System.Data.SqlClient;

namespace sales_pro
{
    public partial class PrintSalesPriv : UserControl
    {
        public PrintSalesPriv()
        {
           
            InitializeComponent();
        }
        private methodes meth = new methodes();
        private SqlConnection connect_sal = new SqlConnection("server=.\\SQLEXPRESS;database=sales;integrated security=SSPI");
        private void PrintSalesPriv_Load(object sender, EventArgs e)
        {
            try
            {
                categoryTableAdapter.Fill(this.salesDataSet.Category);
                itemsTableAdapter.Fill(this.itemsTADS.Items);
                this.agentBindingSource.Filter = "AgentType='Ag'";
                agentTableAdapter.Fill(this.agentDS.Agent);

            }
            catch { }
            try
            {
                OperTypeCB.SelectedIndex = 0;
               // sel_sanf_nam_by_tasn_bx.Items.Clear();
                sel_sanf_nam_by_tasn_bx.Items.Clear();
                //sel_sanf_nam_by_tasn_bx
                for (int i = 0; i < meth.select_all_tasneef().Rows.Count; i++)
                {
                   // sel_sanf_nam_by_tasn_bx.Items.Add(meth.select_all_tasneef().Rows[i][1].ToString());
                    sel_sanf_nam_by_tasn_bx.Items.Add(meth.select_all_tasneef().Rows[i][1].ToString());
                }
               // sel_sanf_nam_by_tasn_bx.SelectedIndex = 0;
                sel_sanf_nam_by_tasn_bx.SelectedIndex = 0;
            }
            catch (Exception kk)
            {
            }
        }

        private void DateRB_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        public string GetDate(string Indate)
        {
            string day, month, year;
            string outDate = "";
            try
            {
                day = (DateTime.Parse(Indate).Day).ToString();
                month = (DateTime.Parse(Indate).Month).ToString();
                year = (DateTime.Parse(Indate).Year).ToString();
                outDate = month + "/" + day + "/" + year;
                return outDate;
            }
            catch { return outDate; }

        }

        private void QueryBTN_Click(object sender, EventArgs e)
        {
            repoerts_form RForm = new repoerts_form();
            SalesCR SalesRep = new SalesCR();
            ParameterFields SalesParam = new ParameterFields();
            ParameterField FromDate = new ParameterField();
            ParameterDiscreteValue FromDatevalue = new ParameterDiscreteValue();
            ParameterField ToDate = new ParameterField();
            ParameterDiscreteValue ToDatevalue = new ParameterDiscreteValue();
            ParameterField CatId = new ParameterField();
            ParameterDiscreteValue CatIdValue = new ParameterDiscreteValue();
            ParameterField RbF = new ParameterField();
            ParameterDiscreteValue RbFvalue = new ParameterDiscreteValue();
            ParameterField AgentId = new ParameterField();
            ParameterDiscreteValue AgentIdvalue = new ParameterDiscreteValue();
            ParameterField ItemId = new ParameterField();
            ParameterDiscreteValue ItemIdvalue = new ParameterDiscreteValue();
            ParameterField OperType = new ParameterField();
            ParameterDiscreteValue OperTypevalue = new ParameterDiscreteValue();

            ParameterField op_type = new ParameterField();
            ParameterDiscreteValue op_dis = new ParameterDiscreteValue();
            op_type.Name = "op_type";
            op_type.CurrentValues.Add(op_dis);
            op_dis.Value = OperTypeCB.Text;
            {
                FromDate.Name = "fromDate";
                FromDatevalue.Value = FromDateTB.Text;
                ToDate.Name = "ToDate";
                ToDatevalue.Value = ToDateTB.Text;
                ItemId.Name = "ItemId";
                RbF.Name = "RbF";
                AgentId.Name = "AgentId";
                CatId.Name = "CatId";
                OperType.Name = "OperType";
                OperTypevalue.Value = "'SEL'";
                if (OperTypeCB.SelectedIndex == 1)
                    OperTypevalue.Value = "'REF'";
                CatIdValue.Value = 0;
                AgentIdvalue.Value = 0;
                if (CategoryCB.Text.Trim() != "")
                    CatIdValue.Value = CategoryCB.SelectedValue;
                if (AgentQCB.Text.Trim() != "")
                    AgentIdvalue.Value = AgentQCB.SelectedValue;

                ItemIdvalue.Value = 0;
               // RbFvalue.Value = 6;
                if (ItemIdTB.Text != "" && sel_rp_cod_rdbtn.Checked)
                    ItemIdvalue.Value = ItemIdTB.Text;
                else if (ItemCB.Text != "" && ItemRB.Checked)
                    ItemIdvalue.Value = meth.select_sanf_data_by_name(ItemCB.Text.Trim()).Rows[0][0] ;

                if (sel_rp_cod_rdbtn.Checked == true && AgentCHB.Checked == false)
                    RbFvalue.Value = 0;
                else if (sel_rp_cod_rdbtn.Checked == true && AgentCHB.Checked == true)
                    RbFvalue.Value = 1;


                


                if (ItemRB.Checked == true && AgentCHB.Checked == false)
                    RbFvalue.Value = 0;
                else if (ItemRB.Checked == true && AgentCHB.Checked == true)
                    RbFvalue.Value = 1;
                else if (CatRB.Checked == true && AgentCHB.Checked == false)
                    RbFvalue.Value = 2;
                else if (CatRB.Checked == true && AgentCHB.Checked == true)
                    RbFvalue.Value = 3;
                else if (AllRB.Checked == true && AgentCHB.Checked == false)
                    RbFvalue.Value = 4;
                else if (AllRB.Checked == true && AgentCHB.Checked == true)
                    RbFvalue.Value = 5;
                AgentId.CurrentValues.Add(AgentIdvalue);
                FromDate.CurrentValues.Add(FromDatevalue);
                ToDate.CurrentValues.Add(ToDatevalue);
                ItemId.CurrentValues.Add(ItemIdvalue);
                RbF.CurrentValues.Add(RbFvalue);
                CatId.CurrentValues.Add(CatIdValue);
                OperType.CurrentValues.Add(OperTypevalue);
                SalesParam.Add(ToDate);
                SalesParam.Add(OperType);
                SalesParam.Add(RbF);
                SalesParam.Add(AgentId);
                SalesParam.Add(FromDate);
                SalesParam.Add(ItemId);
                SalesParam.Add(CatId);
                SalesParam.Add(op_type);

                RForm.rep_crst.ReportSource = SalesRep;
                RForm.rep_crst.ParameterFieldInfo = SalesParam;
                RForm.Show();
                RForm.Dock = DockStyle.Fill;
            }

        }

        private void ItemIdTB_TextChanged(object sender, EventArgs e)
        {
            Int64 data;
            try
            {
                data = Int64.Parse(ItemIdTB.Text);
            }
            catch
            {
                if (ItemIdTB.Text != "")
                {
                    MessageBox.Show("الرجاء ادخال ارقام فقط");
                    ItemIdTB.Text = "";
                }

            }
        }

        private void OperTypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AllRB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ItemCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CategoryCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void AgentCHB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ItemRB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ToDateTB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CatRB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AgentQCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FromDateTB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void sel_sanf_nam_by_tasn_bx_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            { ///////
                ////////sanf combo

                SqlCommand select_item_nam_cmd = connect_sal.CreateCommand();

                select_item_nam_cmd.CommandText = "SELECT ItemName, ItemId FROM Items WHERE CatId =" +

                  meth.select_tasn_data_bynam_orcode("NULL", sel_sanf_nam_by_tasn_bx.Text.Trim()).Rows[0][0].ToString();

                connect_sal.Open();
                SqlDataReader reader = select_item_nam_cmd.ExecuteReader();

                ItemCB.Items.Clear();

                while (reader.Read())
                {
                    ItemCB.Items.Add(reader[0]);

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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
