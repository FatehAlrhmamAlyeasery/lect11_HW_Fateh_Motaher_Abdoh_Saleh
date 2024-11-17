using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lect11_fateh_motaher_abdoh_saleh
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = DateTime.Now.ToString("D");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = DateTime.Now.ToString("t");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox4.Text = DateTime.Now.ToString("yy");
            textBox5.Text = DateTime.Now.ToString("MM");
            textBox6.Text = DateTime.Now.ToString("dd");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox7.Text = DateTime.Now.ToString("hh");
            textBox8.Text = DateTime.Now.ToString("mm");
            textBox9.Text = DateTime.Now.ToString("ss");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {//الاحتياطات
            textBox1.ReadOnly = textBox2.ReadOnly = textBox3.ReadOnly = textBox4.ReadOnly = textBox5.ReadOnly =
                textBox6.ReadOnly = textBox7.ReadOnly = textBox8.ReadOnly = textBox9.ReadOnly = true;
        }
    }
}
