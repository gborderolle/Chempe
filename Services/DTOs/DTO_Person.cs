using System;
using System.Collections.Generic;

namespace Services.DTOs
{
    public class DTO_Person
    {
        public int Person_ID { get; set; }
        public string Full_name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Identification { get; set; }
        public string Gender { get; set; }
        public DateTime? Date_born { get; set; }
        public DTO_Photo Photo { get; set; }
        public DTO_User_client User_client { get; set; }
        public DTO_User_investor User_investor { get; set; }
        public DTO_User_chempe User_chempe { get; set; }
        public List<DTO_Document> List_documents { get; set; }
    }
}
