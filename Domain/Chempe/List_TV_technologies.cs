using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Chempe
{
    [Table("List_TV_technologies")]
    public class List_TV_technologies
    {
        [Key]
        public int List_TV_technologies_ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List_TV_technologies()
        {
        }

        public List_TV_technologies(string name, string description="")
        {
            Name = name;
            Description = description;
        }

    }
}
