using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            localhost.WebService1 ts = new localhost.WebService1();
            listBox_Lista.Items.AddRange(ts.Afis());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            localhost.WebService1 ts = new localhost.WebService1();
            label1.Text = ts.Data();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // C to F
            localhost.WebService1 ts = new localhost.WebService1();
            double C = Convert.ToDouble(textBoxC.Text);
            double rez = ts.CtoF(C);
            textBoxR.Text = rez.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // F to C
            localhost.WebService1 ts = new localhost.WebService1();
            double F = Convert.ToDouble(textBoxF.Text);
            double rez = ts.FtoC(F);
            textBoxR.Text = rez.ToString();
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            double op = 0;
            localhost.WebService1 ts = new localhost.WebService1();
            bool isNum = double.TryParse(textBox4.Text, out op);
            if (isNum)
            {
                if (e.KeyCode == Keys.Enter)
                    textBox5.Text = ts.ConvertMoney(op).ToString();
            }
            else textBox5.Clear();
        }
    }
}
