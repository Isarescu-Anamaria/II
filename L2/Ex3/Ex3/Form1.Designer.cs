namespace Ex3
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
            this.number1 = new System.Windows.Forms.TextBox();
            this.number2 = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.operationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adunare = new System.Windows.Forms.ToolStripMenuItem();
            this.scadere = new System.Windows.Forms.ToolStripMenuItem();
            this.inmultire = new System.Windows.Forms.ToolStripMenuItem();
            this.impartire = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // number1
            // 
            this.number1.Location = new System.Drawing.Point(84, 47);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(100, 20);
            this.number1.TabIndex = 0;
            // 
            // number2
            // 
            this.number2.Location = new System.Drawing.Point(84, 96);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(100, 20);
            this.number2.TabIndex = 1;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(84, 151);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(100, 20);
            this.result.TabIndex = 2;
            this.result.Text = "Result";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // operationToolStripMenuItem
            // 
            this.operationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adunare,
            this.scadere,
            this.inmultire,
            this.impartire});
            this.operationToolStripMenuItem.Name = "operationToolStripMenuItem";
            this.operationToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.operationToolStripMenuItem.Text = "Operation";
            
            // 
            // adunare
            // 
            this.adunare.Name = "adunare";
            this.adunare.Size = new System.Drawing.Size(180, 22);
            this.adunare.Text = "+";
            this.adunare.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // scadere
            // 
            this.scadere.Name = "scadere";
            this.scadere.Size = new System.Drawing.Size(180, 22);
            this.scadere.Text = "_";
            this.scadere.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // inmultire
            // 
            this.inmultire.Name = "inmultire";
            this.inmultire.Size = new System.Drawing.Size(180, 22);
            this.inmultire.Text = "*";
            this.inmultire.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // impartire
            // 
            this.impartire.Name = "impartire";
            this.impartire.Size = new System.Drawing.Size(180, 22);
            this.impartire.Text = "/";
            this.impartire.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.result);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox number1;
        private System.Windows.Forms.TextBox number2;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adunare;
        private System.Windows.Forms.ToolStripMenuItem scadere;
        private System.Windows.Forms.ToolStripMenuItem inmultire;
        private System.Windows.Forms.ToolStripMenuItem impartire;
    }
}

