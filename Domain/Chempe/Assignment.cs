using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Chempe
{
    public class Assignment
    {
        [Key]
        public int Assignment_ID { get; set; }
        [ForeignKey("User_investor_ID")]
        public User_investor User_assignment { get; set; }
        public DateTime Datetime_assignment { get; set; }

    }
}
