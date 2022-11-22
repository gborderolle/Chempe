using System;
using System.Collections.Generic;

namespace Services.DTOs
{
    /// <summary>
    /// La interfaz protege los campos read-only del form de edición (medida de Seguridad) --> Model binding
    /// s: https://www.youtube.com/watch?v=6qq31WYQxrk&list=PL6n9fhu94yhVm6S8I2xd6nYz2ZORd7X2v&index=22&ab_channel=kudvenkat
    /// </summary>
    public interface IDTO_Person
    {
        public int Person_ID { get; set; }
        public string Full_name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public DateTime? Date_born { get; set; }
        public DTO_Photo Photo { get; set; }
        public DTO_Person_client Person_client { get; set; }
        public DTO_Person_investor Person_investor { get; set; }
        public DTO_Person_user Person_chempe { get; set; }
        public List<DTO_Document> List_documents { get; set; }
    }

    public class DTO_Person : IDTO_Person
    {
        public int Person_ID { get; set; }
        public string Identification { get; set; }
        public string Full_name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public DateTime? Date_born { get; set; }
        public DTO_Photo Photo { get; set; }
        public DTO_Person_client Person_client { get; set; }
        public DTO_Person_investor Person_investor { get; set; }
        public DTO_Person_user Person_chempe { get; set; }
        public List<DTO_Document> List_documents { get; set; }
    }
}
