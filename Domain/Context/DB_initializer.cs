using Domain.Chempe;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;

namespace Domain.Context
{
    public class DB_initializer
    {
        private readonly Chempedb_context _chempedb_context;
        private readonly IConfiguration _configuration;
        private bool ContextIsLocal = false;

        public DB_initializer(Chempedb_context chempedb_context, IConfiguration configuration)
        {
            _chempedb_context = chempedb_context;
            _configuration = configuration;

            if (!bool.TryParse(_configuration.GetConnectionString("ConnectionString_isLocal"), out ContextIsLocal))
            {
                ContextIsLocal = false;
            }
        }
        public void Initialize_data()
        {
            //Verifica si existe y si no la crea 
            if (_chempedb_context.Database.EnsureCreated())
            {
                /* ------------ DATOS ESTÁTICOS ------------ */
                /* ------------ Document_type ------------ */
                List_documents_type List_documents_type1 = new("Person_identity", "Cedula de identidad");
                _chempedb_context.List_documents_type.Add(List_documents_type1);

                /* ------------ Document_type ------------ */
                List_warrants_type List_warrants_type1 = new("Televisor", null);
                _chempedb_context.List_warrants_type.Add(List_warrants_type1);

                /* ------------ List_TV_brands ------------ */
                List_TV_brands List_TV_brands1 = new("Sony", null);
                List_TV_brands List_TV_brands2 = new("Panasonic", null);
                List_TV_brands List_TV_brands3 = new("Samsung", null);
                List_TV_brands List_TV_brands4 = new("LG", null);
                _chempedb_context.List_TV_brands.Add(List_TV_brands1);
                _chempedb_context.List_TV_brands.Add(List_TV_brands2);
                _chempedb_context.List_TV_brands.Add(List_TV_brands3);
                _chempedb_context.List_TV_brands.Add(List_TV_brands4);

                /* ------------ List_TV_brand_models ------------ */
                List_TV_brand_models List_TV_brand_models1 = new("Bravia", List_TV_brands1, null);

                /* ------------ List_TV_technologies ------------ */
                List_TV_technologies List_TV_technologies1 = new("LED", null);
                List_TV_technologies List_TV_technologies2 = new("LCD", "Cristal líquido");
                List_TV_technologies List_TV_technologies3 = new("Tubo", null);
                _chempedb_context.List_TV_technologies.Add(List_TV_technologies1);
                _chempedb_context.List_TV_technologies.Add(List_TV_technologies2);
                _chempedb_context.List_TV_technologies.Add(List_TV_technologies3);

                /* ------------ DATOS DINÁMICOS ------------ */
                /* ------------ Photo ------------ */
                //Photo Photo1 = new("", DateTime.UtcNow, "Foto de perfil");
                //Photo Photo2 = new("", DateTime.Now, "CI frente");
                //Photo Photo3 = new("", DateTime.Now, "CI dorso");
                //_chempedb_context.Photo.Add(Photo1);
                //_chempedb_context.Photo.Add(Photo2);
                //_chempedb_context.Photo.Add(Photo3);

                /* ------------ Document ------------ */
                //List<Photo> ListPhoto1 = new();
                //ListPhoto1.Add(Photo2);
                //ListPhoto1.Add(Photo3);
                //Document Document1 = new("CI", List_documents_type1, ListPhoto1, "");
                //_chempedb_context.Document.Add(Document1);

                /* ------------ User_client ------------ */
                User_client User_client1 = new();
                _chempedb_context.User_client.Add(User_client1);

                /* ------------ Person ------------ */
                //List<Document> ListDocument1 = new();
                //ListDocument1.Add(Document1);
                Person Person1 = new("Gonzalo Borderolle", "gborderolle@gmail.com", "154060gb", "42305298", "M", DateTime.Now, null, User_client1, null, null, null);
                //Document1.Person = Person1;

                _chempedb_context.Person.Add(Person1);

                /* ------------ Save to DB ------------ */
                _chempedb_context.SaveChanges();
            }
        }


    }
}
