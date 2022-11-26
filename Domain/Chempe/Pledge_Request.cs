using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Chempe
{
    [Table("Pledge_Request")]
    public class Pledge_Request
    {
        [Key]
        public int Pledge_Request_ID { get; set; }
        
        public DateTime Datetime_request { get; set; }
        
        // FK ------------------
        [ForeignKey("Person_client_ID")]
        public Person_client Person_client { get; set; }
        public int Person_client_ID { get; set; }

        // FK ------------------ recibe (sin FK)
        [ForeignKey("Pledge_ID")]
        public Pledge Pledge { get; set; }
        // FK ------------------

        public Pledge_Request()
        {
            Datetime_request = DateTime.UtcNow;
        }

    }
}
