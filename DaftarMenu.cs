using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manajemen_Pemesanan_Makanan
{
    public partial class DaftarMenu : Form
    {
        public DaftarMenu()
        {
            InitializeComponent();
            LoadMenuData();

        }
        public void MenuForm()
        {
            // Inisialisasi komponen
            dataGridView = new DataGridView();
            btnbackButton = new Button();

            // Set properti DataGridView
            dataGridView.ColumnCount = 2;
            dataGridView.Columns[0].Name = "Nama Makanan";
            dataGridView.Columns[1].Name = "Harga";
            dataGridView.Dock = DockStyle.Top;

            // Set properti Button
            btnbackButton.Text = "Kembali";
            btnbackButton.Dock = DockStyle.Bottom;
            btnbackButton.Click += btnbackButton_Click;

            // Tambahkan komponen ke form
            Controls.Add(dataGridView);
            Controls.Add(btnbackButton);

            // Tambahkan data menu makanan
            LoadMenuData();
        }

        private void LoadMenuData()
        {
            // Tambahkan data menu makanan ke dalam DataGridView
            string[] row1 = new string[] { "Nasi Goreng", "Rp 10.000" };
            string[] row2 = new string[] { "Mie Goreng", "Rp 8.000" };
            string[] row3 = new string[] { "Sate", "Rp 15.000" };

            dataGridView.Rows.Add(row1);
            dataGridView.Rows.Add(row2);
            dataGridView.Rows.Add(row3);
        }

        private void DaftarMenu_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnbackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

