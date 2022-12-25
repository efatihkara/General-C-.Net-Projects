using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProjects
{
    public partial class PastaPisirmeSürec : Form
    {
        public PastaPisirmeSürec()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value==100)
            {
                checkBox1.Checked=true;
                timer1.Stop();
                progressBar1.Value=0;
                timer2.Start();


            }
            else
            {
                progressBar1.Value+=5;
            }
        }

        private void checkedListBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value==100)
            {
                checkBox2.Checked=true;
                timer2.Stop();
                progressBar1.Value=0;
                timer3.Start();


            }
            else
            {
                progressBar1.Value+=5;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value==100)
            {
                checkBox3.Checked=true;
                timer3.Stop();
                progressBar1.Value=0;
                timer4.Start();


            }
            else
            {
                progressBar1.Value+=5;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value==100)
            {
                checkBox4.Checked=true;
                timer4.Stop();
                
                


            }
            else
            {
                progressBar1.Value+=5;
            }
        }
    }
}
