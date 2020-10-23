using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Item> shoppingList = new List<Item>();
            shoppingList.Add(new Item("Bread", 9.00M));
            shoppingList.Add(new Item("Cheese", 15.00M));
            shoppingList.Add(new Item("Eggs", 7.00M));
            shoppingList.Add(new Item("Bacon", 25.00M));

            listBox1.DataSource = shoppingList.ToString();
            MessageBox.Show(shoppingList.ToString());
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
