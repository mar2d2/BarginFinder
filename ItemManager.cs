using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ShoppingApplication
{
    [Serializable]
   public class ItemManager
    {
        /// <summary>
        /// Class to manage the items.
        /// </summary>

        private List<Item> _itemList;
        private List<Item> _filterList;
        [NonSerialized]
        private string _filter;
        [NonSerialized]
        private bool _filteredList;
        public ItemManager()
        {
            if (_itemList == null)
            {
                _itemList = new List<Item>(); // Creates a new itemlist if it's null.
            }

            if (_itemList.Count == 0)
            {
                _itemList = GetExistingItems(); //If the existing items are 0 it populates the list with predefined items.
            }
         
           _filterList = new List<Item>();
            CopyListItem();
        }

        public List<Item> Search(string searchTerm)
        {
            _filteredList = true;  // Sets bool _filteredList to true.
            _filterList.Clear();    //Clears the filtered list.
            if(searchTerm == null)
            {
                throw new ApplicationException("Search Term can not be empty");
            }
            if(_filter != "All")    //Checks to see if the _filter is not "All"
            {
                foreach (Item item in _itemList)        //Searches the _itemlist for items matching the searchterm with filter.
                {
                    if(item.Name.ToLower().Contains(searchTerm.ToLower()) && item.Category == _filter)
                    {
                        _filterList.Add(item); //Adds the items to the filerList.
                    }
                }
            }
            else
            {
                foreach (Item item in _itemList) // If no filter is set it searches the whole list without filter.
                {
                    if (item.Name.ToLower().Contains(searchTerm.ToLower()))
                    {
                        _filterList.Add(item);
                    }                   
                }
            }
            return _filterList;          
        }

        public void AddItemToList(Item item)
        {
            _itemList.Add(item); // Adds an item to the itemlist.
        }

        public void RemoveItemFromList(Item item)
        {            
            _itemList.Remove(item);
        }

        public List<Item> SortList(string sort)
        {
            //Sorts the items depending on the sorting string, and assing it to the _filterList.

            switch(sort)
            {
                case "Price":
                    this._filterList = _itemList.OrderBy(o=>o.Price).ToList();
                    break;
                case "Alphabetical":
                    this._filterList = _itemList.OrderBy(o=>o.Name).ToList();
                    break;
            }
            return this._filterList;
        }

        public List<Item> GetExistingItems()
        {
            //Returns a list of the existing items in the list, if no items are in the list the method adds a couple of predefined items to the list.
            if (_itemList.Count == 0)
            {
                return _itemList = new List<Item> { new Item("Iphone", "Phones", 1000), new Item("Ford Mustang", "Cars", 7000), new Item("LG Refrigerator", "Kitchen", 3000), new Item("Ipa", "Phones", 1000), new Item("Ipas", "Phones", 1000), new Item("Iper", "Phones", 1000), new Item("Ipur", "Phones", 1000) };
            }
            else
            {
                return _itemList;
            }
        }

        public List<Item> SetFilter(RadioButton rbn )
        {
            //Method that sets the filter string depending on which radionbutton has been checked.
            
            switch (rbn.Name)
            {
                case "rbnCars":
                    _filter = "Cars";
                    _filteredList = true;
                    break;
                case "rbnClothes":
                    _filter = "Clothes";
                    _filteredList = true;
                    break;
                case "rbnComputers":
                    _filter = "Computers";
                    _filteredList = true;
                    break;
                case "rbnPhonesGPS":
                    _filter = "Phones";
                    _filteredList = true;
                    break;
                case "rbnAll":
                    _filter = "All";
                    _filteredList = false;
                    break;
                case "rbnKitchen":
                    _filter = "Kitchen";
                    _filteredList = true;
                    break;              
                default:
                    break;
            }

            if (_filteredList)
            {
                _filterList = _itemList.FindAll(i => i.Category == _filter);
            }
            else
            {
                //_filterList = GetExistingItems();
                CopyListItem();
            }
                return _filterList;
        }

        public Item GetItem(int index)
        {
            //Returns requested item. Searches either the itemlist or the filter list depending on what the bool and what the filter strings values are.
            if(!_filteredList)
            {
                if(_filter == "All")
                {
                    return _itemList[index];
                }
                else
                {
                    return _filterList[index];
                }
            }
            else
            {
                return _filterList[index];
            }
        }

        public string SetCategory(int index)
        {
            //Sets the category string depending on what index was chosen in the combobox.

            string category="";
            switch(index)
            {
                case 0:
                    category = "Phones";
                    break;
                case 1:
                    category = "Computers";
                    break;
                case 2:
                    category = "Kitchen";
                    break;
                case 3:
                    category = "Cars";
                    break;
                case 4:
                    category = "Clothes";
                    break;
                default :
                    break;
            }
            return category;
        }

        private void CopyListItem()
        {
            _filterList.Clear();
            foreach (Item item in _itemList)
            {                
                _filterList.Add(new Item(item.Name,item.Category,item.Price));
            }
        }

        public void SetStartingFilter()
        {
            _filter = "All";
            _filteredList = false;
        }

        /// <summary>
        /// Property for the itemlist.
        /// </summary>
        public List<Item> ItemList
        {
            get
            {
                return _itemList;
            }
            set
            {
                _itemList = value;
            }
        }

        public string Filter
        {
            get
            {
                return _filter;
            }
        }

        public List<Item> FilterList
        {
            get
            {
                return _filterList;
            }
        }
    }
}
