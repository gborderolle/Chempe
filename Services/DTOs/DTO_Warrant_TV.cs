using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DTOs
{
    /// <summary>
    /// La interfaz protege los campos read-only del form de edición (medida de Seguridad) --> Model binding
    /// s: https://www.youtube.com/watch?v=6qq31WYQxrk&list=PL6n9fhu94yhVm6S8I2xd6nYz2ZORd7X2v&index=22&ab_channel=kudvenkat
    /// </summary>
    public interface IDTO_Warrant_TV
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Technology { get; set; }
        public int Inches { get; set; }
        public bool IsSmart { get; set; }
    }

    public class DTO_Warrant_TV : DTO_Warrant, IDTO_Warrant_TV
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Technology { get; set; }
        public int Inches { get; set; }
        public bool IsSmart { get; set; }

    }
}
