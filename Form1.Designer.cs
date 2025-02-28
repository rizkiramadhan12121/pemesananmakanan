namespace Manajemen_Pemesanan_Makanan
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputMenuMakananToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pemesananToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.daftarMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.daftarPemesananToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tentangAplikasiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(650, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputMenuMakananToolStripMenuItem,
            this.pemesananToolStripMenuItem,
            this.daftarMenuToolStripMenuItem,
            this.daftarPemesananToolStripMenuItem});
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fIleToolStripMenuItem.Text = "FIle";
            // 
            // inputMenuMakananToolStripMenuItem
            // 
            this.inputMenuMakananToolStripMenuItem.Name = "inputMenuMakananToolStripMenuItem";
            this.inputMenuMakananToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.inputMenuMakananToolStripMenuItem.Text = "Input Menu Makanan";
            this.inputMenuMakananToolStripMenuItem.Click += new System.EventHandler(this.inputMenuMakananToolStripMenuItem_Click);
            // 
            // pemesananToolStripMenuItem
            // 
            this.pemesananToolStripMenuItem.Name = "pemesananToolStripMenuItem";
            this.pemesananToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.pemesananToolStripMenuItem.Text = "Pemesanan";
            this.pemesananToolStripMenuItem.Click += new System.EventHandler(this.pemesananToolStripMenuItem_Click);
            // 
            // daftarMenuToolStripMenuItem
            // 
            this.daftarMenuToolStripMenuItem.Name = "daftarMenuToolStripMenuItem";
            this.daftarMenuToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.daftarMenuToolStripMenuItem.Text = "Daftar Menu";
            this.daftarMenuToolStripMenuItem.Click += new System.EventHandler(this.daftarMenuToolStripMenuItem_Click);
            // 
            // daftarPemesananToolStripMenuItem
            // 
            this.daftarPemesananToolStripMenuItem.Name = "daftarPemesananToolStripMenuItem";
            this.daftarPemesananToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.daftarPemesananToolStripMenuItem.Text = "Daftar Pemesanan";
            this.daftarPemesananToolStripMenuItem.Click += new System.EventHandler(this.daftarPemesananToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tentangAplikasiToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // tentangAplikasiToolStripMenuItem
            // 
            this.tentangAplikasiToolStripMenuItem.Name = "tentangAplikasiToolStripMenuItem";
            this.tentangAplikasiToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.tentangAplikasiToolStripMenuItem.Text = "Tentang Aplikasi";
            this.tentangAplikasiToolStripMenuItem.Click += new System.EventHandler(this.tentangAplikasiToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 460);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputMenuMakananToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pemesananToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem daftarMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem daftarPemesananToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tentangAplikasiToolStripMenuItem;
    }
}

