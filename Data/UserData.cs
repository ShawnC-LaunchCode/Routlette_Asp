using Routlette_Asp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Routlette_Asp.Data
{
    public class UserData
    {
        static private Dictionary<int, User> Users = new Dictionary<int, User>();
        public static void Add(User newUser)
        {
           //TODO make sure username doesnt already exist in Users
            Users.Add(newUser.Id, newUser);
        }

        public static User GetById(int id)
        {
            return Users[id];
        }
    }
}
