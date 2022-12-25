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
    public partial class ProgressBar : Form
    {
        public ProgressBar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value==100)
            {

            }
            else
            {
                progressBar1.Value+=10;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value==0)
            {

            }
            else
            {
                progressBar1.Value-=10;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
            progressBar1.Value=0;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value==100)
            {
                timer1.Stop();
            }
            else
            {
                progressBar1.Value+=10;
            }
        }
    }
}
