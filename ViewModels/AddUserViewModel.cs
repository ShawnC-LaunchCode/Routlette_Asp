using Routlette_Asp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Routlette_Asp.ViewModels
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(50, ErrorMessage = "Password too long!")]
        public string Password { get; set; }

        [DataType(DataType.Password), Compare(nameof(Password))]
        [StringLength(50, ErrorMessage = "Password wasn't that long, neither this, shall be.")]
        public string repeatPassword { get; set; }

       public User User { get; set; }
    }
}
