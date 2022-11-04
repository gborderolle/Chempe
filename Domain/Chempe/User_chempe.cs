using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Chempe
{
    public class User_chempe
    {
        [Key]
        public int User_chempe_ID { get; set; }
        public string User_name { get; set; }
        public string Password { get; set; }
        [ForeignKey("User_setting_ID")]
        public User_setting User_setting { get; set; }
    }
}
