using Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Models
{
    public class JSM_Person_documentsIdentity
    {
        public DTO_Person Person { get; set; }
        public List<DTO_Document> List_documents_identity { get; set; }

        public JSM_Person_documentsIdentity(DTO_Person person, List<DTO_Document> list_documents_identity)
        {
            Person = person;
            List_documents_identity = list_documents_identity;
        }

    }
}
