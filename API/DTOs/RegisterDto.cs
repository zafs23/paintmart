using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{   
    public class RegisterDTO
    {
        [Required]
        public string Username{ get; set; } // username camel case doesnt have to match

        [Required]
        public string Password { get; set;}
    }
}