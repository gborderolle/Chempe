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
        [ForeignKey("User_client_ID")]
        public Person_client User_acceptance { get; set; }
        // FK ------------------
        
        public Acceptance()
        {
        }
    }
}
