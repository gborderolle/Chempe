using System;

namespace Services.DTOs
{
    public class DTO_Assignment
    {
        public int Assignment_ID { get; set; }
        public DTO_Person_investor User_assignment { get; set; }
        public DateTime Datetime_assignment { get; set; }

    }
}
