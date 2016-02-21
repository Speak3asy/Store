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
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.lvl_WHLowQuant = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ClearProductInputs = new System.Windows.Forms.Button();
            this.btn_AddProduct = new System.Windows.Forms.Button();
            this.tb_ProdPrice = new System.Windows.Forms.TextBox();
            this.tb_ProdQuant = new System.Windows.Forms.TextBox();
            this.tb_ProdName = new System.Windows.Forms.TextBox();
            this.lbl_ProductPrice = new System.Windows.Forms.Label();
            this.lbl_ProductQuant = new System.Windows.Forms.Label();
            this.lbl_ProductName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(594, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.name,
            this.quantity,
            this.cost});
            this.listView1.Location = new System.Drawing.Point(16, 29);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(280, 688);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Warehouse:";
            // 
            // lvl_WHLowQuant
            // 
            this.lvl_WHLowQuant.AutoSize = true;
            this.lvl_WHLowQuant.BackColor = System.Drawing.Color.DarkSalmon;
            this.lvl_WHLowQuant.Location = new System.Drawing.Point(110, 13);
            this.lvl_WHLowQuant.Name = "lvl_WHLowQuant";
            this.lvl_WHLowQuant.Size = new System.Drawing.Size(124, 13);
            this.lvl_WHLowQuant.TabIndex = 3;
            this.lvl_WHLowQuant.Text = "Product is low in quantity";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_ClearProductInputs);
            this.groupBox1.Controls.Add(this.btn_AddProduct);
            this.groupBox1.Controls.Add(this.tb_ProdPrice);
            this.groupBox1.Controls.Add(this.tb_ProdQuant);
            this.groupBox1.Controls.Add(this.tb_ProdName);
            this.groupBox1.Controls.Add(this.lbl_ProductPrice);
            this.groupBox1.Controls.Add(this.lbl_ProductQuant);
            this.groupBox1.Controls.Add(this.lbl_ProductName);
            this.groupBox1.Location = new System.Drawing.Point(302, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 126);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add product";
            // 
            // btn_ClearProductInputs
            // 
            this.btn_ClearProductInputs.Location = new System.Drawing.Point(37, 91);
            this.btn_ClearProductInputs.Name = "btn_ClearProductInputs";
            this.btn_ClearProductInputs.Size = new System.Drawing.Size(75, 23);
            this.btn_ClearProductInputs.TabIndex = 4;
            this.btn_ClearProductInputs.Text = "Clear";
            this.btn_ClearProductInputs.UseVisualStyleBackColor = true;
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
            // 
            // tb_ProdQuant
            // 
            this.tb_ProdQuant.AcceptsTab = true;
            this.tb_ProdQuant.Location = new System.Drawing.Point(89, 39);
            this.tb_ProdQuant.MaxLength = 5;
            this.tb_ProdQuant.Name = "tb_ProdQuant";
            this.tb_ProdQuant.Size = new System.Drawing.Size(100, 20);
            this.tb_ProdQuant.TabIndex = 1;
            this.tb_ProdQuant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ProdQuant_KeyPress);
            // 
            // tb_ProdName
            // 
            this.tb_ProdName.AcceptsTab = true;
            this.tb_ProdName.Location = new System.Drawing.Point(89, 13);
            this.tb_ProdName.MaxLength = 50;
            this.tb_ProdName.Name = "tb_ProdName";
            this.tb_ProdName.Size = new System.Drawing.Size(100, 20);
            this.tb_ProdName.TabIndex = 0;
            this.tb_ProdName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ProdName_KeyPress);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(568, 134);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvl_WHLowQuant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader quantity;
        private System.Windows.Forms.ColumnHeader cost;
        private System.Windows.Forms.Label lvl_WHLowQuant;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_ProductName;
        private System.Windows.Forms.Label lbl_ProductPrice;
        private System.Windows.Forms.Label lbl_ProductQuant;
        private System.Windows.Forms.TextBox tb_ProdPrice;
        private System.Windows.Forms.TextBox tb_ProdQuant;
        private System.Windows.Forms.TextBox tb_ProdName;
        private System.Windows.Forms.Button btn_ClearProductInputs;
        private System.Windows.Forms.Button btn_AddProduct;
        private System.Windows.Forms.TextBox textBox1;
    }
}

