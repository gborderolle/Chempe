using System;
using System.Collections.Generic;

namespace Services.DTOs
{
    public class DTO_List_TV_brands
    {
        public int List_TV_brands_ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<DTO_List_TV_brand_models> List_TV_brand_models { get; set; } = new(); // 1 - n 


        /*
    
         public int List_TV_brands_ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<List_TV_brand_models> List_TV_brand_models { get; set; } = new(); // 1 - n 

        */
    }
}
