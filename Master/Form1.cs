using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Timers;
using System.Windows.Forms;
using Timer = System.Timers.Timer;
using System.IO;
using System.Threading;

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
            public Product(string name, double quantity, double cost)
            {
                try
                {
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

        private class CheckoutHistory
        {
            public int Id { get; }
            public double Sum { get; }
            public DateTime Date { get; }

            public CheckoutHistory(int checkId, double totalSum, DateTime checkoutTime)
            {
                this.Id = checkId;
                this.Sum = totalSum;
                this.Date = checkoutTime;
            }
        }

        private class Basket
        {
            public int Id { get; }
            public string ProdName { get; }
            public double ProdQuantity { get; }
            public double ProdPrice { get; }
            public double Total { get; }

            public Basket(int basketId, string basketProdName, double basketProdQuant, double basketProdPrice,
                double basketTotal)
            {
                this.Id = basketId;
                this.ProdName = basketProdName;
                this.ProdQuantity = basketProdQuant;
                this.ProdPrice = basketProdPrice;
                this.Total = basketTotal;
            }
        }
        
        #endregion

        #region Form() and Load

        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillMyListView();
            FillMyCheckHistoryLv();
            _updateLvTimer = new Timer(10000);
            _updateLvTimer.Elapsed += _updateLvTimer_Elapsed;
            _updateLvTimer.Enabled = true;
        }

        #endregion

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

        private void AddProduct(string pname, double pquantity, double pcost)
        {
            try
            {
                var temp = _mrkEnt.Set<Products>();
                temp.Add(new Products { name = pname, quantity = pquantity, cost = pcost });
                _mrkEnt.SaveChanges();
                MessageBox.Show(string.Format("Product {0} added with quantity {1} and price {2}", pname, pquantity,
                    pcost));
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error adding product to database!\n{0}", ex.Message));
            }
        }

        private Product MakeProductFromLv()
        {
            try
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    Product prod = new Product(Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text),
                         double.Parse(listView1.SelectedItems[0].SubItems[2].Text, CultureInfo.InvariantCulture),
                         double.Parse(listView1.SelectedItems[0].SubItems[3].Text, CultureInfo.InvariantCulture),
                         listView1.SelectedItems[0].SubItems[1].Text);
                    return prod;
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error in getting product from LV!\n {0}", ex.Message));
                return null;
            }
        }

        private void FillEditForm(IProduct prod)
        {
            try
            {
                if (prod != null)
                {
                    tb_eProdName.Text = prod.Name;
                    tb_eProdQuant.Text = prod.Quantity.ToString();
                    tb_eProdPrice.Text = prod.Cost.ToString();
                    btn_EditProd.Enabled = true;
                }
                else
                {
                    btn_EditProd.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error in filling edit form!\n {0}", ex.Message));
            }
            ;
        }

        private void EditProduct(Product prod)
        {
            try
            {
                var temp = _mrkEnt.Products.SingleOrDefault(x => x.id == prod.Id);
                if (temp != null)
                {
                    temp.name = tb_eProdName.Text;
                    temp.quantity = Convert.ToDouble(tb_eProdQuant.Text);
                    temp.cost = Convert.ToDouble(tb_eProdPrice.Text);
                    _mrkEnt.SaveChanges();
                    MessageBox.Show(string.Format("Product {0} updatedl with quantity {1} and price {2}", temp.name, temp.quantity,
    temp.cost));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in saving editted product!\n" + ex.Message);
            }
        }

        private IEnumerable<CheckoutHistory> CreateCheckoutHistories()
        {
            try
            {
                var checkoutHistList = _mrkEnt.History.ToList().Select(x => new[]
                {
                    new CheckoutHistory(x.id, x.sum, x.date)
                }).SelectMany(z => z).ToList();
                return checkoutHistList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in creating checkout history list\n" + ex.Message);
                return null;
            }
        }

        private void FillMyCheckHistoryLv()
        {
            try
            {
                lv_CheckHistory.Items.Clear();
                lv_CheckHistory.View = View.Details;
                lv_CheckHistory.BeginUpdate();
                var checkHistoryList = CreateCheckoutHistories();
                foreach (var row in checkHistoryList)
                {
                    var item = new ListViewItem();
                    item.Text = row.Id.ToString();
                    item.SubItems.Add(row.Sum.ToString(CultureInfo.InvariantCulture));
                    item.SubItems.Add(string.Format("{0:yyyy-MM-dd hh:mm}", row.Date));
                    lv_CheckHistory.Items.Add(item);
                    Application.DoEvents();
                }
                lv_CheckHistory.EndUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in filling checkout history list\n" + ex.Message);
            }

        }

        private IEnumerable<Basket> GetBasketItems(int id)
        {
            try
            {
                var basketItems = _mrkEnt.ViewBasket.ToList().Where(z => z.history_id == id).Select(x => new[]
                {
                    new Basket(x.history_id, x.name, x.quantity, x.price, x.Total)
                }).SelectMany(p => p).ToList();
                return basketItems;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in getting basket items\n" + ex.Message);
                return null;
            }

        }

        private int GetBasketIdFromLv()
        {
            int id = 0;
            try
            {
                if (lv_CheckHistory.SelectedItems.Count > 0)
                {
                    id = Convert.ToInt32(lv_CheckHistory.SelectedItems[0].SubItems[0].Text);
                }
                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in getting basket id from Lv\n" + ex.Message);
                return id;
            }
        }

        private string GetGroupBoxNameFromCheckHistory()
        {
            string gbName = "NaN-NaN";
            try
            {
                if (lv_CheckHistory.SelectedItems.Count > 0)
                {
                    gbName = "Basket " + string.Format("{0:yyyy-MM-dd hh:mm}", lv_CheckHistory.SelectedItems[0].SubItems[2].Text);

                }
                return gbName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in getting basket groupbox name from Lv\n" + ex.Message);
                return gbName;
            }
        }

        private void FillBasketItemsLv()
        {
            try
            {
                double totalSum = 0;
                lv_BasketItems.Items.Clear();
                lv_BasketItems.View = View.Details;
                lv_BasketItems.BeginUpdate();
                var basketItems = GetBasketItems(GetBasketIdFromLv());
                foreach (var row in basketItems)
                {
                    totalSum += row.Total;
                    var lvItem = new ListViewItem();
                    lvItem.Text = row.ProdName;
                    lvItem.SubItems.Add(row.ProdQuantity.ToString());
                    lvItem.SubItems.Add(row.ProdPrice.ToString());
                    lvItem.SubItems.Add(row.Total.ToString());
                    lv_BasketItems.Items.Add(lvItem);
                    Application.DoEvents();
                }
                var lvTotalItem = new ListViewItem();
                lvTotalItem.Text = "";
                lvTotalItem.SubItems.Add("");
                lvTotalItem.SubItems.Add("Total:");
                lvTotalItem.SubItems.Add(totalSum.ToString());
                lv_BasketItems.Items.Add(lvTotalItem);
                Application.DoEvents();
                lv_BasketItems.EndUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in filling basket items slist\n" + ex.Message);
            }
        }

        private void _updateLvTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            //FillMyListView();
        }

        #endregion

        #region Controls Events

        #region tb_ProdQuant events

        private void tb_ProdQuant_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckIfDouble(tb_ProdQuant, e);
        }

        private void tb_ProdQuant_KeyUp(object sender, KeyEventArgs e)
        {
            EnableButton(btn_AddProduct, gb_AddProduct.Controls);
        }

        #endregion

        #region tb_ProdName events

        private void tb_ProdName_KeyUp(object sender, KeyEventArgs e)
        {
            EnableButton(btn_AddProduct, gb_AddProduct.Controls);
        }
        #endregion

        #region tb_ProdPrice events
        private void tb_ProdPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckIfDouble(tb_ProdPrice, e);
        }

        private void tb_ProdPrice_KeyUp(object sender, KeyEventArgs e)
        {
            EnableButton(btn_AddProduct, gb_AddProduct.Controls);
        }

        #endregion

        #region tb_eProdName events

        private void tb_eProdName_KeyUp(object sender, KeyEventArgs e)
        {
            EnableButton(btn_EditProd, gb_EditProduct.Controls);
        }

        #endregion

        #region tb_eProdQuant events

        private void tb_eProdQuant_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckIfDouble(tb_eProdQuant, e);
        }

        private void tb_eProdQuant_KeyUp(object sender, KeyEventArgs e)
        {
            EnableButton(btn_EditProd, gb_EditProduct.Controls);
        }

        #endregion

        #region tb_eProdPrice

        private void tb_eProdPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckIfDouble(tb_eProdPrice, e);
        }

        private void tb_eProdPrice_KeyUp(object sender, KeyEventArgs e)
        {
            EnableButton(btn_EditProd, gb_EditProduct.Controls);
        }

        #endregion

        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            AddProduct(tb_ProdName.Text, Convert.ToDouble(tb_ProdQuant.Text), Convert.ToDouble(tb_ProdPrice.Text));
            ClearProductFields(gb_AddProduct.Controls, btn_AddProduct);
        }

        private void btn_ClearProductInputs_Click(object sender, EventArgs e)
        {
            ClearProductFields(gb_AddProduct.Controls, btn_AddProduct);
        }

        private void btn_EditProd_Click(object sender, EventArgs e)
        {
            EditProduct(MakeProductFromLv());
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillEditForm(MakeProductFromLv());
        }

        private void lv_CheckHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillBasketItemsLv();
            gb_Check.Text = GetGroupBoxNameFromCheckHistory();
        }

        #endregion

        #region Input & Control validation
        private void CheckIfDouble(TextBox tb, KeyPressEventArgs e)
        {
            try
            {
                double value = 0;
                if (!double.TryParse(tb.Text + e.KeyChar, out value) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error checking if double!\n {0}", ex.Message));
            }

        }

        private static void EnableButton(Button c, Control.ControlCollection cc)
        {
            try
            {
                bool validData = true;
                foreach (Control control in cc)
                {
                    if (control is TextBox)
                    {
                        TextBox textbox = control as TextBox;
                        validData &= !string.IsNullOrWhiteSpace(textbox.Text);
                    }
                }
                c.Enabled = validData;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error trying to enable '{1}' button!\n {0}", ex.Message, c.Text));
            }

        }

        private static void ClearProductFields(Control.ControlCollection cc, Button c)
        {
            try
            {
                foreach (Control ctrl in cc)
                {
                    TextBox tb = ctrl as TextBox;
                    if (tb != null)
                    {
                        tb.Text = "";
                    }
                    else
                    {
                        ClearProductFields(ctrl.Controls, c);
                    }
                }
                c.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error trying to clear '{1} products' fields!\n {0}", ex.Message, c.Text));
            }
        }


        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            FillBasketItemsLv();
        }


    }
}
