using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Chempe
{
    public class Logs
    {
        [Key]
        public int Log_ID { get; set; }
        public DateTime Datetime_created { get; set; }
        [ForeignKey("Person_ID")]
        public Person Person { get; set; }
        public string IP_client { get; set; }
        public string Description { get; set; }
        public string Info { get; set; }

    }
}
