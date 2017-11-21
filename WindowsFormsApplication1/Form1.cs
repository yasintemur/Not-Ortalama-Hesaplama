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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string adi, soyadi, no, tc;
        private void button1_Click(object sender, EventArgs e)
        {
            adi = textBox1.Text;
            soyadi = textBox2.Text;
            no = textBox3.Text;
            tc = textBox4.Text;
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                label5.Text = "Lütfen Bilgileri Eksiksiz Giriniz";
            }
            else
            {
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }
        }
    }
}
