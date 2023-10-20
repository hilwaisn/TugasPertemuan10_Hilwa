using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TugasPertemuan10_Hilwa.Controller;

namespace TugasPertemuan10_Hilwa
{
    public partial class store : Form
    {
        private SupplierController supcontroller;
        private KategoriController katcontroller;
        private PelangganController pelcontroller;
        private ProdukController procontroller;

        public store()
        {
            supcontroller = new SupplierController();
            katcontroller = new KategoriController();
            pelcontroller = new PelangganController();  
            procontroller = new ProdukController();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //refresh();
        }
        public void supplier()
        {
            dataStore.DataSource = supcontroller.tampilSupplier();
            dataStore.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void kategori()
        {
            dataStore.DataSource = supcontroller.tampilKategori();
            dataStore.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void pelanggan()
        {
            dataStore.DataSource = supcontroller.tampilPelanggan();
            dataStore.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void produk()
        {
            dataStore.DataSource = supcontroller.tampilProduk();
            dataStore.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnSup_Click(object sender, EventArgs e)
        {
            supplier();
        }

        private void btnKat_Click(object sender, EventArgs e)
        {
            kategori();
        }

        private void btnPel_Click(object sender, EventArgs e)
        {
            pelanggan();
        }
        private void btnPro_Click(object sender, EventArgs e)
        {
            produk();
        }
    }
}
