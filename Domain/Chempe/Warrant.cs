using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Chempe
{
    public class Warrant
    {
        [Key]
        public int Warrant_ID { get; set; }
        public List_goods_type Goods_type { get; set; }
        public DateTime Datetime_purchase { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Purchase_import { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Current_fair_value { get; set; }

    }
}
