using System;

namespace ShoppingListBL
{
    class Program
    {
        static void Main(string[] args)
        {
            ShoppingList shoppingList = new ShoppingList("Food list");
            shoppingList.AddItemToShoppingList(new Item("Tomatoes"));
            shoppingList.AddItemToShoppingList(new Item("Potatoes"));
            shoppingList.AddItemToShoppingList(new Item("Cheese"));
            shoppingList.AddItemToShoppingList(new Item("Bacon"));
            shoppingList.DisplayItems();
        }
    }
}
