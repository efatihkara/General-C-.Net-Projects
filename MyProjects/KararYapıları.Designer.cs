namespace MyProjects
{
    partial class KararYapıları
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
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.rdbtnmod2 = new System.Windows.Forms.RadioButton();
            this.rdbtnmod3 = new System.Windows.Forms.RadioButton();
            this.rdbtnmod5 = new System.Windows.Forms.RadioButton();
            this.rdbtnmod7 = new System.Windows.Forms.RadioButton();
            this.rdbtnmodtam = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "Getir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(91, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(214, 160);
            this.listBox1.TabIndex = 1;
            // 
            // rdbtnmod2
            // 
            this.rdbtnmod2.AutoSize = true;
            this.rdbtnmod2.Location = new System.Drawing.Point(12, 194);
            this.rdbtnmod2.Name = "rdbtnmod2";
            this.rdbtnmod2.Size = new System.Drawing.Size(58, 17);
            this.rdbtnmod2.TabIndex = 2;
            this.rdbtnmod2.TabStop = true;
            this.rdbtnmod2.Text = "Mod 2 ";
            this.rdbtnmod2.UseVisualStyleBackColor = true;
            // 
            // rdbtnmod3
            // 
            this.rdbtnmod3.AutoSize = true;
            this.rdbtnmod3.Location = new System.Drawing.Point(103, 194);
            this.rdbtnmod3.Name = "rdbtnmod3";
            this.rdbtnmod3.Size = new System.Drawing.Size(55, 17);
            this.rdbtnmod3.TabIndex = 3;
            this.rdbtnmod3.TabStop = true;
            this.rdbtnmod3.Text = "Mod 3";
            this.rdbtnmod3.UseVisualStyleBackColor = true;
            // 
            // rdbtnmod5
            // 
            this.rdbtnmod5.AutoSize = true;
            this.rdbtnmod5.Location = new System.Drawing.Point(194, 194);
            this.rdbtnmod5.Name = "rdbtnmod5";
            this.rdbtnmod5.Size = new System.Drawing.Size(55, 17);
            this.rdbtnmod5.TabIndex = 4;
            this.rdbtnmod5.TabStop = true;
            this.rdbtnmod5.Text = "Mod 5";
            this.rdbtnmod5.UseVisualStyleBackColor = true;
            // 
            // rdbtnmod7
            // 
            this.rdbtnmod7.AutoSize = true;
            this.rdbtnmod7.Location = new System.Drawing.Point(285, 194);
            this.rdbtnmod7.Name = "rdbtnmod7";
            this.rdbtnmod7.Size = new System.Drawing.Size(55, 17);
            this.rdbtnmod7.TabIndex = 5;
            this.rdbtnmod7.TabStop = true;
            this.rdbtnmod7.Text = "Mod 7";
            this.rdbtnmod7.UseVisualStyleBackColor = true;
            // 
            // rdbtnmodtam
            // 
            this.rdbtnmodtam.AutoSize = true;
            this.rdbtnmodtam.Location = new System.Drawing.Point(152, 230);
            this.rdbtnmodtam.Name = "rdbtnmodtam";
            this.rdbtnmodtam.Size = new System.Drawing.Size(89, 17);
            this.rdbtnmodtam.TabIndex = 6;
            this.rdbtnmodtam.TabStop = true;
            this.rdbtnmodtam.Text = "Tam Bölenleri";
            this.rdbtnmodtam.UseVisualStyleBackColor = true;
            // 
            // KararYapıları
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 373);
            this.Controls.Add(this.rdbtnmodtam);
            this.Controls.Add(this.rdbtnmod7);
            this.Controls.Add(this.rdbtnmod5);
            this.Controls.Add(this.rdbtnmod3);
            this.Controls.Add(this.rdbtnmod2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Name = "KararYapıları";
            this.Text = "KararYapıları";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton rdbtnmod2;
        private System.Windows.Forms.RadioButton rdbtnmod3;
        private System.Windows.Forms.RadioButton rdbtnmod5;
        private System.Windows.Forms.RadioButton rdbtnmod7;
        private System.Windows.Forms.RadioButton rdbtnmodtam;
    }
}