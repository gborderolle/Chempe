using Domain.Chempe;
using Microsoft.EntityFrameworkCore;

namespace Domain.Context
{
    public class Chempedb_context : DbContext
    {
        // -------- DATOS ESTÁTICOS --------
        public virtual DbSet<List_documents_type> List_documents_type { get; set; }
        public virtual DbSet<List_TV_brands> List_TV_brands { get; set; }
        public virtual DbSet<List_TV_brand_models> List_TV_brand_models { get; set; }
        public virtual DbSet<List_TV_technologies> List_TV_technologies { get; set; }
        public virtual DbSet<List_warrants_type> List_warrants_type { get; set; }

        // -------- DATOS DINÁMICOS --------
        public virtual DbSet<Pledge_Acceptance> Pledge_Acceptance { get; set; }
        public virtual DbSet<Pledge_Approval> Pledge_Approval { get; set; }
        public virtual DbSet<Pledge_Assignment> Pledge_Assignment { get; set; }
        public virtual DbSet<Document> Document { get; set; }
        public virtual DbSet<Logs> Logs { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Photo> Photo { get; set; }
        public virtual DbSet<Pledge> Pledge { get; set; }
        public virtual DbSet<Pledge_status> Pledge_status { get; set; }
        public virtual DbSet<Pledge_Request> Pledge_Request { get; set; }
        public virtual DbSet<Person_user> Person_user { get; set; }
        public virtual DbSet<Person_client> Person_client { get; set; }
        public virtual DbSet<Person_investor> Person_investor { get; set; }
        public virtual DbSet<User_Session> User_Session { get; set; }
        public virtual DbSet<Warrant> Warrant { get; set; }
        public virtual DbSet<Warrant_TV> Warrant_TV { get; set; }

        public Chempedb_context(DbContextOptions<Chempedb_context> options)
            : base(options)
        {
        }
        public Chempedb_context()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

    }
}
