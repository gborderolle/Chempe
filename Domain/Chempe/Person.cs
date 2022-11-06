using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Chempe
{
    [Table("Person")]
    public class Person
    {
        [Key]
        public int Person_ID { get; set; }
        
        [MaxLength(80)]
        public string Identification { get; set; }
        
        public string Full_name { get; set; }
        [MaxLength(30)]
        [EmailAddress]
        public string Email { get; set; }
        
        [MaxLength(20)]
        public string Password { get; set; }
        
        public string Gender { get; set; }
        
        public DateTime? Date_born { get; set; }
        
        // FK ------------------
        [ForeignKey("Photo_ID")]
        public Photo Photo { get; set; } // 1* - 1
        public int? Photo_ID { get; set; } // 1 - 1*
        
        // FK ------------------
        [ForeignKey("User_client_ID")]
        public User_client User_client { get; set; } // 1* - 1
        public int? User_client_ID { get; set; } // 1 - 1*
        
        // FK ------------------
        [ForeignKey("User_investor_ID")]
        public User_investor User_investor { get; set; } // 1* - 1
        public int? User_investor_ID { get; set; } // 1 - 1*
        
        // FK ------------------
        [ForeignKey("User_chempe_ID")]
        public User_chempe User_chempe { get; set; } // 1* - 1
        public int? User_chempe_ID { get; set; } // 1 - 1*
        // FK ------------------

        // Source: https://learn.microsoft.com/en-us/ef/core/modeling/relationships?tabs=fluent-api%2Cfluent-api-simple-key%2Csimple-key        
        public virtual List<Document> List_documents { get; set; } // 1 - n 
        // FK ------------------

        public Person()
        {

        }

        public Person(string full_name, string email, string password, string identification, string gender, DateTime date_born, Photo photo, User_client user_client, User_investor user_investor, User_chempe user_chempe, List<Document> list_documents)
        {
            Full_name = full_name;
            Email = email;
            Password = password;
            Identification = identification;
            Gender = gender;
            Date_born = date_born;
            Photo = photo;
            User_client = user_client;
            User_investor = user_investor;
            User_chempe = user_chempe;
            List_documents = list_documents;
        }
    }
}
