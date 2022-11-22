using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Chempe
{
    /// <summary>
    /// Fotografías
    /// Formato de archivos: yyyy/MM/dd HH:mm:ss.fff --> yyyyMMddHHmmssfff
    /// </summary>
    [Table("Photo")]
    public class Photo
    {
        [Key]
        public int Photo_ID { get; set; }

        public string URL { get; set; }

        public string Filename { get; set; }

        public DateTime Datetime_upload { get; set; }

        [MaxLength(100)]
        public string Description { get; set; }

        public bool IsDeleted { get; set; } = false;

        // FK ------------------ recibe (sin FK)
        //[ForeignKey("Person_ID")]
        public Person Person { get; set; } // 1 - 1*
        public int Person_ID { get; set; } // 1 - 1*

        // FK ------------------
        [ForeignKey("Document_ID")]
        public Document Document { get; set; } // n - 1
        public int? Document_ID { get; set; } // n - 1 - // ?: Puede existir foto sin documento

        // FK ------------------

        public Photo()
        {
            IsDeleted = false;
        }
        public Photo(string description, string person_identification = "", string uRL = "", int photo_count_byPerson = 0)
        {
            URL = uRL;
            Datetime_upload = DateTime.UtcNow;
            Description = description;
            Filename = DateTime.UtcNow.ToString("yyyy/MM/dd HH:mm:ss.fff").Replace("/", "").Replace(":", "").Replace(".", "").Replace(" ", "");
            IsDeleted = false;
        }

    }
}
