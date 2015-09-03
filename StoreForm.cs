using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ShoppingApplication
{
    /// <summary>
    /// StoreForm that handles the actions of a user and send information to either ItemManager class or UserManager. 
    /// </summary>
    public partial class StoreForm : Form
    {
        public StoreForm()
        {
            InitializeComponent();         
        }
        private string _sort;
        private RadioButton _rbn;
        private ItemManager _itemManager;
        private UserManager _userManager;
        private User _currentUser;
        
        public StoreForm(User currentUser,UserManager usermanager, ItemManager itemmanager)
        {

            _currentUser = currentUser; //Assigns the current user.
            InitializeComponent();          
            _itemManager = itemmanager; //Assigns the itemmanager.
            _userManager = usermanager; // Assings the usermanager.
            UpdateGUI(_currentUser);    //Updates the GUI with user information.
        }

        private void btnAddToTrolly_Click(object sender, EventArgs e)
        {
            //Adds selected item from listbox to the current users personal trolly list based on the listbox selected index.
            if (lstBoxItems.SelectedIndex != -1)
            {
                _userManager.AddToPersonalTrolly(_itemManager.GetItem(lstBoxItems.SelectedIndex));
                // Updates the GUI with the latest information.
                UpdateGUI(_currentUser);
            }
            else
            {
                MessageBox.Show("Please select an item to add to your trolly");
            }
        }

        private void UpdateGUI(User cu)
        {
            lstBoxItems.Items.Clear(); //Clears the item listbox.
            lstBoxTrolly.Items.Clear(); // Clears the personal trolly listbox.
            if (lblUsername.Text == null || lblUsername.Text == "")
            {
                lblUsername.Text = cu.Username + "'s Trolly"; // Sets the name label to the current users username.
            }
            // Gets each item from the current users personal trolly and popultes the personal trolly listbox with the relevant items.
            // Sets the total cost label to the total cost of the personal trolly items.
            foreach (Item personalItem in _userManager.GetPersonalTrolly()) 
            {
                lstBoxTrolly.Items.Add(personalItem);
                lblTotalCost.Text = _userManager.GetTotalCost().ToString();
            }
            if (_itemManager.Filter == "All")
            {
                foreach (Item item in _itemManager.ItemList)
                {
                    lstBoxItems.Items.Add(item); //Adds all the items from itemList to the item listbox.
                }
            }
            else
            {
                foreach (Item item in _itemManager.FilterList)
                {
                    lstBoxItems.Items.Add(item);
                }
            }
        }

        private void SetFilter(object sender, EventArgs e)
        {
            //Gets filter setting from radiobutton and sends it to itemmanagers SetFilter method.
            _rbn = sender as RadioButton;
            lstBoxItems.Items.Clear();
            foreach (Item item in _itemManager.SetFilter(_rbn))
            {
                lstBoxItems.Items.Add(item);
            } 
        }
     
        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            //Everytime the user types a character into the search textbox it calls on the itemManager Search method with the current string in the textbox.
            lstBoxItems.Items.Clear(); //Clears the list before every search is made.
            foreach (Item item in _itemManager.Search(txtSearch.Text))
            {
                lstBoxItems.Items.Add(item); //For each item it finds with a match it populates the listbox with that item.
            }      
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(comboBox1.SelectedIndex == 0)
            {
                _sort = "Price";  //If the selected index is 0 it sets the sorting string to Price.
            }
            else if(comboBox1.SelectedIndex == 1)
            {
                _sort = "Alphabetical";  // If the selected index is 1 it sets the sorting string to Alphabetical.
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please provid sorting option"); //When the sorting button is pressed and the value of the combobox is -1, the applicatin prompts the user to choose an option.
            }
            else
            {
                lstBoxItems.Items.Clear(); //clears the the listbox

                foreach (Item item in _itemManager.SortList(_sort)) //Calls the itemManagers method Sort which returns a sorted list with the given sorting filter. 
                {
                    lstBoxItems.Items.Add(item);   // Adds the sorted items to the listbox.
                } 
            }
        }

        private void btnBuyItems_Click(object sender, EventArgs e)
        {
            Stream myStream; //Declears a stream.
            PDFReceipt pdfWriter = new PDFReceipt(_userManager); // Creates a new instance of PDFReceipt class and sending the _usermanager refrence.
            SaveFileDialog saveFile = new SaveFileDialog(); // Creates a new SaveFileDialog.
            saveFile.FileName = "MyReceipt";        // Sets standard filename.
            saveFile.DefaultExt = ".pdf";          // Sets the default extension.
            saveFile.Filter = "(.pdf)|*.pdf";     // Sets the filters avaiable to the user.

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFile.OpenFile()) != null)
                {
                    try
                    {
                        pdfWriter.PrintReceipt(_userManager.GetPersonalTrolly(), myStream); //Tries to create a .pdf receipt and write it to the stream.
                    }
                    catch(Exception)
                    {
                        MessageBox.Show("Failed to print receipt");
                    }
                    finally
                    {
                        myStream.Close(); // Closes stream.
                    }
                }
            }
            
            _currentUser.PersonalTrolly.Clear(); // Clears the personal trolly.
            UpdateGUI(_currentUser); // Updates the GUI.
            
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            AddItemForm itemForm = new AddItemForm(_itemManager); // Creates a AddItemForm and sends the _itemManager refrence. 
            itemForm.Show(); // Shows the form.
            itemForm.FormClosed += itemForm_FormClosed;
        }

        void itemForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            lstBoxItems.Items.Clear(); // Clears the listbox.
            foreach (Item item in _itemManager.GetExistingItems()) //Gets all the existing items in the itemlist.
            {
                lstBoxItems.Items.Add(item); // Adds each item to the itemlist.
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                _userManager.RemoveItemFromTrolly(_userManager.GetPersonalTrolly()[lstBoxTrolly.SelectedIndex]);
                UpdateGUI(_currentUser);
            }
            catch(Exception)
            {
                MessageBox.Show("Please choose an item to remove");
            }
        }

      

    }
}
