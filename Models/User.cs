using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Routlette_Asp.Models
{
    public class User
    {
        public string Username { get; set; }
        
        public string Password { get; set; }

        public double Bank { get; set; }

        

        public int Id { get; set; }

        public User()
        {
           
            Bank = 500;
        }

        public User(string username, string password) : this()
        {
            this.Username = username;
            this.Password = password;
        }

        public override string ToString()
        {
            return Username;
        }
    }
}
