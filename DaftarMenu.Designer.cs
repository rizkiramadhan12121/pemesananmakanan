namespace Manajemen_Pemesanan_Makanan
{
    partial class DaftarMenu
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnbackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(369, 350);
            this.dataGridView.TabIndex = 0;
            // 
            // btnbackButton
            // 
            this.btnbackButton.Location = new System.Drawing.Point(387, 21);
            this.btnbackButton.Name = "btnbackButton";
            this.btnbackButton.Size = new System.Drawing.Size(126, 45);
            this.btnbackButton.TabIndex = 1;
            this.btnbackButton.Text = "Kembali";
            this.btnbackButton.UseVisualStyleBackColor = true;
            // 
            // DaftarMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 378);
            this.Controls.Add(this.btnbackButton);
            this.Controls.Add(this.dataGridView);
            this.MaximizeBox = false;
            this.Name = "DaftarMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DaftarMenu";
            this.Load += new System.EventHandler(this.DaftarMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnbackButton;
    }
}