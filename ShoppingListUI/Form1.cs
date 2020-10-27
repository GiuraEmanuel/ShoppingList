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

        List<Item> items = new List<Item>()
        {
            new Item("Bread",5.00M),
            new Item("Bacon",10.00M),
            new Item("Cheese",7.00M),
            new Item("Eggs",6.00M),
        };

        
        private void BtnLoadShoppingList_Click(object sender, EventArgs e)
        {
            
            checkedShoppingList.DisplayMember = "Name - Price";
            checkedShoppingList.DataSource = items;
            lblTotal.Text = "Total : " + CalculateTotal();
        }

        private string CalculateTotal()
        {
            decimal total = 0;
            foreach (var item in new ShoppingList("Food list", items).Items)
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
