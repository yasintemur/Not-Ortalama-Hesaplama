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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            Form2.sonuckapsa = Math.Round(Form2.sonuckapsa, 2);
            label1.Text = Form1.tc;
            label2.Text = "11-AA " + Form1.no;
            label3.Text = "2014-2015";
            label6.Text = Form1.adi + " " + Form1.soyadi;
            label9.Text = Form2.sonuckapsa.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
