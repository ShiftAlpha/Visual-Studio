using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpCalculator;

//16012775_PROG_Task 1
namespace ExpCalculator
{
    //worker class is created to house and rertieve the dictionary collection'
    //a dictionary collection is used in place of an array
    // there are many times a developer has to decide to use either a dictionary or an array
    //It is useful as one can store groups of related data. Dictionary object is useless as you have access(read, write, update) to a key property associated with an item in the dictionary. 
    //You can assign a Key to an Item when you add the Item to the Collection, but you cannot retrieve the Key associated with an Item nor can you determine (directly) whether a key exists in a Collection.
    //Dictionaries are much friendly and open with their keys. Dictionaries are also considerably faster than Collections.
    class Worker
    {
        private static Worker expInstance;
        // instance of worker class, Expenses Instance 
        public static Worker ExpInstance
        {
            //gets instance if 
            get
            {
                //if Expense instance is equavilent to null
                if(expInstance is null)
                {
                    //then expInstance is equal to a new Worker object
                    expInstance = new Worker();
                }
                //thus returning the expInstance
                return expInstance;
            }
        }
        //Dictionary collection
        //Will be used throughout the program as storage
        private Dictionary<string, Exp> expenses;

        //worker class
        private Worker()
        {
            //expenses is the dictionary object
            //the dictionary houses a string , and that of the attribute that is Exp 
            expenses = new Dictionary<string, Exp>();
        }

        //adds to the dictionary
        public void addExp(string expKey, Exp expense)
        {
            expenses.Add(expKey, expense);
        }

        //represents a generic collection of key value pairs 
        public IDictionary<string, Exp> GetExp()
        {
            //returns expenses obj
            return expenses;
        }
    }
}
