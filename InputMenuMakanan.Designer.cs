namespace Manajemen_Pemesanan_Makanan
{
    partial class InputMenuMakanan
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNamaMakanan = new System.Windows.Forms.TextBox();
            this.txtHargaMakanan = new System.Windows.Forms.TextBox();
            this.btnTambahMakanan = new System.Windows.Forms.Button();
            this.btnLihatMenu = new System.Windows.Forms.Button();
            this.lblKonfirmasi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Makanan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Harga Makanan";
            // 
            // txtNamaMakanan
            // 
            this.txtNamaMakanan.Location = new System.Drawing.Point(230, 91);
            this.txtNamaMakanan.Name = "txtNamaMakanan";
            this.txtNamaMakanan.Size = new System.Drawing.Size(141, 20);
            this.txtNamaMakanan.TabIndex = 2;
            // 
            // txtHargaMakanan
            // 
            this.txtHargaMakanan.Location = new System.Drawing.Point(230, 155);
            this.txtHargaMakanan.Name = "txtHargaMakanan";
            this.txtHargaMakanan.Size = new System.Drawing.Size(141, 20);
            this.txtHargaMakanan.TabIndex = 3;
            // 
            // btnTambahMakanan
            // 
            this.btnTambahMakanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambahMakanan.Location = new System.Drawing.Point(89, 232);
            this.btnTambahMakanan.Name = "btnTambahMakanan";
            this.btnTambahMakanan.Size = new System.Drawing.Size(134, 35);
            this.btnTambahMakanan.TabIndex = 4;
            this.btnTambahMakanan.Text = "Tambah Makanan";
            this.btnTambahMakanan.UseVisualStyleBackColor = true;
            this.btnTambahMakanan.Click += new System.EventHandler(this.btnTambahMakanan_Click);
            // 
            // btnLihatMenu
            // 
            this.btnLihatMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLihatMenu.Location = new System.Drawing.Point(270, 232);
            this.btnLihatMenu.Name = "btnLihatMenu";
            this.btnLihatMenu.Size = new System.Drawing.Size(101, 35);
            this.btnLihatMenu.TabIndex = 5;
            this.btnLihatMenu.Text = "Lihat Menu";
            this.btnLihatMenu.UseVisualStyleBackColor = true;
            this.btnLihatMenu.Click += new System.EventHandler(this.btnLihatMenu_Click);
            // 
            // lblKonfirmasi
            // 
            this.lblKonfirmasi.AutoSize = true;
            this.lblKonfirmasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKonfirmasi.Location = new System.Drawing.Point(69, 294);
            this.lblKonfirmasi.Name = "lblKonfirmasi";
            this.lblKonfirmasi.Size = new System.Drawing.Size(79, 16);
            this.lblKonfirmasi.TabIndex = 6;
            this.lblKonfirmasi.Text = "Konfirmasi";
            this.lblKonfirmasi.Click += new System.EventHandler(this.lblKonfirmasi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Manajemen Pemesanan Makanan ";
            // 
            // InputMenuMakanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 339);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblKonfirmasi);
            this.Controls.Add(this.btnLihatMenu);
            this.Controls.Add(this.btnTambahMakanan);
            this.Controls.Add(this.txtHargaMakanan);
            this.Controls.Add(this.txtNamaMakanan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "InputMenuMakanan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InputMenuMakanan";
            this.Load += new System.EventHandler(this.InputMenuMakanan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNamaMakanan;
        private System.Windows.Forms.TextBox txtHargaMakanan;
        private System.Windows.Forms.Button btnTambahMakanan;
        private System.Windows.Forms.Button btnLihatMenu;
        private System.Windows.Forms.Label lblKonfirmasi;
        private System.Windows.Forms.Label label3;
    }
}