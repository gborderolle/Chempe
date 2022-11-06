using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Chempe
{
    /// <summary>
    /// Naturaleza de los bienes: televisores, heladeras, lavarropas, calefones, celulares, laptops, tabletas, aspiradoras, etc.
    /// </summary>
    [Table("List_goods_type")]
    public class List_goods_type
    {
        [Key]
        public int List_goods_type_ID { get; set; }
        
        public string Name { get; set; }
        
        public bool Enabled { get; set; }

    }
}
