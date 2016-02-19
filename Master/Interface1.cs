using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master
{
    public interface ICheckout
    {
        void AddProduct(IProduct product); float total();
    }
    public interface IProduct {
        int Id { get; set; }
        string Name { get; set; }
        double Cost { get; set; }
        double Quantity { get; set; }
    }
}
