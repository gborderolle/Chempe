using System;

namespace Services.DTOs
{
    public class DTO_Photo
    {
        public int Photo_ID { get; set; }
        public string URL { get; set; }
        public string Filename { get; set; }
        public DateTime Datetime_upload { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }

    }
}
