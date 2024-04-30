namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.listBox_Lista = new System.Windows.Forms.ListBox();
            this.button_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.textBoxF = new System.Windows.Forms.TextBox();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.label_tempF = new System.Windows.Forms.Label();
            this.label_tempC = new System.Windows.Forms.Label();
            this.label_rezultat = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox_Lista
            // 
            this.listBox_Lista.FormattingEnabled = true;
            this.listBox_Lista.ItemHeight = 16;
            this.listBox_Lista.Location = new System.Drawing.Point(41, 49);
            this.listBox_Lista.Name = "listBox_Lista";
            this.listBox_Lista.Size = new System.Drawing.Size(120, 132);
            this.listBox_Lista.TabIndex = 0;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(51, 200);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(101, 23);
            this.button_add.TabIndex = 1;
            this.button_add.Text = "AddButton";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(438, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(424, 95);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(100, 22);
            this.textBoxC.TabIndex = 3;
            // 
            // textBoxF
            // 
            this.textBoxF.Location = new System.Drawing.Point(424, 145);
            this.textBoxF.Name = "textBoxF";
            this.textBoxF.Size = new System.Drawing.Size(100, 22);
            this.textBoxF.TabIndex = 4;
            // 
            // textBoxR
            // 
            this.textBoxR.Location = new System.Drawing.Point(424, 200);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(100, 22);
            this.textBoxR.TabIndex = 5;
            // 
            // label_tempF
            // 
            this.label_tempF.AutoSize = true;
            this.label_tempF.Location = new System.Drawing.Point(364, 151);
            this.label_tempF.Name = "label_tempF";
            this.label_tempF.Size = new System.Drawing.Size(54, 16);
            this.label_tempF.TabIndex = 6;
            this.label_tempF.Text = "Temp F";
            // 
            // label_tempC
            // 
            this.label_tempC.AutoSize = true;
            this.label_tempC.Location = new System.Drawing.Point(363, 98);
            this.label_tempC.Name = "label_tempC";
            this.label_tempC.Size = new System.Drawing.Size(55, 16);
            this.label_tempC.TabIndex = 7;
            this.label_tempC.Text = "Temp C";
            // 
            // label_rezultat
            // 
            this.label_rezultat.AutoSize = true;
            this.label_rezultat.Location = new System.Drawing.Point(363, 203);
            this.label_rezultat.Name = "label_rezultat";
            this.label_rezultat.Size = new System.Drawing.Size(55, 16);
            this.label_rezultat.TabIndex = 8;
            this.label_rezultat.Text = "Rezultat";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(616, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "CtoF";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(616, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "FtoC";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(424, 268);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 11;
            this.textBox4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox4_KeyDown);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(424, 323);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_rezultat);
            this.Controls.Add(this.label_tempC);
            this.Controls.Add(this.label_tempF);
            this.Controls.Add(this.textBoxR);
            this.Controls.Add(this.textBoxF);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.listBox_Lista);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Lista;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.TextBox textBoxF;
        private System.Windows.Forms.TextBox textBoxR;
        private System.Windows.Forms.Label label_tempF;
        private System.Windows.Forms.Label label_tempC;
        private System.Windows.Forms.Label label_rezultat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
    }
}

