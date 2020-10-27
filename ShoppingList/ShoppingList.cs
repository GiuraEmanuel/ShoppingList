using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingListBL
{
    public class ShoppingList
    {
        public List<Item> Items { get;}
        public string ListName { get;}

        public ShoppingList(string listName, List<Item> items)
        {
            ListName = listName;
            Items = items;
        }

        public void DisplayItems()
        {
            foreach (var item in Items)
            {
                Console.WriteLine(item.NameAndPrice);
            }
        }

        public void AddItemToShoppingList(Item item)
        {
            Items.Add(item);
        }

        public void RemoveItemFromShoppingList(Item item)
        {
            Items.Remove(item);
        }

    }
}
