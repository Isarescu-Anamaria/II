using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema1
{
    public partial class Planner : Form
    {
        String lastElement;
        public Planner()
        {
            InitializeComponent();
        }

        private void Planner_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to your daily planner!\nChoose your activities and a hobby and move them to the checkbox using the Move button.");
        }

        

        private void buttonMove_Click(object sender, EventArgs e)
        {
            if (listBoxThings.SelectedIndex != -1)
            {
                checkedListBoxActivities.Items.Add(listBoxThings.SelectedItem.ToString());

                lastElement = listBoxThings.SelectedItem.ToString();

                listBoxThings.ClearSelected();
            }
            else
            {
                foreach (RadioButton radioButton in groupBox1.Controls)
                {
                    if (radioButton.Checked == true)
                    {
                        checkedListBoxActivities.Items.Add(radioButton.Text);

                        lastElement = radioButton.Text;
                        radioButton.Checked = false;
                    }
                }
            }
            
        }

       

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            checkedListBoxActivities.Items.Remove(lastElement);
            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
