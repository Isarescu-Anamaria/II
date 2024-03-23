using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader streamReader = new StreamReader("fisier.txt");
            string line;
            while ((line = streamReader.ReadLine()) != null)
            {
                string[] array = line.Split(' ');
                if ((array[0] == txtUsername.Text) && (array[1] == txtPassword.Text))
                {
                    Form2 secondForm = new Form2(txtUsername.Text);
                    secondForm.Show();
                }
            }

           
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
