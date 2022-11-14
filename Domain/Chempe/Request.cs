using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Chempe
{
    [Table("Request")]
    public class Request
    {
        [Key]
        public int Request_ID { get; set; }
        
        public DateTime Datetime_request { get; set; }
        
        // FK ------------------
        [ForeignKey("User_client_ID")]
        public User_client User_request { get; set; }
        public int User_client_ID { get; set; }
        
        // FK ------------------ recibe (sin FK)
        //[ForeignKey("Pledge_ID")]
        public Pledge Pledge { get; set; }
        public int Pledge_ID { get; set; }
        // FK ------------------

        public Request()
        {
        }

    }
}
