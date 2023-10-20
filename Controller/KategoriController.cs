using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasPertemuan10_Hilwa.Controller
{
    internal class KategoriController:Model.Connection
    {
        public DataTable tampilKategori()
        {
            DataTable data = new DataTable();
            try
            {
                string tampil = "SELECT * FROM kategori";
                da = new MySqlConnector.MySqlDataAdapter(tampil, GetConn());
                da.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }
    }
}
