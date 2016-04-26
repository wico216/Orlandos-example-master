using System;
using System.Collections.Generic;

namespace Orlandos_example
{
    class Shopping_Cart
    {

        public decimal _subTotal;
        private decimal SubDisc;
        
        List<Category> _category = new List<Orlandos_example.Category>()
        {
            new Category(0, "iPhone"),
            new Category(1, "Samsung"),
            new Category(2, "BlackBerry"),
            new Category(3, "Nokia")
         };

        List<Product> _product = new List<Orlandos_example.Product>() {
            new Product(0,"Product1","This is my Product",5.23m, 14.99m),
            new Product(1, "Product2", "This is my Product", 4.23m, 16.99m),
            new Product(2, "Product3", "This is my Product", 5.23m, 17.99m),
            new Product(3, "Product4", "This is my Product", 2.23m, 18.99m)
         };

        List<CartItem> _cartItems = new List<CartItem>()
        {
           // new CartItem(_product[0],1,2.5,6),
            // new CartItem(2,3,2.5,6)
        };
             
        

        //List<string> Cart = new List<string>();

        public void ShowCategories()
        {

            for (int i = 0; i < _category.Count; i++)
            {
                Console.WriteLine(_category[i].CategoryName);
            }

        }


        public void ShowProducts()
        {

            for (int i = 0; i < _product.Count; i++)
            {
                Console.WriteLine(_product[i].ProductName);
            }

        }

        public void AddToCart(int id, int Qty)
        {
            _cartItems.Add(new CartItem(_product[id], Qty));

            //_product.Find(item.ProductId)
            //_cartItems.Add(new CartItem(item.ProductId,Qty,0.00,(item.ProductPrice*Qty)));
        }

        public void RemoveFromCart(int ProductRow)
        {
            _cartItems.RemoveAt(ProductRow);
        }

        public void ShowCart()
        {
            foreach (var item in _cartItems)
            {

                Console.WriteLine(item.Product.ProductName + " " + item.Product.ProductPrice + " " + item.Quantity + " " + item.Subtotal);
            }
            
        }

        public void ShoppingCartSubtotal()
        {


            //add subtotal and return


            //stupid sum
            for (int i = 0; i < _cartItems.Count; i++)
            {
                _subTotal += _cartItems[i].Subtotal;// need to each cartitem subtotal to sum it up
            }
            SubDisc = _subTotal;

            Console.WriteLine("Cart Total: " + _subTotal);


            //normal show separate subtotals
            foreach (var item in _cartItems)
            {
                Console.WriteLine(item.Subtotal);
            }

            //same as  above
            //lambda 
            _cartItems.ForEach( item => Console.WriteLine(item.Subtotal));

        }

        public void AddGlobalDiscountDollars(decimal discount)
        {
            _subTotal -= discount;
        }

        public void AddGlobalDiscountPercentage(decimal percentage)
        {
            _subTotal = - (_subTotal * (percentage / 100));
        }

        public void ShowTotalDiscount()
        {
            // return total cart amount
            Console.WriteLine("Total Discount: " + (SubDisc - _subTotal));
        }
    }
}
