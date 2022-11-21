using System;

namespace Services.DTOs
{
    /// <summary>
    /// La interfaz protege los campos read-only del form de edición (medida de Seguridad) --> Model binding
    /// s: https://www.youtube.com/watch?v=6qq31WYQxrk&list=PL6n9fhu94yhVm6S8I2xd6nYz2ZORd7X2v&index=22&ab_channel=kudvenkat
    /// </summary>
    public interface IDTO_Warrant
    {
        public int Warrant_ID { get; set; }
        public DTO_List_warrants_type Warrant_type { get; set; }
        public DateTime Datetime_purchase { get; set; }
        public decimal Purchase_import { get; set; }
        public decimal Current_fair_value { get; set; }
        public string Comments { get; set; }
    }

    public class DTO_Warrant : IDTO_Warrant
    {
        public int Warrant_ID { get; set; }
        public DTO_List_warrants_type Warrant_type { get; set; }
        public DateTime Datetime_purchase { get; set; }
        public decimal Purchase_import { get; set; }
        public decimal Current_fair_value { get; set; }
        public string Comments { get; set; }

    }
}