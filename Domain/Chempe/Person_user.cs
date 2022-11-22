using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Chempe
{
    [Table("Person_user")]
    public class Person_user
    {
        [Key]
        public int Person_user_ID { get; set; }

        // FK ------------------ recibe (sin FK)
        [ForeignKey("Person_ID")]
        public Person Person { get; set; } // 1 - 1*
        // FK ------------------

        public Person_user()
        {
        }
    }
}
