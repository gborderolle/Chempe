using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DTOs
{
    public class DTO_Request_create
    {
        /* ------------ View properties ------------ */
        public DTO_Person DTO_Person { get; set; }
        public DTO_Request DTO_Request { get; set; }
        public List<DTO_List_warrants_type> List_DTO_List_warrants_type { get; set; }
        public List<DTO_List_TV_brands> List_DTO_List_TV_brands { get; set; }
        public List<DTO_List_TV_brand_models> List_DTO_List_TV_brand_models { get; set; }
        public List<DTO_List_TV_technologies> List_DTO_List_TV_technologies { get; set; }

        /* ------------ Request properties ------------ */
        public int Request_ID { get; set; }
        public DTO_User_client User_request { get; set; }
        public DateTime Datetime_request { get; set; }
        public DTO_Pledge Pledge { get; set; }

        /* ------------ Warrant properties ------------ */
        public int Warrant_ID { get; set; }
        public DTO_List_warrants_type Warrant_type { get; set; }
        public DateTime Datetime_purchase { get; set; }
        public decimal Purchase_import { get; set; }
        public decimal Current_fair_value { get; set; }
        public string Comments { get; set; }


        /* ------------ Warrant_TV properties ------------ */
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Technology { get; set; }
        public int Inches { get; set; }
        public bool IsSmart { get; set; }


    }
}
