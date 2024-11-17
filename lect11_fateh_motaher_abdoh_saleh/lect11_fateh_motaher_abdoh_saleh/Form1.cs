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
    public partial class Form1 : Form
    {
        TextBox txtb1;
        Button add;
        Label lbl1;
        Panel pan1;
        Button clear;
        ListBox lst;
        Timer tim;
        Button b1;
        public Form1()
        {
            InitializeComponent();
            txtb1 = new TextBox();
            clear = new Button();
            add = new Button();
            b1 = new Button();
            lbl1 = new Label();
            lst = new ListBox();
            pan1 = new Panel();
            tim = new Timer();
            this.Width = 400;
            this.Height = 500;
            add.Text = "add";
            add.Click += addclick;
            lbl1.Text = "insert";
            clear.Text = "claere";
            clear.Click += clclick;
            pan1.Width = 200;
            pan1.Height = 255;
            pan1.BackColor = Color.Gray;
            add.Click += all;
            clear.Click += all;
            tim.Tick += ttick;
            tim.Interval = 1020;
            tim.Enabled = true;
            design();
            visual();

        }
        public void design()
        { add.Top = 31;add.Left = 12;lst.Top = 60;txtb1.Top = 10;lbl1.Left = 110;lbl1.Top = 10;
            txtb1.Width = 80;txtb1.Height = 30;
            clear.Top = 170; pan1.Left = 30;pan1.Top = 10;
            b1.Top = 212;
        }
        public void visual()
        {
            Control[] tools = {  add, lbl1, txtb1, lst, clear };
            pan1.Controls.AddRange(tools);
            this.Controls.Add(pan1);
            this.Controls.Add(b1);
            pan1.AutoSize = true;//احتياط
            pan1.AutoScroll = true;//احتياط
        }
        private void addclick(object sender,EventArgs e)
        {
            if (txtb1.Text.Trim() != null)
            
                lst.Items.Add(txtb1.Text.Trim());
                else
                MessageBox.Show("the text is null");
            

        }
        private void clclick(object sender,EventArgs e)
        {
            List<string> students = new List<string>();
            students.Add("fateh");
            students.Add("hosam");
            students.Add("mounawar");
            students.Add("saker");
            foreach (string c in students)
            { 
                MessageBox.Show(c);
            }
            students.Clear();
            foreach(object c in Controls)
            {
                if(c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                else if(c is ListBox)
                {
                    ((ListBox)c).ClearSelected();
                }
                else if(c is Button)
                {
                    ((Button)c).Text = null;
                }
                else if(c is Label)
                {
                    ((Label)c).Text = null;
                }
            }
        }
        private void all(object sender ,EventArgs e)
        {
            Object obj = (sender);
            if (obj is TextBox)
            {
                MessageBox.Show("this is textbox");
            }
            else if (obj is Label)
                MessageBox.Show("this is label");
            else if (obj is Button)
                MessageBox.Show("this is button");
        }
        int count = 0;
        private void ttick(object sender,EventArgs e)
        {
            all(sender, e);//ربط حدث tick بحدث all
            lbl1.Text += 1.ToString();
            lst.Items.Add(++count);
        }
    }
}
