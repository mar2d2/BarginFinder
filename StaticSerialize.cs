using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace ShoppingApplication
{
   static class StaticSerialize<T> where T : class
    {
       /// <summary>
       /// Class that serializes and deserializes objects.
       /// </summary>

      private static string _userPath;
      private static string _itemPath;
      static FileStream fs;
      static BinaryFormatter bf;
      
       static StaticSerialize()
       {
           //Sets the paths.
           _userPath = AppDomain.CurrentDomain.BaseDirectory + "\\userInfo.ser";
           _itemPath = AppDomain.CurrentDomain.BaseDirectory + "\\itemInfo.ser";
       }
       public static void SerializeData(object obj)
       {
           //Checks if obj is Usermanager or ItemManager. Depending on what type the object is the method serializes the object at relevant path.
           if(obj is UserManager)
           {
               fs = new FileStream(_userPath, FileMode.Create);
               bf = new BinaryFormatter();
               bf.Serialize(fs, obj);
               fs.Close();
           }
           if(obj is ItemManager)
           {
               fs = new FileStream(_itemPath, FileMode.Create);
               bf = new BinaryFormatter();
               bf.Serialize(fs, obj);
               fs.Close();
           }
       }

       public static T DeserializeData(char list)
       {
           // Method that deserializes the data. Depending on what the char "list" contains it goes to relevant path and tries to deserialize the object then returns the object.
          bf = new BinaryFormatter();
          T _deserializedData = null;
          if(list == 'u')
          {
             fs = new FileStream(_userPath, FileMode.Open);
             _deserializedData = (T)(object)bf.Deserialize(fs);
        
             fs.Close();
          }

           if(list  == 'i')
           {
               fs = new FileStream(_itemPath, FileMode.Open);
               _deserializedData = (T)(object)bf.Deserialize(fs);
               fs.Close();
           }
           return _deserializedData;
          
       }

    }
}
