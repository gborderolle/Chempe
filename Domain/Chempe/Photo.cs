using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Chempe
{
    /// <summary>
    /// Evidencias en fotos
    /// </summary>
    [Table("Photo")]
    public class Photo
    {
        [Key]
        public int Photo_ID { get; set; }
        
        public string URL { get; set; }
        
        public DateTime Datetime_upload{ get; set; }
        
        public string Description { get; set; }
        
        // FK ------------------ recibe (sin FK)
        public Person Person { get; set; } // 1 - 1*
        public int Person_ID { get; set; } // 1 - 1*
        
        // FK ------------------
        [ForeignKey("Document_ID")]
        public Document Document { get; set; } // n - 1
        public int? Document_ID { get; set; } // n - 1 - // ?: Puede existir foto sin documento
        
        // FK ------------------

        public Photo(string uRL, DateTime datetime_upload, string description)
        {
            URL = uRL;
            Datetime_upload = datetime_upload;
            Description = description;
        }

    }
}
