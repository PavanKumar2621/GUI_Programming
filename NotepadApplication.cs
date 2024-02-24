using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp2
{
    public partial class NotepadApplication : Form
    {
        public NotepadApplication()
        {
            InitializeComponent();
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wordWrapToolStripMenuItem.Checked)
            {
                wordWrapToolStripMenuItem.Checked = false;
                richTextBox1.WordWrap = false;
            }
            else
            {
                wordWrapToolStripMenuItem.Checked = true;
                richTextBox1.WordWrap = true;
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (richTextBox1.Text.Length > 0)
            {
                DialogResult d=MessageBox.Show($"Do you want to save changes to {richTextBox1.Text}.txt", "Notepad", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    saveFile();
                }
                else if (d == DialogResult.No)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
             
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "";
        }
        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (statusBarToolStripMenuItem.Checked)
            {
                statusBarToolStripMenuItem.Checked = false;
                statusStrip1.Visible = false;
            }
            else
            {
                statusBarToolStripMenuItem.Checked = true;
                statusStrip1.Visible = true;
            }

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 a = new AboutBox1();
            a.ShowDialog();
        }

        private void fonrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult d = fontDialog1.ShowDialog();
            if (d == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }
         

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Text Documents|*.txt|CS Files|*.cs|All Files|*.*";

            DialogResult d = openFileDialog1.ShowDialog();
            if (d == DialogResult.OK)
            {
                string s = openFileDialog1.FileName;
                int pos = s.LastIndexOf("\\");
                string name = s.Substring(pos + 1);
                string filename;
                if (name.Contains("."))
                {
                    int lastdotpos = name.LastIndexOf(".");
                    filename = name.Substring(0, lastdotpos);
                }
                else
                {
                    filename= name;
                }
                try
                {
                    richTextBox1.Text = File.ReadAllText(s);
                    this.Text = $"{filename} - Notepad";
                    /* File.ReadAllText() method reads all content of selected file 
                                                               Display on the notpad */

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
        }
        private void saveFile()
        {
            saveFileDialog1.FileName = richTextBox1.Text;
            saveFileDialog1.Filter = "Text Documents|*.txt|All Files|*.*";
            DialogResult d = saveFileDialog1.ShowDialog();
            if (d == DialogResult.OK)
            {

                string s = saveFileDialog1.FileName;
                int pos = s.LastIndexOf("\\"); 
                string s1= s.Substring(pos + 1);
                string filename;
                if (s1.Contains("."))
                {
                    int lastdotpos = s1.LastIndexOf(".");
                    filename = s1.Substring(0, lastdotpos);
                }
                else
                {
                    filename =  s1;
                }
                try
                {
                    File.WriteAllText(s, richTextBox1.Text);
                    //MessageBox.Show("Text saved successfully");
                    this.Text = $"{filename} - Notepad";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving text: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }


        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            int pos = richTextBox1.SelectionStart;
            int line= richTextBox1.GetLineFromCharIndex(pos) + 1;
            int col = pos - richTextBox1.GetFirstCharIndexOfCurrentLine() + 1;
            tsStatusLabel1.Text = $"Ln {line}, Col {col}";
            //MessageBox.Show(pos + " " + line);
            long len=0;
            foreach(char c in richTextBox1.Text)
            {
                if(c == '\t')
                {
                    len = richTextBox1.Text.Length+1;
                }
                else
                    len = richTextBox1.Text.Length;
            }
            tsStatusLabel2.Text = $"{len} Characters";
            
        }
        
        private void zoomToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor  += 0.1f;
            tsStatusLabel3.Text = $" {Math.Round(richTextBox1.ZoomFactor * 100)}%";

        }
        private float z = 0.1f;
        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(z< richTextBox1.ZoomFactor)
            {
                richTextBox1.ZoomFactor -= 0.1f;
            }
            tsStatusLabel3.Text = $" {Math.Round(richTextBox1.ZoomFactor * 100)}%";
        }
        
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            this.Text = this.Tag.ToString();
        }

        private void timeDaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            string dateTimeformat = dateTime.ToString("h:mm tt dd-MM-yyyy");
            richTextBox1.Text += dateTimeformat;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult d = colorDialog1.ShowDialog();
            if(d == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
            }
        }
    }
 }

