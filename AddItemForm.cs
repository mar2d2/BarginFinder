using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ShoppingApplication
{
    public partial class AddItemForm : Form
    {
        public AddItemForm(ItemManager itemManager)
        {
            InitializeComponent();
            _itemManager = itemManager; // Sets the itemManager.
        } 
        private ItemManager _itemManager;

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            decimal price;
            if(comboBox1.SelectedIndex == -1)       //Checks if the combobox Selected item isn't -1.
            {
                MessageBox.Show("Please provide category");
            }

           if (Decimal.TryParse(txtPrice.Text.Trim(), out price)) //Tries to parse the price given by the user.
           {
               try
               {
                   string category = _itemManager.SetCategory(comboBox1.SelectedIndex); //Gets the category from the combobox and sets it to the category string.
                   _itemManager.AddItemToList(new Item(txtProductName.Text, category, price)); // Adds new item to the lits with the values given by the user.
                   this.Close(); // Closes form.
               }
               catch(Exception)
               {
                   MessageBox.Show("Please fill in all the textboxes");
               }
           }
           else
           {
               MessageBox.Show("Please provide valid data");
           }
        }
    }
}
