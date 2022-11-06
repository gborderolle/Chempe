using System;

namespace Services.DTOs
{
    public class DTO_Acceptance
    {
        public int Acceptance_ID { get; set; }
        public DTO_User_client User_acceptance { get; set; }
        public DateTime Datetime_acceptance { get; set; }
    }
}
