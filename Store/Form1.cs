using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store
{
    public partial class Form1 : Form
    {
        class Product : IProduct
        {
            public double Cost { get; set; }
            public string Name { get; set; }

            public Product (double cost, string name)
            {
                try
                {
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

        void CreateProducts()
        {
            Product A = new Product(0.63, "A");
            Product B = new Product(0.20, "B");
            Product C = new Product(0.74, "C");
            Product D = new Product(0.11, "D");
            Product E = new Product(0.50, "E");
        }

        private void btn_Test_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateProducts();
        }
    }
}
