using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orlandos_example
{
    class CartItem
    {
        public Product Product { get; private set; }
        public int Quantity;
        public decimal Tax = 0.07m; // 7% Tax
        public decimal Subtotal { get { return Product.ProductPrice * Quantity; } }
        //public decimal Subtotal => Product.ProductPrice * Quantity; - same as above

        public CartItem(Product item, int Qty)
        {
            Product = item;
            Quantity = Qty;

           

        }      


        a

    }
}





 

