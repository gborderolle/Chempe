using Domain.Chempe;
using Domain.Context;
using Microsoft.Extensions.Configuration;
using Services.Utils;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Claims;

namespace Services.Chempe
{
    public class Service_User_client
    {
        private readonly Chempedb_context _chempedb_context;
        private readonly IConfiguration _configuration;

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
                if (!DateTime.TryParseExact(input_borndate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out input_borndate_out))
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

        #region Authorization User

        public User_client GetUserByExternalProvider(string provider, string nameIdentifier)
        {
            var appUser = _chempedb_context.User_client.Where(a => a.Provider == provider).Where(a => a.NameIdentifier == nameIdentifier).FirstOrDefault();
            return appUser;
        }

        public User_client GetUserById(int id)
        {
            var appUser = _chempedb_context.User_client.Find(id);
            return appUser;
        }

        public User_client GetUserByEmail(string Email)
        {
            if (!Email.Equals(""))
            {
                var appUser = _chempedb_context.User_client.Where(a => a.Person.Email == Email).FirstOrDefault();
                return appUser;
            }
            else
            {
                return null;
            }
        }

        //Esto esta resuelto en el Login_use: se debe pelar.
        public bool TryValidateUser(string username, string password, out List<Claim> claims)
        {
            claims = new List<Claim>();
            var appUser = _chempedb_context.User_client.Where(a => a.Person.Email == username).Where(a => a.Person.Password == password).FirstOrDefault();
            if (appUser is null)
            {
                return false;
            }
            else
            {
                claims.Add(new Claim(ClaimTypes.NameIdentifier, username));
                claims.Add(new Claim("User_Name", username));
                /*claims.Add(new Claim(ClaimTypes.GivenName, appUser.Firstname));
                claims.Add(new Claim(ClaimTypes.Surname, appUser.Lastname));
                claims.Add(new Claim(ClaimTypes.Email, appUser.Email));
                claims.Add(new Claim(ClaimTypes.MobilePhone, appUser.Mobile));
                foreach (var r in appUser.RoleList)
                {
                    claims.Add(new Claim(ClaimTypes.Role, r));
                }*/
                return true;
            }
        }

        //Esto se tiene que hacer en lo que ya estaba por usaurio, cargar todo y ver lo de los claims, seguramente lo metemos como parte del objeto usuario al asignar un proveedor externo.
        public User_client AddNewUser(string provider, List<Claim> claims)
        {
            User_client appUser = new();
            /*
            appUser.Provider = provider;
            appUser.NameIdentifier = claims.GetClaim(ClaimTypes.NameIdentifier);
            appUser.User_Name = claims.GetClaim("User_Name");
            */

            //appUser.Firstname = claims.GetClaim(ClaimTypes.GivenName);
            //appUser.Lastname = claims.GetClaim(ClaimTypes.Surname);
            var name = claims.GetClaim("User_Name");
            // very rudimentary handling of splitting a users fullname into first and last name. Not very robust.
            /*if (string.IsNullOrEmpty(appUser.Firstname))
            {
                appUser.Firstname = name?.Split(' ').First();
            }
            if (string.IsNullOrEmpty(appUser.Lastname))
            {
                var nameSplit = name?.Split(' ');
                if (nameSplit.Length > 1)
                {
                    appUser.Lastname = name?.Split(' ').Last();
                }
            }
            appUser.Email = claims.GetClaim(ClaimTypes.Email);
            appUser.Mobile = claims.GetClaim(ClaimTypes.MobilePhone);
            appUser.Roles = "NewUser";*/
            var entity = _chempedb_context.User_client.Add(appUser);
            _chempedb_context.SaveChanges();
            return entity.Entity;
        }

        //Manda el correo con el token de verificación.
        //El link a dominio/Account/Recovery/?token
        //Token se almacena en la bd para cuando entre en el link.
        public bool AccountSendRecovery(string email)
        {
            var _user = GetUserByEmail(email);
            if (_user != null)
            {
                /*
                var vv = _configuration.GetSection("DeadNodesTolerance").Value;
                //El dominio tiene que estar declarado en el appsettings
                var systemdomain = _configuration.GetSection("SystemDomain").Value;
                if (string.IsNullOrEmpty(systemdomain)) { systemdomain = "https://localhost"; };

                //Obtiene de utils el token para mandar al correo. 
                Utls util = new ();
                string token = util.GetSha256(Guid.NewGuid().ToString());

                string urlDomain = systemdomain + "/Account/Recovery/?token=" + token;

                //Mandar Correo con el recovery al usuario
                string subject = "Recuperación de contraseña";
                string Body = "<p>Correo para recuperación de contraseña del usuario " + _user.Person.Email + "</p><br>" +
                     "<a href='" + urlDomain + "'>Click para recuperar</a>";

                //Guarda en el usuario el token y la fecha.
                if (util.SendEmail("EmailAccounts", email, subject, Body))
                {
                    _user.Token_Recovery = token;
                    _user.Token_Date_created = DateTime.UtcNow;
                    _chevacaDB_context.Entry(_user).State = EntityState.Modified;
                    _chevacaDB_context.SaveChanges();
                    return true;
                }
                */
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion
    }

    public static class Extensions
    {
        public static string GetClaim(this List<Claim> claims, string name)
        {
            return claims.FirstOrDefault(c => c.Type == name)?.Value;
        }
    }

}