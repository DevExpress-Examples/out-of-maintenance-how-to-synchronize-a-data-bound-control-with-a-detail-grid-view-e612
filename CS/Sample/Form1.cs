using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace Sample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            customersTableAdapter1.Fill(nwindDataSet1.Customers );
            ordersTableAdapter1.Fill(nwindDataSet1.Orders );
            GridView masterGridView = new GridView();
            GridView detailView = new GridView();
            GridLevelNode gridLevelNode2 = new GridLevelNode();
            gridLevelNode2.LevelTemplate = detailView;
            gridLevelNode2.RelationName = "CustomersOrders";
            GridControl gridControl = new GridControl();

            detailView.DataSourceChanged += new EventHandler(detailView_DataSourceChanged);
            detailView.GridControl = gridControl;
            gridControl.ViewCollection.Add(masterGridView);
            gridControl.LevelTree.Nodes.Add(gridLevelNode2);
           
            gridControl.MainView = masterGridView;            
            gridControl.DataSource = nwindDataSet1.Customers;
            Controls.Add(gridControl);
            gridControl.Dock = DockStyle.Top;
            masterGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(masterGridView_FocusedRowChanged);
            
        }

        void detailView_DataSourceChanged(object sender, EventArgs e)
        {
            dataGrid.DataSource = null;
            dataGrid.DataMember = "";
            GridView gv = sender as GridView;
            if (gv == null) return;
            dataGrid.DataSource = gv.DataSource;
        }

        void masterGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GridView gv = sender as GridView;
            dataGrid.DataSource = null;
            GridView detailView = gv.GetDetailView(e.FocusedRowHandle, 0) as GridView;
            if (detailView == null)
            {
                dataGrid.DataMember = "CustomersOrders";
                dataGrid.DataSource = this.nwindDataSet1.Customers;
            }
            else
            {
                dataGrid.DataMember = "";
                dataGrid.DataSource = detailView.DataSource;
            }
        }
    }
}