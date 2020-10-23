using System;

namespace ShoppingListBL
{
    class Program
    {
        static void Main(string[] args)
        {
            ShoppingList shoppingList = new ShoppingList("Food list");
            shoppingList.AddItemToShoppingList(new Item("Tomatoes",10.00M));
            shoppingList.AddItemToShoppingList(new Item("Potatoes",7.50M));
            shoppingList.AddItemToShoppingList(new Item("Cheese",12.00M));
            shoppingList.AddItemToShoppingList(new Item("Bacon",15.00M));
            shoppingList.DisplayItems();
        }
    }
}
