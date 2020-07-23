using Microsoft.EntityFrameworkCore;
using Roulette_Asp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Roulette_Asp.Data
{
    public class UserDbContext : DbContext
    {

        public DbSet<User> Users { get; set; }

        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {

        }

    }
}
