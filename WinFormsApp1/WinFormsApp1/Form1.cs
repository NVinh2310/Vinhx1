using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(textBox1.Text);
            //listBox1.Items.Add(textBox1.Text);
            //textBox1.Text = listBox1.SelectedItem.ToString();
            // textBox1.Text = listBox1.SelectedIndex.ToString();
            //ListBox.SelectedObjectCollection r = listBox1.SelectedItems;
            String txt = textBox1.Text;
                if(txt !="")
            {
                if(listBox1.Items.IndexOf(txt) <0)
                {
                    listBox1.Items.Add(txt);
                }    
                else
                {
                    MessageBox.Show("Trùng rồi kìa bro");
                }    
            }    else
                MessageBox.Show("nhập vào textBox kìa bro");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            String txt = textBox1.Text;
            if (txt != "")
            {
                if (comboBox1.Items.IndexOf(txt) < 0)
                {
                    comboBox1.Items.Add(txt);
                }
                else
                {
                    MessageBox.Show("Trùng rồi kìa bro");
                }
            }
            else
                MessageBox.Show("nhập vào textBox kìa bro");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            textBox1.Text = comboBox1.Items[index].ToString();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(checkBox1.Checked.ToString());
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(radioButton1.Checked.ToString());
        }
    }
}
