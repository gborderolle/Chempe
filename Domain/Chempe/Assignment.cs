using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Chempe
{
    [Table("Assignment")]
    public class Assignment
    {
        [Key]
        public int Assignment_ID { get; set; }
        
        public DateTime Datetime_assignment { get; set; }
        
        // FK ------------------
        [ForeignKey("User_investor_ID")]
        public User_investor User_assignment { get; set; }
        public int User_investor_ID { get; set; }
        
        // FK ------------------ recibe (sin FK)
        //[ForeignKey("Pledge_ID")]
        public Pledge Pledge { get; set; }
        public int Pledge_ID { get; set; }
        // FK ------------------

        public Assignment()
        {
        }
    }
}
