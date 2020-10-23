using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingListBL
{
    public class ShoppingList
    {
        private List<Item> items;
        public string ListName { get;}

        public ShoppingList(string listName)
        {
            ListName = listName;
            items = new List<Item>();
        }

        public void DisplayItems()
        {
            foreach (var item in items)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void AddItemToShoppingList(Item item)
        {
            items.Add(item);
        }
    }
}
