using System;

namespace Services.ViewModels
{
    /// <summary>
    /// ModelView que carga la vista para guardado de datos del form
    /// </summary>
    public class VM_Approval_create
    {

        /* ------------ Approval properties ------------ */
        public int Approval_ID { get; set; }
        public int Person_ID { get; set; } // ?? Person_ID o Person_client_ID ??
        public DateTime Datetime_approval { get; set; }
        public int Pledge_ID { get; set; }

        /* ------------ Warrant properties ------------ */
        public int Warrant_ID { get; set; }
        public string Warrant_type_ID { get; set; }
        public DateTime Datetime_purchase { get; set; }
        public decimal Purchase_import { get; set; }
        public decimal Current_fair_value { get; set; }
        public string Comments { get; set; }


        /* ------------ Warrant_TV properties ------------ */
        public string Brand_ID { get; set; }
        public string Model_ID { get; set; }
        public string Technology_ID { get; set; }
        public string Inches { get; set; }
        public string IsSmart { get; set; }

        /* ------------ Public methods ------------ */
        public string Datetime_toString(DateTime dt)
        {
            return dt.ToString("dd MMM, yyyy");
        }

    }
}
