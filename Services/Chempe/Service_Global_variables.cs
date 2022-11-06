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

        public bool IsLocalhost()
        {
            bool contextIsLocal = false;
            if (!bool.TryParse(_configuration.GetConnectionString("ConnectionString_isLocal"), out contextIsLocal))
            {
                contextIsLocal = false;
            }
            return contextIsLocal;
        }

        public DateTime GetCurrentTime_Uruguay()
        {
            //return DateTime.Now.ToUniversalTime(); //UTC
            return TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, TimeZoneInfo.FindSystemTimeZoneById("Montevideo Standard Time"));
        }

        private bool IsLocalConnection()
        {
            bool envIsLocal = false;
            if (!string.IsNullOrWhiteSpace(_configuration.GetConnectionString("ConnectionString_isLocal")))
            {
                if (!bool.TryParse(_configuration.GetConnectionString("ConnectionString_isLocal"), out envIsLocal))
                {
                    envIsLocal = false;
                }
            }
            return envIsLocal;
        }

        public string Get_ConnectionString_ChempeDB()
        {
            string value_return = string.Empty;
            if (IsLocalConnection())
            {
                if (!string.IsNullOrWhiteSpace(_configuration.GetConnectionString("ConnectionString_chempedb")))
                {
                    value_return = _configuration.GetConnectionString("ConnectionString_chempedb");
                }
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(_configuration.GetConnectionString("ConnectionString_chempedb_remoto")))
                {
                    value_return = _configuration.GetConnectionString("ConnectionString_chempedb_remoto");
                }
            }
            return value_return;
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
