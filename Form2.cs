using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                MessageBox.Show("RB_1 Clicked");
            }
            else if (radioButton2.Checked)
            {
                MessageBox.Show("RB_2 Clicked");
            }
            else if (radioButton3.Checked)
            {
                MessageBox.Show("RB_3 Clicked");
            }
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show("CB_1 Clicked");
            }
             if (checkBox2.Checked)
            {
                MessageBox.Show("CB_2 Clicked");
            }
             if (checkBox3.Checked)
            {
                MessageBox.Show("CB_3 Clicked");
            }
        }
    }
}
