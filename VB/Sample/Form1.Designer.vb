Imports Microsoft.VisualBasic
Imports System
Namespace Sample
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
			Me.nwindDataSet1 = New Sample.nwindDataSet()
			Me.bindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
			Me.customersTableAdapter1 = New Sample.nwindDataSetTableAdapters.CustomersTableAdapter()
			Me.ordersTableAdapter1 = New Sample.nwindDataSetTableAdapters.OrdersTableAdapter()
			Me.dataGrid = New System.Windows.Forms.DataGrid()
			Me.ordersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ordersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' nwindDataSet1
			' 
			Me.nwindDataSet1.DataSetName = "nwindDataSet"
			Me.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' bindingSource1
			' 
			Me.bindingSource1.DataSource = Me.nwindDataSet1
			Me.bindingSource1.Position = 0
			' 
			' customersTableAdapter1
			' 
			Me.customersTableAdapter1.ClearBeforeFill = True
			' 
			' ordersTableAdapter1
			' 
			Me.ordersTableAdapter1.ClearBeforeFill = True
			' 
			' dataGrid
			' 
			Me.dataGrid.DataMember = ""
			Me.dataGrid.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.dataGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText
			Me.dataGrid.Location = New System.Drawing.Point(0, 211)
			Me.dataGrid.Name = "dataGrid"
			Me.dataGrid.Size = New System.Drawing.Size(912, 222)
			Me.dataGrid.TabIndex = 4
			' 
			' ordersBindingSource
			' 
			Me.ordersBindingSource.DataMember = "Orders"
			Me.ordersBindingSource.DataSource = Me.bindingSource1
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(912, 433)
			Me.Controls.Add(Me.dataGrid)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ordersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private nwindDataSet1 As nwindDataSet
		Private bindingSource1 As System.Windows.Forms.BindingSource
		Private customersTableAdapter1 As Sample.nwindDataSetTableAdapters.CustomersTableAdapter
		Private ordersTableAdapter1 As Sample.nwindDataSetTableAdapters.OrdersTableAdapter
		Friend dataGrid As System.Windows.Forms.DataGrid
		Private ordersBindingSource As System.Windows.Forms.BindingSource

	End Class
End Namespace

