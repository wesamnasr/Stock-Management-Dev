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
            DeleteProductBtn = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            button6 = new System.Windows.Forms.Button();
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
            flowLayoutPanel1.Controls.Add(DeleteProductBtn);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Controls.Add(button5);
            flowLayoutPanel1.Controls.Add(button6);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(927, 59);
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
            // DeleteProductBtn
            // 
            DeleteProductBtn.Location = new System.Drawing.Point(141, 3);
            DeleteProductBtn.Name = "DeleteProductBtn";
            DeleteProductBtn.Size = new System.Drawing.Size(132, 46);
            DeleteProductBtn.TabIndex = 1;
            DeleteProductBtn.Text = "ازالة منتج";
            DeleteProductBtn.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(279, 3);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(132, 46);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(417, 3);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(132, 46);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new System.Drawing.Point(555, 3);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(132, 46);
            button5.TabIndex = 4;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new System.Drawing.Point(693, 3);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(132, 46);
            button6.TabIndex = 5;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // ProductsTable
            // 
            ProductsTable.AutoGenerateColumns = false;
            ProductsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { productIDDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, quantityInStockDataGridViewTextBoxColumn, unitPriceDataGridViewTextBoxColumn, supplierIDDataGridViewTextBoxColumn, supplierDataGridViewTextBoxColumn });
            ProductsTable.DataSource = productBindingSource;
            ProductsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            ProductsTable.Location = new System.Drawing.Point(0, 59);
            ProductsTable.Name = "ProductsTable";
            ProductsTable.RowHeadersWidth = 51;
            ProductsTable.Size = new System.Drawing.Size(927, 391);
            ProductsTable.TabIndex = 1;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            productIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            productIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityInStockDataGridViewTextBoxColumn
            // 
            quantityInStockDataGridViewTextBoxColumn.DataPropertyName = "QuantityInStock";
            quantityInStockDataGridViewTextBoxColumn.HeaderText = "QuantityInStock";
            quantityInStockDataGridViewTextBoxColumn.MinimumWidth = 6;
            quantityInStockDataGridViewTextBoxColumn.Name = "quantityInStockDataGridViewTextBoxColumn";
            quantityInStockDataGridViewTextBoxColumn.Width = 125;
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
            unitPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            unitPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // supplierIDDataGridViewTextBoxColumn
            // 
            supplierIDDataGridViewTextBoxColumn.DataPropertyName = "SupplierID";
            supplierIDDataGridViewTextBoxColumn.HeaderText = "SupplierID";
            supplierIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            supplierIDDataGridViewTextBoxColumn.Name = "supplierIDDataGridViewTextBoxColumn";
            supplierIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // supplierDataGridViewTextBoxColumn
            // 
            supplierDataGridViewTextBoxColumn.DataPropertyName = "Supplier";
            supplierDataGridViewTextBoxColumn.HeaderText = "Supplier";
            supplierDataGridViewTextBoxColumn.MinimumWidth = 6;
            supplierDataGridViewTextBoxColumn.Name = "supplierDataGridViewTextBoxColumn";
            supplierDataGridViewTextBoxColumn.Width = 125;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(927, 450);
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
        private System.Windows.Forms.Button DeleteProductBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
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