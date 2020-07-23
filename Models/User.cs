using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Roulette_Asp.Models
{
    public class User
    {
        public string Username { get; set; }
        
        public string Password { get; set; }

        public double Bank { get; set; }


        //0=admin, 1=user, 2=delete dummies-->regular users can delete these, but not delete users or admins
        public int UserLevel { get; set; }


        

        public int Id { get; set; }

        public User()
        {
        }

        public User(string username, string password) : this()
        {
            Bank = 500;
            this.Username = username;
            this.Password = password;
            this.UserLevel = 1;
        }

        public override string ToString()
        {
            return Username;
        }
    }
}
