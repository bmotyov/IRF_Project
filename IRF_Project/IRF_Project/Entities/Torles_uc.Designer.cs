namespace IRF_Project.Entities
{
    partial class Torles_uc
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
            this.components = new System.ComponentModel.Container();
            this.button_delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.eszkozokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gyartoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Besz_eve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leltariszamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eszkozokBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.Red;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_delete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_delete.Location = new System.Drawing.Point(166, 11);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(100, 23);
            this.button_delete.TabIndex = 1;
            this.button_delete.Text = "Törlés";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(23, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kiválasztott elem törlése:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(45, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Több elem törlése tulajdonság alapján :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button_delete);
            this.panel1.Location = new System.Drawing.Point(465, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 47);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(465, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(282, 224);
            this.panel2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(91, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Törlés";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // eszkozokBindingSource
            // 
            this.eszkozokBindingSource.DataSource = typeof(IRF_Project.Eszkozok);
            // 
            // gyartoDataGridViewTextBoxColumn
            // 
            this.gyartoDataGridViewTextBoxColumn.DataPropertyName = "Gyarto";
            this.gyartoDataGridViewTextBoxColumn.HeaderText = "Gyarto";
            this.gyartoDataGridViewTextBoxColumn.Name = "gyartoDataGridViewTextBoxColumn";
            // 
            // mACDataGridViewTextBoxColumn
            // 
            this.mACDataGridViewTextBoxColumn.DataPropertyName = "MAC";
            this.mACDataGridViewTextBoxColumn.HeaderText = "MAC";
            this.mACDataGridViewTextBoxColumn.Name = "mACDataGridViewTextBoxColumn";
            // 
            // Besz_eve
            // 
            this.Besz_eve.DataPropertyName = "Besz_eve";
            this.Besz_eve.HeaderText = "Besz_eve";
            this.Besz_eve.Name = "Besz_eve";
            // 
            // leltariszamDataGridViewTextBoxColumn
            // 
            this.leltariszamDataGridViewTextBoxColumn.DataPropertyName = "Leltari_szam";
            this.leltariszamDataGridViewTextBoxColumn.HeaderText = "Leltari_szam";
            this.leltariszamDataGridViewTextBoxColumn.Name = "leltariszamDataGridViewTextBoxColumn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.leltariszamDataGridViewTextBoxColumn,
            this.Besz_eve,
            this.mACDataGridViewTextBoxColumn,
            this.gyartoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.eszkozokBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(452, 294);
            this.dataGridView1.TabIndex = 0;
            // 
            // Torles_uc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Torles_uc";
            this.Size = new System.Drawing.Size(750, 300);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eszkozokBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource eszkozokBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gyartoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mACDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Besz_eve;
        private System.Windows.Forms.DataGridViewTextBoxColumn leltariszamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
