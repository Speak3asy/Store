namespace Master
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gb_AddProduct = new System.Windows.Forms.GroupBox();
            this.btn_ClearProductInputs = new System.Windows.Forms.Button();
            this.btn_AddProduct = new System.Windows.Forms.Button();
            this.tb_ProdPrice = new System.Windows.Forms.TextBox();
            this.tb_ProdQuant = new System.Windows.Forms.TextBox();
            this.tb_ProdName = new System.Windows.Forms.TextBox();
            this.lbl_ProductPrice = new System.Windows.Forms.Label();
            this.lbl_ProductQuant = new System.Windows.Forms.Label();
            this.lbl_ProductName = new System.Windows.Forms.Label();
            this.lvl_WHLowQuant = new System.Windows.Forms.Label();
            this.gb_Warehouse = new System.Windows.Forms.GroupBox();
            this.gb_Legend = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_EditProduct = new System.Windows.Forms.GroupBox();
            this.btn_EditProd = new System.Windows.Forms.Button();
            this.tb_eProdPrice = new System.Windows.Forms.TextBox();
            this.tb_eProdQuant = new System.Windows.Forms.TextBox();
            this.tb_eProdName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lv_CheckHistory = new System.Windows.Forms.ListView();
            this.gb_CheckHistory = new System.Windows.Forms.GroupBox();
            this.gb_Check = new System.Windows.Forms.GroupBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_BasketItems = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gb_AddProduct.SuspendLayout();
            this.gb_Warehouse.SuspendLayout();
            this.gb_Legend.SuspendLayout();
            this.gb_EditProduct.SuspendLayout();
            this.gb_CheckHistory.SuspendLayout();
            this.gb_Check.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.name,
            this.quantity,
            this.cost});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(3, 16);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(277, 685);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.Text = "ID";
            // 
            // name
            // 
            this.name.Text = "Name";
            // 
            // quantity
            // 
            this.quantity.Text = "Quantity";
            // 
            // cost
            // 
            this.cost.Text = "Cost";
            // 
            // gb_AddProduct
            // 
            this.gb_AddProduct.Controls.Add(this.btn_ClearProductInputs);
            this.gb_AddProduct.Controls.Add(this.btn_AddProduct);
            this.gb_AddProduct.Controls.Add(this.tb_ProdPrice);
            this.gb_AddProduct.Controls.Add(this.tb_ProdQuant);
            this.gb_AddProduct.Controls.Add(this.tb_ProdName);
            this.gb_AddProduct.Controls.Add(this.lbl_ProductPrice);
            this.gb_AddProduct.Controls.Add(this.lbl_ProductQuant);
            this.gb_AddProduct.Controls.Add(this.lbl_ProductName);
            this.gb_AddProduct.Location = new System.Drawing.Point(302, 13);
            this.gb_AddProduct.Name = "gb_AddProduct";
            this.gb_AddProduct.Size = new System.Drawing.Size(201, 126);
            this.gb_AddProduct.TabIndex = 4;
            this.gb_AddProduct.TabStop = false;
            this.gb_AddProduct.Text = "Add product";
            // 
            // btn_ClearProductInputs
            // 
            this.btn_ClearProductInputs.Location = new System.Drawing.Point(37, 91);
            this.btn_ClearProductInputs.Name = "btn_ClearProductInputs";
            this.btn_ClearProductInputs.Size = new System.Drawing.Size(75, 23);
            this.btn_ClearProductInputs.TabIndex = 4;
            this.btn_ClearProductInputs.Text = "Clear";
            this.btn_ClearProductInputs.UseVisualStyleBackColor = true;
            this.btn_ClearProductInputs.Click += new System.EventHandler(this.btn_ClearProductInputs_Click);
            // 
            // btn_AddProduct
            // 
            this.btn_AddProduct.Enabled = false;
            this.btn_AddProduct.Location = new System.Drawing.Point(114, 91);
            this.btn_AddProduct.Name = "btn_AddProduct";
            this.btn_AddProduct.Size = new System.Drawing.Size(75, 23);
            this.btn_AddProduct.TabIndex = 3;
            this.btn_AddProduct.Text = "Add";
            this.btn_AddProduct.UseVisualStyleBackColor = true;
            this.btn_AddProduct.Click += new System.EventHandler(this.btn_AddProduct_Click);
            // 
            // tb_ProdPrice
            // 
            this.tb_ProdPrice.AcceptsReturn = true;
            this.tb_ProdPrice.AcceptsTab = true;
            this.tb_ProdPrice.Location = new System.Drawing.Point(89, 65);
            this.tb_ProdPrice.MaxLength = 5;
            this.tb_ProdPrice.Name = "tb_ProdPrice";
            this.tb_ProdPrice.Size = new System.Drawing.Size(100, 20);
            this.tb_ProdPrice.TabIndex = 2;
            this.tb_ProdPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ProdPrice_KeyPress);
            this.tb_ProdPrice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_ProdPrice_KeyUp);
            // 
            // tb_ProdQuant
            // 
            this.tb_ProdQuant.AcceptsReturn = true;
            this.tb_ProdQuant.AcceptsTab = true;
            this.tb_ProdQuant.Location = new System.Drawing.Point(89, 39);
            this.tb_ProdQuant.MaxLength = 5;
            this.tb_ProdQuant.Name = "tb_ProdQuant";
            this.tb_ProdQuant.Size = new System.Drawing.Size(100, 20);
            this.tb_ProdQuant.TabIndex = 1;
            this.tb_ProdQuant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ProdQuant_KeyPress);
            this.tb_ProdQuant.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_ProdQuant_KeyUp);
            // 
            // tb_ProdName
            // 
            this.tb_ProdName.AcceptsTab = true;
            this.tb_ProdName.Location = new System.Drawing.Point(89, 13);
            this.tb_ProdName.MaxLength = 50;
            this.tb_ProdName.Name = "tb_ProdName";
            this.tb_ProdName.Size = new System.Drawing.Size(100, 20);
            this.tb_ProdName.TabIndex = 0;
            this.tb_ProdName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_ProdName_KeyUp);
            // 
            // lbl_ProductPrice
            // 
            this.lbl_ProductPrice.AutoSize = true;
            this.lbl_ProductPrice.Location = new System.Drawing.Point(49, 72);
            this.lbl_ProductPrice.Name = "lbl_ProductPrice";
            this.lbl_ProductPrice.Size = new System.Drawing.Size(34, 13);
            this.lbl_ProductPrice.TabIndex = 2;
            this.lbl_ProductPrice.Text = "Price:";
            // 
            // lbl_ProductQuant
            // 
            this.lbl_ProductQuant.AutoSize = true;
            this.lbl_ProductQuant.Location = new System.Drawing.Point(34, 46);
            this.lbl_ProductQuant.Name = "lbl_ProductQuant";
            this.lbl_ProductQuant.Size = new System.Drawing.Size(49, 13);
            this.lbl_ProductQuant.TabIndex = 1;
            this.lbl_ProductQuant.Text = "Quantity:";
            // 
            // lbl_ProductName
            // 
            this.lbl_ProductName.AutoSize = true;
            this.lbl_ProductName.Location = new System.Drawing.Point(7, 20);
            this.lbl_ProductName.Name = "lbl_ProductName";
            this.lbl_ProductName.Size = new System.Drawing.Size(76, 13);
            this.lbl_ProductName.TabIndex = 0;
            this.lbl_ProductName.Text = "Product name:";
            // 
            // lvl_WHLowQuant
            // 
            this.lvl_WHLowQuant.AutoSize = true;
            this.lvl_WHLowQuant.BackColor = System.Drawing.Color.DarkSalmon;
            this.lvl_WHLowQuant.Location = new System.Drawing.Point(7, 16);
            this.lvl_WHLowQuant.Name = "lvl_WHLowQuant";
            this.lvl_WHLowQuant.Size = new System.Drawing.Size(124, 13);
            this.lvl_WHLowQuant.TabIndex = 3;
            this.lvl_WHLowQuant.Text = "Product is low in quantity";
            // 
            // gb_Warehouse
            // 
            this.gb_Warehouse.Controls.Add(this.listView1);
            this.gb_Warehouse.Location = new System.Drawing.Point(13, 13);
            this.gb_Warehouse.Name = "gb_Warehouse";
            this.gb_Warehouse.Size = new System.Drawing.Size(283, 704);
            this.gb_Warehouse.TabIndex = 6;
            this.gb_Warehouse.TabStop = false;
            this.gb_Warehouse.Text = "Warehouse";
            // 
            // gb_Legend
            // 
            this.gb_Legend.Controls.Add(this.label1);
            this.gb_Legend.Controls.Add(this.lvl_WHLowQuant);
            this.gb_Legend.Location = new System.Drawing.Point(302, 146);
            this.gb_Legend.Name = "gb_Legend";
            this.gb_Legend.Size = new System.Drawing.Size(200, 160);
            this.gb_Legend.TabIndex = 7;
            this.gb_Legend.TabStop = false;
            this.gb_Legend.Text = "Legend";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Product has a discount";
            // 
            // gb_EditProduct
            // 
            this.gb_EditProduct.Controls.Add(this.btn_EditProd);
            this.gb_EditProduct.Controls.Add(this.tb_eProdPrice);
            this.gb_EditProduct.Controls.Add(this.tb_eProdQuant);
            this.gb_EditProduct.Controls.Add(this.tb_eProdName);
            this.gb_EditProduct.Controls.Add(this.label2);
            this.gb_EditProduct.Controls.Add(this.label3);
            this.gb_EditProduct.Controls.Add(this.label4);
            this.gb_EditProduct.Location = new System.Drawing.Point(302, 312);
            this.gb_EditProduct.Name = "gb_EditProduct";
            this.gb_EditProduct.Size = new System.Drawing.Size(201, 126);
            this.gb_EditProduct.TabIndex = 5;
            this.gb_EditProduct.TabStop = false;
            this.gb_EditProduct.Text = "Edit product";
            // 
            // btn_EditProd
            // 
            this.btn_EditProd.Enabled = false;
            this.btn_EditProd.Location = new System.Drawing.Point(114, 91);
            this.btn_EditProd.Name = "btn_EditProd";
            this.btn_EditProd.Size = new System.Drawing.Size(75, 23);
            this.btn_EditProd.TabIndex = 8;
            this.btn_EditProd.Text = "Edit";
            this.btn_EditProd.UseVisualStyleBackColor = true;
            this.btn_EditProd.Click += new System.EventHandler(this.btn_EditProd_Click);
            // 
            // tb_eProdPrice
            // 
            this.tb_eProdPrice.AcceptsReturn = true;
            this.tb_eProdPrice.AcceptsTab = true;
            this.tb_eProdPrice.Location = new System.Drawing.Point(89, 65);
            this.tb_eProdPrice.MaxLength = 5;
            this.tb_eProdPrice.Name = "tb_eProdPrice";
            this.tb_eProdPrice.Size = new System.Drawing.Size(100, 20);
            this.tb_eProdPrice.TabIndex = 7;
            this.tb_eProdPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_eProdPrice_KeyPress);
            this.tb_eProdPrice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_eProdPrice_KeyUp);
            // 
            // tb_eProdQuant
            // 
            this.tb_eProdQuant.AcceptsTab = true;
            this.tb_eProdQuant.Location = new System.Drawing.Point(89, 39);
            this.tb_eProdQuant.MaxLength = 5;
            this.tb_eProdQuant.Name = "tb_eProdQuant";
            this.tb_eProdQuant.Size = new System.Drawing.Size(100, 20);
            this.tb_eProdQuant.TabIndex = 6;
            this.tb_eProdQuant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_eProdQuant_KeyPress);
            this.tb_eProdQuant.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_eProdQuant_KeyUp);
            // 
            // tb_eProdName
            // 
            this.tb_eProdName.AcceptsTab = true;
            this.tb_eProdName.Location = new System.Drawing.Point(89, 13);
            this.tb_eProdName.MaxLength = 50;
            this.tb_eProdName.Name = "tb_eProdName";
            this.tb_eProdName.Size = new System.Drawing.Size(100, 20);
            this.tb_eProdName.TabIndex = 5;
            this.tb_eProdName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_eProdName_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Quantity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Product name:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(299, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 133);
            this.button1.TabIndex = 8;
            this.button1.Text = "One Big Test Button";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lv_CheckHistory
            // 
            this.lv_CheckHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lv_CheckHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_CheckHistory.FullRowSelect = true;
            this.lv_CheckHistory.GridLines = true;
            this.lv_CheckHistory.Location = new System.Drawing.Point(3, 16);
            this.lv_CheckHistory.MultiSelect = false;
            this.lv_CheckHistory.Name = "lv_CheckHistory";
            this.lv_CheckHistory.Size = new System.Drawing.Size(194, 682);
            this.lv_CheckHistory.TabIndex = 9;
            this.lv_CheckHistory.UseCompatibleStateImageBehavior = false;
            this.lv_CheckHistory.SelectedIndexChanged += new System.EventHandler(this.lv_CheckHistory_SelectedIndexChanged);
            // 
            // gb_CheckHistory
            // 
            this.gb_CheckHistory.Controls.Add(this.lv_CheckHistory);
            this.gb_CheckHistory.Location = new System.Drawing.Point(509, 13);
            this.gb_CheckHistory.Name = "gb_CheckHistory";
            this.gb_CheckHistory.Size = new System.Drawing.Size(200, 701);
            this.gb_CheckHistory.TabIndex = 10;
            this.gb_CheckHistory.TabStop = false;
            this.gb_CheckHistory.Text = "Checkout history";
            // 
            // gb_Check
            // 
            this.gb_Check.Controls.Add(this.lv_BasketItems);
            this.gb_Check.Location = new System.Drawing.Point(715, 13);
            this.gb_Check.Name = "gb_Check";
            this.gb_Check.Size = new System.Drawing.Size(281, 698);
            this.gb_Check.TabIndex = 11;
            this.gb_Check.TabStop = false;
            this.gb_Check.Text = "Basket items";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Sum";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Checkout date";
            this.columnHeader3.Width = 120;
            // 
            // lv_BasketItems
            // 
            this.lv_BasketItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lv_BasketItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_BasketItems.FullRowSelect = true;
            this.lv_BasketItems.GridLines = true;
            this.lv_BasketItems.Location = new System.Drawing.Point(3, 16);
            this.lv_BasketItems.MultiSelect = false;
            this.lv_BasketItems.Name = "lv_BasketItems";
            this.lv_BasketItems.Size = new System.Drawing.Size(275, 679);
            this.lv_BasketItems.TabIndex = 0;
            this.lv_BasketItems.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Product Name";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Quantity";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Price";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Total";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.gb_Check);
            this.Controls.Add(this.gb_CheckHistory);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gb_EditProduct);
            this.Controls.Add(this.gb_Legend);
            this.Controls.Add(this.gb_Warehouse);
            this.Controls.Add(this.gb_AddProduct);
            this.Name = "Form1";
            this.Text = "Store VI&KO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_AddProduct.ResumeLayout(false);
            this.gb_AddProduct.PerformLayout();
            this.gb_Warehouse.ResumeLayout(false);
            this.gb_Legend.ResumeLayout(false);
            this.gb_Legend.PerformLayout();
            this.gb_EditProduct.ResumeLayout(false);
            this.gb_EditProduct.PerformLayout();
            this.gb_CheckHistory.ResumeLayout(false);
            this.gb_Check.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader quantity;
        private System.Windows.Forms.ColumnHeader cost;
        private System.Windows.Forms.GroupBox gb_AddProduct;
        private System.Windows.Forms.Label lbl_ProductName;
        private System.Windows.Forms.Label lbl_ProductPrice;
        private System.Windows.Forms.Label lbl_ProductQuant;
        private System.Windows.Forms.TextBox tb_ProdPrice;
        private System.Windows.Forms.TextBox tb_ProdQuant;
        private System.Windows.Forms.TextBox tb_ProdName;
        private System.Windows.Forms.Button btn_ClearProductInputs;
        private System.Windows.Forms.Button btn_AddProduct;
        private System.Windows.Forms.Label lvl_WHLowQuant;
        private System.Windows.Forms.GroupBox gb_Warehouse;
        private System.Windows.Forms.GroupBox gb_Legend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_EditProduct;
        private System.Windows.Forms.Button btn_EditProd;
        private System.Windows.Forms.TextBox tb_eProdPrice;
        private System.Windows.Forms.TextBox tb_eProdQuant;
        private System.Windows.Forms.TextBox tb_eProdName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView lv_CheckHistory;
        private System.Windows.Forms.GroupBox gb_CheckHistory;
        private System.Windows.Forms.GroupBox gb_Check;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView lv_BasketItems;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}

