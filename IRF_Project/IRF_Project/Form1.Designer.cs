namespace IRF_Project
{
    partial class From1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(From1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.főoldalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keresőToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szerkesztőFelületToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leltárElemekKivezetéseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leltárElemekHozzáadásaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelExportálásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hELPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.eszkozokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eszkozokBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.főoldalToolStripMenuItem,
            this.keresőToolStripMenuItem,
            this.szerkesztőFelületToolStripMenuItem,
            this.excelExportálásToolStripMenuItem,
            this.hELPToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // főoldalToolStripMenuItem
            // 
            this.főoldalToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.főoldalToolStripMenuItem.Name = "főoldalToolStripMenuItem";
            resources.ApplyResources(this.főoldalToolStripMenuItem, "főoldalToolStripMenuItem");
            this.főoldalToolStripMenuItem.Click += new System.EventHandler(this.főoldalToolStripMenuItem_Click);
            // 
            // keresőToolStripMenuItem
            // 
            this.keresőToolStripMenuItem.Name = "keresőToolStripMenuItem";
            resources.ApplyResources(this.keresőToolStripMenuItem, "keresőToolStripMenuItem");
            this.keresőToolStripMenuItem.Click += new System.EventHandler(this.keresőToolStripMenuItem_Click);
            // 
            // szerkesztőFelületToolStripMenuItem
            // 
            this.szerkesztőFelületToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leltárElemekKivezetéseToolStripMenuItem,
            this.leltárElemekHozzáadásaToolStripMenuItem});
            this.szerkesztőFelületToolStripMenuItem.Name = "szerkesztőFelületToolStripMenuItem";
            resources.ApplyResources(this.szerkesztőFelületToolStripMenuItem, "szerkesztőFelületToolStripMenuItem");
            // 
            // leltárElemekKivezetéseToolStripMenuItem
            // 
            this.leltárElemekKivezetéseToolStripMenuItem.Name = "leltárElemekKivezetéseToolStripMenuItem";
            resources.ApplyResources(this.leltárElemekKivezetéseToolStripMenuItem, "leltárElemekKivezetéseToolStripMenuItem");
            // 
            // leltárElemekHozzáadásaToolStripMenuItem
            // 
            this.leltárElemekHozzáadásaToolStripMenuItem.Name = "leltárElemekHozzáadásaToolStripMenuItem";
            resources.ApplyResources(this.leltárElemekHozzáadásaToolStripMenuItem, "leltárElemekHozzáadásaToolStripMenuItem");
            // 
            // excelExportálásToolStripMenuItem
            // 
            this.excelExportálásToolStripMenuItem.Name = "excelExportálásToolStripMenuItem";
            resources.ApplyResources(this.excelExportálásToolStripMenuItem, "excelExportálásToolStripMenuItem");
            this.excelExportálásToolStripMenuItem.Click += new System.EventHandler(this.excelExportálásToolStripMenuItem_Click);
            // 
            // hELPToolStripMenuItem
            // 
            this.hELPToolStripMenuItem.Name = "hELPToolStripMenuItem";
            resources.ApplyResources(this.hELPToolStripMenuItem, "hELPToolStripMenuItem");
            this.hELPToolStripMenuItem.Click += new System.EventHandler(this.hELPToolStripMenuItem_Click);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // eszkozokBindingSource
            // 
            this.eszkozokBindingSource.DataSource = typeof(IRF_Project.Eszkozok);
            // 
            // From1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "From1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eszkozokBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource eszkozokBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem főoldalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szerkesztőFelületToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leltárElemekKivezetéseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leltárElemekHozzáadásaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelExportálásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hELPToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem keresőToolStripMenuItem;
    }
}

