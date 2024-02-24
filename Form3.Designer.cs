namespace WindowsFormsApp2
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPlace = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbWebDev = new System.Windows.Forms.CheckBox();
            this.cbHtmlcss = new System.Windows.Forms.CheckBox();
            this.cbDotnet = new System.Windows.Forms.CheckBox();
            this.cbJavascript = new System.Windows.Forms.CheckBox();
            this.cbVLSI = new System.Windows.Forms.CheckBox();
            this.cbPhyton = new System.Windows.Forms.CheckBox();
            this.cbOracle = new System.Windows.Forms.CheckBox();
            this.cbJava = new System.Windows.Forms.CheckBox();
            this.cbCLang = new System.Windows.Forms.CheckBox();
            this.tbTotalFee = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(238, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Online Training Pro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(91, 89);
            this.tbName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(113, 20);
            this.tbName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Place";
            // 
            // tbPlace
            // 
            this.tbPlace.Location = new System.Drawing.Point(91, 117);
            this.tbPlace.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPlace.Name = "tbPlace";
            this.tbPlace.Size = new System.Drawing.Size(113, 20);
            this.tbPlace.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbWebDev);
            this.panel1.Controls.Add(this.cbHtmlcss);
            this.panel1.Controls.Add(this.cbDotnet);
            this.panel1.Controls.Add(this.cbJavascript);
            this.panel1.Controls.Add(this.cbVLSI);
            this.panel1.Controls.Add(this.cbPhyton);
            this.panel1.Controls.Add(this.cbOracle);
            this.panel1.Controls.Add(this.cbJava);
            this.panel1.Controls.Add(this.cbCLang);
            this.panel1.Location = new System.Drawing.Point(32, 173);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 151);
            this.panel1.TabIndex = 7;
            // 
            // cbWebDev
            // 
            this.cbWebDev.AutoSize = true;
            this.cbWebDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWebDev.Location = new System.Drawing.Point(454, 112);
            this.cbWebDev.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbWebDev.Name = "cbWebDev";
            this.cbWebDev.Size = new System.Drawing.Size(162, 17);
            this.cbWebDev.TabIndex = 8;
            this.cbWebDev.Tag = "4000";
            this.cbWebDev.Text = "WebDevelopment(4000)";
            this.cbWebDev.UseVisualStyleBackColor = true;
            this.cbWebDev.CheckedChanged += new System.EventHandler(this.cbCLang_CheckedChanged);
            // 
            // cbHtmlcss
            // 
            this.cbHtmlcss.AutoSize = true;
            this.cbHtmlcss.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHtmlcss.Location = new System.Drawing.Point(454, 65);
            this.cbHtmlcss.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbHtmlcss.Name = "cbHtmlcss";
            this.cbHtmlcss.Size = new System.Drawing.Size(119, 17);
            this.cbHtmlcss.TabIndex = 7;
            this.cbHtmlcss.Tag = "4000";
            this.cbHtmlcss.Text = "Html, CSS(4000)";
            this.cbHtmlcss.UseVisualStyleBackColor = true;
            this.cbHtmlcss.CheckedChanged += new System.EventHandler(this.cbCLang_CheckedChanged);
            // 
            // cbDotnet
            // 
            this.cbDotnet.AutoSize = true;
            this.cbDotnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDotnet.Location = new System.Drawing.Point(454, 24);
            this.cbDotnet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbDotnet.Name = "cbDotnet";
            this.cbDotnet.Size = new System.Drawing.Size(111, 17);
            this.cbDotnet.TabIndex = 6;
            this.cbDotnet.Tag = "10000";
            this.cbDotnet.Text = "Dot net(10000)";
            this.cbDotnet.UseVisualStyleBackColor = true;
            this.cbDotnet.CheckedChanged += new System.EventHandler(this.cbCLang_CheckedChanged);
            // 
            // cbJavascript
            // 
            this.cbJavascript.AutoSize = true;
            this.cbJavascript.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbJavascript.Location = new System.Drawing.Point(254, 112);
            this.cbJavascript.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbJavascript.Name = "cbJavascript";
            this.cbJavascript.Size = new System.Drawing.Size(120, 17);
            this.cbJavascript.TabIndex = 5;
            this.cbJavascript.Tag = "5000";
            this.cbJavascript.Text = "Javascript(5000)";
            this.cbJavascript.UseVisualStyleBackColor = true;
            this.cbJavascript.CheckedChanged += new System.EventHandler(this.cbCLang_CheckedChanged);
            // 
            // cbVLSI
            // 
            this.cbVLSI.AutoSize = true;
            this.cbVLSI.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVLSI.Location = new System.Drawing.Point(254, 65);
            this.cbVLSI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbVLSI.Name = "cbVLSI";
            this.cbVLSI.Size = new System.Drawing.Size(89, 17);
            this.cbVLSI.TabIndex = 4;
            this.cbVLSI.Tag = "9000";
            this.cbVLSI.Text = "VLSI(9000)";
            this.cbVLSI.UseVisualStyleBackColor = true;
            this.cbVLSI.CheckedChanged += new System.EventHandler(this.cbCLang_CheckedChanged);
            // 
            // cbPhyton
            // 
            this.cbPhyton.AutoSize = true;
            this.cbPhyton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPhyton.Location = new System.Drawing.Point(254, 24);
            this.cbPhyton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbPhyton.Name = "cbPhyton";
            this.cbPhyton.Size = new System.Drawing.Size(101, 17);
            this.cbPhyton.TabIndex = 3;
            this.cbPhyton.Tag = "3000";
            this.cbPhyton.Text = "Python(3000)";
            this.cbPhyton.UseVisualStyleBackColor = true;
            this.cbPhyton.CheckedChanged += new System.EventHandler(this.cbCLang_CheckedChanged);
            // 
            // cbOracle
            // 
            this.cbOracle.AutoSize = true;
            this.cbOracle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOracle.Location = new System.Drawing.Point(31, 112);
            this.cbOracle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbOracle.Name = "cbOracle";
            this.cbOracle.Size = new System.Drawing.Size(99, 17);
            this.cbOracle.TabIndex = 2;
            this.cbOracle.Tag = "4000";
            this.cbOracle.Text = "Oracle(4000)";
            this.cbOracle.UseVisualStyleBackColor = true;
            this.cbOracle.CheckedChanged += new System.EventHandler(this.cbCLang_CheckedChanged);
            // 
            // cbJava
            // 
            this.cbJava.AutoSize = true;
            this.cbJava.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbJava.Location = new System.Drawing.Point(31, 65);
            this.cbJava.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbJava.Name = "cbJava";
            this.cbJava.Size = new System.Drawing.Size(89, 17);
            this.cbJava.TabIndex = 1;
            this.cbJava.Tag = "2300";
            this.cbJava.Text = "Java(2300)";
            this.cbJava.UseVisualStyleBackColor = true;
            this.cbJava.CheckedChanged += new System.EventHandler(this.cbCLang_CheckedChanged);
            // 
            // cbCLang
            // 
            this.cbCLang.AutoSize = true;
            this.cbCLang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCLang.Location = new System.Drawing.Point(31, 24);
            this.cbCLang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbCLang.Name = "cbCLang";
            this.cbCLang.Size = new System.Drawing.Size(130, 17);
            this.cbCLang.TabIndex = 0;
            this.cbCLang.Tag = "1000";
            this.cbCLang.Text = "C Language(1000)";
            this.cbCLang.UseVisualStyleBackColor = true;
            this.cbCLang.CheckedChanged += new System.EventHandler(this.cbCLang_CheckedChanged);
            // 
            // tbTotalFee
            // 
            this.tbTotalFee.Location = new System.Drawing.Point(528, 92);
            this.tbTotalFee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbTotalFee.Name = "tbTotalFee";
            this.tbTotalFee.ReadOnly = true;
            this.tbTotalFee.Size = new System.Drawing.Size(113, 20);
            this.tbTotalFee.TabIndex = 4;
            this.tbTotalFee.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(458, 94);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Fee";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 372);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 44);
            this.button1.TabIndex = 8;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(446, 372);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 44);
            this.button2.TabIndex = 9;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(685, 444);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbTotalFee);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbPlace);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPlace;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbWebDev;
        private System.Windows.Forms.CheckBox cbHtmlcss;
        private System.Windows.Forms.CheckBox cbDotnet;
        private System.Windows.Forms.CheckBox cbJavascript;
        private System.Windows.Forms.CheckBox cbVLSI;
        private System.Windows.Forms.CheckBox cbPhyton;
        private System.Windows.Forms.CheckBox cbOracle;
        private System.Windows.Forms.CheckBox cbJava;
        private System.Windows.Forms.CheckBox cbCLang;
        private System.Windows.Forms.TextBox tbTotalFee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}