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

        public string Phone { get; set; }

        [MaxLength(30)]
        [EmailAddress]
        public string Email { get; set; }
        
        [MaxLength(20)]
        public string Password { get; set; }
        
        public string Gender { get; set; }
        
        public DateTime? Date_born { get; set; }
        
        // FK ------------------
        public Photo Photo { get; set; } // 1* - 1
        
        // FK ------------------
        public Person_client User_client { get; set; } // 1* - 1
        
        // FK ------------------
        public Person_investor User_investor { get; set; } // 1* - 1
        
        // FK ------------------
        public Person_user User_chempe { get; set; } // 1* - 1
        // FK ------------------

        // Source: https://learn.microsoft.com/en-us/ef/core/modeling/relationships?tabs=fluent-api%2Cfluent-api-simple-key%2Csimple-key        
        public virtual List<Document> List_documents { get; set; } = new(); // 1 - n 
        // FK ------------------

        public Person()
        {
            List_documents = new List<Document>();
        }

        public Person(string full_name, string email, string password, string identification, string gender, DateTime date_born, Photo photo, Person_client user_client, Person_investor user_investor, Person_user user_chempe, List<Document> list_documents)
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
