using Domain.Chempe;
using Domain.Context;
using Microsoft.Extensions.Configuration;
using System;

namespace Services.Chempe
{
    public class Service_Person_user
    {
        private readonly Chempedb_context _chempedb_context;
        private readonly IConfiguration _configuration;

        /* ------------ DYNAMIC ENTITIES ------------ */
        /* ------------ STATIC ENTITIES ------------ */


        public Service_Person_user(Chempedb_context chempedb_context, IConfiguration configuration)
        {
            _chempedb_context = chempedb_context;
            _configuration = configuration;
        }

        internal Person_user GetUserById(int id)
        {
            return _chempedb_context.Person_user.Find(id);
        }
    }
}
