using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Chempe
{
    /// <summary>
    /// Investigar y listar valores por defecto del mercado, nuevos
    /// </summary>
    [Table("List_TV_brand_models")]    
    public class List_TV_brand_models
    {
        [Key]
        public int List_TV_brand_models_ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        // FK ------------------
        [ForeignKey("List_TV_brands_ID")]
        public List_TV_brands List_TV_brands { get; set; } // n - 1
        public int List_TV_brands_ID { get; set; } // n - 1
        // FK ------------------


        public List_TV_brand_models()
        {
        }

        public List_TV_brand_models(string name, List_TV_brands list_TV_brands, string description = "")
        {
            Name = name;
            Description = description;
            List_TV_brands = list_TV_brands;
        }
    }
}
