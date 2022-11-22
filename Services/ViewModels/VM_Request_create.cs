using Services.DTOs;
using System;
using System.Collections.Generic;

namespace Services.ViewModels
{
    public class VM_Request_create
    {

        /* ------------ Request properties ------------ */
        public int Request_ID { get; set; }
        public int User_client_ID { get; set; }
        public DateTime Datetime_request { get; set; }
        public int Pledge_ID { get; set; }

        /* ------------ Warrant properties ------------ */
        public int Warrant_ID { get; set; }
        public string Warrant_type { get; set; }
        public DateTime Datetime_purchase { get; set; }
        public decimal Purchase_import { get; set; }
        public decimal Current_fair_value { get; set; }
        public string Comments { get; set; }


        /* ------------ Warrant_TV properties ------------ */
        public int Brand_ID { get; set; }
        public int Model_ID { get; set; }
        public int Technology_ID { get; set; }
        public int Inches { get; set; }
        public bool IsSmart { get; set; }


    }
}
