Imports Microsoft.VisualBasic
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

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'nwindDataSet.Customers' table. You can move, or remove it, as needed.
			Me.customersTableAdapter.Fill(Me.nwindDataSet.Customers)

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