using System;

namespace Services.DTOs
{
    public class DTO_Pledge_Assignment
    {
        public int Pledge_Assignment_ID { get; set; }
        public DTO_Person_investor User_assignment { get; set; }
        public DateTime Datetime_assignment { get; set; }

    }
}
