﻿// <auto-generated />
using System;
using Domain.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Domain.Migrations
{
    [DbContext(typeof(Chempedb_context))]
    partial class Chempedb_contextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Chempe.Acceptance", b =>
                {
                    b.Property<int>("Acceptance_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Datetime_acceptance")
                        .HasColumnType("datetime2");

                    b.Property<int>("User_client_ID")
                        .HasColumnType("int");

                    b.HasKey("Acceptance_ID");

                    b.HasIndex("User_client_ID");

                    b.ToTable("Acceptance");
                });

            modelBuilder.Entity("Domain.Chempe.Approval", b =>
                {
                    b.Property<int>("Approval_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Datetime_approval")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Loan_amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Pledge_ID")
                        .HasColumnType("int");

                    b.Property<decimal>("Primary_coupon_rate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("User_chempe_ID")
                        .HasColumnType("int");

                    b.HasKey("Approval_ID");

                    b.HasIndex("Pledge_ID");

                    b.HasIndex("User_chempe_ID");

                    b.ToTable("Approval");
                });

            modelBuilder.Entity("Domain.Chempe.Assignment", b =>
                {
                    b.Property<int>("Assignment_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Datetime_assignment")
                        .HasColumnType("datetime2");

                    b.Property<int>("Pledge_ID")
                        .HasColumnType("int");

                    b.Property<int>("User_investor_ID")
                        .HasColumnType("int");

                    b.HasKey("Assignment_ID");

                    b.HasIndex("Pledge_ID");

                    b.HasIndex("User_investor_ID");

                    b.ToTable("Assignment");
                });

            modelBuilder.Entity("Domain.Chempe.Document", b =>
                {
                    b.Property<int>("Document_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Documents_typeList_documents_type_ID")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Person_ID")
                        .HasColumnType("int");

                    b.HasKey("Document_ID");

                    b.HasIndex("Documents_typeList_documents_type_ID");

                    b.HasIndex("Person_ID");

                    b.ToTable("Document");
                });

            modelBuilder.Entity("Domain.Chempe.List_TV_brand_models", b =>
                {
                    b.Property<int>("List_TV_brand_models_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("List_TV_brands_ID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("List_TV_brand_models_ID");

                    b.HasIndex("List_TV_brands_ID");

                    b.ToTable("List_TV_brand_models");
                });

            modelBuilder.Entity("Domain.Chempe.List_TV_brands", b =>
                {
                    b.Property<int>("List_TV_brands_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("List_TV_brands_ID");

                    b.ToTable("List_TV_brands");
                });

            modelBuilder.Entity("Domain.Chempe.List_TV_technologies", b =>
                {
                    b.Property<int>("List_TV_technologies_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("List_TV_technologies_ID");

                    b.ToTable("List_TV_technologies");
                });

            modelBuilder.Entity("Domain.Chempe.List_documents_type", b =>
                {
                    b.Property<int>("List_documents_type_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("List_documents_type_ID");

                    b.ToTable("List_documents_type");
                });

            modelBuilder.Entity("Domain.Chempe.List_warrants_type", b =>
                {
                    b.Property<int>("List_warrants_type_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("List_warrants_type_ID");

                    b.ToTable("List_warrants_type");
                });

            modelBuilder.Entity("Domain.Chempe.Logs", b =>
                {
                    b.Property<int>("Log_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Datetime_created_UY")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("IP_client")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Info")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("Person_ID")
                        .HasColumnType("int");

                    b.HasKey("Log_ID");

                    b.HasIndex("Person_ID");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("Domain.Chempe.Person", b =>
                {
                    b.Property<int>("Person_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Date_born")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Full_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Identification")
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("Password")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("Photo_ID")
                        .HasColumnType("int");

                    b.Property<int?>("User_chempe_ID")
                        .HasColumnType("int");

                    b.Property<int?>("User_client_ID")
                        .HasColumnType("int");

                    b.Property<int?>("User_investor_ID")
                        .HasColumnType("int");

                    b.HasKey("Person_ID");

                    b.HasIndex("Photo_ID");

                    b.HasIndex("User_chempe_ID");

                    b.HasIndex("User_client_ID");

                    b.HasIndex("User_investor_ID");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("Domain.Chempe.Photo", b =>
                {
                    b.Property<int>("Photo_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Datetime_upload")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Document_ID")
                        .HasColumnType("int");

                    b.Property<string>("Filename")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("Person_ID")
                        .HasColumnType("int");

                    b.Property<string>("URL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Photo_ID");

                    b.HasIndex("Document_ID");

                    b.HasIndex("Person_ID");

                    b.ToTable("Photo");
                });

            modelBuilder.Entity("Domain.Chempe.Pledge", b =>
                {
                    b.Property<int>("Pledge_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Approval_ID")
                        .HasColumnType("int");

                    b.Property<int?>("Assignment_ID")
                        .HasColumnType("int");

                    b.Property<int>("Loan_term")
                        .HasColumnType("int");

                    b.Property<int?>("Pledge_status_ID")
                        .HasColumnType("int");

                    b.Property<int?>("Request_ID")
                        .HasColumnType("int");

                    b.Property<int?>("Warrant_ID")
                        .HasColumnType("int");

                    b.HasKey("Pledge_ID");

                    b.HasIndex("Approval_ID");

                    b.HasIndex("Assignment_ID");

                    b.HasIndex("Pledge_status_ID");

                    b.HasIndex("Request_ID");

                    b.HasIndex("Warrant_ID");

                    b.ToTable("Pledge");
                });

            modelBuilder.Entity("Domain.Chempe.Pledge_status", b =>
                {
                    b.Property<int>("Pledge_status_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Datetime_lastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Pledge_ID")
                        .HasColumnType("int");

                    b.HasKey("Pledge_status_ID");

                    b.HasIndex("Pledge_ID");

                    b.ToTable("Pledge_status");
                });

            modelBuilder.Entity("Domain.Chempe.Request", b =>
                {
                    b.Property<int>("Request_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Datetime_request")
                        .HasColumnType("datetime2");

                    b.Property<int>("Pledge_ID")
                        .HasColumnType("int");

                    b.Property<int>("User_client_ID")
                        .HasColumnType("int");

                    b.HasKey("Request_ID");

                    b.HasIndex("Pledge_ID");

                    b.HasIndex("User_client_ID");

                    b.ToTable("Request");
                });

            modelBuilder.Entity("Domain.Chempe.User_Session", b =>
                {
                    b.Property<int>("User_Session_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Datetime_login")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("User_Session_ID");

                    b.ToTable("User_Session");
                });

            modelBuilder.Entity("Domain.Chempe.User_chempe", b =>
                {
                    b.Property<int>("User_chempe_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Person_ID")
                        .HasColumnType("int");

                    b.HasKey("User_chempe_ID");

                    b.HasIndex("Person_ID");

                    b.ToTable("User_chempe");
                });

            modelBuilder.Entity("Domain.Chempe.User_client", b =>
                {
                    b.Property<int>("User_client_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NameIdentifier")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Person_ID")
                        .HasColumnType("int");

                    b.Property<string>("Provider")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("User_client_ID");

                    b.HasIndex("Person_ID");

                    b.ToTable("User_client");
                });

            modelBuilder.Entity("Domain.Chempe.User_investor", b =>
                {
                    b.Property<int>("User_investor_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Person_ID")
                        .HasColumnType("int");

                    b.HasKey("User_investor_ID");

                    b.HasIndex("Person_ID");

                    b.ToTable("User_investor");
                });

            modelBuilder.Entity("Domain.Chempe.Warrant", b =>
                {
                    b.Property<int>("Warrant_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Current_fair_value")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Datetime_purchase")
                        .HasColumnType("datetime2");

                    b.Property<int?>("List_goods_type_ID")
                        .HasColumnType("int");

                    b.Property<int>("Pledge_ID")
                        .HasColumnType("int");

                    b.Property<decimal>("Purchase_import")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Warrant_ID");

                    b.HasIndex("List_goods_type_ID");

                    b.HasIndex("Pledge_ID");

                    b.ToTable("Warrant");
                });

            modelBuilder.Entity("Domain.Chempe.Warrant_TV", b =>
                {
                    b.HasBaseType("Domain.Chempe.Warrant");

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Inches")
                        .HasColumnType("int");

                    b.Property<bool>("IsSmart")
                        .HasColumnType("bit");

                    b.Property<string>("Technology")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Warrant_TV");
                });

            modelBuilder.Entity("Domain.Chempe.Acceptance", b =>
                {
                    b.HasOne("Domain.Chempe.User_client", "User_acceptance")
                        .WithMany()
                        .HasForeignKey("User_client_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User_acceptance");
                });

            modelBuilder.Entity("Domain.Chempe.Approval", b =>
                {
                    b.HasOne("Domain.Chempe.Pledge", "Pledge")
                        .WithMany()
                        .HasForeignKey("Pledge_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Chempe.User_chempe", "User_approval")
                        .WithMany()
                        .HasForeignKey("User_chempe_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pledge");

                    b.Navigation("User_approval");
                });

            modelBuilder.Entity("Domain.Chempe.Assignment", b =>
                {
                    b.HasOne("Domain.Chempe.Pledge", "Pledge")
                        .WithMany()
                        .HasForeignKey("Pledge_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Chempe.User_investor", "User_assignment")
                        .WithMany()
                        .HasForeignKey("User_investor_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pledge");

                    b.Navigation("User_assignment");
                });

            modelBuilder.Entity("Domain.Chempe.Document", b =>
                {
                    b.HasOne("Domain.Chempe.List_documents_type", "Documents_type")
                        .WithMany()
                        .HasForeignKey("Documents_typeList_documents_type_ID");

                    b.HasOne("Domain.Chempe.Person", "Person")
                        .WithMany("List_documents")
                        .HasForeignKey("Person_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Documents_type");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Domain.Chempe.List_TV_brand_models", b =>
                {
                    b.HasOne("Domain.Chempe.List_TV_brands", "List_TV_brands")
                        .WithMany("List_TV_brand_models")
                        .HasForeignKey("List_TV_brands_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("List_TV_brands");
                });

            modelBuilder.Entity("Domain.Chempe.Logs", b =>
                {
                    b.HasOne("Domain.Chempe.Person", "Person")
                        .WithMany()
                        .HasForeignKey("Person_ID");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Domain.Chempe.Person", b =>
                {
                    b.HasOne("Domain.Chempe.Photo", "Photo")
                        .WithMany()
                        .HasForeignKey("Photo_ID");

                    b.HasOne("Domain.Chempe.User_chempe", "User_chempe")
                        .WithMany()
                        .HasForeignKey("User_chempe_ID");

                    b.HasOne("Domain.Chempe.User_client", "User_client")
                        .WithMany()
                        .HasForeignKey("User_client_ID");

                    b.HasOne("Domain.Chempe.User_investor", "User_investor")
                        .WithMany()
                        .HasForeignKey("User_investor_ID");

                    b.Navigation("Photo");

                    b.Navigation("User_chempe");

                    b.Navigation("User_client");

                    b.Navigation("User_investor");
                });

            modelBuilder.Entity("Domain.Chempe.Photo", b =>
                {
                    b.HasOne("Domain.Chempe.Document", "Document")
                        .WithMany("List_photos")
                        .HasForeignKey("Document_ID");

                    b.HasOne("Domain.Chempe.Person", "Person")
                        .WithMany()
                        .HasForeignKey("Person_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Document");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Domain.Chempe.Pledge", b =>
                {
                    b.HasOne("Domain.Chempe.Approval", "Approval")
                        .WithMany()
                        .HasForeignKey("Approval_ID");

                    b.HasOne("Domain.Chempe.Assignment", "Assignment")
                        .WithMany()
                        .HasForeignKey("Assignment_ID");

                    b.HasOne("Domain.Chempe.Pledge_status", "Pledge_status")
                        .WithMany()
                        .HasForeignKey("Pledge_status_ID");

                    b.HasOne("Domain.Chempe.Request", "Request")
                        .WithMany()
                        .HasForeignKey("Request_ID");

                    b.HasOne("Domain.Chempe.Warrant", "Warrant")
                        .WithMany()
                        .HasForeignKey("Warrant_ID");

                    b.Navigation("Approval");

                    b.Navigation("Assignment");

                    b.Navigation("Pledge_status");

                    b.Navigation("Request");

                    b.Navigation("Warrant");
                });

            modelBuilder.Entity("Domain.Chempe.Pledge_status", b =>
                {
                    b.HasOne("Domain.Chempe.Pledge", "Pledge")
                        .WithMany()
                        .HasForeignKey("Pledge_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pledge");
                });

            modelBuilder.Entity("Domain.Chempe.Request", b =>
                {
                    b.HasOne("Domain.Chempe.Pledge", "Pledge")
                        .WithMany()
                        .HasForeignKey("Pledge_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Chempe.User_client", "User_request")
                        .WithMany()
                        .HasForeignKey("User_client_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pledge");

                    b.Navigation("User_request");
                });

            modelBuilder.Entity("Domain.Chempe.User_chempe", b =>
                {
                    b.HasOne("Domain.Chempe.Person", "Person")
                        .WithMany()
                        .HasForeignKey("Person_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Domain.Chempe.User_client", b =>
                {
                    b.HasOne("Domain.Chempe.Person", "Person")
                        .WithMany()
                        .HasForeignKey("Person_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Domain.Chempe.User_investor", b =>
                {
                    b.HasOne("Domain.Chempe.Person", "Person")
                        .WithMany()
                        .HasForeignKey("Person_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Domain.Chempe.Warrant", b =>
                {
                    b.HasOne("Domain.Chempe.List_warrants_type", "Goods_type")
                        .WithMany()
                        .HasForeignKey("List_goods_type_ID");

                    b.HasOne("Domain.Chempe.Pledge", "Pledge")
                        .WithMany()
                        .HasForeignKey("Pledge_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Goods_type");

                    b.Navigation("Pledge");
                });

            modelBuilder.Entity("Domain.Chempe.Warrant_TV", b =>
                {
                    b.HasOne("Domain.Chempe.Warrant", null)
                        .WithOne()
                        .HasForeignKey("Domain.Chempe.Warrant_TV", "Warrant_ID")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Chempe.Document", b =>
                {
                    b.Navigation("List_photos");
                });

            modelBuilder.Entity("Domain.Chempe.List_TV_brands", b =>
                {
                    b.Navigation("List_TV_brand_models");
                });

            modelBuilder.Entity("Domain.Chempe.Person", b =>
                {
                    b.Navigation("List_documents");
                });
#pragma warning restore 612, 618
        }
    }
}
