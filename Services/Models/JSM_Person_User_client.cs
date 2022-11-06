using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Models
{
    public class JSM_Person_User_client
    {
        // Person
        public int Person_ID { get; set; }
        public string Full_name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Identification { get; set; }
        public string Gender { get; set; }
        public DateTime? Date_born { get; set; }
        //public Photo Photo { get; set; }
        //public List<Document> List_documents { get; set; }

        // User_client
        public int UserClient_ID { get; set; }

        // Photo
        public int Photo_ID { get; set; }
        public string Photo_URL { get; set; }
        public DateTime Photo_Datetime_upload { get; set; }

        // Document (list)
        public int Document_ID { get; set; }
        public string Document_Name { get; set; }

        // Document

        //********* Falta terminar


    }
}
