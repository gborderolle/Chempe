using System;

namespace Services.DTOs
{
    public class DTO_Approval
    {
        public int Approval_ID { get; set; }
        public DTO_Person_user User_approval { get; set; }
        public DateTime Datetime_approval { get; set; }
        public decimal Loan_amount { get; set; }
        public decimal Primary_coupon_rate { get; set; }

    }
}
