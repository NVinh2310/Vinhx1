using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("nhap ten di bro");
            }
            else
            {
                textBox2.Text = Total().ToString();
            }


        }

        private double Total()
        {
            double t = 0;
            if (checkBox1.Checked)
                t += 100000;
            if (checkBox2.Checked)
                t += 1200000;
            if (checkBox3.Checked)
                t += 200000;
            //string select = comboBox1.SelectedItem.ToString();
            //int r = Convert.ToInt32(select);
            // t += r * 80000;
            t += Convert.ToInt32(comboBox1.SelectedItem.ToString()) * 80000;
            return t;
        }
    }
}
