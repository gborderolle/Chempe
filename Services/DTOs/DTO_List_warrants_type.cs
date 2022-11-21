using System;

namespace Services.DTOs
{
    public class DTO_List_warrants_type
    {
        public int DTO_List_warrants_type_ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsEnabled { get; set; } = true;

        public override string ToString()
        {
            return Name;
        }

    }
}
