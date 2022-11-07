using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Chempe
{
    /// <summary>
    /// Bienes prendados de garantía para el crédito
    /// Investigar y listar valores por defecto del mercado, nuevos
    /// Vida útil promedio y calcular amortizaciones
    /// </summary>
    [Table("Warrant")]    
    public class Warrant
    {
        [Key]
        public int Warrant_ID { get; set; }
        
        public DateTime Datetime_purchase { get; set; }
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal Purchase_import { get; set; }
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal Current_fair_value { get; set; }

        // FK ------------------ recibe (sin FK)
        public Pledge Pledge { get; set; }
        public int Pledge_ID { get; set; }
        
        // FK ------------------
        [ForeignKey("List_goods_type_ID")]
        public List_warrants_type Goods_type { get; set; }
        public int? List_goods_type_ID { get; set; }
        // FK ------------------

        public Warrant()
        {
        }
    }
}
