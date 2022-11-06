using System;
using System.Collections.Generic;

namespace Services.DTOs
{
    public class DTO_Document
    {
        public int Document_ID { get; set; }
        public string Name { get; set; }
        public DTO_List_documents_type Documents_type { get; set; }
        public List<DTO_Photo> List_photos { get; set; }

    }
}
