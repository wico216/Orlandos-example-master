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