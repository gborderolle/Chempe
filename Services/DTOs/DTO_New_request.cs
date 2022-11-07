using System;
using System.Collections.Generic;

namespace Services.DTOs
{
    public class DTO_New_request
    {
        public DTO_Person DTO_Person { get; set; }
        public List<DTO_List_warrants_type> List_DTO_List_warrants_type { get; set; }
        public List<DTO_List_TV_brands> List_DTO_List_TV_brands { get; set; }
        public List<DTO_List_TV_brand_models> List_DTO_List_TV_brand_models { get; set; }
        public List<DTO_List_TV_technologies> List_DTO_List_TV_technologies { get; set; }

    }
}
