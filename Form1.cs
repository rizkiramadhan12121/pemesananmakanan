using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manajemen_Pemesanan_Makanan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void inputMenuMakananToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputMenuMakanan formInput = new InputMenuMakanan();
            formInput.MdiParent = this;
            formInput.Show();
        }

        private void pemesananToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pemesanan formInput = new Pemesanan();
            formInput.MdiParent = this;
            formInput.Show();
        }

        private void daftarMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DaftarMenu formInput = new DaftarMenu();
            formInput.MdiParent = this;
            formInput.Show();
        }

        private void daftarPemesananToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tentangAplikasiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplikasi Pengelolaan Inventaris Barang v1.0\nPengembang: SMKN 6 Jakarta", "Tentang Aplikasi");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
