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
    /// <summary>
    /// Sign in form that tiggers events when a user tries to log in to the application.
    /// Once the user is validated it procedes to the store form.
    /// </summary>
    public partial class SignInForm : Form
    {
        UserManager userManager;
        ItemManager itemManager;
        RegisterForm regForm;
        StoreForm storeForm;
        public SignInForm()
        {
            InitializeComponent();
            try
            { 
                // Tires to deserialize the data saved in the debug folder. The char 'u' stands for usermanager and lets the DeserializeData method know that it is supposed
                // to deserialize the "userInfo.ser" file to get user information that has been saved to the userManager variable.
                userManager = StaticSerialize<UserManager>.DeserializeData('u');
            }
            catch (Exception)
            {
                // If the try block fails to deserialize the data it means there is no data to be deserialized in the "userInfo.ser" file and thus creates a new UserManager object 
                // and assigns it to the userManager refrence.
                userManager = new UserManager();
            }
        }
      
        private void lnkLblRegUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Creates a new Registration form and gives the parameter of userManager and the instance of the current form.
            regForm = new RegisterForm(userManager,this);
            // Hides the current form and shows the register form.
            this.Hide();     
            regForm.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //Tries to deserialize the data saved in the debug folder. The char 'i' stands for itemmanager and lets the DeserializeData method know that it is supposed
                // to deserialize the "itemInfo.ser" file to get the item list information that has been saved to the itemManager variable.
                itemManager = StaticSerialize<ItemManager>.DeserializeData('i');
            }
            catch(Exception)
            {
                // If the try block fails to deserialize the data it means that there is no data to be deserialized in the "itemInfo.ser" file and thus creates a new ItemManager object
                // and assigns it to the itemManager refrence.
                itemManager = new ItemManager();
            }
            finally
            {
                itemManager.SetStartingFilter();
            }
            try
            {
                //Tries to create the store form based on the return value of the Login methood. Login method takes the parameters username and password and tries to find a match
                // then returns the matching user which is sent to the Store form along with the shared resource of userManager and itemManager.
                storeForm = new StoreForm(userManager.Login(txtUserName.Text, txtPassword.Text), userManager, itemManager);
                this.Hide();
                //When the store form is closed the application serialize the userManager and the itemManager to save all the changes that has been done.
                storeForm.FormClosed += storeForm_FormClosed;
                storeForm.Show();
             }
            catch(Exception)
            {
                MessageBox.Show("Login Failed");
            }
        }

        void storeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Serialize methods that gets called on when the StoreForm is closed.
            StaticSerialize<UserManager>.SerializeData(userManager);
            StaticSerialize<ItemManager>.SerializeData(itemManager);
            Application.Exit();
            
        }  
    }
}
