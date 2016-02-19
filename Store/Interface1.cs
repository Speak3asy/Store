using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public interface ICheckout
    {
        void AddProduct(IProduct product); float total();
    }
    public interface IProduct { string Name { get; set; } double Cost { get; set; } }
}
