using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Services.DTOs
{
    public class DTO_List_TV_brand_models
    {
        public int List_TV_brand_models_ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DTO_List_TV_brands List_TV_brands { get; set; } // n - 1
        public int List_TV_brands_ID { get; set; } // n - 1

        /*

        public int List_TV_brand_models_ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        // FK ------------------
        [ForeignKey("List_TV_brands_ID")]
        public List_TV_brands List_TV_brands { get; set; } // n - 1
        public int List_TV_brands_ID { get; set; } // n - 1


        */
    }
}
