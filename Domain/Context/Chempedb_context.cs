using Domain.Chempe;
using Microsoft.EntityFrameworkCore;

namespace Domain.Context
{
    public class Chempedb_context : DbContext
    {
        public virtual DbSet<Logs> Logs { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<User_client> User_client { get; set; }
        public virtual DbSet<User_investor> User_investor { get; set; }
        public virtual DbSet<User_chempe> User_chempe { get; set; }
        public virtual DbSet<Pledge> Pledge { get; set; }
        public virtual DbSet<Pledge_state> Pledge_state { get; set; }
        public virtual DbSet<Acceptance> Acceptance { get; set; }
        public virtual DbSet<Approval> Approval { get; set; }
        public virtual DbSet<Assignment> Assignment { get; set; }
        public virtual DbSet<Request> Request { get; set; }
        public virtual DbSet<Warrant> Warrant { get; set; }

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
