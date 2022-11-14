using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Chempe
{
    [Table("User_chempe")]
    public class User_chempe
    {
        [Key]
        public int User_chempe_ID { get; set; }
        
        // FK ------------------ recibe (sin FK)
        //[ForeignKey("Person_ID")]
        public Person Person { get; set; } // 1 - 1*
        public int Person_ID { get; set; } // 1 - 1*
        // FK ------------------

        public User_chempe()
        {
        }
    }
}
