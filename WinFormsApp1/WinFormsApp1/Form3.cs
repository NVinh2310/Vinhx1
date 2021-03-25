using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            create_col();
            create_row();
        }

        public void create_col()
        {
            ColumnHeader c1 = new ColumnHeader();
            c1.Text = "MSSV";
            ColumnHeader c2 = new ColumnHeader();
            c2.Text = "Tên";
            ColumnHeader c3 = new ColumnHeader();
            c2.Text = "Lớp sh";
            listView1.Columns.AddRange(new ColumnHeader[] { c1, c2, c3 });
            
                }
        public void create_row()
        {
            ListViewItem i1 = new ListViewItem();
            i1.Text = "10001";
            ListViewItem.ListViewSubItem i2 = new ListViewItem.ListViewSubItem();
            i2.Text = "NNV";
            ListViewItem.ListViewSubItem i3 = new ListViewItem.ListViewSubItem();
            i3.Text = "T1";
            i1.SubItems.AddRange(new ListViewItem.ListViewSubItem[] { i2, i3 });

        }
    }
}
