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
    public partial class doWhile : Form
    {
        public doWhile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int sayac = 0;
            //int sayi = Convert.ToInt16(textBox1.Text);
            //bool kontrol = false;

            //do
            //{
            //    for (int i = 1; i <=sayi; i++)
            //    {
            //        if (sayi%i==0)
            //        {

            //            kontrol=false;
            //        }
            //    }
            //} 
            //while (kontrol);
            //{

            //    for (int i = 2; i < sayi; i++)
            //    {
            //        sayac=0;
            //        for (int j = 2; j < i; j++)
            //        {
            //            if (i%j==0)
            //            {
            //                sayac++;

            //            }
            //        }
            //        if(sayac==0)
            //        {
            //            listBox1.Items.Add("Asal sayılar ="+i);


            //        }

            //    }
            //    kontrol=false;



            //}

            int sayac = 0;
            int sayi = Convert.ToInt16(textBox1.Text);
            bool kontrol = false;

            do
            {
                for (int i = 1; i <=sayi; i++)
                {
                    if (sayi%i==0)
                    {
                        kontrol=true;
                        break;
                    }
                }
                kontrol = false;
            }
            while (kontrol);

            for (int i = 2; i < sayi; i++)
            {
                sayac=0;
                for (int j = 2; j < i; j++)
                {
                    if (i%j==0)
                    {
                        sayac++;
                        break;
                    }
                }
                if (sayac==0)
                {
                    listBox1.Items.Add("Asal sayılar ="+i);
                }
            }

        }
    }
}
