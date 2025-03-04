using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace modul3_103022330059
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        int hasil;

        private void btnTambah_Click(object sender, EventArgs e)
        {
            hasil += Convert.ToInt32(richTextBox1.Text);
            richTextBox1.Text = "";
        }

        private void btnHasil_Click(object sender, EventArgs e)
        {
            hasil += Convert.ToInt32(richTextBox1.Text);
            richTextBox1.Text = hasil.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string input = button3.Text;
            richTextBox1.Text += input;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string input = button4.Text;
            richTextBox1.Text += input;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string input = button6.Text;
            richTextBox1.Text += input;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string input = button7.Text;
            richTextBox1.Text += input;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string input = button8.Text;
            richTextBox1.Text += input;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string input = button9.Text;
            richTextBox1.Text += input;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string input = button10.Text;
            richTextBox1.Text += input;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string input = button11.Text;
            richTextBox1.Text += input;
        }
    }
}
