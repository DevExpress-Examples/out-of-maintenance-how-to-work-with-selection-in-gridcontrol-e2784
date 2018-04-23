Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.customersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.nwindDataSet = New WindowsApplication1.nwindDataSet()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colCustomerID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCompanyName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colContactName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colContactTitle = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colAddress = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCity = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colRegion = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colPostalCode = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCountry = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colPhone = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colFax = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.customersTableAdapter = New WindowsApplication1.nwindDataSetTableAdapters.CustomersTableAdapter()
			Me.simpleButton7 = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButton6 = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButton5 = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButton4 = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButton3 = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButton2 = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.customersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.simpleButton7)
			Me.panelControl1.Controls.Add(Me.simpleButton6)
			Me.panelControl1.Controls.Add(Me.simpleButton5)
			Me.panelControl1.Controls.Add(Me.simpleButton4)
			Me.panelControl1.Controls.Add(Me.simpleButton3)
			Me.panelControl1.Controls.Add(Me.simpleButton2)
			Me.panelControl1.Controls.Add(Me.simpleButton1)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.panelControl1.Location = New System.Drawing.Point(0, 447)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(594, 34)
			Me.panelControl1.TabIndex = 0
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.customersBindingSource
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(594, 447)
			Me.gridControl1.TabIndex = 1
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' customersBindingSource
			' 
			Me.customersBindingSource.DataMember = "Customers"
			Me.customersBindingSource.DataSource = Me.nwindDataSet
			' 
			' nwindDataSet
			' 
			Me.nwindDataSet.DataSetName = "nwindDataSet"
			Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colCustomerID, Me.colCompanyName, Me.colContactName, Me.colContactTitle, Me.colAddress, Me.colCity, Me.colRegion, Me.colPostalCode, Me.colCountry, Me.colPhone, Me.colFax})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsSelection.MultiSelect = True
			' 
			' colCustomerID
			' 
			Me.colCustomerID.FieldName = "CustomerID"
			Me.colCustomerID.Name = "colCustomerID"
			Me.colCustomerID.Visible = True
			Me.colCustomerID.VisibleIndex = 0
			' 
			' colCompanyName
			' 
			Me.colCompanyName.FieldName = "CompanyName"
			Me.colCompanyName.Name = "colCompanyName"
			Me.colCompanyName.Visible = True
			Me.colCompanyName.VisibleIndex = 1
			' 
			' colContactName
			' 
			Me.colContactName.FieldName = "ContactName"
			Me.colContactName.Name = "colContactName"
			Me.colContactName.Visible = True
			Me.colContactName.VisibleIndex = 2
			' 
			' colContactTitle
			' 
			Me.colContactTitle.FieldName = "ContactTitle"
			Me.colContactTitle.Name = "colContactTitle"
			Me.colContactTitle.Visible = True
			Me.colContactTitle.VisibleIndex = 3
			' 
			' colAddress
			' 
			Me.colAddress.FieldName = "Address"
			Me.colAddress.Name = "colAddress"
			Me.colAddress.Visible = True
			Me.colAddress.VisibleIndex = 4
			' 
			' colCity
			' 
			Me.colCity.FieldName = "City"
			Me.colCity.Name = "colCity"
			Me.colCity.Visible = True
			Me.colCity.VisibleIndex = 5
			' 
			' colRegion
			' 
			Me.colRegion.FieldName = "Region"
			Me.colRegion.Name = "colRegion"
			Me.colRegion.Visible = True
			Me.colRegion.VisibleIndex = 6
			' 
			' colPostalCode
			' 
			Me.colPostalCode.FieldName = "PostalCode"
			Me.colPostalCode.Name = "colPostalCode"
			Me.colPostalCode.Visible = True
			Me.colPostalCode.VisibleIndex = 7
			' 
			' colCountry
			' 
			Me.colCountry.FieldName = "Country"
			Me.colCountry.Name = "colCountry"
			Me.colCountry.Visible = True
			Me.colCountry.VisibleIndex = 8
			' 
			' colPhone
			' 
			Me.colPhone.FieldName = "Phone"
			Me.colPhone.Name = "colPhone"
			Me.colPhone.Visible = True
			Me.colPhone.VisibleIndex = 9
			' 
			' colFax
			' 
			Me.colFax.FieldName = "Fax"
			Me.colFax.Name = "colFax"
			Me.colFax.Visible = True
			Me.colFax.VisibleIndex = 10
			' 
			' customersTableAdapter
			' 
			Me.customersTableAdapter.ClearBeforeFill = True
			' 
			' simpleButton7
			' 
			Me.simpleButton7.AllowFocus = False
			Me.simpleButton7.Location = New System.Drawing.Point(513, 6)
			Me.simpleButton7.Name = "simpleButton7"
			Me.simpleButton7.Size = New System.Drawing.Size(75, 23)
			Me.simpleButton7.TabIndex = 14
			Me.simpleButton7.Text = "Invert"
'			Me.simpleButton7.Click += New System.EventHandler(Me.simpleButton7_Click);
			' 
			' simpleButton6
			' 
			Me.simpleButton6.AllowFocus = False
			Me.simpleButton6.Location = New System.Drawing.Point(418, 6)
			Me.simpleButton6.Name = "simpleButton6"
			Me.simpleButton6.Size = New System.Drawing.Size(89, 23)
			Me.simpleButton6.TabIndex = 13
			Me.simpleButton6.Text = "Unselect 6 rows"
'			Me.simpleButton6.Click += New System.EventHandler(Me.simpleButton6_Click);
			' 
			' simpleButton5
			' 
			Me.simpleButton5.AllowFocus = False
			Me.simpleButton5.Location = New System.Drawing.Point(337, 6)
			Me.simpleButton5.Name = "simpleButton5"
			Me.simpleButton5.Size = New System.Drawing.Size(75, 23)
			Me.simpleButton5.TabIndex = 12
			Me.simpleButton5.Text = "Select 6 rows"
'			Me.simpleButton5.Click += New System.EventHandler(Me.simpleButton5_Click);
			' 
			' simpleButton4
			' 
			Me.simpleButton4.AllowFocus = False
			Me.simpleButton4.Location = New System.Drawing.Point(248, 6)
			Me.simpleButton4.Name = "simpleButton4"
			Me.simpleButton4.Size = New System.Drawing.Size(83, 23)
			Me.simpleButton4.TabIndex = 11
			Me.simpleButton4.Text = "Unselect 1 row"
'			Me.simpleButton4.Click += New System.EventHandler(Me.simpleButton4_Click);
			' 
			' simpleButton3
			' 
			Me.simpleButton3.AllowFocus = False
			Me.simpleButton3.Location = New System.Drawing.Point(167, 6)
			Me.simpleButton3.Name = "simpleButton3"
			Me.simpleButton3.Size = New System.Drawing.Size(75, 23)
			Me.simpleButton3.TabIndex = 10
			Me.simpleButton3.Text = "Select 1 row"
'			Me.simpleButton3.Click += New System.EventHandler(Me.simpleButton3_Click);
			' 
			' simpleButton2
			' 
			Me.simpleButton2.AllowFocus = False
			Me.simpleButton2.Location = New System.Drawing.Point(86, 6)
			Me.simpleButton2.Name = "simpleButton2"
			Me.simpleButton2.Size = New System.Drawing.Size(75, 23)
			Me.simpleButton2.TabIndex = 9
			Me.simpleButton2.Text = "Deselect All"
'			Me.simpleButton2.Click += New System.EventHandler(Me.simpleButton2_Click);
			' 
			' simpleButton1
			' 
			Me.simpleButton1.AllowFocus = False
			Me.simpleButton1.Location = New System.Drawing.Point(5, 6)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(75, 23)
			Me.simpleButton1.TabIndex = 8
			Me.simpleButton1.Text = "Select All"
'			Me.simpleButton1.Click += New System.EventHandler(Me.simpleButton1_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(594, 481)
			Me.Controls.Add(Me.gridControl1)
			Me.Controls.Add(Me.panelControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.customersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private nwindDataSet As nwindDataSet
		Private customersBindingSource As System.Windows.Forms.BindingSource
		Private customersTableAdapter As WindowsApplication1.nwindDataSetTableAdapters.CustomersTableAdapter
		Private colCustomerID As DevExpress.XtraGrid.Columns.GridColumn
		Private colCompanyName As DevExpress.XtraGrid.Columns.GridColumn
		Private colContactName As DevExpress.XtraGrid.Columns.GridColumn
		Private colContactTitle As DevExpress.XtraGrid.Columns.GridColumn
		Private colAddress As DevExpress.XtraGrid.Columns.GridColumn
		Private colCity As DevExpress.XtraGrid.Columns.GridColumn
		Private colRegion As DevExpress.XtraGrid.Columns.GridColumn
		Private colPostalCode As DevExpress.XtraGrid.Columns.GridColumn
		Private colCountry As DevExpress.XtraGrid.Columns.GridColumn
		Private colPhone As DevExpress.XtraGrid.Columns.GridColumn
		Private colFax As DevExpress.XtraGrid.Columns.GridColumn
		Private WithEvents simpleButton7 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents simpleButton6 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents simpleButton5 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents simpleButton4 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents simpleButton3 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents simpleButton2 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
	End Class
End Namespace

