using System;

namespace Services.DTOs
{
    public class DTO_Request
    {
        public int Request_ID { get; set; }
        public DTO_User_client User_request { get; set; }
        public DateTime Datetime_request { get; set; }

    }
}
