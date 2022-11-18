using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bir_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void iki_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void uc_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void sifir_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }
        private void dort_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }
        private void bes_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }
        private void alti_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }
        private void yedi_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }
        private void sekiz_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }
        private void dokuz_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";        }
        private void nokta_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }
        private void bol_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
        }
        private void carp_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
        }
        private void topla_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }
        private void cikart_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }
        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            
        }

        double sonuc=0;
        private void esittir_Click(object sender, EventArgs e)
        {
            char[] isaret = { '+', '-', '*', '/' };
            String[] dizi = new String[5];
            String islem=textBox1.Text;
            if (islem.Contains("+"))
            {
                dizi=islem.Split(isaret);
                sonuc = Convert.ToDouble(dizi[0]) + Convert.ToDouble(dizi[1]) ;
                textBox1.Text = sonuc.ToString();
            }
            if (islem.Contains("-"))
            {
                dizi = islem.Split(isaret);
                sonuc = Convert.ToDouble(dizi[0]) - Convert.ToDouble(dizi[1]) ;
                textBox1.Text = sonuc.ToString();
            }
            if (islem.Contains("*"))
            {
                dizi = islem.Split(isaret);
                sonuc = Convert.ToDouble(dizi[0]) * Convert.ToDouble(dizi[1]) ;
                textBox1.Text = sonuc.ToString();
            }
            if (islem.Contains("/"))
            {
                dizi = islem.Split(isaret);
                sonuc = Convert.ToDouble(dizi[0]) / Convert.ToDouble(dizi[1]) ;
                textBox1.Text = sonuc.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
