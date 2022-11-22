using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Chempe
{
    [Table("List_TV_brands")]
    public class List_TV_brands
    {
        [Key]
        public int List_TV_brands_ID { get; set; }

        [MaxLength(30)]
        public string Name { get; set; }

        [MaxLength(100)]
        public string Description { get; set; }

        public List<List_TV_brand_models> List_TV_brand_models { get; set; } = new(); // 1 - n 

        // FK ------------------ recibe (sin FK)
        [ForeignKey("Warrant_ID")]
        public Warrant_TV Warrant_TV { get; set; }

        public List_TV_brands()
        {
        }

        public List_TV_brands(string name, string description="")
        {
            Name = name;
            Description = description;
            List_TV_brand_models = new ();
        }

        public List_TV_brands(string name, string description, List<List_TV_brand_models> list_TV_brand_models)
        {
            Name = name;
            Description = description;
            List_TV_brand_models = list_TV_brand_models;
        }

    }
}
