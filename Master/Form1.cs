using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Master
{
    public partial class Form1 : Form
    {
        marketEntities mrkEnt = new marketEntities();

        //class ShoppingCart
        //{
        //    public List<Product> Products { get; set; }

        //    public void AddItem(int productId, double quantity, double cost)
        //    {
        //        Product Item = new Product(productId, quantity, cost);
        //        if (Products.Contains(Item))
        //        {
        //            foreach (var item in Products)
        //            {
        //                if (item.Equals(Item))
        //                {
        //                    item.Quantity++;
        //                    return;
        //                }
        //            }
        //        }
        //        else
        //        {
        //            Item.Quantity = 1;
        //            Products.Add(Item);
        //        }
        //    }
        //}

        class Product : IProduct
        {
            public double Cost { get; set; }
            public string Name { get; set; }
            public int Id { get; set; }
            public double Quantity { get; set; }

            public Product(int productId, double quantity, double cost, string name)
            {
                try
                {
                    this.Id = productId;
                    this.Quantity = quantity;
                    this.Cost = cost;
                    this.Name = name;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        List<Product> CreateProductList(marketEntities ent)
        {
            List<Product> productList = new List<Product>();
            try
            {
                using (ent)
                {
                    productList = mrkEnt.Products.ToList().Select(p => new[] {
                    new Product(p.id, p.quantity, p.cost, p.name)
                }).SelectMany(g => g).ToList();
                }
                return productList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in creating products list\n" + ex.Message);
                return null;
            }            
        }

        void FillMyListView()
        {
            listView1.View = View.Details;
            listView1.BeginUpdate();
            var productList = CreateProductList(mrkEnt);
            foreach (var row in productList)
            {
                ListViewItem Item = new ListViewItem();
                ColumnHeader header1;
                header1 = new ColumnHeader();
                Item.Text = row.Id.ToString();
                Item.SubItems.Add(row.Name);
                if (row.Quantity <= 2)
                {
                    MessageBox.Show(String.Format("Low quantity of this product: {0}", row.Name));
                }
                Item.SubItems.Add(row.Quantity.ToString());
                Item.SubItems.Add(row.Cost.ToString());
                listView1.Items.Add(Item);
                header1.Width = -1;
            }
            listView1.EndUpdate();
            FillMyListView();
            MessageBox.Show("Thread started");
            Thread.Sleep(3000);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            new Thread(FillMyListView).Start(); 
        }
    }
}
