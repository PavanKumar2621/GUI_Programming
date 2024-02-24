using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void cbCLang_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox c = (CheckBox)sender;
            int x=int.Parse(tbTotalFee.Text);
            if(c.Checked)
                x += Convert.ToInt32( c.Tag);
            else
                x -= Convert.ToInt32(c.Tag);
            tbTotalFee.Text=x.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult d= MessageBox.Show("Are you want to close the Form", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(d == DialogResult.Yes)
                this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control c in panel1.Controls)
            {
                CheckBox ch = (CheckBox)c;
                ch.Checked = false;
            }
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox ch = (TextBox)c;
                    ch.Clear();
                }
            }
            tbTotalFee.Text = "0";
            tbName.Focus();
        }

        
    }
}
