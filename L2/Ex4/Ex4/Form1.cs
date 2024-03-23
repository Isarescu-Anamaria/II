using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           string s =  listBox1.SelectedItem.ToString();
            switch (s)
            {
                case "Porsche":
                    pictureBox1.Image = Image.FromFile("porsche.jpg");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case "Ford":
                    pictureBox1.Image = Image.FromFile("ford.jpg");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                case "BMW":
                    pictureBox1.Image = Image.FromFile("bmw.jpg");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg = string.Empty;
            foreach(RadioButton radioButton in groupBox1.Controls)
            {
                if(radioButton.Checked == true)
                {
                    msg = radioButton.Text;
                }
            }

            foreach (RadioButton radioButton in groupBox2.Controls)
            {
                if (radioButton.Checked == true)
                {
                    msg = msg + " with " + radioButton.Text;
                }
            }
            MessageBox.Show("You have chosen pizza " + msg + " sauce!","Selection");
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
