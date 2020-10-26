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

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        List<Item> shoppingList = new List<Item>()
            {
                new Item{ItemName = "Bread", Price = 4.00M},
                new Item{ItemName = "Cheese", Price = 10.00M},
                new Item{ItemName = "Eggs", Price = 7.00M},
                new Item{ItemName = "Bacon", Price = 15.00M},
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
            foreach (var item in shoppingList)
            {
                if (checkedShoppingList.CheckedItems.Contains(item))
                {
                    shoppingList.Remove(item);
                }
            }
        }
    }
}
