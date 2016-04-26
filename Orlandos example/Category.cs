using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orlandos_example
{
    class Category
    {
        public int CategoryId;
        public string CategoryName;        

        public Category(int ID, string Name)
        {
            CategoryId = ID;
            CategoryName = Name;
        }
    }
}
