using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Chempe
{
    public class User_client
    {
        [Key]
        public int User_client_ID { get; set; }
    }
}
