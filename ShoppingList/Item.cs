using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingListBL
{
    public class Item
    {
        public string ItemName { get;}
        public decimal Price { get;}

        public Item(string itemName, decimal price)
        {
            ItemName = itemName;
            Price = price;
        }

        public override string ToString()
        {
            return $"{ItemName}";
        }
    }
}
