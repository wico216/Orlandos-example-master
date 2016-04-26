using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orlandos_example
{
    class Program
    {
        static void Main(string[] args)
        {
            Shopping_Cart Store = new Shopping_Cart();

            //Showing Categories and products
            Console.WriteLine("\nCategories");
            Store.ShowCategories();
            Console.WriteLine("\nProducts:");
            Store.ShowProducts();
            Console.ReadKey();
            Console.Clear();

            
            //Adding products to cart  and showing cart
            Store.AddToCart(3, 3);
            Store.AddToCart(0, 2);
            Store.AddToCart(2, 1);
            Store.ShowCart();
            Console.ReadKey();
            Console.Clear();

            //Removing item from cart
            Console.WriteLine("\nRemove item from cart:");
            Store.RemoveFromCart(1);
            Store.ShowCart();
            Console.ReadKey();
            Console.Clear();

            //
            Console.WriteLine("\nShopping Cart:");
            Store.ShowCart();
            Store.ShoppingCartSubtotal();
            Store.AddGlobalDiscountPercentage(20);
            Store.ShoppingCartSubtotal();
            
            Console.ReadLine();
        }
    }
}
 