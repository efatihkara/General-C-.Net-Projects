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
    public partial class TimerUsed : Form
    {
        public TimerUsed()
        {
            InitializeComponent();
        }
        int sayac = 0;
        private void btnbaslat_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            
           
            if (sayac==30)
            {
                pictureBox4.Visible= false;
                pictureBox2.Visible=true;
            }
            if (sayac==40)
            {
                pictureBox2.Visible=false;
                pictureBox3.Visible=true;


            }
            if (sayac==50)
            {
                timer1.Stop();
                pictureBox2.Visible=false;
                pictureBox3.Visible=false;
                pictureBox4.Visible=true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void TimerUsed_Load(object sender, EventArgs e)
        {
            timer1.Start();
            pictureBox2.Visible=false;
            pictureBox3.Visible=false;
            pictureBox4.Visible=false;
        }
    }
}
