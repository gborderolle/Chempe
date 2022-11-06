using Domain.Chempe;
using Microsoft.EntityFrameworkCore;

namespace Domain.Context
{
    public class Chempedb_context : DbContext
    {
        // -------- DATOS ESTÁTICOS --------
        public virtual DbSet<List_documents_type> List_documents_type { get; set; }
        public virtual DbSet<List_goods_type> List_goods_type { get; set; }

        // -------- DATOS DINÁMICOS --------
        public virtual DbSet<Logs> Logs { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<User_client> User_client { get; set; }
        public virtual DbSet<User_investor> User_investor { get; set; }
        public virtual DbSet<User_chempe> User_chempe { get; set; }
        public virtual DbSet<Pledge> Pledge { get; set; }
        public virtual DbSet<Pledge_status> Pledge_status { get; set; }
        public virtual DbSet<Acceptance> Acceptance { get; set; }
        public virtual DbSet<Approval> Approval { get; set; }
        public virtual DbSet<Assignment> Assignment { get; set; }
        public virtual DbSet<Request> Request { get; set; }
        public virtual DbSet<Warrant> Warrant { get; set; }
        public virtual DbSet<Photo> Photo { get; set; }
        public virtual DbSet<Document> Document { get; set; }

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
