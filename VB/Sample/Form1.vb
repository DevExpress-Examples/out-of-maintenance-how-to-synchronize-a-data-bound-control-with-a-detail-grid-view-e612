Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid

Namespace Sample
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            customersTableAdapter1.Fill(nwindDataSet1.Customers)
            ordersTableAdapter1.Fill(nwindDataSet1.Orders)
            Dim masterGridView As New GridView()
            Dim detailView As New GridView()
            Dim gridLevelNode2 As New GridLevelNode()
            gridLevelNode2.LevelTemplate = detailView
            gridLevelNode2.RelationName = "CustomersOrders"
            Dim gridControl As New GridControl()

            AddHandler detailView.DataSourceChanged, AddressOf detailView_DataSourceChanged
            detailView.GridControl = gridControl
            gridControl.ViewCollection.Add(masterGridView)
            gridControl.LevelTree.Nodes.Add(gridLevelNode2)

            gridControl.MainView = masterGridView
            gridControl.DataSource = nwindDataSet1.Customers
            Controls.Add(gridControl)
            gridControl.Dock = DockStyle.Top
            AddHandler masterGridView.FocusedRowChanged, AddressOf masterGridView_FocusedRowChanged

        End Sub

        Private Sub detailView_DataSourceChanged(ByVal sender As Object, ByVal e As EventArgs)
            dataGrid.DataSource = Nothing
            dataGrid.DataMember = ""
            Dim gv As GridView = TryCast(sender, GridView)
            If gv Is Nothing Then
                Return
            End If
            dataGrid.DataSource = gv.DataSource
        End Sub

        Private Sub masterGridView_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs)
            Dim gv As GridView = TryCast(sender, GridView)
            dataGrid.DataSource = Nothing
            Dim detailView As GridView = TryCast(gv.GetDetailView(e.FocusedRowHandle, 0), GridView)
            If detailView Is Nothing Then
                dataGrid.DataMember = "CustomersOrders"
                dataGrid.DataSource = Me.nwindDataSet1.Customers
            Else
                dataGrid.DataMember = ""
                dataGrid.DataSource = detailView.DataSource
            End If
        End Sub
    End Class
End Namespace