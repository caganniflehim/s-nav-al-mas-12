using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace sınav_çalışması12
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sale;
            double markap;
            if (double.TryParse(textBox1.Text, out sale) && double.TryParse(textBox2.Text, out markap))
            {
                double retailprice;
                retailprice = calculateretawil(sale, markap);
                textBox3.Text = retailprice.ToString("c");
            }
            else
            {
                MessageBox.Show("lütfen geçerli bir sayı giriniz", "geçersiz girişi");
            }
           
        }

        private double calculateretawil(double sale, double markap)
        {
            double retailprice;
            retailprice = sale + sale * markap / 100;
            return retailprice;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double yag;
            double karbonhidrat;
            if (double.TryParse(textBox4.Text,out yag)&& double.TryParse(textBox5.Text,out karbonhidrat))
            {
                double yak;
                double kak;
                yak = fatcalories(yag);
                kak = carbcalories(karbonhidrat);
                listBox1.Items.Add("yagdanalınan hesap" + yag);
                listBox1.Items.Add("karbonhidrattan alınan" + karbonhidrat);
                listBox1.Items.Add("karbon ve yag toplamı" + yak + kak);
            }
            else
            {
                MessageBox.Show("geçerli şey girin");
            }
        }

        private double carbcalories(double karbonhidrat)
        {
            return karbonhidrat * 4;
        }

        private double fatcalories(double yag)
        {
            return yag * 9;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double kutle;
            double hızı;
            if (double.TryParse(textBox6.Text, out kutle) && double.TryParse(textBox7.Text, out hızı)) 
            {
                double kinetikenerji;
                kinetikenerji = kinetikenergji(kutle,hızı);
                textBox8.Text = kinetikenerji.ToString();
            }
        }

        private double kinetikenergji(double kutle, double hızı)
        {
            double kinetikenerji;
            kinetikenerji = 0.5 * kutle * Math.Pow(hızı, 2);
            return kinetikenerji;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int number;
            if (int.TryParse(textBox9.Text,out number))
            {
                if (IsPrime(number))
                {
                    MessageBox.Show(number + "asal sayılar");
                }
                else
                {
                    MessageBox.Show(number + "asal sayı değildir");
                }
                
            }
            else
             {
                    MessageBox.Show("adam akılı bir şey", "yanlıi girdin");
             }
        }

        private bool IsPrime(int number)
        {
            if (number==1||number==2||number==3)
            {
                return true;
            }
            if (number %2==0)
            {
                return false;
            }
            int kok = (int)Math.Sqrt(number);
            for (int i = 2; i < kok; i++)
            {
                if (number%i==0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
