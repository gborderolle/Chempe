using Services.DTOs;
using System;

namespace Services.ViewModels
{
    /// <summary>
    /// ModelView que carga la vista para guardado de datos del form
    /// </summary>
    public class VM_Approval_create
    {
        public DTO_Pledge DTO_Pledge { get; set; }



        /* ------------ Approval properties ------------ */
        //public DTO_Pledge_Approval DTO_Pledge_Approval { get; set; }

        //public int Approval_ID { get; set; }
        //public int Person_ID { get; set; } // ?? Person_ID o Person_client_ID ??
        //public DateTime Datetime_approval { get; set; }
        //public int Pledge_ID { get; set; }

        //public DTO_Pledge_Request DTO_Pledge_Request { get; set; }

        /* ------------ Warrant properties ------------ */
        //public DTO_Warrant DTO_Warrant { get; set; }
        //public int Warrant_ID { get; set; }
        //public string Warrant_type_ID { get; set; }
        //public DateTime Datetime_purchase { get; set; }
        //public decimal Purchase_import { get; set; }
        //public decimal Current_fair_value { get; set; }
        //public string Comments { get; set; }

        /* ------------ Warrant_TV properties ------------ */
        //public DTO_Warrant_TV DTO_Warrant_TV { get; set; }
        //public string Brand_ID { get; set; }
        //public string Model_ID { get; set; }
        //public string Technology_ID { get; set; }
        //public string Inches { get; set; }
        //public string IsSmart { get; set; }

        /* ------------ Public methods ------------ */
        public string Datetime_toString(DateTime dt)
        {
            return dt.ToString("dd MMM, yyyy");
        }

    }
}
