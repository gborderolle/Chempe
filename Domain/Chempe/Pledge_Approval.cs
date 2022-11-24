using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Chempe
{
    [Table("Pledge_Approval")]
    public class Pledge_Approval
    {
        [Key]
        public int Pledge_Approval_ID { get; set; }
        
        public DateTime Datetime_approval { get; set; }
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal Loan_amount { get; set; }
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal Primary_coupon_rate { get; set; }

        // FK ------------------ recibe (sin FK)
        [ForeignKey("Pledge_ID")]
        public Pledge Pledge { get; set; }
        
        // FK ------------------
        [ForeignKey("Person_user_ID")]
        public Person_user Person_user { get; set; }
        public int Person_user_ID { get; set; }
        // FK ------------------

        public Pledge_Approval()
        {
        }
    }
}
