using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Chempe
{
    public class Document
    {
        [Key]
        public int Document_ID { get; set; }
        public string Name { get; set; }
        public List_documents_type Documents_type { get; set; }
        public List<Photo> List_photos { get; set; }

    }
}
