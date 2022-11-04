using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Chempe
{
    public class Request
    {
        [Key]
        public int Request_ID { get; set; }
        [ForeignKey("User_client_ID")]
        public User_client User_request { get; set; }
        public DateTime Datetime_request { get; set; }

    }
}
