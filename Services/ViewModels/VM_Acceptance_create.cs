using System;

namespace Services.ViewModels
{
    /// <summary>
    /// ModelView que carga la vista para guardado de datos del form
    /// </summary>
    public class VM_Acceptance_create
    {
        /* ------------ Acceptance properties ------------ */
        public int Acceptance_ID { get; set; }
        public int Person_ID { get; set; } // ?? Person_ID o Person_client_ID ??
        public DateTime Datetime_acceptance { get; set; }
        public int Pledge_ID { get; set; }


        /* ------------ Public methods ------------ */
        public string Datetime_toString(DateTime dt)
        {
            return dt.ToString("dd MMM, yyyy");
        }

    }
}
