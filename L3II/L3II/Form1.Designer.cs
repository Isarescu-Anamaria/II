namespace L3II
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox_Univ = new System.Windows.Forms.ListBox();
            this.listBox_Fac = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBox_NameUniv = new System.Windows.Forms.TextBox();
            this.textBox_City = new System.Windows.Forms.TextBox();
            this.textBox_CodUniv = new System.Windows.Forms.TextBox();
            this.buttonDeleteUniv = new System.Windows.Forms.Button();
            this.buttonInsertUniv = new System.Windows.Forms.Button();
            this.buttonUpdateUniv = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.buttonUpdateUniv);
            this.groupBox1.Controls.Add(this.buttonInsertUniv);
            this.groupBox1.Controls.Add(this.buttonDeleteUniv);
            this.groupBox1.Controls.Add(this.textBox_CodUniv);
            this.groupBox1.Controls.Add(this.textBox_City);
            this.groupBox1.Controls.Add(this.textBox_NameUniv);
            this.groupBox1.Controls.Add(this.textBoxId);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.listBox_Fac);
            this.groupBox1.Controls.Add(this.listBox_Univ);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(41, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(747, 385);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Exemplu DB";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Universitati";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Facultati";
            // 
            // listBox_Univ
            // 
            this.listBox_Univ.FormattingEnabled = true;
            this.listBox_Univ.ItemHeight = 16;
            this.listBox_Univ.Location = new System.Drawing.Point(9, 59);
            this.listBox_Univ.Name = "listBox_Univ";
            this.listBox_Univ.Size = new System.Drawing.Size(120, 212);
            this.listBox_Univ.TabIndex = 2;
            this.listBox_Univ.SelectedIndexChanged += new System.EventHandler(this.listBox_Univ_SelectedIndexChanged);
            // 
            // listBox_Fac
            // 
            this.listBox_Fac.FormattingEnabled = true;
            this.listBox_Fac.ItemHeight = 16;
            this.listBox_Fac.Location = new System.Drawing.Point(197, 46);
            this.listBox_Fac.Name = "listBox_Fac";
            this.listBox_Fac.Size = new System.Drawing.Size(120, 84);
            this.listBox_Fac.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nume_univ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Oras";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(194, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Cod_Univ";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(197, 164);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 22);
            this.textBoxId.TabIndex = 8;
            // 
            // textBox_NameUniv
            // 
            this.textBox_NameUniv.Location = new System.Drawing.Point(197, 217);
            this.textBox_NameUniv.Name = "textBox_NameUniv";
            this.textBox_NameUniv.Size = new System.Drawing.Size(100, 22);
            this.textBox_NameUniv.TabIndex = 9;
            // 
            // textBox_City
            // 
            this.textBox_City.Location = new System.Drawing.Point(197, 261);
            this.textBox_City.Name = "textBox_City";
            this.textBox_City.Size = new System.Drawing.Size(100, 22);
            this.textBox_City.TabIndex = 10;
            // 
            // textBox_CodUniv
            // 
            this.textBox_CodUniv.Location = new System.Drawing.Point(197, 312);
            this.textBox_CodUniv.Name = "textBox_CodUniv";
            this.textBox_CodUniv.ReadOnly = true;
            this.textBox_CodUniv.Size = new System.Drawing.Size(100, 22);
            this.textBox_CodUniv.TabIndex = 11;
            // 
            // buttonDeleteUniv
            // 
            this.buttonDeleteUniv.Location = new System.Drawing.Point(29, 290);
            this.buttonDeleteUniv.Name = "buttonDeleteUniv";
            this.buttonDeleteUniv.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteUniv.TabIndex = 12;
            this.buttonDeleteUniv.Text = "Stergere";
            this.buttonDeleteUniv.UseVisualStyleBackColor = true;
            this.buttonDeleteUniv.Click += new System.EventHandler(this.buttonDeleteUniv_Click);
            // 
            // buttonInsertUniv
            // 
            this.buttonInsertUniv.Location = new System.Drawing.Point(176, 340);
            this.buttonInsertUniv.Name = "buttonInsertUniv";
            this.buttonInsertUniv.Size = new System.Drawing.Size(84, 23);
            this.buttonInsertUniv.TabIndex = 13;
            this.buttonInsertUniv.Text = "Introducere";
            this.buttonInsertUniv.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonInsertUniv.UseVisualStyleBackColor = true;
            this.buttonInsertUniv.Click += new System.EventHandler(this.buttonInsertUniv_Click);
            // 
            // buttonUpdateUniv
            // 
            this.buttonUpdateUniv.Location = new System.Drawing.Point(278, 340);
            this.buttonUpdateUniv.Name = "buttonUpdateUniv";
            this.buttonUpdateUniv.Size = new System.Drawing.Size(83, 23);
            this.buttonUpdateUniv.TabIndex = 14;
            this.buttonUpdateUniv.Text = "Actualizare";
            this.buttonUpdateUniv.UseVisualStyleBackColor = true;
            this.buttonUpdateUniv.Click += new System.EventHandler(this.buttonUpdateUniv_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(392, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(349, 288);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "Id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NameFac";
            this.Column3.HeaderText = "NumeFac";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Code";
            this.Column2.HeaderText = "NumeUniv";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonUpdateUniv;
        private System.Windows.Forms.Button buttonInsertUniv;
        private System.Windows.Forms.Button buttonDeleteUniv;
        private System.Windows.Forms.TextBox textBox_CodUniv;
        private System.Windows.Forms.TextBox textBox_City;
        private System.Windows.Forms.TextBox textBox_NameUniv;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox_Fac;
        private System.Windows.Forms.ListBox listBox_Univ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column2;
    }
}

