using System;

namespace Services.DTOs
{
    public class DTO_Warrant
    {
        public int Warrant_ID { get; set; }
        public DTO_List_goods_type Goods_type { get; set; }
        public DateTime Datetime_purchase { get; set; }
        public decimal Purchase_import { get; set; }
        public decimal Current_fair_value { get; set; }

    }
}