using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Sales_Managment
{
    // connection to database
    class Database
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LATITUDEE5440;Initial Catalog=Sales_System;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        // read data from database
        public DataTable readData(string stmt , string message)
        {
           

                DataTable tbl = new DataTable();

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = stmt;
                conn.Open();

                tbl.Load(cmd.ExecuteReader());

                conn.Close();
                 if (message!= "")
                {
                    MessageBox.Show(message, "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            return tbl; 
        }

        // insert update delete
        public bool excuteData(string stmt,string message)
        {
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = stmt;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                if (message!= "")
                {
                    MessageBox.Show(message, "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                }
                return true;

            }
            catch (Exception )
            {
                return false;
            }
            return true;
        }

    }
}
    