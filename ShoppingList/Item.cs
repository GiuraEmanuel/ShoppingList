using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingListBL
{
    public class Item
    {
        public decimal Price { get; set; }
        public string ItemName { get; set; }
        public string Name
        {
            get
            {
                return $"{ItemName} - {Price:C}";
            }

            set
            {
                Name = value;
            }
        }

        public Item()
        {

        }

        public Item(string itemName, decimal price)
        {
            ItemName = itemName;
            Price = price;
        }

        public override string ToString()
        {
            return $"{ItemName} - {Price}";
        }

    }
}
