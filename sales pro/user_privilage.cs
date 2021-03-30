using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class user_privilage : Form
    {
        public user_privilage()
        {
            InitializeComponent();
        }
        private methodes meth = new methodes();

        private SqlConnection connect_sal = new SqlConnection("server=.\\SQLEXPRESS;database=sales;integrated security=SSPI");
        private void user_privilage_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCommand select_user_cmd = connect_sal.CreateCommand();
                DataTable user_dtb = new DataTable();
                SqlDataAdapter user_adap = new SqlDataAdapter();
                user_adap.SelectCommand = select_user_cmd;
                select_user_cmd.CommandText = "SELECT user_name FROM user_table";
                user_adap.Fill(user_dtb);
                if (user_dtb.Rows.Count > 0)
                {
                    for (int i = 0; i < user_dtb.Rows.Count; i++)
                    {
                        user_name_cmbx.Items.Add(user_dtb.Rows[i][0].ToString());
                    }
                }
            }
            catch (Exception dd)
            {
                MessageBox.Show("من فضلك لابد من تسجيل اسماء المستخدمين اولا");
            }
        }

        private void user_name_cmbx_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            try
            {
                SqlCommand select_user_cmd =connect_sal.CreateCommand();
                DataTable user_dtb = new DataTable();
                SqlDataAdapter user_adap = new SqlDataAdapter();
                user_adap.SelectCommand = select_user_cmd;
                select_user_cmd.CommandText = "SELECT data_screen, sel_screen, wared_screen, parcode_screen, user_salahia_screen, reports_screen,"+

                    " sanf_prices_chkbx, mas_irad_screen, imp_ag_fat_screen, reports_form2, ag_account_screen, item_expire_screen" +
                    
                    " FROM user_table WHERE user_name='" + user_name_cmbx.Text.Trim() + "'";
                user_adap.Fill(user_dtb);
                if (user_dtb.Rows.Count > 0)
                {

                   

                    if (user_dtb.Rows[0][0].ToString().Trim() == "1")//بيانات اساسية
                    {
                        org_data_chbx.Checked = true;
                    }
                    else
                        org_data_chbx.Checked = false;
                    if (user_dtb.Rows[0][1].ToString().Trim() == "1")//مبيعات
                    {
                        sels_chbx.Checked = true;
                    }
                    else
                        sels_chbx.Checked = false;
                    if (user_dtb.Rows[0][2].ToString().Trim() == "1")//وارد
                    {
                        wared_chbx.Checked = true;
                    }
                    else
                        wared_chbx.Checked = false;
                    if (user_dtb.Rows[0][3].ToString().Trim() == "1")//باركود
                    {
                        parcode_chbx.Checked = true;
                    }
                    else
                        parcode_chbx.Checked = false;
                    if (user_dtb.Rows[0][7].ToString().Trim() == "1")//مصاريف وابرادات
                    {
                        mas_irad_chbx.Checked = true;
                    }
                    else
                        mas_irad_chbx.Checked = false;
                    
                    if (user_dtb.Rows[0][4].ToString().Trim() == "1")//صلاحيات
                    {
                        salahia_chkbx.Checked = true;
                    }
                    else
                        salahia_chkbx.Checked = false;
                    if (user_dtb.Rows[0][5].ToString().Trim() == "1")//تقارير
                    {
                        reports_chbx.Checked = true;
                    }
                    else
                        reports_chbx.Checked = false;
                   

                    if (user_dtb.Rows[0][6].ToString().Trim() == "1")//تغير اسعار الاصناف
                    {
                        sanf_prices_salahia_chbx.Checked = true;
                    }
                    else
                        sanf_prices_salahia_chbx.Checked = false;
                    /////////
                    

                    ////
                    if (user_dtb.Rows[0][8].ToString().Trim() == "1")//فواتير عملاء وموردين
                    {
                        imp_ag_fat_sala_chkbx.Checked = true;
                    }
                    else
                        imp_ag_fat_sala_chkbx.Checked = false;
                    
                    if (user_dtb.Rows[0][9].ToString().Trim() == "1")//فواتير عملاء وموردين
                    {
                        report2_chbx.Checked = true;
                    }
                    else
                        report2_chbx.Checked = false;


                    if (user_dtb.Rows[0][10].ToString().Trim() == "1")//حسابات عميل
                    {
                        ag_fat_sc_chbx.Checked = true;
                    }
                    else
                        ag_fat_sc_chbx.Checked = false;

                    if (user_dtb.Rows[0][11].ToString().Trim() == "1")//صلاحيات اصناف
                    {
                        item_expire_sc_chkbx.Checked = true;
                    }
                    else
                        item_expire_sc_chkbx.Checked = false;
                    ////
                   
                    ////
                    
                }


            }
            catch (Exception dd)
            {
                MessageBox.Show(dd.Message+"من فضلك تاكد من ان هذا المستخدم مسجل بقاعدة البيانات ويملك صلاحيات داخل البرنامج");
            }
        }

        private void save_p_btn_Click(object sender, System.EventArgs e)
        {
            string org = ""; string sels = ""; string wared = ""; string parcode = ""; string mas_irad = ""; string halek = ""; string salahiat = ""; string reports = "";
            string sel_price = ""; string sanf_prices = ""; string guan = ""; string imp_ag_fat = ""; string siana_sal = ""; string reports2 = "";

            string ag_fat_sc = ""; string exp_sc = "";

            if (org_data_chbx.Checked) { org = "1"; }; if (sels_chbx.Checked) { sels = "1"; }; if (wared_chbx.Checked) { wared = "1"; };

            if (parcode_chbx.Checked) { parcode = "1"; }; if (parcode_chbx.Checked) { parcode = "1"; };

            if (imp_ag_fat_sala_chkbx.Checked) { imp_ag_fat = "1"; } if (mas_irad_chbx.Checked) { mas_irad = "1"; }

           /* if (salahia_chkbx.Checked) { salahiat = "1"; }*/ if (reports_chbx.Checked) { reports = "1"; } if (sanf_prices_salahia_chbx.Checked) { sanf_prices = "1"; }

            if (report2_chbx.Checked) { reports2 = "1"; }

            if (ag_fat_sc_chbx.Checked) { ag_fat_sc = "1"; }

            if (item_expire_sc_chkbx.Checked) { exp_sc = "1"; }

            if (user_name_cmbx.Text != "")
            {
                try
                {

                    SqlCommand update_salahia_cmd =connect_sal.CreateCommand();
                    update_salahia_cmd.CommandText = "UPDATE user_table SET data_screen='" + org + "',sel_screen='" + sels + "',wared_screen='" + wared + "',parcode_screen='" +
                        parcode + "',mas_irad_screen='" + mas_irad + "',user_salahia_screen='" + salahiat + "',reports_screen='" + reports 
                        + "',sanf_prices_chkbx='" + sanf_prices

                         + "',imp_ag_fat_screen='" + imp_ag_fat + "',reports_form2='" + reports2 + "',ag_account_screen='" + ag_fat_sc.Trim() + "',item_expire_screen='" + exp_sc
                        + "' WHERE user_code=" + meth.select_user_data("NULL",user_name_cmbx.Text.Trim()).Rows[0][0].ToString();

                    connect_sal.Open();
                    update_salahia_cmd.ExecuteNonQuery();
                    connect_sal.Close();
                    MessageBox.Show("تم حفظ التعديلات");
                }
                catch (Exception ff)
                {
                    MessageBox.Show(ff.Message+"من فضلك تاكد ان هذا المستخدم مسجل بقاعدة البيانات");
                    connect_sal.Close();
                }
            }
            else
                MessageBox.Show("من فضلك اختر المستخدم المطلوب تعديل صلاحياته");
        }

        private void exit_btn_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void imp_ag_fat_sala_chkbx_CheckedChanged(object sender, System.EventArgs e)
        {

        }
    }
}
