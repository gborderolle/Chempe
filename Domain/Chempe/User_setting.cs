using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Chempe
{
    public class User_setting
    {
        [Key]
        public int User_setting_ID { get; set; }
        public string Value { get; set; }
        public User_client User_client { get; set; }
        public User_investor User_investor { get; set; }
    }
}
