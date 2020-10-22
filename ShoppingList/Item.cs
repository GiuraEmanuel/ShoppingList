using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingListBL
{
    public class Item
    {
        public string ItemName { get; set; }

        public Item(string itemName)
        {
            ItemName = itemName;
        }

        public override string ToString()
        {
            return $"{ItemName}";
        }
    }
}
