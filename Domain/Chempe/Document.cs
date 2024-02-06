using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Chempe
{
    [Table("Document")]
    public class Document
    {
        [Key]
        public int Document_ID { get; set; }
        
        [MaxLength(30)]
        public string Name { get; set; }

        public List_documents_type Documents_type { get; set; }

        public virtual List<Photo> List_photos { get; set; } = new(); // 1 - n
        
        [MaxLength(100)]
        public string Description { get; set; }

        public bool IsDeleted { get; set; } = false;

        // FK ------------------
        //[ForeignKey("Person_ID")]
        //public Person Person { get; set; } // n - 1
        // FK ------------------

        public Document()
        {
            IsDeleted = false;
        }
        public Document(string name)
        {
            Name = name;
            IsDeleted = false;
        }
        public Document(string name, List_documents_type documents_type, List<Photo> list_photos, string description)
        {
            Name = name;
            Documents_type = documents_type;
            List_photos = list_photos;
            Description = description;
            IsDeleted = false;
        }

        public Document(string name, List_documents_type documents_type, string description = "")
        {
            Name = name;
            Documents_type = documents_type;
            Description = description;
            IsDeleted = false;
        }

    }
}
