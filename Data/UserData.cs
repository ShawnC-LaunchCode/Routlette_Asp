using Routlette_Asp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Routlette_Asp.Data
{
    public  class UserData
    {
        static private Dictionary<int, User> Users = new Dictionary<int, User>();
        // key-1 value-first user
        //key-2  value-second user

        public UserData()
        {
            User temp = new User("Shawn", "1234");
            Users.Add(temp.Id,temp);
        }

        public static void Add(User newUser)
        {
           //TODO make sure username doesnt already exist in Users
            Users.Add(newUser.Id, newUser);
        }

        public static User GetById(int id)
        {
            return Users[id];
        }

        public static void DeleteUser(int id)
        {
            Users.Remove(id);
        }

        public static void EditUser(int idToEdit, User newInfo)
        {
            //DeleteUser(idToEdit);
            //Add(newInfo);

            Users[idToEdit].Username = newInfo.Username;
            Users[idToEdit].Password = newInfo.Password;
            Users[idToEdit].Bank = newInfo.Bank;
        }

        public static User UserAuth (string username, string password)
        {
            foreach(KeyValuePair<int,User> user in Users)
            {
                if(user.Value.Username == username && user.Value.Password == password)
                {
                    return user.Value;
                }
            }
            return null;
        }

        public static IEnumerable<User> GetAll()
        {
            return Users.Values;
        }
    }
}
