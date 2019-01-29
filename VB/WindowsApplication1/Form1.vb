Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace WindowsApplication1
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub


        Private Function CreateTable() As DataTable
            Dim table As New DataTable()
            Dim dataRow As DataRow

            table.Columns.Add("Prod_NO", GetType(String))
            table.Columns.Add("Prod_Name", GetType(String))
            table.Columns.Add("Order_Date", GetType(String))
            table.Columns.Add("Quantity", GetType(String))

            dataRow = table.NewRow()
            dataRow("Prod_NO") = "101"
            dataRow("Prod_Name") = "Product1"
            dataRow("Order_Date") = "12/06/2012"
            dataRow("Quantity") = "50"
            table.Rows.Add(dataRow)

            dataRow = table.NewRow()
            dataRow("Prod_NO") = "102"
            dataRow("Prod_Name") = "Product2"
            dataRow("Order_Date") = "15/06/2012"
            dataRow("Quantity") = "70"
            table.Rows.Add(dataRow)

            dataRow = table.NewRow()
            dataRow("Prod_NO") = "102"
            dataRow("Prod_Name") = "Product2"
            dataRow("Order_Date") = "15/06/2012"
            dataRow("Quantity") = "70"
            table.Rows.Add(dataRow)

            dataRow = table.NewRow()
            dataRow("Prod_NO") = "103"
            dataRow("Prod_Name") = "Product3"
            dataRow("Order_Date") = "18/06/2012"
            dataRow("Quantity") = "30"
            table.Rows.Add(dataRow)

            dataRow = table.NewRow()
            dataRow("Prod_NO") = "104"
            dataRow("Prod_Name") = "Product4"
            dataRow("Order_Date") = "25/06/2012"
            dataRow("Quantity") = "20"
            table.Rows.Add(dataRow)

            dataRow = table.NewRow()
            dataRow("Prod_NO") = "105"
            dataRow("Prod_Name") = "Product5"
            dataRow("Order_Date") = "25/06/2012"
            dataRow("Quantity") = "55"
            table.Rows.Add(dataRow)

            dataRow = table.NewRow()
            dataRow("Prod_NO") = "106"
            dataRow("Prod_Name") = "Product6"
            dataRow("Order_Date") = "25/06/2012"
            dataRow("Quantity") = "82"
            table.Rows.Add(dataRow)

            Return table
        End Function
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
            gridControl1.DataSource = CreateTable()

        End Sub

        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
            gridView1.SelectAll()
        End Sub

        Private Sub simpleButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton2.Click
            gridView1.ClearSelection()
        End Sub

        Private Sub simpleButton3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton3.Click
            gridView1.SelectRow(5)
        End Sub

        Private Sub simpleButton4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton4.Click
            gridView1.UnselectRow(5)
        End Sub

        Private Sub simpleButton5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton5.Click
            gridView1.SelectRange(0, 5)
        End Sub

        Private Sub simpleButton6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton6.Click
            For i As Integer = 0 To 5
                gridView1.UnselectRow(i)
            Next i
        End Sub

        Private Sub simpleButton7_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton7.Click
            gridView1.BeginSelection()
            Dim aList() As Integer = gridView1.GetSelectedRows()
            gridView1.SelectAll()
            For Each aRowHandle As Integer In aList
                gridView1.UnselectRow(aRowHandle)
            Next aRowHandle
            gridView1.EndSelection()
        End Sub
    End Class
End Namespace