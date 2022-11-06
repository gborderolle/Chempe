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
            config.CreateMap<DTO_Acceptance, Acceptance>();
            config.CreateMap<Acceptance, DTO_Acceptance>();

            config.CreateMap<DTO_Approval, Approval>();
            config.CreateMap<Approval, DTO_Approval>();

            config.CreateMap<DTO_Assignment, Assignment>();
            config.CreateMap<Assignment, DTO_Person>();

            config.CreateMap<DTO_Document, Document>();
            config.CreateMap<Document, DTO_Document>();

            config.CreateMap<DTO_List_documents_type, List_documents_type>();
            config.CreateMap<List_documents_type, DTO_List_documents_type>();

            config.CreateMap<DTO_List_goods_type, List_goods_type>();
            config.CreateMap<List_goods_type, DTO_List_goods_type>();

            config.CreateMap<DTO_Person, Person>();
            config.CreateMap<Person, DTO_Person>();

            config.CreateMap<DTO_Photo, Photo>();
            config.CreateMap<Photo, DTO_Photo>();

            config.CreateMap<DTO_Pledge, Pledge>();
            config.CreateMap<Pledge, DTO_Pledge>();

            config.CreateMap<DTO_Pledge_status, Pledge_status>();
            config.CreateMap<Pledge_status, DTO_Pledge_status>();

            config.CreateMap<DTO_Request, Request>();
            config.CreateMap<Request, DTO_Request>();

            config.CreateMap<DTO_User_chempe, User_chempe>();
            config.CreateMap<User_chempe, DTO_User_chempe>();

            config.CreateMap<DTO_User_client, User_client>();
            config.CreateMap<User_client, DTO_User_client>();

            config.CreateMap<DTO_User_investor, User_investor>();
            config.CreateMap<User_investor, DTO_User_investor>();

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
            catch (System.Exception ex)
            {
                //loguear el error
                return false;
            }
        }

        #endregion
    }
}