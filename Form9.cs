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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

      

        private void Form9_Load(object sender, EventArgs e)
        {
            //pictureBox1.ImageLocation = "D:\\source\\Raj.jpg.jpg";
            pictureBox1.Image = Image.FromFile("D:\\Camera Roll\\loki.JPG");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult d= colorDialog1.ShowDialog();
            if(d == DialogResult.OK)
            {
                button1.BackColor = colorDialog1.Color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult d=  fontDialog1.ShowDialog();
            if(d == DialogResult.OK)
            {
                button2.Font = fontDialog1.Font;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Jpeg Images|*.jpg|Icon Images|*.ico|Bitmap Images|*.bmp|All Files|*.*";
            DialogResult d = openFileDialog1.ShowDialog();
            if(d == DialogResult.OK)
            {
                string s= openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(s);
                //MessageBox.Show(s);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "*.jpg";
            saveFileDialog1.Filter = "Jpeg Images|*.jpg|Icon Images|*.ico|Bitmap Images|*.bmp|All Files|*.*";
            DialogResult d= saveFileDialog1.ShowDialog();
            if(d == DialogResult.OK)
            {

                string s= saveFileDialog1.FileName;
                
                    pictureBox1.Image.Save(s);

                    MessageBox.Show("Image saved successfully");
               
               
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Exit", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(d == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
