using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Orlandos_example
{
    class Product
    {
        public int ProductId;
        public decimal ProductCost;
        public decimal ProductPrice;
        public string ProductName;
        public string ProductDescription;

        public Product ()
        {

        }

        public Product(int ID, string Name, string Description, decimal Cost, decimal Price)
        {
            ProductId = ID;
            ProductName = Name;
            ProductDescription = Description;
            ProductCost = Cost;
            ProductPrice = Price;
        }
    }
}
