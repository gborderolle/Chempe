using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Chempe
{
    [Table("Person_client")]
    public class Person_client
    {
        [Key]
        public int Person_client_ID { get; set; }

        // FK ------------------ recibe (sin FK)
        [ForeignKey("Person_ID")]
        public Person Person { get; set; } // 1 - 1*
        // FK ------------------

        public Person_client()
        {
        }
    }
}
