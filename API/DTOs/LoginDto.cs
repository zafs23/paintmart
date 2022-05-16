using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class LoginDTO
    {
        public string Username{ get; set; } // username camel case doesnt have to match

        public string Password { get; set;}
        
    }
}