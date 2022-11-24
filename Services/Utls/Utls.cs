using AutoMapper;
using Domain.Chempe;
using Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Services.Utils
{
    public class Utls
    {
        private static MapperConfiguration configuration = new(config =>
        {
            /* ------------ STATIC ENTITIES ------------ */
            config.CreateMap<DTO_List_warrants_type, List_warrants_type>();
            config.CreateMap<List_warrants_type, DTO_List_warrants_type>();

            config.CreateMap<DTO_List_TV_brands, List_TV_brands>();
            config.CreateMap<List_TV_brands, DTO_List_TV_brands>();

            config.CreateMap<DTO_List_TV_brand_models, List_TV_brand_models>();
            config.CreateMap<List_TV_brand_models, DTO_List_TV_brand_models>();

            config.CreateMap<DTO_List_TV_technologies, List_TV_technologies>();
            config.CreateMap<List_TV_technologies, DTO_List_TV_technologies>();

            /* ------------ DYNAMIC ENTITIES ------------ */
            config.CreateMap<DTO_Pledge_Acceptance, Pledge_Acceptance>();
            config.CreateMap<Pledge_Acceptance, DTO_Pledge_Acceptance>();

            config.CreateMap<DTO_Pledge_Approval, Pledge_Approval>();
            config.CreateMap<Pledge_Approval, DTO_Pledge_Approval>();

            config.CreateMap<DTO_Pledge_Assignment, Pledge_Assignment>();
            config.CreateMap<Pledge_Assignment, DTO_Person>();

            config.CreateMap<DTO_Document, Document>();
            config.CreateMap<Document, DTO_Document>();

            config.CreateMap<DTO_List_documents_type, List_documents_type>();
            config.CreateMap<List_documents_type, DTO_List_documents_type>();

            config.CreateMap<DTO_List_warrants_type, List_warrants_type>();
            config.CreateMap<List_warrants_type, DTO_List_warrants_type>();

            config.CreateMap<DTO_Person, Person>();
            config.CreateMap<Person, DTO_Person>();

            config.CreateMap<DTO_Photo, Photo>();
            config.CreateMap<Photo, DTO_Photo>();

            config.CreateMap<DTO_Pledge, Pledge>();
            config.CreateMap<Pledge, DTO_Pledge>();

            config.CreateMap<DTO_Pledge_status, Pledge_status>();
            config.CreateMap<Pledge_status, DTO_Pledge_status>();

            config.CreateMap<DTO_Pledge_Request, Pledge_Request>();
            config.CreateMap<Pledge_Request, DTO_Pledge_Request>();

            config.CreateMap<DTO_Person_user, Person_user>();
            config.CreateMap<Person_user, DTO_Person_user>();

            config.CreateMap<DTO_Person_client, Person_client>();
            config.CreateMap<Person_client, DTO_Person_client>();

            config.CreateMap<DTO_Person_investor, Person_investor>();
            config.CreateMap<Person_investor, DTO_Person_investor>();

            config.CreateMap<DTO_Warrant, Warrant>();
            config.CreateMap<Warrant, DTO_Warrant>();

        });
        public static Mapper mapper { get; set; } = new(configuration);

        #region Helpers

        public string GetSha256(string str)
        {
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }

        public bool SendEmail(string EmailType, string EmailTo, string Subject, string Body)
        {
            try
            {
                string EmailFrom;
                string EmailPassw;

                //correo para manejo de cuentas de usuario
                if (EmailType == "EmailAccounts")
                {
                    EmailFrom = "ChevacaAgrotechnology@gmail.com";
                    EmailPassw = "Chev1122aca33";
                }
                //otros if para otras cuentas y que salga de appconfig o la bd
                else
                {
                    return false;
                }

                MailMessage oMailMessage = new(EmailFrom, EmailTo, Subject, Body);
                oMailMessage.IsBodyHtml = true;

                SmtpClient oSmtpClient = new ("smtp.gmail.com");
                oSmtpClient.EnableSsl = true;
                oSmtpClient.UseDefaultCredentials = false;
                oSmtpClient.Port = 587;
                oSmtpClient.Credentials = new System.Net.NetworkCredential(EmailFrom, EmailPassw);

                oSmtpClient.Send(oMailMessage);

                oSmtpClient.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion
    }
}