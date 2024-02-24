using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = "";
            comboBox2.Items.Clear();
            string[] s1 = { "Andhra Pradesh", "Telengana", "TamilNadu" };
            string[] s2 = { "Alaska", "California", "Florida" };
            string[] s3 = { "Benin", "Congo", "Cabocerde" };
            switch (comboBox1.SelectedIndex)
            {
                case 0: comboBox2.Items.AddRange(s1); break;
                case 1: comboBox2.Items.AddRange(s2); break;
                case 2: comboBox2.Items.AddRange(s3); break;
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Text = "";
            comboBox3.Items.Clear();
            string[] s1 = { "RJY", "KKD", "GNT" };
            string[] s2 = { "HYD", "WRL", "KHM" };
            string[] s3 = { "CNH", "COM", "MDR" };

            string[] c1 = { "ANC", "NOM", "SIK" };
            string[] c2 = { "LOA", "SANF", "SAND" };
            string[] c3 = { "MIM", "JAM", "ORL" };

            string[] d1 = { "COT", "POR", "ABO" };
            string[] d2 = { "C1", "C2", "C3" };
            string[] d3 = { "KIV", "ALI", "KAS" };
            switch (comboBox2.SelectedItem)                          //comboBox2.Items[comboBox2.SelectedIndex]
            {
                case "Andhra Pradesh": comboBox3.Items.AddRange(s1); break;
                case "Telengana": comboBox3.Items.AddRange(s2); break;
                case "TamilNadu": comboBox3.Items.AddRange(s3); break;
                case "Alaska": comboBox3.Items.AddRange(c1); break;
                case "California": comboBox3.Items.AddRange(c2); break;
                case "Florida": comboBox3.Items.AddRange(c3); break;
                case "Benin": comboBox3.Items.AddRange(d1); break;
                case "Congo": comboBox3.Items.AddRange(d2); break;
                case "Cabocerde": comboBox3.Items.AddRange(d3); break;
            }
        }
    }
}
