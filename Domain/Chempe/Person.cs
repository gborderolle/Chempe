using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Chempe
{
    public class Person
    {
        [Key]
        public int Person_ID { get; set; }
        [MaxLength(80)]
        public string Full_name { get; set; }
        [MaxLength(30)]
        public string Email { get; set; }
        [MaxLength(20)]
        public string Password { get; set; }
        public string Identification { get; set; }
        public string Gender { get; set; }
        public DateTime? Date_born { get; set; }
        public Photo Photo { get; set; }
        [ForeignKey("User_client_ID")]
        public User_client User_client { get; set; }
        [ForeignKey("User_investor_ID")]
        public User_investor User_investor { get; set; }
        [ForeignKey("User_chempe_ID")]
        public User_chempe User_chempe { get; set; }
        public List<Document> List_documents { get; set; }

    }
}
