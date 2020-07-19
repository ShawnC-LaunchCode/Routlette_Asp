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

        private static int nextId { get; set; }

        public int Id { get; }

        public User()
        {
            Id = nextId++;
            Bank = 500;
        }

        public User(string username, string password) : this()
        {
            this.Username = username;
            this.Password = password;
        }
    }
}
