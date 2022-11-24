using System;

namespace Services.DTOs
{
    /// <summary>
    /// La interfaz protege los campos read-only del form de edición (medida de Seguridad) --> Model binding
    /// s: https://www.youtube.com/watch?v=6qq31WYQxrk&list=PL6n9fhu94yhVm6S8I2xd6nYz2ZORd7X2v&index=22&ab_channel=kudvenkat
    /// </summary>
    public interface IDTO_Pledge_Approval
    {
        public int Pledge_Approval_ID { get; set; }
        public DTO_Person_user User_approval { get; set; }
        public DateTime Datetime_approval { get; set; }
        public decimal Loan_amount { get; set; }
        public decimal Primary_coupon_rate { get; set; }
    }
    public class DTO_Pledge_Approval : IDTO_Pledge_Approval
    {
        public int Pledge_Approval_ID { get; set; }
        public DTO_Person_user User_approval { get; set; }
        public DateTime Datetime_approval { get; set; }
        public decimal Loan_amount { get; set; }
        public decimal Primary_coupon_rate { get; set; }

    }
}
