namespace Stock_Management_Dev
{
    partial class ProductsForm
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
            components = new System.ComponentModel.Container();
            productBindingSource = new System.Windows.Forms.BindingSource(components);
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            AddProductBtn = new System.Windows.Forms.Button();
            ProductsTable = new System.Windows.Forms.DataGridView();
            productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            quantityInStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            supplierIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            supplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductsTable).BeginInit();
            SuspendLayout();
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Models.Product);
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(AddProductBtn);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(970, 59);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // AddProductBtn
            // 
            AddProductBtn.Location = new System.Drawing.Point(3, 3);
            AddProductBtn.Name = "AddProductBtn";
            AddProductBtn.Size = new System.Drawing.Size(132, 46);
            AddProductBtn.TabIndex = 0;
            AddProductBtn.Text = "اضافة منتج";
            AddProductBtn.UseVisualStyleBackColor = true;
            AddProductBtn.Click += AddProductBtn_Click;
            // 
            // ProductsTable
            // 
            ProductsTable.AutoGenerateColumns = false;
            ProductsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            ProductsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { productIDDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, quantityInStockDataGridViewTextBoxColumn, unitPriceDataGridViewTextBoxColumn, supplierIDDataGridViewTextBoxColumn, supplierDataGridViewTextBoxColumn });
            ProductsTable.DataSource = productBindingSource;
            ProductsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            ProductsTable.Location = new System.Drawing.Point(0, 59);
            ProductsTable.Name = "ProductsTable";
            ProductsTable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            ProductsTable.RowHeadersWidth = 51;
            ProductsTable.Size = new System.Drawing.Size(970, 530);
            ProductsTable.TabIndex = 1;
            ProductsTable.CellClick += ProductsTable_CellClick;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            productIDDataGridViewTextBoxColumn.HeaderText = "رقم المنتج";
            productIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "اسم المنتج";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "الوصف";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // quantityInStockDataGridViewTextBoxColumn
            // 
            quantityInStockDataGridViewTextBoxColumn.DataPropertyName = "QuantityInStock";
            quantityInStockDataGridViewTextBoxColumn.HeaderText = "الكمية في المخزن";
            quantityInStockDataGridViewTextBoxColumn.MinimumWidth = 6;
            quantityInStockDataGridViewTextBoxColumn.Name = "quantityInStockDataGridViewTextBoxColumn";
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            unitPriceDataGridViewTextBoxColumn.HeaderText = "سعر الوحدة";
            unitPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            // 
            // supplierIDDataGridViewTextBoxColumn
            // 
            supplierIDDataGridViewTextBoxColumn.DataPropertyName = "SupplierID";
            supplierIDDataGridViewTextBoxColumn.HeaderText = "رقم المورد";
            supplierIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            supplierIDDataGridViewTextBoxColumn.Name = "supplierIDDataGridViewTextBoxColumn";
            // 
            // supplierDataGridViewTextBoxColumn
            // 
            supplierDataGridViewTextBoxColumn.DataPropertyName = "Supplier";
            supplierDataGridViewTextBoxColumn.HeaderText = "المورد";
            supplierDataGridViewTextBoxColumn.MinimumWidth = 6;
            supplierDataGridViewTextBoxColumn.Name = "supplierDataGridViewTextBoxColumn";
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(970, 589);
            Controls.Add(ProductsTable);
            Controls.Add(flowLayoutPanel1);
            Name = "ProductsForm";
            Text = "ProductsForm";
            Load += ProductsForm_Load;
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ProductsTable).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button AddProductBtn;
        private System.Windows.Forms.DataGridView ProductsTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityInStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierDataGridViewTextBoxColumn;
    }
}