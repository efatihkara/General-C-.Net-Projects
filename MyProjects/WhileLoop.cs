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
    public partial class WhileLoop : Form
    {
        public WhileLoop()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="")
            {
                MessageBox.Show("Lütfen metin kutucuğunu doldurun","Hata");

            }
            else
            {
                if (radioButton1.Checked==true)
                {//5
                    int i = 1;
                    listBox1.Items.Clear();
                    while (i<=5)
                    {
                        listBox1.Items.Add(i+". "+textBox1.Text);
                        i++;
                    }

                }
                if (radioButton2.Checked==true)
                {//10
                    int i = 1;
                    listBox1.Items.Clear();
                    while (i<=10)
                    {
                        listBox1.Items.Add(i+". "+textBox1.Text);
                        i++;
                    }
                }
                if (radioButton3.Checked==true)
                {//20
                    int i = 1;
                    listBox1.Items.Clear();
                    while (i<=20)
                    {
                        listBox1.Items.Add(i+". "+textBox1.Text);
                        i++;
                    }
                }
                if (radioButton4.Checked==true)
                {//30
                    int i = 1;
                    listBox1.Items.Clear();
                    while (i<=30)
                    {
                        listBox1.Items.Add(i+". "+textBox1.Text);
                        i++;
                    }
                }
               
            }
        }
    }
}
