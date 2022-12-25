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
    public partial class KararYapıları : Form
    {
        public KararYapıları()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdbtnmod2.Checked==true)
            {
                listBox1.Items.Clear();
                for (int i = 0; i <=100; i++)
                {
                    if (i%2==0)
                    {
                       
                        listBox1.Items.Add(i);
                    }
                }
            }
            if (rdbtnmod3.Checked==true)
            {
                listBox1.Items.Clear();
                for (int i = 0; i <=100; i++)
                {
                    if (i%3==0)
                    {
                       
                        listBox1.Items.Add(i);
                    }
                }
            }
            if (rdbtnmod5.Checked==true)
            {
                listBox1.Items.Clear();
                for (int i = 0; i <=100; i++)
                {
                    if (i%5==0)
                    {
                        listBox1.Items.Add(i);
                    }
                }
            }
            if (rdbtnmod7.Checked==true)
            {
                listBox1.Items.Clear();
                for (int i = 0; i <=100; i++)
                {
                    if (i%7==0)
                    {
                        listBox1.Items.Add(i);
                    }
                }
            }
            if (rdbtnmodtam.Checked==true)
            {
                listBox1.Items.Clear();
                for (int i = 1; i <=100; i++)
                {
                    if (100%i==0)
                    {
                        listBox1.Items.Add(i);
                    }
                }
            }






        }
        
    }
}
