using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Chempe
{
    public class Pledge_status
    {
        [Key]
        public int Pledge_status_ID { get; set; }
        public DateTime Datetime_lastUpdate { get; set; }


    }
}
