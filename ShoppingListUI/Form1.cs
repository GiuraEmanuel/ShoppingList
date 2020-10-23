using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShoppingListBL;
namespace ShoppingListUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShoppingList shoppingList = new ShoppingList("Food List");
            shoppingList.AddItemToShoppingList(new Item("Bread",15.0M));
            shoppingList.AddItemToShoppingList(new Item("Cheese",25.5M));
            shoppingList.AddItemToShoppingList(new Item("Bacon",30.5M));
            shoppingList.AddItemToShoppingList(new Item("Eggs",17.99M));
            shoppingList.DisplayItems();

            shoppingListBox.DataSource = shoppingList;
            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
