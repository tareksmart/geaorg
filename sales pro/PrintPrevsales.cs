using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.ReportSource;

namespace sales_pro
{
    public partial class PrintPrevsales : Form
    {
        public PrintPrevsales()
        {
            InitializeComponent();
        }

        private void QueryBTN_Click(object sender, EventArgs e)
        {
            SalesBillCRD SalesRep = new SalesBillCRD();
            ParameterFields SalesParam = new ParameterFields();
            ParameterField BillType = new ParameterField();
            ParameterDiscreteValue BillValue = new ParameterDiscreteValue();
           
            ParameterField FromDate = new ParameterField();
            ParameterDiscreteValue FromDatevalue = new ParameterDiscreteValue();
            
            ParameterField ToDate = new ParameterField();
            ParameterDiscreteValue ToDatevalue = new ParameterDiscreteValue();
           
            ParameterField BillNo = new ParameterField();
            ParameterDiscreteValue BillNovalue = new ParameterDiscreteValue();
           
            ParameterField RbF = new ParameterField();
            ParameterDiscreteValue RbFvalue = new ParameterDiscreteValue();
          
            ParameterField BillIdP = new ParameterField();
            ParameterDiscreteValue BillIdPFvalue = new ParameterDiscreteValue();
           
            ParameterField AgentId = new ParameterField();
            ParameterDiscreteValue AgentIdvalue = new ParameterDiscreteValue();

            BillIdPFvalue.Value = 0;
           // RbFvalue.Value = 7;
            BillType.Name = "BillType";
                if (OperType.SelectedIndex == 0)
                    BillValue.Value = "'SEL'";
                else
                    BillValue.Value = "'REF'";

                BillType.CurrentValues.Add(BillValue);
                FromDate.Name = "fromDate";
                FromDatevalue.Value = FromDateTB.Text;
                ToDate.Name = "ToDate";
                ToDatevalue.Value = ToDateTB.Text;
                RbF.Name = "RbF";
                BillIdP.Name = "BillId";
                if (fat_id_rdbtn.Checked)
                {
                    if (BillIdTB.Text != "")
                        BillIdPFvalue.Value = BillIdTB.Text.Trim();
                    else
                    {
                        BillIdPFvalue.Value = 0;
                        MessageBox.Show("لايوجد رقم فاتورة سوف يتم عرض اخر فاتورة");
                    }

                }
                
                AgentId.Name = "AgentId";
                if (AgentQCB.Items.Count > 0)
                    AgentIdvalue.Value = AgentQCB.SelectedValue;
                else
                    AgentIdvalue.Value = 0;

                if (fat_id_rdbtn.Checked)
                {
                    if (BillIdTB.Text != "")
                        RbFvalue.Value = 3;
                    else
                        RbFvalue.Value = 2;
                }
                else if (DateRB.Checked == true && AgentCHB.Checked == false)
                    RbFvalue.Value = 0;
                else if (BillCounterRB.Checked == true && AgentCHB.Checked == false)
                    RbFvalue.Value = 1;
                else if (FinalBillRB.Checked == true && AgentCHB.Checked == false)
                    RbFvalue.Value = 2;
                else if (DateRB.Checked == true && AgentCHB.Checked == true)
                    RbFvalue.Value = 4;
                else if (BillCounterRB.Checked == true && AgentCHB.Checked == true)
                    RbFvalue.Value = 5;
                else if (FinalBillRB.Checked == true && AgentCHB.Checked == true)
                    RbFvalue.Value = 6;
                else
                    RbFvalue.Value = 2;
                AgentId.CurrentValues.Add(AgentIdvalue);
                BillIdP.CurrentValues.Add(BillIdPFvalue);
                FromDate.CurrentValues.Add(FromDatevalue);
                BillIdP.CurrentValues.Add(BillIdPFvalue);
                BillNo.Name = "BillNo";
                BillNovalue.Value = BillNoTB.Value;
                BillNo.CurrentValues.Add(BillNovalue);
                ToDate.CurrentValues.Add(ToDatevalue);
                RbF.CurrentValues.Add(RbFvalue);
                SalesParam.Add(BillType);
                SalesParam.Add(ToDate);
                SalesParam.Add(RbF);
                SalesParam.Add(BillIdP);
                //SalesParam.Add();
                SalesParam.Add(AgentId);
                SalesParam.Add(FromDate);
                SalesParam.Add(BillNo);
                SalesCRV.ReportSource = SalesRep;
                SalesCRV.ParameterFieldInfo = SalesParam;
            
        }

        private void PrintPrevsales_Load(object sender, EventArgs e)
        {
            try
            {
                OperType.SelectedIndex = 0;
                agentBindingSource.Filter = "AgentType='Ag'";
                agentTableAdapter.Fill(this.agentDS.Agent);
            }
            catch { }
        }

        private void BillIdTB_TextChanged(object sender, EventArgs e)
        {
            Int64 data;
            try
            {
                data = Int64.Parse(BillIdTB.Text);
            }
            catch
            {
                if (BillIdTB.Text != "")
                {
                    MessageBox.Show("الرجاء ادخال ارقام فقط");
                    BillIdTB.Text = "";
                }

            }
        }

        private void fat_id_rdbtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
