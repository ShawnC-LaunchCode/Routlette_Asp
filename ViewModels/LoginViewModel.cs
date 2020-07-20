using Routlette_Asp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Routlette_Asp.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Required")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "Needs to be between 3 and 15 chars")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Required")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 1, ErrorMessage = "Needs to be between 1 and 20 chars")]
        public string Password { get; set; }

       
    }
}
