using System;

namespace Services.DTOs
{
    /// <summary>
    /// La interfaz protege los campos read-only del form de edición (medida de Seguridad) --> Model binding
    /// s: https://www.youtube.com/watch?v=6qq31WYQxrk&list=PL6n9fhu94yhVm6S8I2xd6nYz2ZORd7X2v&index=22&ab_channel=kudvenkat
    /// </summary>
    public interface IDTO_Pledge_Acceptance
    {
        public int Pledge_Acceptance_ID { get; set; }
        public DTO_Person_client User_acceptance { get; set; }
        public DateTime Datetime_acceptance { get; set; }
    }
    public class DTO_Pledge_Acceptance : IDTO_Pledge_Acceptance
    {
        public int Pledge_Acceptance_ID { get; set; }
        public DTO_Person_client User_acceptance { get; set; }
        public DateTime Datetime_acceptance { get; set; }
    }
}
