using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Chempe
{
    /// <summary>
    /// Naturaleza de los bienes: televisores, heladeras, lavarropas, calefones, celulares, laptops, tabletas, aspiradoras, etc.
    /// </summary>
    [Table("List_warrants_type")]
    public class List_warrants_type
    {
        [Key]
        public int List_warrants_type_ID { get; set; }
        
        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsEnabled { get; set; } = true;

        public List_warrants_type()
        {
            IsEnabled = true;
        }
        public List_warrants_type(string name, string description = "")
        {
            Name = name;
            Description = description;
            IsEnabled = true;
        }
    }
}
