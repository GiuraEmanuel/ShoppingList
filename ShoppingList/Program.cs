using System;
using System.Collections.Generic;
namespace ShoppingListBL
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> items = new List<Item>();
            items.Add(new Item("Bread", 6.00M));
            items.Add(new Item("Cheese", 8.00M));
            items.Add(new Item("Bacon", 12.00M));
            items.Add(new Item("Eggs", 5.00M));
            ShoppingList shoppingList = new ShoppingList("Food list", items);
            shoppingList.AddItemToShoppingList(new Item("Potatoes", 9.00M));
            shoppingList.DisplayItems();
            Console.WriteLine();
            shoppingList.RemoveItemFromShoppingList(items[0]);
            shoppingList.DisplayItems();
        }
    }
}
