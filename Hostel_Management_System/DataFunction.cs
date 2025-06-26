using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Management_System
{
    internal class DataFunction
    {
        
        protected SqlConnection getConnection()
        {
           
            SqlConnection con = new SqlConnection();

            
            con.ConnectionString = "data source=WIN11\\SQLEXPRESS;database=HMS;Integrated Security=True";

            // Returns the configured SqlConnection object.
            // This object can then be used to open a connection, execute commands, and close the connection.
            return con;
        }

        
        public DataSet getData(String query)
        {
            
            SqlConnection con = getConnection();

           
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;

            
            cmd.CommandText = query;

            
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            
            DataSet ds = new DataSet();

            
            da.Fill(ds);

            
            return ds;
        }

        public void setData(String query, String msg)
        {
          
            SqlConnection con = getConnection();

           
            SqlCommand cmd = new SqlCommand();

           
            cmd.Connection = con;

            
            con.Open();

           
            cmd.CommandText = query;

            
            cmd.ExecuteNonQuery();

           
            con.Close();

           
            MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public string Count(string query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            string count = cmd.ExecuteScalar().ToString();
            con.Close();
            return count;
        }
    }
}
