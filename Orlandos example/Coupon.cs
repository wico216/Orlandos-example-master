using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orlandos_example
{
    internal class Coupon
    {
        public decimal couponDiscount;
        public Product product;

        // how to add a coupon to the cart???
        public Coupon(decimal discount, Product item)
        {
            couponDiscount = discount;
            product = item;
        }
    }
}