namespace IRF_Project
{
    partial class kereso_uc
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
            this.txtbox_MAC = new System.Windows.Forms.TextBox();
            this.txtbox_leltar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.listBox_gyarto = new System.Windows.Forms.ListBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.txtbox_eszkoz = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.leltariszamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beszeveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gyartoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eszkozokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.leltarEntitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eszkozokBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leltarEntitiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbox_MAC
            // 
            this.txtbox_MAC.Location = new System.Drawing.Point(567, 87);
            this.txtbox_MAC.Name = "txtbox_MAC";
            this.txtbox_MAC.Size = new System.Drawing.Size(152, 20);
            this.txtbox_MAC.TabIndex = 20;
            this.txtbox_MAC.TextChanged += new System.EventHandler(this.txtbox_MAC_TextChanged);
            // 
            // txtbox_leltar
            // 
            this.txtbox_leltar.Location = new System.Drawing.Point(568, 38);
            this.txtbox_leltar.Name = "txtbox_leltar";
            this.txtbox_leltar.Size = new System.Drawing.Size(153, 20);
            this.txtbox_leltar.TabIndex = 19;
            this.txtbox_leltar.TextChanged += new System.EventHandler(this.txtbox_leltar_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(567, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Gyártó:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(571, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Besz Éve:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(568, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "MAC cím:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(564, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Leltári szám:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.leltariszamDataGridViewTextBoxColumn,
            this.tipusDataGridViewTextBoxColumn,
            this.mACDataGridViewTextBoxColumn,
            this.beszeveDataGridViewTextBoxColumn,
            this.gyartoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.eszkozokBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(11, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(540, 288);
            this.dataGridView1.TabIndex = 13;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(638, 259);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(66, 20);
            this.numericUpDown1.TabIndex = 24;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // listBox_gyarto
            // 
            this.listBox_gyarto.FormattingEnabled = true;
            this.listBox_gyarto.Location = new System.Drawing.Point(567, 185);
            this.listBox_gyarto.Name = "listBox_gyarto";
            this.listBox_gyarto.Size = new System.Drawing.Size(136, 56);
            this.listBox_gyarto.TabIndex = 25;
            this.listBox_gyarto.SelectedIndexChanged += new System.EventHandler(this.listBox_gyarto_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkBox1.Location = new System.Drawing.Point(711, 262);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(29, 17);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = " ";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkBox2.Location = new System.Drawing.Point(711, 208);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(29, 17);
            this.checkBox2.TabIndex = 27;
            this.checkBox2.Text = " ";
            this.checkBox2.UseVisualStyleBackColor = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // txtbox_eszkoz
            // 
            this.txtbox_eszkoz.Location = new System.Drawing.Point(568, 139);
            this.txtbox_eszkoz.Name = "txtbox_eszkoz";
            this.txtbox_eszkoz.Size = new System.Drawing.Size(152, 20);
            this.txtbox_eszkoz.TabIndex = 29;
            this.txtbox_eszkoz.TextChanged += new System.EventHandler(this.txtbox_eszkoz_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(569, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Eszköz típusa:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(559, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 288);
            this.panel1.TabIndex = 30;
            // 
            // leltariszamDataGridViewTextBoxColumn
            // 
            this.leltariszamDataGridViewTextBoxColumn.DataPropertyName = "Leltari_szam";
            this.leltariszamDataGridViewTextBoxColumn.HeaderText = "Leltári szám";
            this.leltariszamDataGridViewTextBoxColumn.Name = "leltariszamDataGridViewTextBoxColumn";
            this.leltariszamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipusDataGridViewTextBoxColumn
            // 
            this.tipusDataGridViewTextBoxColumn.DataPropertyName = "Tipus";
            this.tipusDataGridViewTextBoxColumn.HeaderText = "Típus";
            this.tipusDataGridViewTextBoxColumn.Name = "tipusDataGridViewTextBoxColumn";
            this.tipusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mACDataGridViewTextBoxColumn
            // 
            this.mACDataGridViewTextBoxColumn.DataPropertyName = "MAC";
            this.mACDataGridViewTextBoxColumn.HeaderText = "MAC";
            this.mACDataGridViewTextBoxColumn.Name = "mACDataGridViewTextBoxColumn";
            this.mACDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // beszeveDataGridViewTextBoxColumn
            // 
            this.beszeveDataGridViewTextBoxColumn.DataPropertyName = "Besz_eve";
            this.beszeveDataGridViewTextBoxColumn.HeaderText = "Beszerzés éve";
            this.beszeveDataGridViewTextBoxColumn.Name = "beszeveDataGridViewTextBoxColumn";
            this.beszeveDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gyartoDataGridViewTextBoxColumn
            // 
            this.gyartoDataGridViewTextBoxColumn.DataPropertyName = "Gyarto";
            this.gyartoDataGridViewTextBoxColumn.HeaderText = "Gyártó";
            this.gyartoDataGridViewTextBoxColumn.Name = "gyartoDataGridViewTextBoxColumn";
            this.gyartoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eszkozokBindingSource
            // 
            this.eszkozokBindingSource.DataSource = typeof(IRF_Project.Eszkozok);
            // 
            // leltarEntitiesBindingSource
            // 
            this.leltarEntitiesBindingSource.DataSource = typeof(IRF_Project.LeltarEntities);
            // 
            // kereso_uc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.txtbox_eszkoz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.listBox_gyarto);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.txtbox_MAC);
            this.Controls.Add(this.txtbox_leltar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "kereso_uc";
            this.Size = new System.Drawing.Size(750, 300);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eszkozokBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leltarEntitiesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtbox_MAC;
        private System.Windows.Forms.TextBox txtbox_leltar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource eszkozokBindingSource;
        private System.Windows.Forms.BindingSource leltarEntitiesBindingSource;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ListBox listBox_gyarto;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox txtbox_eszkoz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn leltariszamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mACDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beszeveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gyartoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
    }
}
