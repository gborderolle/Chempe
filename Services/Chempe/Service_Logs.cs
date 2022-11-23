using Domain.Chempe;
using Domain.Context;
using Microsoft.Extensions.Configuration;
using Services.DTOs;
using Services.Utils;
using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace Services.Chempe
{
    public class Service_Logs
    {
        private readonly IConfiguration _configurations;
        private readonly Chempedb_context _chempedb_context;

        /* ------------ DYNAMIC ENTITIES ------------ */
        private readonly Service_Global_variables _service_global_variables;

        /* ------------ STATIC ENTITIES ------------ */


        public Service_Logs(IConfiguration configuration, Chempedb_context chempedb_context, Service_Global_variables service_global_variables)
        {
            _configurations = configuration;
            _chempedb_context = chempedb_context;
            _service_global_variables = service_global_variables;
        }

        public void Log_AgregarExcepcion(string message, string className, string methodName, string obj, [CallerLineNumber] int numberNumber = 0)
        {
            try
            {
                string error_log_file = _configurations.GetSection("Error_log_file").Value;
                if (!string.IsNullOrWhiteSpace(error_log_file))
                {
                    using (StreamWriter writer = new(error_log_file, true))
                    {
                        writer.WriteLine(DateTime.Now.ToString() + ": [ln:" + numberNumber + "] " + className + ": " + methodName + "() - " + message + " " + obj + ".");
                    }
                }
            }
            catch (Exception) { }
        }

        public void Log_AgregarAccion(string message, string object_ID, Person person, string IP_client = "")
        {
            // Logger variables
            System.Diagnostics.StackTrace stackTrace = new(true);
            System.Diagnostics.StackFrame stackFrame = new();
            string className = System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name;
            string methodName = stackFrame.GetMethod().Name;

            Logs _logs = new(_service_global_variables.GetCurrentTime_Uruguay(), IP_client, message, object_ID, person);

            _chempedb_context.Logs.Add(_logs);
            _chempedb_context.SaveChanges();
        }

    }
}