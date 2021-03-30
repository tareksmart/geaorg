using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace sales_pro
{
    class method_class
    {
        private SqlConnection connect_per = new SqlConnection("server=.\\SQLEXPRESS;database=pro;integrated security=SSPI");
        public bool check_for_qutatin(string str)//فحص العلامات فى مدخلات ال strings
        {
            bool state = true;

           if (str.Contains("!")) state = false;
            if (str.Contains(";")) state = false;
            if (str.Contains("'")) state = false;
            if (str.Contains("@")) state = false;
            if (str.Contains("#")) state = false;
            if (str.Contains("$")) state = false;
            if (str.Contains("^")) state = false;
            if (str.Contains("%")) state = false;
            if (str.Contains("*")) state = false;
            if (str.Contains("_")) state = false;
            if (str.Contains("-")) state = false;
            if (str.Contains("+")) state = false;
            if (str.Contains("&")) state = false;
            if (str.Contains("?")) state = false;
            if (str.Contains("^")) state = false;
            if (str.Contains(")")) state = false;
            if (str.Contains("(")) state = false;
            if (str.Contains("}")) state = false;
            if (str.Contains("{")) state = false;
            if (str.Contains(":")) state = false;
            if (str.Contains("<")) state = false;
            if (str.Contains(">")) state = false;
            if (str.Contains(",")) state = false;
            if (str.Contains("\"")) state = false;
            if (str.Trim().Substring(0,1).GetHashCode()==(-842352775)) state = false;
           
          



            if (state == false)
            {
                MessageBox.Show("يجب ان تكون البيانات مدخلة بدون اى علامات");
                state = false;
            }
            return state;
        }
        public bool check_for_numreic(string number)//فحص بيانات رقمية
        {
            bool state = true;
            try
            {
                Convert.ToDouble(number);
            }
            catch (Exception dd)
            {
                throw new Exception("يجب ان تكون البيانات المدخله رقمية");
                state = false;
            }
            return state;
        }

        public DataTable select_tasn_data_bynam_orcode(string tas_code, string tas_nam)//سحب بيانات تصنيف بالاسم او بالكود
        {
            DataTable tas_data_dtb = new DataTable();

            try
            {
                SqlCommand tas_data_cmd = connect_per.CreateCommand();
                SqlDataAdapter tasn_adap = new SqlDataAdapter();

                tasn_adap.SelectCommand = tas_data_cmd;
                tas_data_cmd.CommandText = "SELECT sanf_dep_code,sanf_dep_name,notes FROM sanf_dep_table WHERE sanf_dep_code =" +

                   tas_code + " OR sanf_dep_name LIKE '" + tas_nam + "'";

                tasn_adap.Fill(tas_data_dtb);

            }
            catch (Exception rr)
            {
                throw new Exception(rr.Message);
            }
            return tas_data_dtb;
        }
    }
}
