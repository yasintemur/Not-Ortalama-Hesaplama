using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public static double sonuckapsa;
        private void button1_Click(object sender, EventArgs e)
        {
            sonuckapsa = Math.Round(sonuckapsa, 2);
            double beden, dva, din, felsefe, grafik, ntp, inklap, edebiyat, web, ingilizce;
            beden = 0;
            dva = 0;
            din = 0;
            felsefe = 0;
            grafik = 0;
            ntp = 0;
            inklap = 0;
            edebiyat = 0;
            web = 0;
            ingilizce = 0;
            double sonuc1, sonuc2, sonuc3, sonuc4, sonuc5, sonuc6, sonuc7, sonuc8, sonuc9, sonuc10;
            beden = Convert.ToDouble(textBox1.Text);
            dva = Convert.ToDouble(textBox2.Text);
            din = Convert.ToDouble(textBox3.Text);
            felsefe = Convert.ToDouble(textBox4.Text);
            grafik = Convert.ToDouble(textBox5.Text);
            ntp = Convert.ToDouble(textBox6.Text);
            inklap = Convert.ToDouble(textBox7.Text);
            edebiyat = Convert.ToDouble(textBox8.Text);
            web = Convert.ToDouble(textBox9.Text);
            ingilizce = Convert.ToDouble(textBox10.Text);
            sonuc1 = beden * 2;
            sonuc2 = dva * 2;
            sonuc3 = din * 1;
            sonuc4 = felsefe * 2;
            sonuc5 = grafik * 6;
            sonuc6 = ntp * 5;
            sonuc7 = inklap * 2;
            sonuc8 = edebiyat * 3;
            sonuc9 = web * 12;
            sonuc10 = ingilizce * 4;
            sonuckapsa = (sonuc1 + sonuc2 + sonuc3 + sonuc4 + sonuc5 + sonuc6 + sonuc7 + sonuc8 + sonuc9 + sonuc10) / 39;
            if (sonuckapsa >= 70 && sonuckapsa <= 84)
            {
                Form3 f3 = new Form3();
                f3.Show();
                this.Hide();
            }
            else if (sonuckapsa >= 85 && sonuckapsa <= 100)
            {
                Form4 f4 = new Form4();
                f4.Show();
                this.Hide();
            }
            else if (sonuckapsa >= 50 && sonuckapsa <= 69)
            {
                lbl_sonuc.Text = sonuckapsa + " notunuz ile Hiçbir Belge alamıyorsunuz.";
            }
            else
            {
                lbl_sonuc.Text = sonuckapsa + " notunuz ile KALDINIZ.";
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label14.Text = "Hoşgeldiniz Sayın " + Form1.adi + " " + Form1.soyadi;
        }
    }
}
