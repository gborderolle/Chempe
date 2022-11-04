using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Chempe
{
    /// <summary>
    /// Evidencias en fotos
    /// </summary>
    public class Photo
    {
        [Key]
        public int Photo_ID { get; set; }
        public string URL { get; set; }
        public DateTime Datetime_upload{ get; set; }

    }
}
