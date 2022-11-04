using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Chempe
{
    public class Acceptance
    {
        [Key]
        public int Acceptance_ID { get; set; }
        [ForeignKey("User_client_ID")]
        public User_client User_acceptance { get; set; }
        public DateTime Datetime_acceptance { get; set; }
    }
}
