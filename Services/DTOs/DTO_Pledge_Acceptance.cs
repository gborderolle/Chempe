using System;

namespace Services.DTOs
{
    public class DTO_Pledge_Acceptance
    {
        public int Pledge_Acceptance_ID { get; set; }
        public DTO_Person_client User_acceptance { get; set; }
        public DateTime Datetime_acceptance { get; set; }
    }
}
