// new model to hold user information

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;

namespace OnlineBookStore.Models.ViewModels
{
    public class LoginModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        public string ReturnUrl { get; set; }
    }
}
