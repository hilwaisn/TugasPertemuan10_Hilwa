using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace TugasPertemuan10_Hilwa.Model
{
    internal class Connection
    {
        public MySqlCommand cmd;
        public DataSet ds;
        public MySqlDataAdapter da;

        public MySqlConnection GetConn()
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "server=localhost;user=root;database=store";
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {;
                MessageBox.Show("Koneksi gagal" + ex.Message);
            }
            return conn;
        }
    }
}
