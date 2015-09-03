using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingApplication
{
    [Serializable]
    public class UserManager
    {
        /// <summary>
        /// Class that manages the user.
        /// </summary>

        private User _user; // Current user object.
        private List<User> _userList; // List of all the users.

        public UserManager()
        {
            _userList = new List<User>();
        }

        public void Validate(string username, string password, string confPassword)
        {
            //Validates if password is not null or empty.
            if (password != null || password != "")
            {
                if (password == confPassword)       //Checks if password and confirmed password are the same.
                {
                    if (!_userList.Exists(j => j.Username == username))     //Checks to see if user does not already exist.
                    {
                        CreateUser(username, password);                     //Creates new user.
                    }
                    else
                    {
                        throw new ApplicationException("Username already exists");
                    }
                }
            }
            else
            {
                throw new ApplicationException("Password cannot be empty");
            }
        }

        public User Login(string username, string password)
        {
           _user = _userList.Find(u => u.Username == username && u.Password == password);  //Gets the user who is about to login.
            if(_user == null)
            {
                throw new ApplicationException("Login Failed");
            }
            return _user; 
        }

        public List<Item> GetPersonalTrolly()
        {
            return this._user.PersonalTrolly;       //Returns the current users personal trolly.
        }

        private void CreateUser(string userName, string passWord)
        {
            _user = new User(userName, passWord); // Creates a new user with the given username and password.
            _userList.Add(_user);                   // Adds the new user to the userlist.
        }

        public void AddToPersonalTrolly(Item item)
        {
            _user.PersonalTrolly.Add(item);         //Adds item to current users personal trolly.
        }

        public void RemoveItemFromTrolly(Item item)
        {
            this._user.PersonalTrolly.Remove(item);
        }

        public decimal GetTotalCost()
        {
            decimal totalCost = 0;
            foreach (Item item in GetPersonalTrolly()) //Gets the total cost of all the items in the personal trolly and adds it to the totalCost decimal.
            {
                totalCost += item.Price;
            }
            return totalCost;
        }

        /// <summary>
        /// Property for Userlist.
        /// </summary>
        public List<User> UserList
        {
            get
            {
                return _userList;
            }
            set
            {
                _userList = value;
            }
        }


    }
}
