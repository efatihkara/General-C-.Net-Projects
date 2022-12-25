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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ardsıktoplama form2 =new ardsıktoplama();
            form2.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            KararYapıları form3 =new KararYapıları();
            form3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WhileLoop form4 = new WhileLoop();
            form4.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            doWhile form5 =new doWhile();
            form5.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TimerUsed form6 =new TimerUsed();
            form6.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DigitalClock form7 = new DigitalClock();
            form7.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ProgressBar form8 = new ProgressBar();
            form8.ShowDialog();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            PastaPisirmeSürec form9=new PastaPisirmeSürec();
            form9.ShowDialog();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Diziler form10=new Diziler();
            form10.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Foreach form11 = new Foreach();
            form11.ShowDialog();
        }
    }
}
