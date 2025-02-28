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
    public partial class Pemesanan : Form
    {
        private decimal totalBiaya = 0;
        private Dictionary<string, decimal> hargaMenu; // Dictionary for menu prices

        public Pemesanan()
        {
            InitializeComponent();
            InitializeMenu();
        }

        private void Pemesanan_Load(object sender, EventArgs e)
        {
            // Populate combo box with menu items
            cmbMenuMakanan.Items.AddRange(hargaMenu.Keys.ToArray());
        }

        private void InitializeMenu()
        {
            // Initialize the dictionary with menu items and prices
            hargaMenu = new Dictionary<string, decimal>
            {
                { "Nasi Goreng", 20000 },
                { "Mie Ayam", 15000 },
                { "Ayam Bakar", 25000 },
                { "Sate Ayam", 18000 },
                { "Bakso", 12000 }
            };
        }

        private decimal GetHargaMakanan(string namaMakanan)
        {
            // Check if the selected food exists in the dictionary and return its price
            if (hargaMenu.TryGetValue(namaMakanan, out decimal harga))
            {
                return harga;
            }
            else
            {
                MessageBox.Show("Menu tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        private void btnTambahPesanan_Click(object sender, EventArgs e)
        {
            // Mendapatkan makanan yang dipilih dan jumlahnya
            if (cmbMenuMakanan.SelectedItem == null)
            {
                MessageBox.Show("Pilih menu makanan terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string namaMakanan = cmbMenuMakanan.SelectedItem.ToString();
            int jumlah = (int)nudJumlah.Value;

            if (jumlah <= 0)
            {
                MessageBox.Show("Jumlah harus lebih dari 0.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Mendapatkan harga makanan
            decimal hargaMakanan = GetHargaMakanan(namaMakanan);

            decimal biayaPesanan = hargaMakanan * jumlah;
            totalBiaya += biayaPesanan;
            lblTotalBiaya.Text = $"Total Biaya: {totalBiaya:C}";
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            if (totalBiaya == 0)
            {
                MessageBox.Show("Belum ada pesanan yang ditambahkan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show($"Total biaya pemesanan adalah: {totalBiaya:C}", "Total Biaya", MessageBoxButtons.OK, MessageBoxIcon.Information);

            totalBiaya = 0;
            lblTotalBiaya.Text = "Total Biaya: 0";
            cmbMenuMakanan.SelectedIndex = -1;
            nudJumlah.Value = 1;
        }
    }
}
