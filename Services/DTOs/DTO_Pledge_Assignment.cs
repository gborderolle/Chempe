using System;

namespace Services.DTOs
{
    /// <summary>
    /// La interfaz protege los campos read-only del form de edición (medida de Seguridad) --> Model binding
    /// s: https://www.youtube.com/watch?v=6qq31WYQxrk&list=PL6n9fhu94yhVm6S8I2xd6nYz2ZORd7X2v&index=22&ab_channel=kudvenkat
    /// </summary>
    public interface IDTO_Pledge_Assignment
    {
        public int Pledge_Assignment_ID { get; set; }
        public DTO_Person_investor User_assignment { get; set; }
        public DateTime Datetime_assignment { get; set; }
    }

    public class DTO_Pledge_Assignment : IDTO_Pledge_Assignment
    {
        public int Pledge_Assignment_ID { get; set; }
        public DTO_Person_investor User_assignment { get; set; }
        public DateTime Datetime_assignment { get; set; }
    }
}
