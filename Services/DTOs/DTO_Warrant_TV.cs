using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DTOs
{
    public class DTO_Warrant_TV : DTO_Warrant
    {
        public string Brand { get; set; }
        public string Technology { get; set; }
        public int Inches { get; set; }
        public bool IsSmart { get; set; }

    }
}
