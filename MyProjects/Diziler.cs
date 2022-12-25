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
    public partial class Diziler : Form
    {
        public Diziler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string[] sehirler = { "Deadly", "Ertuğrul", "Fatih", "Kara", "Evo" };
            for (int i = 0; i <sehirler.Length; i++)
            {
                listBox1.Items.Add(i+"."+sehirler[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int[] sayi = { 53, 633, 6, 8, 12, 320, 50, 10, 18, 17, 86, 42, 40, 54 };

            for (int i = 0; i < sayi.Length; i++)
            {
                if (sayi[i]%2==0)
                {
                    listBox1.Items.Add(sayi[i]);
                }
            }
        }
    }
}
