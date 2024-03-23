using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //adunare
            try
            {
                result.Text = (Convert.ToDouble(number1.Text) + Convert.ToDouble(number2.Text)).ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error!" + ex);
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //scadere
            try
            {
                result.Text = (Convert.ToDouble(number1.Text) - Convert.ToDouble(number2.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex);
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            //inmultire
            try
            {
                result.Text = (Convert.ToDouble(number1.Text) * Convert.ToDouble(number2.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex);
            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            //impartire
            try
            {
                result.Text = (Convert.ToDouble(number1.Text) / Convert.ToDouble(number2.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex);
            }
        }
    }
}
