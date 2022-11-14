using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Chempe
{
    [Table("Pledge_status")]
    public class Pledge_status
    {
        [Key]
        public int Pledge_status_ID { get; set; }
        
        public DateTime Datetime_lastUpdate { get; set; }
        
        // FK ------------------ recibe (sin FK)
        //[ForeignKey("Pledge_ID")]
        public Pledge Pledge { get; set; }
        public int Pledge_ID { get; set; }
        // FK ------------------

        public Pledge_status()
        {
        }
    }
}
