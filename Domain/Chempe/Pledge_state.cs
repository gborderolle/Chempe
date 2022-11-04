using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Chempe
{
    public class Pledge_state
    {
        [Key]
        public int Pledge_state_ID { get; set; }
        public DateTime Datetime_lastUpdate { get; set; }


    }
}
