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
    public partial class ardsıktoplama : Form
    {
        public ardsıktoplama()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            int toplanan = 0;
            int artıs = Convert.ToInt32(txtboxartıs.Text);
            int sonsayi = Convert.ToInt32(txtboxsonsayı.Text);

            for (int i = artıs; i <= sonsayi; i+=artıs)
            {

               toplam=toplam+i;
                toplanan+=1;
                
            }
            lblsonuc.Text=toplam.ToString();
            label5.Text=Convert.ToString(toplanan);
        }
    }
}
