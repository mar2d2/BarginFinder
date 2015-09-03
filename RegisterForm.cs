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
    public partial class RegisterForm : Form
    {
        public RegisterForm(UserManager usermanager,SignInForm logForm)
        {
            InitializeComponent();                      
            userManager = usermanager;        //Sets the usermanager sent from signIn form.
            signForm = logForm;              //Sets the SignIn form to control it from registerform.
        }

       SignInForm signForm;
       private UserManager userManager;   
  
       private void btnRegister_Click(object sender, EventArgs e)
       {
           try
           {
               userManager.Validate(txtRegUserName.Text, txtRegPassword.Text.Trim(), txtRegConfPassword.Text); // Validates if the username is already taken and sees if the passwords match.
               this.Close(); // Closes the form.
               signForm.Show(); // Shows the signForm again.
           }
           catch(Exception m)
           {
               MessageBox.Show(m.Message);
           }
       }
    }
}
