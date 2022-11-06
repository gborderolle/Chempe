using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Chempe
{
    [Table("User_client")]
    public class User_client
    {
        [Key]
        public int User_client_ID { get; set; }
        
        // FK ------------------ recibe (sin FK)
        public Person Person { get; set; } // 1 - 1*
        public int Person_ID { get; set; } // 1 - 1*
        // FK ------------------

        public User_client()
        {
        }
    }
}
