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
    public partial class Print : Form
    {
        int billId;
        public Print(int BillId)
        {
            billId = BillId;
            InitializeComponent();
        }

        private void Print_Load(object sender, EventArgs e)
        {
            try
            {
                SalesBillCRD SalesRep = new SalesBillCRD();

                SalesSmallBillCRD SaleSmallRep = new SalesSmallBillCRD();

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
                BillType.Name = "BillType";
                BillValue.Value = "'SEL'";
                AgentId.Name = "AgentId";
                AgentIdvalue.Value = 0;
                SalesParam.Add(AgentId);
                AgentId.CurrentValues.Add(AgentIdvalue);
                BillType.CurrentValues.Add(BillValue);
                SalesParam.Add(BillType);
                FromDate.Name = "fromDate";
                FromDatevalue.Value = DateTime.Now;
                ToDate.Name = "ToDate";
                ToDatevalue.Value = DateTime.Now;
                RbF.Name = "RbF";
                RbFvalue.Value = 2;
                if (billId != 0)
                    RbFvalue.Value = 3;
                else
                    RbFvalue.Value = 2;
                BillIdP.Name = "BillId";
                BillIdPFvalue.Value = billId;
                SalesParam.Add(BillIdP);
                BillIdP.CurrentValues.Add(BillIdPFvalue);
                FromDate.CurrentValues.Add(FromDatevalue);
                SalesParam.Add(FromDate);
                ToDate.CurrentValues.Add(ToDatevalue);
                SalesParam.Add(ToDate);
                RbF.CurrentValues.Add(RbFvalue);
                SalesParam.Add(RbF);
                SalesParam.Add(BillIdP);
                BillIdP.CurrentValues.Add(BillIdPFvalue);
                BillNo.Name = "BillNo";
                BillNovalue.Value = 3;
                BillNo.CurrentValues.Add(BillNovalue);
                SalesParam.Add(BillNo);
               
                    SalesCRV.ReportSource = SalesRep;
                
                    SalesCRV.ParameterFieldInfo = SalesParam;
                
            }
            catch (Exception hh)
            {
                MessageBox.Show(hh.Message);
            }


        }
    }
}
