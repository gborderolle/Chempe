using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Chempe
{
    public class Approval
    {
        [Key]
        public int Approval_ID { get; set; }
        [ForeignKey("User_chempe_ID")]
        public User_chempe User_approval { get; set; }
        public DateTime Datetime_approval { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Loan_amount { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Primary_coupon_rate { get; set; }

    }
}
