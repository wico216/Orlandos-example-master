using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orlandos_example
{
    class Coupon
    { 
        public  double couponDiscount;
        public Product product;

        // how to add a coupon to the cart???
        public Coupon(double discount, Product item)
        {
            couponDiscount = discount;
            product = item;
        }

    }
}
