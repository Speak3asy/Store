using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Timers;
using System.Windows.Forms;
using Timer = System.Timers.Timer;
using System.IO;

namespace Master
{
    public partial class Form1 : Form
    {
        #region Readonly, constants etc.
        readonly marketEntities _mrkEnt = new marketEntities();
        private static Timer _updateLvTimer;
        #endregion

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
        #region Classes
        private class Product : IProduct
        {
            public double Cost { get; set; }
            public string Name { get; set; }
            public int Id { get; set; }
            public double Quantity { get; set; }

            public Product(int productId, double quantity, double cost, string name)
            {
                try
                {
                    Id = productId;
                    Quantity = quantity;
                    Cost = cost;
                    Name = name;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }


        #endregion

        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        #region Methods
        private IEnumerable<Product> CreateProductList()
        {
            try
            {
                var productList = _mrkEnt.Products.ToList().Select(p => new[] {
                    new Product(p.id, p.quantity, p.cost, p.name)
                }).SelectMany(g => g).ToList();
                return productList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in creating products list\n" + ex.Message);
                return null;
            }
        }

        private void FillMyListView()
        {
            listView1.Items.Clear();
            listView1.View = View.Details;
            listView1.BeginUpdate();
            var productList = CreateProductList();
            foreach (var row in productList)
            {
                var item = new ListViewItem();
                item.Text = row.Id.ToString();
                item.SubItems.Add(row.Name);
                if (row.Quantity <= 2)
                    item.BackColor = Color.DarkSalmon;
                item.SubItems.Add(row.Quantity.ToString(CultureInfo.InvariantCulture));
                item.SubItems.Add(row.Cost.ToString(CultureInfo.InvariantCulture));
                listView1.Items.Add(item);
                Application.DoEvents();
            }
            listView1.EndUpdate();
        }
        #endregion

        #region Controls Events

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillMyListView();
            _updateLvTimer = new Timer(10000);
            _updateLvTimer.Elapsed += _updateLvTimer_Elapsed;
            _updateLvTimer.Enabled = true;
        }

        private void _updateLvTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            FillMyListView();
        }

        private void tb_ProdQuant_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckIfDouble(e);
            EnableAdd();
        }

        private void tb_ProdName_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnableAdd();
        }

        private void tb_ProdPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckIfDouble(e);
            EnableAdd();
        }
        #endregion

        #region Input & Control validation
        private void CheckIfDouble(KeyPressEventArgs e)
        {
            double value = 0;
            if (!double.TryParse(tb_ProdQuant.Text + e.KeyChar.ToString(), out value) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void EnableAdd()
        {
            bool validData = true;
            foreach (Control control in groupBox1.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textbox = control as TextBox;
                    validData &= !string.IsNullOrWhiteSpace(textbox.Text);
                }
            }
            btn_AddProduct.Enabled = validData;
        }
        #endregion
    }
}
