namespace Manajemen_Pemesanan_Makanan
{
    partial class Pemesanan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbMenuMakanan = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudJumlah = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTambahPesanan = new System.Windows.Forms.Button();
            this.btnSelesai = new System.Windows.Forms.Button();
            this.lblTotalBiaya = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudJumlah)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMenuMakanan
            // 
            this.cmbMenuMakanan.FormattingEnabled = true;
            this.cmbMenuMakanan.Location = new System.Drawing.Point(140, 48);
            this.cmbMenuMakanan.Name = "cmbMenuMakanan";
            this.cmbMenuMakanan.Size = new System.Drawing.Size(164, 21);
            this.cmbMenuMakanan.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu Makanan";
            // 
            // nudJumlah
            // 
            this.nudJumlah.Location = new System.Drawing.Point(140, 107);
            this.nudJumlah.Name = "nudJumlah";
            this.nudJumlah.Size = new System.Drawing.Size(164, 20);
            this.nudJumlah.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Jumlah";
            // 
            // btnTambahPesanan
            // 
            this.btnTambahPesanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambahPesanan.Location = new System.Drawing.Point(38, 179);
            this.btnTambahPesanan.Name = "btnTambahPesanan";
            this.btnTambahPesanan.Size = new System.Drawing.Size(128, 38);
            this.btnTambahPesanan.TabIndex = 4;
            this.btnTambahPesanan.Text = "Tambah Pesanan";
            this.btnTambahPesanan.UseVisualStyleBackColor = true;
            this.btnTambahPesanan.Click += new System.EventHandler(this.btnTambahPesanan_Click);
            // 
            // btnSelesai
            // 
            this.btnSelesai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelesai.Location = new System.Drawing.Point(38, 286);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(128, 38);
            this.btnSelesai.TabIndex = 5;
            this.btnSelesai.Text = "Selesai";
            this.btnSelesai.UseVisualStyleBackColor = true;
            this.btnSelesai.Click += new System.EventHandler(this.btnSelesai_Click);
            // 
            // lblTotalBiaya
            // 
            this.lblTotalBiaya.AutoSize = true;
            this.lblTotalBiaya.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBiaya.Location = new System.Drawing.Point(192, 228);
            this.lblTotalBiaya.Name = "lblTotalBiaya";
            this.lblTotalBiaya.Size = new System.Drawing.Size(76, 16);
            this.lblTotalBiaya.TabIndex = 6;
            this.lblTotalBiaya.Text = "Total Biaya";
            // 
            // Pemesanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 387);
            this.Controls.Add(this.lblTotalBiaya);
            this.Controls.Add(this.btnSelesai);
            this.Controls.Add(this.btnTambahPesanan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudJumlah);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMenuMakanan);
            this.MaximizeBox = false;
            this.Name = "Pemesanan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pemesanan";
            this.Load += new System.EventHandler(this.Pemesanan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudJumlah)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMenuMakanan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudJumlah;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTambahPesanan;
        private System.Windows.Forms.Button btnSelesai;
        private System.Windows.Forms.Label lblTotalBiaya;
    }
}