using System;

namespace Services.DTOs
{
    public class DTO_Pledge
    {
        public int Pledge_ID { get; set; }
        public DTO_Warrant Warrant { get; set; }
        public DTO_Pledge_Request Request { get; set; }
        public DTO_Pledge_Approval Approval { get; set; }
        public DTO_Pledge_Acceptance Acceptance { get; set; }
        public DTO_Pledge_Assignment Assignment { get; set; }
        public DTO_Pledge_status Pledge_status { get; set; }
        public int Loan_term { get; set; }

    }
}
