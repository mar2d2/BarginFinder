using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingApplication
{
    [Serializable]
    public class User
    {
        /// <summary>
        /// Class for the User.
        /// </summary>
        private string _username, _password;
        private List<Item> _personalTrolly;
        public User(string username,string password)
        {
            _personalTrolly = new List<Item>(); //Creates a personal trolly list.
            Username = username; //Sets the username.
            Password = password; //Sets the password.
        }


        public void AddItemToTrolly(Item item)
        {
            //Adds item to the personal trolly.
            _personalTrolly.Add(item);
        }

        /// <summary>
        /// Property for Password.
        /// </summary>
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if(value.Length < 6)
                {
                    throw new ApplicationException("Password must be 6 characters or more");
                }
                else
                {
                    _password = value;
                }
            }
        }
        /// <summary>
        /// Property for Username.
        /// </summary>
        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
            }
        }
        /// <summary>
        /// Property for Personal Trolly.
        /// </summary>
        public List<Item> PersonalTrolly
        {
            get
            {
                return _personalTrolly;
            }
            set
            {
                _personalTrolly = value;
            }
        }

    }
}
