using Domain.Chempe;
using Microsoft.EntityFrameworkCore;

namespace Domain.Context
{
    public class Chempedb_context : DbContext
    {
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<User_client> User_client { get; set; }
        public virtual DbSet<User_investor> User_investor { get; set; }
        public virtual DbSet<User_chempe> User_chempe { get; set; }
        public virtual DbSet<User_setting> User_setting { get; set; }
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
            //modelBuilder.Entity<Person>().HasKey(e => e.Person_ID);
            //modelBuilder.Entity<Person>().HasOne(e => e.User_client).WithOne(e => e.Person);
            //modelBuilder.Entity<Person>().HasOne(e => e.User_investor).WithOne(e => e.Person);

            //modelBuilder.Entity<User_Client>().HasKey(e => e.User_client_ID);
            //modelBuilder.Entity<User_Client>().HasOne(e => e.User_setting).WithOne(e => e.User_Client);

            //modelBuilder.Entity<User_Investor>().HasKey(e => e.User_Investor_ID);
            //modelBuilder.Entity<User_Investor>().HasOne(e => e.User_setting).WithOne(e => e.User_Investor);

            //modelBuilder.Entity<User_Setting>().HasKey(e => e.User_setting_ID);


            /*
            // ToDo: Optimizar uso de FKs -> Ver Youtube *************************
            modelBuilder.Entity<Person>(entity =>
            {
                entity.ToTable("Person");

                entity.HasKey(e => e.Person_ID)
                    .HasName("PK_Person_ID");

                // User_Client 1 FK
                entity.Property(e => e.User_client_ID)
                    .IsRequired()
                    .ValueGeneratedNever();

                entity.HasOne(e => e.User_client)
                    .WithOne(e => e.Person)
                    .HasForeignKey<User_Client>(e => e.User_client_ID);

                // User_Investor 1 FK
                entity.Property(e => e.User_investor_ID)
                    .IsRequired()
                    .ValueGeneratedNever();

                entity.HasOne(e => e.User_investor)
                    .WithOne(e => e.Person)
                    .HasForeignKey<User_Investor>(e => e.User_Investor_ID);
            });

            modelBuilder.Entity<User_Client>(entity =>
            {
                entity.ToTable("User_Client");

                entity.HasKey(e => e.User_client_ID)
                    .HasName("PK_User_Client_ID");

                // User_Setting 1 FK
                entity.HasOne(e => e.User_setting).WithOne(e => e.User_Client);

                //.HasForeignKey<User_Setting>(e => e.User_Setting_ID);



                //entity.HasOne(e => e.User_Setting)
                //    .WithOne(e => e.User_Client)
                //    .HasForeignKey<User_Setting>(e => e.User_Setting_ID);
            });

            modelBuilder.Entity<User_Investor>(entity =>
            {
                entity.ToTable("User_Investor");

                entity.HasKey(e => e.User_Investor_ID)
                    .HasName("PK_User_Investor_ID");

                // User_Setting 1 FK
                entity.Property(e => e.User_setting_ID)
                    .IsRequired()
                    .ValueGeneratedNever();

                //entity.HasOne(e => e.User_Setting)
                //    .WithOne(e => e.User_Investor)
                //    .HasForeignKey<User_Setting>(e => e.User_Setting_ID);
            });

            modelBuilder.Entity<User_Setting>(entity =>
            {
                entity.ToTable("User_Setting");

                entity.HasKey(e => e.User_setting_ID)
                    .HasName("PK_User_Setting_ID");
            });

            */
        }

    }
}
