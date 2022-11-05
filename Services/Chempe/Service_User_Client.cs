using Domain.Chempe;
using Domain.Context;
using Microsoft.Extensions.Configuration;
using System;
using System.Globalization;

namespace Services.Chempe
{
    public class Service_User_client
    {
        private readonly Chempedb_context _chempedb_context;
        private readonly IConfiguration _configuration;

        Configurations _configurations = new();

        public Service_User_client(Chempedb_context chempedb_context, IConfiguration configuration)
        {
            _chempedb_context = chempedb_context;
            _configuration = configuration;
        }

        public bool New_user_client(string input_name, string input_phone, string input_borndate, string input_email, string input_password1, string input_identity)
        {
            bool result = false;
            if (!string.IsNullOrWhiteSpace(input_name) && !string.IsNullOrWhiteSpace(input_phone) &&
                !string.IsNullOrWhiteSpace(input_borndate) && !string.IsNullOrWhiteSpace(input_email) &&
                !string.IsNullOrWhiteSpace(input_password1) && !string.IsNullOrWhiteSpace(input_identity))
            {
                // Sistema de logs
                System.Diagnostics.StackTrace stackTrace = new(true);
                System.Diagnostics.StackFrame stackFrame = new();
                string className = System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name;
                string methodName = stackFrame.GetMethod().Name;

                DateTime input_borndate_out = DateTime.MinValue;
                if (!DateTime.TryParseExact(input_borndate,"dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out input_borndate_out))
                {
                    input_borndate_out = DateTime.MinValue;
                }

                User_client user_client = new();

                _chempedb_context.User_client.Add(user_client);
                _chempedb_context.SaveChanges();

                Person person = new();
                person.Full_name = input_name;
                person.Email = input_email;
                person.Password = input_password1;
                person.Identification = input_identity;
                person.Date_born = input_borndate_out;
                person.User_client = user_client;

                _chempedb_context.Person.Add(person);
                _chempedb_context.SaveChanges();
                result = true;
            }
            return result;
        }
    }
}

