using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult d= folderBrowserDialog1.ShowDialog();
            if(d== DialogResult.OK)
            {
                
                string path= folderBrowserDialog1.SelectedPath;
                string[] files=Directory.GetFiles(path,"*.png");   // Directory.GetFiles() method will gives all files in a folder 
                
                listBox1.Tag = path;                               // GetFiles() is a overload method
                listBox1.Items.Clear();
                /*  listBox1.Items.AddRange(k);
                   */ //This is to get all file  path at a time.
                foreach (string file in files)
                {
                    int pos = file.LastIndexOf("\\");
                    string name= file.Substring(pos+1);
                    listBox1.Items.Add(name);
                }
                listBox1.SelectedIndex = 0;
                

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Tag : " + listBox1.Tag); // gives folderpath
            //MessageBox.Show("selected : " + listBox1.SelectedItem); //gives selected option
            //MessageBox.Show(listBox1.Tag + "\\" + listBox1.SelectedItem);
            pictureBox1.ImageLocation= listBox1.Tag + "\\" + listBox1.SelectedItem;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
                btnPrev.Enabled = false;
            else
            {
                listBox1.SelectedIndex -= 1;
                btnNext.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int k = listBox1.Tag.ToString().Length;
            if (listBox1.SelectedIndex >= 0 && listBox1.SelectedIndex < k)
            {
                
                btnPrev.Enabled = true;
                listBox1.SelectedIndex += 1;
                //MessageBox.Show("Length: " + k);
                if (listBox1.SelectedIndex == k-1)
                {
                    btnNext.Enabled = false; 
                }
            }
            else
            {
                btnNext.Enabled = false;
            }

            
        }
    }
}
 