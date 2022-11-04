using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Chempe
{
    public class Person
    {
        [Key]
        public int Person_ID { get; set; }
        public string Full_name { get; set; }
        public string Email { get; set; }
        public string Identification { get; set; }
        public DateTime? Date_born { get; set; }
        [ForeignKey("User_client_ID")]
        public Photo Photo { get; set; }
        public User_client User_client { get; set; }
        [ForeignKey("User_investor_ID")]
        public User_investor User_investor { get; set; }
        [ForeignKey("User_chempe_ID")]
        public User_chempe User_chempe { get; set; }

    }
}
