namespace IRF_Project.Entities
{
    partial class Help_uc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.keresőToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szerkesztőiFelületToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelExportálásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.keresőToolStripMenuItem,
            this.szerkesztőiFelületToolStripMenuItem,
            this.excelExportálásToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(240, 274);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(397, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // keresőToolStripMenuItem
            // 
            this.keresőToolStripMenuItem.Name = "keresőToolStripMenuItem";
            this.keresőToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.keresőToolStripMenuItem.Text = "Kereső";
            this.keresőToolStripMenuItem.Click += new System.EventHandler(this.keresőToolStripMenuItem_Click);
            // 
            // szerkesztőiFelületToolStripMenuItem
            // 
            this.szerkesztőiFelületToolStripMenuItem.Name = "szerkesztőiFelületToolStripMenuItem";
            this.szerkesztőiFelületToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.szerkesztőiFelületToolStripMenuItem.Text = "Szerkesztői felület";
            this.szerkesztőiFelületToolStripMenuItem.Click += new System.EventHandler(this.szerkesztőiFelületToolStripMenuItem_Click);
            // 
            // excelExportálásToolStripMenuItem
            // 
            this.excelExportálásToolStripMenuItem.Name = "excelExportálásToolStripMenuItem";
            this.excelExportálásToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.excelExportálásToolStripMenuItem.Text = "Excel Exportálás";
            this.excelExportálásToolStripMenuItem.Click += new System.EventHandler(this.excelExportálásToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(14, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(724, 260);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Help_uc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Help_uc";
            this.Size = new System.Drawing.Size(750, 300);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem keresőToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szerkesztőiFelületToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelExportálásToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
