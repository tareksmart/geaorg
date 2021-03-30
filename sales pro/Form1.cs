using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
using System.Drawing.Printing;
using System.Runtime.InteropServices;


namespace sales_pro
{
    public partial class Form1 : Form
    {
        splash_screen s_sc;
        public Form1()
        {
           
            InitializeComponent();
           
        }




        private SqlConnection connect_sal = new SqlConnection("server=.\\SQLEXPRESS;database=sales;integrated security=SSPI");
        private methodes meth = new methodes();
        private bool check_status;
        private void buttonX1_Click_1(object sender, EventArgs e)
        {
           
            basic_data basic_data_form = new basic_data(check_status);
            basic_data_form.Show();
            basic_data_form.Dock = DockStyle.Fill;

            basic_data_form.MdiParent = this;
            basic_data_form.BringToFront();

            face_panel.SendToBack();
        }

        private void wared_screen_btn_Click(object sender, EventArgs e)
        {

            wared_screen_form wared_data_form = new wared_screen_form(check_status);
            wared_data_form.Show();
            wared_data_form.Dock = DockStyle.Fill;

            wared_data_form.MdiParent = this;
            wared_data_form.BringToFront();

            face_panel.SendToBack();

        }
        private void listAllPrinters()
        {
            foreach (var item in PrinterSettings.InstalledPrinters)
            {
                this.print_type_cmbx.Items.Add(item.ToString());
            }
        }
        private static class myPrinters//dafault printetr
        {
            [DllImport("winspool.drv", CharSet = CharSet.Auto, SetLastError = true)]
            public static extern bool SetDefaultPrinter(string Name);

        }
        private log_in_frm lg = new log_in_frm();
        private expire_warn ex_w_form = new expire_warn();
        private void Form1_Load(object sender, EventArgs e)
        {
           
            int i = 0;
            Thread t = new Thread(new ThreadStart(startThread));
            t.Start();
            this.Hide();
           
            listAllPrinters();//سحب الطابعات المصطبة
            if (print_type_cmbx.Items.Count > 0)
                print_type_cmbx.SelectedIndex = 0;
            meth.check_periorty();

           // store_sanf_alarm(0);
            while (i <1000)
            {
                i++;
                label1.Text = i.ToString();
                
            }
           if (i >= 1000/*&&ex_w_form.ShowDialog()!=null*/)
            {
                t.Abort();
               if(meth.expire_date_less_7().Rows.Count>0)
                   MessageBox.Show("!!!!يوجد اصناف صلاحيتها اقل من 7 ايام", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               //lg.ShowDialog();
                user_btn.Text = lg.user_name_var;
                sal();//صلاحيات
               // meth.test_pro();
              
              
               
                try
                {
                    this.Show();
                }
                catch { }
              
            }
          
           
          
           
           
           
          
        }
        public void startThread()
        {
            try
            {
                s_sc = new splash_screen();
                s_sc.ShowDialog();
                Application.Run(s_sc);
            }
            catch { }
        }
        private void Form1_MdiChildActivate(object sender, EventArgs e)
        {
            face_panel.BringToFront();
        }

        private void sales_fat_btn_Click(object sender, EventArgs e)
        {
            sales_fat sal_form = new sales_fat(print_type_cmbx.Text.Trim(),check_status);
            sal_form.Show();
            sal_form.Dock = DockStyle.Fill;
            sal_form.MdiParent = this;
            sal_form.BringToFront();
            face_panel.SendToBack();
        }

        private void barcode_screen_btn_Click(object sender, EventArgs e)
        {
            barcode_frm bar_frm = new barcode_frm(print_type_cmbx.Text.Trim());
            bar_frm.Show();
            bar_frm.Dock = DockStyle.Fill;
            bar_frm.MdiParent = this;
            bar_frm.BringToFront();
            face_panel.SendToBack();
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            morred_account_form mor_frm = new morred_account_form();
            mor_frm.Show();
            mor_frm.Dock = DockStyle.Fill;
            mor_frm.MdiParent = this;
            mor_frm.BringToFront();
            face_panel.SendToBack();
        }

        private void spent_screen_btn_Click(object sender, EventArgs e)
        {
            spent_form s_frm = new spent_form();
            s_frm.Show();
            s_frm.Dock = DockStyle.Fill;
            s_frm.MdiParent = this;
            s_frm.BringToFront();
            face_panel.SendToBack();
        }

        private void user_screen_btn_Click(object sender, EventArgs e)
        {
            user_privilage us_p = new user_privilage();
            us_p.Show();
            us_p.Dock = DockStyle.Fill;
            us_p.MdiParent = this;
            us_p.BringToFront();
            face_panel.SendToBack();
        }

        private void reports_screen_btn_Click(object sender, EventArgs e)
        {
            reports_screen_form rep_frm = new reports_screen_form();
            rep_frm.Show();
            rep_frm.Dock = DockStyle.Fill;
            rep_frm.MdiParent = this;
            rep_frm.BringToFront();
            face_panel.SendToBack();
        }
        /// <summary>
        /// دالة تحمل كل النواقص من المخزن
        /// </summary>
        /// <returns></returns>
        private DataTable less_store_sanf()
        {
            DataTable stor_dtb = new DataTable();
            try
            {
              
                
                SqlCommand select_store = connect_sal.CreateCommand();
                SqlDataAdapter store_adap = new SqlDataAdapter();
               
                store_adap.SelectCommand = select_store;
                select_store.CommandText = "SELECT ItemQuantity, ItemId, WarnLimit FROM Store where ItemQuantity<=WarnLimit";
                store_adap.Fill(stor_dtb);
               
            }
            catch (Exception dd)
            {
                MessageBox.Show(dd.Message + " خطا فى ادخال البيانات");
            }
            return stor_dtb;
        }
        private void store_sanf_alarm(int z=0)
        {
            try
            {
                double sanf_num = 0;
                string messag = "";
                int done = 0;

               
                if (less_store_sanf().Rows.Count > z)
                {
                    messag = " الصنف:" + meth.select_sanf_data_by_barcode_orcode(less_store_sanf().Rows[z][1].ToString()).Rows[0][1].ToString() + "   العددالمتبقى  " +
                          less_store_sanf().Rows[z][0].ToString() + " ** ";
                    //  done = 1;

                    store_alarm_lbl.Text = messag;
                    //  if (done == 0)
                    //  store_alarm_lbl.Text = "";
                    // break;
                }

                else
                {
                    i = -1;//لما كان بصفر يروح يزود1 فياخد من 1 مش من صفر فى less_dtb
                    z = 0;
                }
               // }
            }
            catch (Exception dd)
            {
                //MessageBox.Show(dd.Message+" خطا فى ادخال البيانات");
            }
        }
        private Point x_coor = new Point();
       
        private int counter_timer = 0;
        private int i = 0;
        private void store_alarm_tmr_Tick(object sender, EventArgs e)
        {
            try
            {
               // store_sanf_alarm();
               /* if (store_alarm_lbl.Text != "")
                {
                  
                    store_alarm_lbl.Visible=true;

                    store_alarm_tmr.Enabled = true;
                    store_alarm_tmr.Start();
                    x_coor.X += 10;
                    x_coor.Y = 1;
                   
                   
                    store_alarm_lbl.Location = x_coor ;
                   
                    if (x_coor.X >= 1500)
                    {
                        //MessageBox.Show(x_coor.X.ToString());
                        store_alarm_lbl.Visible=false;
                       
                        
                         
                           // MessageBox.Show(i.ToString());
                        
                        x_coor.X = 1-store_alarm_lbl.Width;//-3000;
                       
                    }
                    
                }*/
                tim_btn.Text = DateTime.Now.ToString("hh:mm:ss tt");
                date_btn.Text = DateTime.Now.ToShortDateString();


            }
            catch (Exception dd)
            {
                //MessageBox.Show(" خطا فى ادخال البيانات");
            }
        }

        private void refresh_bnt_Click(object sender, EventArgs e)
        {
           
        }

        private void tim_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DateTime.Now.Hour.ToString());
        }

        private void backup_timer_Tick(object sender, EventArgs e)
        {

        }
        private int counter_timer2 = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            if (DateTime.Now.Hour == 18 && DateTime.Now.Minute == 0 && DateTime.Now.Second == 0)
            {
                //timer1.Stop();
                if (MessageBox.Show("سوف يتم عمل نسخة احتياطية لقاعدة البيانات", "Backup database", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                   
                    meth.backup_database();
                   // timer1.Start();
                }
            }


        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("سوف يتم عمل نسخة احتياطية لقاعدة البيانات", "Backup database", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                meth.backup_database();
            }
        }

        private void start_timr_Tick(object sender, EventArgs e)
        {
           
            store_sanf_alarm(i);
            store_alarm_lbl.Refresh();
            i++;
           // MessageBox.Show(i.ToString());
        }

        private void sal()
        {
            //////////////////////////////////////
            ///////////////////////////////////////////////////////////تظبيط الصلاحيات///////////////////////////
            try
            {

                SqlCommand select_user_cmd = connect_sal.CreateCommand();
                DataTable user_dtb2 = new DataTable();
                SqlDataAdapter user_adap = new SqlDataAdapter();
                user_adap.SelectCommand = select_user_cmd;

                select_user_cmd.CommandText = "SELECT data_screen, sel_screen, wared_screen, parcode_screen, " +
                    "user_salahia_screen, reports_screen, sanf_prices_chkbx, mas_irad_screen, imp_ag_fat_screen, reports_form2, ag_account_screen, item_expire_screen" +
                    " FROM user_table WHERE user_name='" + user_btn.Text.Trim() + "'";

                user_adap.Fill(user_dtb2);

                if (user_dtb2.Rows.Count > 0)
                {



                    if (user_dtb2.Rows[0][0].ToString().Trim() == "1")//بيانات اساسية
                    {
                        buttonX1.Enabled = true;
                    }
                    else
                        buttonX1.Enabled = false;
                    if (user_dtb2.Rows[0][1].ToString().Trim() == "1")//مبيعات
                    {
                        sales_fat_btn.Enabled = true;
                    }
                    else
                        sales_fat_btn.Enabled = false;
                    if (user_dtb2.Rows[0][2].ToString().Trim() == "1")//وارد
                    {
                        wared_screen_btn.Enabled = true;
                    }
                    else
                        wared_screen_btn.Enabled = false;
                    if (user_dtb2.Rows[0][3].ToString().Trim() == "1")//باركود
                    {
                        barcode_screen_btn.Enabled = true;
                    }
                    else
                        barcode_screen_btn.Enabled = false;
                    if (user_dtb2.Rows[0][4].ToString().Trim() == "1")//صلاحية مستخدمين
                    {
                        user_screen_btn.Enabled = true;
                    }
                    else
                        user_screen_btn.Enabled = false;
                    if (user_dtb2.Rows[0][5].ToString().Trim() == "1")//تقارير
                    {
                        reports_screen_btn.Enabled = true;
                    }
                    else
                        reports_screen_btn.Enabled = false;

                  
                    if (user_dtb2.Rows[0][6].ToString().Trim() == "1")//اسعار الصنف
                    {
                        check_status = true;
                       // MessageBox.Show(check_status.ToString());
                    }
                    else
                        check_status = false;
                    if (user_dtb2.Rows[0][7].ToString().Trim() == "1")//مصاريف
                    {
                        spent_screen_btn.Enabled = true;

                    }
                    else
                    {
                        spent_screen_btn.Enabled = false;
                    }

                    if (user_dtb2.Rows[0][8].ToString().Trim() == "1")//حسابات مورد
                    {
                        buttonX5.Enabled = true;
                    }
                    else
                        buttonX5.Enabled = false;

                    if (user_dtb2.Rows[0][9].ToString().Trim() == "1")//تقارير2
                    {
                        reports_screen2_btn.Enabled = true;
                    }
                    else
                        reports_screen2_btn.Enabled = false;

                    if (user_dtb2.Rows[0][10].ToString().Trim() == "1")//حسابات عميل
                    {
                        buttonX4.Enabled = true;
                    }
                    else
                        buttonX4.Enabled = false;

                    if (user_dtb2.Rows[0][11].ToString().Trim() == "1")//صلاحيات اصناف
                    {
                        expire_date_btn.Enabled = true;
                    }
                    else
                        expire_date_btn.Enabled = false;


                }


            }
            catch (Exception dd)
            {
                MessageBox.Show(" من فضلك تأكد من ان هذا المستخدم له صلاحيات داخل البرنامج");
            }


            //////////////////////////////////////////////////////////////////////////////////////

        }
       

        private void checkBoxX1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                string datelastday;
                EarnCalc ec = new EarnCalc();
                datelastday = (Int32.Parse(DateTime.Now.Day.ToString()) - 1).ToString();
                datelastday = datelastday + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();
               // ec.EarnCalcOper(datelastday);
               // ec.EarnCalcOper(DateTime.Now.ToShortDateString());
            }
            catch { }

        }

        private void repor_Click(object sender, EventArgs e)
        {
            ReportScreen rep = new ReportScreen();
            rep.Show();
            rep.Dock = DockStyle.Fill;
            rep.MdiParent = this;
            rep.BringToFront();
            face_panel.SendToBack();
        }

        private void print_type_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pname = this.print_type_cmbx.SelectedItem.ToString();
            myPrinters.SetDefaultPrinter(pname);
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            x_coor.X = -400;
            wait_lbl.Text = "....برجاء الانتظار";
            store_sanf_alarm(0);

            wait_lbl.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            ag_acc_frm ag_frm = new ag_acc_frm();
            ag_frm.Show();
            ag_frm.Dock = DockStyle.Fill;
            ag_frm.MdiParent = this;
            ag_frm.BringToFront();
            face_panel.SendToBack();

          
        }

        private void reports_screen2_btn_Click(object sender, EventArgs e)
        {
            report2_form rep_frm = new report2_form();
            rep_frm.Show();
            rep_frm.Dock = DockStyle.Fill;
            rep_frm.MdiParent = this;
            rep_frm.BringToFront();
            face_panel.SendToBack();
        }

        private void expire_date_btn_Click(object sender, EventArgs e)
        {
            expir_query_frm rep_frm = new expir_query_frm();
            rep_frm.Show();
            rep_frm.Dock = DockStyle.Fill;
            rep_frm.MdiParent = this;
            rep_frm.BringToFront();
            face_panel.SendToBack();
        }

        private void storeScBtn_Click(object sender, EventArgs e)
        {
            storeForm rep_frm = new storeForm(check_status, user_btn.Text);
            rep_frm.Show();
            rep_frm.Dock = DockStyle.Fill;
            rep_frm.MdiParent = this;
            rep_frm.BringToFront();
            face_panel.SendToBack();
        }
        
        ///////////////////////////////////////////////////////checkBoxX1
    }
}

