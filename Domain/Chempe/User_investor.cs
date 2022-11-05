using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Chempe
{
    public class User_investor
    {
        [Key]
        public int User_investor_ID { get; set; }
        public string User_name { get; set; }
        public string Password { get; set; }
        public string Image_Url { get; set; }
    }
}
