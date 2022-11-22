using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Chempe
{
    [Table("Person_investor")]
    public class Person_investor
    {
        [Key]
        public int Person_investor_ID { get; set; }

        // FK ------------------ recibe (sin FK)
        [ForeignKey("Person_ID")]
        public Person Person { get; set; } // 1 - 1*
        // FK ------------------

        public Person_investor()
        {
        }

    }
}
