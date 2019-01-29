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


        DataTable CreateTable()
        {
            DataTable table = new DataTable();
            DataRow dataRow;

            table.Columns.Add("Prod_NO", typeof(string));
            table.Columns.Add("Prod_Name", typeof(string));
            table.Columns.Add("Order_Date", typeof(string));
            table.Columns.Add("Quantity", typeof(string));

            dataRow = table.NewRow();
            dataRow["Prod_NO"] = "101";
            dataRow["Prod_Name"] = "Product1";
            dataRow["Order_Date"] = "12/06/2012";
            dataRow["Quantity"] = "50";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["Prod_NO"] = "102";
            dataRow["Prod_Name"] = "Product2";
            dataRow["Order_Date"] = "15/06/2012";
            dataRow["Quantity"] = "70";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["Prod_NO"] = "102";
            dataRow["Prod_Name"] = "Product2";
            dataRow["Order_Date"] = "15/06/2012";
            dataRow["Quantity"] = "70";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["Prod_NO"] = "103";
            dataRow["Prod_Name"] = "Product3";
            dataRow["Order_Date"] = "18/06/2012";
            dataRow["Quantity"] = "30";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["Prod_NO"] = "104";
            dataRow["Prod_Name"] = "Product4";
            dataRow["Order_Date"] = "25/06/2012";
            dataRow["Quantity"] = "20";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["Prod_NO"] = "105";
            dataRow["Prod_Name"] = "Product5";
            dataRow["Order_Date"] = "25/06/2012";
            dataRow["Quantity"] = "55";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["Prod_NO"] = "106";
            dataRow["Prod_Name"] = "Product6";
            dataRow["Order_Date"] = "25/06/2012";
            dataRow["Quantity"] = "82";
            table.Rows.Add(dataRow);

            return table;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = CreateTable();

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