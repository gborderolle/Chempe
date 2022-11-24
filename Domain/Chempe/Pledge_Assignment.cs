using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Chempe
{
    [Table("Pledge_Assignment")]
    public class Pledge_Assignment
    {
        [Key]
        public int Pledge_Assignment_ID { get; set; }
        
        public DateTime Datetime_assignment { get; set; }
        
        // FK ------------------
        [ForeignKey("Person_investor_ID")]
        public Person_investor Person_investor { get; set; }
        public int Person_investor_ID { get; set; }

        // FK ------------------ recibe (sin FK)
        [ForeignKey("Pledge_ID")]
        public Pledge Pledge { get; set; }
        // FK ------------------

        public Pledge_Assignment()
        {
        }
    }
}
