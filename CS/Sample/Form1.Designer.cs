namespace Sample
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.nwindDataSet1 = new Sample.nwindDataSet();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter1 = new Sample.nwindDataSetTableAdapters.CustomersTableAdapter();
            this.ordersTableAdapter1 = new Sample.nwindDataSetTableAdapters.OrdersTableAdapter();
            this.dataGrid = new System.Windows.Forms.DataGrid();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nwindDataSet1
            // 
            this.nwindDataSet1.DataSetName = "nwindDataSet";
            this.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.nwindDataSet1;
            this.bindingSource1.Position = 0;
            // 
            // customersTableAdapter1
            // 
            this.customersTableAdapter1.ClearBeforeFill = true;
            // 
            // ordersTableAdapter1
            // 
            this.ordersTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGrid
            // 
            this.dataGrid.DataMember = "";
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid.Location = new System.Drawing.Point(0, 211);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(912, 222);
            this.dataGrid.TabIndex = 4;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.bindingSource1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 433);
            this.Controls.Add(this.dataGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private nwindDataSet nwindDataSet1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Sample.nwindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter1;
        private Sample.nwindDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter1;
        internal System.Windows.Forms.DataGrid dataGrid;
        private System.Windows.Forms.BindingSource ordersBindingSource;

    }
}

