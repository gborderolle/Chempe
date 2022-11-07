using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DTOs
{
    public class DTO_Login
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public DTO_Login()
        {
        }

        public DTO_Login(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
}