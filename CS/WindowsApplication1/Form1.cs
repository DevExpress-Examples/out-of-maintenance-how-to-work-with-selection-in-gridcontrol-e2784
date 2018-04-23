using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nwindDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.nwindDataSet.Customers);

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gridView1.SelectAll();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            gridView1.ClearSelection();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            gridView1.SelectRow(5);
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            gridView1.UnselectRow(5);
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            gridView1.SelectRange(0, 5);
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                gridView1.UnselectRow(i);
            }  
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            gridView1.BeginSelection();
            int[] aList = gridView1.GetSelectedRows();
            gridView1.SelectAll();
            foreach (int aRowHandle in aList)
                gridView1.UnselectRow(aRowHandle);
            gridView1.EndSelection();
        }
    }
}