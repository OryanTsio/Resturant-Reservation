using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinuxOs_Project
{
    public static class StaticClass
    {
        public static int tableNum = -1;
        
        public static string phoneNumber;
        public static int costNum;
        public static DateTime date;
        public static string hour;


        public static void InitialCheck(Form form)
        {
            
            using (SqlConnection conn = new SqlConnection("server=localhost\\SQLEXPRESS;database=LynoxProject;Integrated Security=SSPI;"))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"select TableNum from Data2 where place = '{form.Text}'";
                List<Control> list = new List<Control>();
                for (int i = 0; i < form.Controls.Count; i++)
                {
                    if (form.Controls[i] is CheckBox)
                        list.Add(form.Controls[i]);
                }
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        int tableNum = int.Parse(reader["tablenum"].ToString());

                        list.Find(x => x is CheckBox &&
                        int.Parse((x as CheckBox).Text.Substring((x as CheckBox).Text.IndexOf('.') + 1)) == tableNum).Enabled = false;
                    }
                    for (int i = 0; i < form.Controls.Count; i++)
                    {
                        if (form.Controls[i] is CheckBox)
                        {
                            form.Controls.RemoveAt(i);

                        }

                    }
                    foreach (var item in list)
                    {
                        form.Controls.Add(item);
                    }

                }

            }
        }
    }
}
