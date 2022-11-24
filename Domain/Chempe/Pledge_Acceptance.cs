using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Chempe
{
    [Table("Pledge_Acceptance")]
    public class Pledge_Acceptance
    {
        [Key]
        public int Pledge_Acceptance_ID { get; set; }
        
        public DateTime Datetime_acceptance { get; set; }

        // FK ------------------ recibe (sin FK)
        [ForeignKey("Person_client_ID")]
        public Person_client Person_client { get; set; }
        // FK ------------------
        
        public Pledge_Acceptance()
        {
        }
    }
}
