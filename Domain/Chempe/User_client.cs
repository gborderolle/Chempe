using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Chempe
{
    [Table("User_client")]
    public class User_client
    {
        [Key]
        public int User_client_ID { get; set; }

        // FK ------------------ recibe (sin FK)
        public Person Person { get; set; } // 1 - 1*
        public int Person_ID { get; set; } // 1 - 1*
        // FK ------------------


        /* Esto va a quedar en otro contexto donde haya una relación de usaurio/reporte para tomar el correo y mandar distintas cosas
            public bool Reporting_ON { get; set; }
            public int Reports_EmailDaily_ID { get; set; }
            public Reports_DailyEmail Reports_DailyEmail { get; set; }
        */

        //Add to external authorization (google/facebook/microsoft365)
        public string NameIdentifier { get; set; }  //el id que entrega el proveedor
        public string Provider { get; set; }       // proveedor de oauth2

        public User_client()
        {
        }
    }
}
