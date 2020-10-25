using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingListBL
{
    public class Item
    {
        public decimal Price { get; set; }
        public string Name { get; set; }
        public string ItemName
        {
            get
            {
                return $"{Name} {Price:C}";
            }

            set
            {
                Name = value;
            }
        }

        public Item()
        {

        }

        public Item(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name} - {Price}";
        }


    }
}
