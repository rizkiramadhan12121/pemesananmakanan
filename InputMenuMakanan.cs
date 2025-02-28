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
    public partial class InputMenuMakanan : Form
    {
        public InputMenuMakanan()
        {
            InitializeComponent();
        }

        public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeComponent();
            }

            private void InitializeComponent()
            {
                this.lblNamaMakanan = new System.Windows.Forms.Label();
                this.lblHarga = new System.Windows.Forms.Label();
                this.txtNamaMakanan = new System.Windows.Forms.TextBox();
                this.txtHarga = new System.Windows.Forms.TextBox();
                this.btnTambahPesanan = new System.Windows.Forms.Button();
                this.btnTampilkanMenu = new System.Windows.Forms.Button();
                this.SuspendLayout();
                // 
                // lblNamaMakanan
                // 
                this.lblNamaMakanan.AutoSize = true;
                this.lblNamaMakanan.Location = new System.Drawing.Point(50, 50);
                this.lblNamaMakanan.Name = "lblNamaMakanan";
                this.lblNamaMakanan.Size = new System.Drawing.Size(92, 13);
                this.lblNamaMakanan.Text = "Nama Makanan:";
                // 
                // lblHarga
                // 
                this.lblHarga.AutoSize = true;
                this.lblHarga.Location = new System.Drawing.Point(50, 100);
                this.lblHarga.Name = "lblHarga";
                this.lblHarga.Size = new System.Drawing.Size(40, 13);
                this.lblHarga.Text = "Harga:";
                // 
                // txtNamaMakanan
                // 
                this.txtNamaMakanan.Location = new System.Drawing.Point(150, 50);
                this.txtNamaMakanan.Size = new System.Drawing.Size(150, 20);
                // 
                // txtHarga
                // 
                this.txtHarga.Location = new System.Drawing.Point(150, 100);
                this.txtHarga.Size = new System.Drawing.Size(150, 20);
                // 
                // btnTambahPesanan
                // 
                this.btnTambahPesanan.BackColor = System.Drawing.Color.FromArgb(40, 167, 69); // Green color
                this.btnTambahPesanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.btnTambahPesanan.Location = new System.Drawing.Point(50, 150);
                this.btnTambahPesanan.Size = new System.Drawing.Size(120, 40);
                this.btnTambahPesanan.Text = "Tambah Pesanan";
                this.btnTambahPesanan.Click += new System.EventHandler(this.btnTambahPesanan_Click);
                // 
                // btnTampilkanMenu
                // 
                this.btnTampilkanMenu.BackColor = System.Drawing.Color.FromArgb(0, 123, 255); // Blue color
                this.btnTampilkanMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.btnTampilkanMenu.Location = new System.Drawing.Point(180, 150);
                this.btnTampilkanMenu.Size = new System.Drawing.Size(120, 40);
                this.btnTampilkanMenu.Text = "Tampilkan Menu";
                this.btnTampilkanMenu.Click += new System.EventHandler(this.btnTampilkanMenu_Click);
                // 
                // Form1
                // 
                this.ClientSize = new System.Drawing.Size(350, 250);
                this.Controls.Add(this.lblNamaMakanan);
                this.Controls.Add(this.lblHarga);
                this.Controls.Add(this.txtNamaMakanan);
                this.Controls.Add(this.txtHarga);
                this.Controls.Add(this.btnTambahPesanan);
                this.Controls.Add(this.btnTampilkanMenu);
                this.Text = "Form Pemesanan";
                this.ResumeLayout(false);
                this.PerformLayout();
            }

            private void btnTambahPesanan_Click(object sender, EventArgs e)
            {
                // Add order logic here
            }

            private void btnTampilkanMenu_Click(object sender, EventArgs e)
            {
                // Show menu logic here
            }

            private System.Windows.Forms.Label lblNamaMakanan;
            private System.Windows.Forms.Label lblHarga;
            private System.Windows.Forms.TextBox txtNamaMakanan;
            private System.Windows.Forms.TextBox txtHarga;
            private System.Windows.Forms.Button btnTambahPesanan;
            private System.Windows.Forms.Button btnTampilkanMenu;
        }


        private void btnTambahMakanan_Click(object sender, EventArgs e)
        {
            string namaMakanan = txtNamaMakanan.Text;
            string hargaText = txtHargaMakanan.Text;
            decimal harga;

            if (string.IsNullOrWhiteSpace(namaMakanan) || string.IsNullOrWhiteSpace(hargaText) || !decimal.TryParse(hargaText, out harga))
            {
                lblKonfirmasi.Text = "Masukkan nama dan harga makanan dengan benar.";
                lblKonfirmasi.ForeColor = Color.Red;
                return;
            }

            lblKonfirmasi.Text = "Menu berhasil ditambahkan!";
            lblKonfirmasi.ForeColor = Color.Green;
            txtNamaMakanan.Clear();
            txtHargaMakanan.Clear();
        }

        private void btnLihatMenu_Click(object sender, EventArgs e)
        {
            DaftarMenu formInput = new DaftarMenu();
            formInput.MdiParent = this;
            formInput.Show();
        }

        private void InputMenuMakanan_Load(object sender, EventArgs e)
        {

        }

        private void lblKonfirmasi_Click(object sender, EventArgs e)
        {

        }
    }
}
