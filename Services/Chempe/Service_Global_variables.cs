using Domain.Context;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeZoneConverter;

namespace Services.Chempe
{
    public class Service_Global_variables
    {
        private readonly IConfiguration _configuration;

        public Service_Global_variables(IConfiguration configuration, Chempedb_context chempedb_context)
        {
            _configuration = configuration;
        }

        public enum Documents_type_enum
        {
            Person_identity
        }

        public enum Warrants_type_enum
        {
            Televisor
        }

        public enum Nombres_espanol_enum
        {
            Documento_de_identidad
        }

        public DateTime GetCurrentTime_Uruguay()
        {
            //return DateTime.Now.ToUniversalTime(); //UTC
            return TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, TimeZoneInfo.FindSystemTimeZoneById("Montevideo Standard Time"));
        }

        public string Get_ConnectionString_ChempeDB()
        {
            return _configuration.GetConnectionString("ConnectionString_chempedb");
        }

        public string Get_GenericConfigurationKey(string key)
        {
            string value_return = string.Empty;
            if (!string.IsNullOrWhiteSpace(_configuration.GetSection(key).Value))
            {
                value_return = _configuration.GetSection(key).Value;
            }
            return value_return;
        }

        public DateTime Datetime_UTCtoUruguayTime(DateTime datetime_Fin)
        {
            TimeZoneInfo TZ = TZConvert.GetTimeZoneInfo("Montevideo Standard Time");
            return TimeZoneInfo.ConvertTimeFromUtc(datetime_Fin, TZ);
        }

        public bool IsIPLocalhost(string iP_address)
        {
            return (iP_address == "127.0.0.1" || iP_address == "::1");
        }
    }
}
