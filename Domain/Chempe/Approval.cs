using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Chempe
{
    [Table("Approval")]
    public class Approval
    {
        [Key]
        public int Approval_ID { get; set; }
        
        public DateTime Datetime_approval { get; set; }
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal Loan_amount { get; set; }
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal Primary_coupon_rate { get; set; }
        
        // FK ------------------ recibe (sin FK)
        public Pledge Pledge { get; set; }
        public int Pledge_ID { get; set; }
        
        // FK ------------------
        [ForeignKey("User_chempe_ID")]
        public User_chempe User_approval { get; set; }
        public int User_chempe_ID { get; set; }
        // FK ------------------
    }
}
