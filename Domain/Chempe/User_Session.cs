using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Chempe
{
    public class User_Session
    {
        [Key]
        public int User_Session_ID { get; set; }

        public string Email { get; set; }

        public DateTime Datetime_login { get; set; }

        public User_Session()
        {
        }
        public User_Session(string email)
        {
            Email = email;
            Datetime_login = DateTime.UtcNow;
            //Jwt = BCrypt.Net.BCrypt.HashPassword(jwt);
        }
    }
}