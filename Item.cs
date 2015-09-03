using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingApplication
{
    [Serializable]
   public class Item 
    {
        /// <summary>
        /// Class for items.
        /// </summary>
        private string _name;
        private string _category;
        private decimal _price;

        public Item(string name, string category, decimal price)
        {
            Name = name;
            Category = category;
            Price = price;
        }
        /// <summary>
        /// Property for item name.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length > 20 || value.Length<0)
                {
                    throw new ApplicationException("Name of product has to be 20 characters or less");
                }
                else
                {
                    _name = value;
                }
            }
        }
        /// <summary>
        /// Property for item category.
        /// </summary>
        public string Category
        {
            get
            {
                return _category;
            }
            set
            {
                _category = value;
            }
        }
        /// <summary>
        /// Property for item price.
        /// </summary>
        public decimal Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value < 0 || value == 0)
                {
                    throw new ApplicationException("Price can not be set to less than zero");
                }
                else
                {
                    _price = value;
                }


            }

        }
        /// <summary>
        /// overridden toString method.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Name.PadRight(20 - Name.Length) + "\t\t\t"+ Category + "\t\t\t" + Price.ToString();
        }       
    }
}