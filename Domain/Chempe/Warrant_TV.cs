using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Chempe
{
    [Table("Warrant_TV")]
    public class Warrant_TV : Warrant
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public string Technology { get; set; }

        public int Inches { get; set; }

        public bool IsSmart { get; set; }

    }
}
