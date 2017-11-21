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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Form2.sonuckapsa = Math.Round(Form2.sonuckapsa, 2);
            label1.Text = Form1.no;
            label2.Text = Form1.adi + " " + Form1.soyadi;
            label11.Text = Form2.sonuckapsa.ToString();
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
