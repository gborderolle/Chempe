using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Chempe
{
    [Table("Logs")]
    public class Logs
    {
        [Key]
        public int Log_ID { get; set; }
        
        public DateTime Datetime_created_UY { get; set; }
        
        [MaxLength(20)]
        public string IP_client { get; set; }

        [MaxLength(100)]
        public string Description { get; set; }
        
        [MaxLength(100)]
        public string Info { get; set; }

        // FK ------------------
        [ForeignKey("Person_ID")]
        public Person Person { get; set; }
        public int? Person_ID { get; set; } // 1 - 1*
        // FK ------------------

        public Logs()
        {
        }

        public Logs(DateTime datetime, string ip_client, string descrption, string info, Person person)
        {
            Datetime_created_UY = datetime;
            IP_client = ip_client;
            Description = descrption;
            Info = info;
            Person = person;
        }
    }
}
