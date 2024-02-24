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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            
            comboBox1.Items.Add("Rajah");
            listBox1.Items.Add("Jaipur");
            string[] s = {"Raj","Pune","JarKandh","Odissa","MalDieves" };
            checkedListBox1.Items.AddRange(s);
            listBox1.Items.AddRange(s);
           
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Convert.ToInt32(e.KeyChar)==13)
            {
                if(comboBox1.FindStringExact(comboBox1.Text) == -1)
                {
                    comboBox1.Items.Add(comboBox1.Text.ToString());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.Text);
            MessageBox.Show("Selected Index : " + comboBox1.SelectedIndex);
            MessageBox.Show("Selected Item : "+comboBox1.SelectedItem);
            MessageBox.Show("Selected Item index: "+comboBox1.Items[comboBox1.SelectedIndex]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(object o in listBox1.SelectedItems)
            {
                MessageBox.Show("Selected is :" + o);
                //MessageBox.Show("Selected Index : " + listBox1.SelectedIndex);
                //MessageBox.Show("Selected Item : " + listBox1.SelectedItem);
                //MessageBox.Show("Selected Item index: " + listBox1.Items[listBox1.SelectedIndex]);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s = "";
            foreach (object o in checkedListBox1.CheckedItems)
            {
                s += o+", ";
               
                //MessageBox.Show("Selected is: " + checkedListBox1.Text);
                //MessageBox.Show("Selected Index : " + checkedListBox1.SelectedIndex);
                //MessageBox.Show("Selected Item : " + checkedListBox1.SelectedItem);
                //MessageBox.Show("Selected Item index: " + checkedListBox1.Items[checkedListBox1.SelectedIndex]);
            }
            s=s.Substring(0, s.Length-2);
            //MessageBox.Show("Selected is :" + s);
            int k=s.LastIndexOf(',');
            //MessageBox.Show("index : "+k);
            if(k!=-1)
            {
                s = s.Remove(k, 1);
                s = s.Insert(k, " and ");
            }
            //string ss = s.Remove(k);
            MessageBox.Show("asf: " + s);


        }
    }
}
