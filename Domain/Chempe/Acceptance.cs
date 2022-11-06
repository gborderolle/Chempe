using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Chempe
{
    [Table("Acceptance")]
    public class Acceptance
    {
        [Key]
        public int Acceptance_ID { get; set; }
        
        public DateTime Datetime_acceptance { get; set; }
        
        // FK ------------------ recibe (sin FK)
        public User_client User_acceptance { get; set; }
        public int User_client_ID { get; set; }
        // FK ------------------
    }
}
