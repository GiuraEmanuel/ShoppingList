using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
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

        List<Item> shoppingList = new List<Item>()
            {
                new Item("Bread", 4.00M),
                new Item("Cheese", 10.00M),
                new Item("Eggs", 7.00M),
                new Item("Bacon", 15.00M),
                new Item("Potatoes", 8.00M),
            };

        private void BtnLoadShoppingList_Click(object sender, EventArgs e)
        {
            checkedShoppingList.DisplayMember = "Name - Price";
            checkedShoppingList.DataSource = shoppingList;
            lblTotal.Text = "Total : " + CalculateTotal();
        }

        private string CalculateTotal()
        {
            decimal total = 0;
            foreach (var item in shoppingList)
            {
                total += item.Price;
            }
            return total.ToString();
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {

        }
    }
}
