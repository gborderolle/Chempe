using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Chempe
{
    [Table("Warrant_TV")]
    public class Warrant_TV : Warrant
    {
        public int Inches { get; set; }

        public bool IsSmart { get; set; }

        // FK ------------------
        [ForeignKey("List_TV_brands_ID")]
        public List_TV_brands TV_Brand { get; set; }
        public int? List_TV_brands_ID { get; set; }
        // FK ------------------

        // FK ------------------
        [ForeignKey("List_TV_brand_models_ID")]
        public List_TV_brand_models TV_brand_model { get; set; }
        public int? List_TV_brand_models_ID { get; set; }
        // FK ------------------

        // FK ------------------
        [ForeignKey("List_TV_technologies_ID")]
        public List_TV_technologies TV_technology { get; set; }
        public int? List_TV_technologies_ID { get; set; }
        // FK ------------------




    }
}
