using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "List_documents_type",
                columns: table => new
                {
                    List_documents_type_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_List_documents_type", x => x.List_documents_type_ID);
                });

            migrationBuilder.CreateTable(
                name: "List_TV_brands",
                columns: table => new
                {
                    List_TV_brands_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_List_TV_brands", x => x.List_TV_brands_ID);
                });

            migrationBuilder.CreateTable(
                name: "List_TV_technologies",
                columns: table => new
                {
                    List_TV_technologies_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_List_TV_technologies", x => x.List_TV_technologies_ID);
                });

            migrationBuilder.CreateTable(
                name: "List_warrants_type",
                columns: table => new
                {
                    List_warrants_type_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_List_warrants_type", x => x.List_warrants_type_ID);
                });

            migrationBuilder.CreateTable(
                name: "User_Session",
                columns: table => new
                {
                    User_Session_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Datetime_login = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Session", x => x.User_Session_ID);
                });

            migrationBuilder.CreateTable(
                name: "List_TV_brand_models",
                columns: table => new
                {
                    List_TV_brand_models_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    List_TV_brands_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_List_TV_brand_models", x => x.List_TV_brand_models_ID);
                    table.ForeignKey(
                        name: "FK_List_TV_brand_models_List_TV_brands_List_TV_brands_ID",
                        column: x => x.List_TV_brands_ID,
                        principalTable: "List_TV_brands",
                        principalColumn: "List_TV_brands_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pledge",
                columns: table => new
                {
                    Pledge_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Loan_term = table.Column<int>(type: "int", nullable: false),
                    Warrant_ID = table.Column<int>(type: "int", nullable: true),
                    Request_ID = table.Column<int>(type: "int", nullable: true),
                    Approval_ID = table.Column<int>(type: "int", nullable: true),
                    Assignment_ID = table.Column<int>(type: "int", nullable: true),
                    Pledge_status_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pledge", x => x.Pledge_ID);
                });

            migrationBuilder.CreateTable(
                name: "Pledge_status",
                columns: table => new
                {
                    Pledge_status_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Datetime_lastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Pledge_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pledge_status", x => x.Pledge_status_ID);
                    table.ForeignKey(
                        name: "FK_Pledge_status_Pledge_Pledge_ID",
                        column: x => x.Pledge_ID,
                        principalTable: "Pledge",
                        principalColumn: "Pledge_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Warrant",
                columns: table => new
                {
                    Warrant_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Datetime_purchase = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Purchase_import = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Current_fair_value = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Pledge_ID = table.Column<int>(type: "int", nullable: false),
                    List_goods_type_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warrant", x => x.Warrant_ID);
                    table.ForeignKey(
                        name: "FK_Warrant_List_warrants_type_List_goods_type_ID",
                        column: x => x.List_goods_type_ID,
                        principalTable: "List_warrants_type",
                        principalColumn: "List_warrants_type_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Warrant_Pledge_Pledge_ID",
                        column: x => x.Pledge_ID,
                        principalTable: "Pledge",
                        principalColumn: "Pledge_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Warrant_TV",
                columns: table => new
                {
                    Warrant_ID = table.Column<int>(type: "int", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Technology = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inches = table.Column<int>(type: "int", nullable: false),
                    IsSmart = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warrant_TV", x => x.Warrant_ID);
                    table.ForeignKey(
                        name: "FK_Warrant_TV_Warrant_Warrant_ID",
                        column: x => x.Warrant_ID,
                        principalTable: "Warrant",
                        principalColumn: "Warrant_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Photo",
                columns: table => new
                {
                    Photo_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Filename = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Datetime_upload = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Person_ID = table.Column<int>(type: "int", nullable: false),
                    Document_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photo", x => x.Photo_ID);
                });

            migrationBuilder.CreateTable(
                name: "Document",
                columns: table => new
                {
                    Document_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Documents_typeList_documents_type_ID = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Person_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document", x => x.Document_ID);
                    table.ForeignKey(
                        name: "FK_Document_List_documents_type_Documents_typeList_documents_type_ID",
                        column: x => x.Documents_typeList_documents_type_ID,
                        principalTable: "List_documents_type",
                        principalColumn: "List_documents_type_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Logs",
                columns: table => new
                {
                    Log_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Datetime_created_UY = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IP_client = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Info = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Person_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.Log_ID);
                });

            migrationBuilder.CreateTable(
                name: "User_chempe",
                columns: table => new
                {
                    User_chempe_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Person_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_chempe", x => x.User_chempe_ID);
                });

            migrationBuilder.CreateTable(
                name: "Approval",
                columns: table => new
                {
                    Approval_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Datetime_approval = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Loan_amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Primary_coupon_rate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Pledge_ID = table.Column<int>(type: "int", nullable: false),
                    User_chempe_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Approval", x => x.Approval_ID);
                    table.ForeignKey(
                        name: "FK_Approval_Pledge_Pledge_ID",
                        column: x => x.Pledge_ID,
                        principalTable: "Pledge",
                        principalColumn: "Pledge_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Approval_User_chempe_User_chempe_ID",
                        column: x => x.User_chempe_ID,
                        principalTable: "User_chempe",
                        principalColumn: "User_chempe_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User_client",
                columns: table => new
                {
                    User_client_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Person_ID = table.Column<int>(type: "int", nullable: false),
                    NameIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Provider = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_client", x => x.User_client_ID);
                });

            migrationBuilder.CreateTable(
                name: "Acceptance",
                columns: table => new
                {
                    Acceptance_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Datetime_acceptance = table.Column<DateTime>(type: "datetime2", nullable: false),
                    User_client_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acceptance", x => x.Acceptance_ID);
                    table.ForeignKey(
                        name: "FK_Acceptance_User_client_User_client_ID",
                        column: x => x.User_client_ID,
                        principalTable: "User_client",
                        principalColumn: "User_client_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Request",
                columns: table => new
                {
                    Request_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Datetime_request = table.Column<DateTime>(type: "datetime2", nullable: false),
                    User_client_ID = table.Column<int>(type: "int", nullable: false),
                    Pledge_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Request", x => x.Request_ID);
                    table.ForeignKey(
                        name: "FK_Request_Pledge_Pledge_ID",
                        column: x => x.Pledge_ID,
                        principalTable: "Pledge",
                        principalColumn: "Pledge_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Request_User_client_User_client_ID",
                        column: x => x.User_client_ID,
                        principalTable: "User_client",
                        principalColumn: "User_client_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User_investor",
                columns: table => new
                {
                    User_investor_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Person_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_investor", x => x.User_investor_ID);
                });

            migrationBuilder.CreateTable(
                name: "Assignment",
                columns: table => new
                {
                    Assignment_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Datetime_assignment = table.Column<DateTime>(type: "datetime2", nullable: false),
                    User_investor_ID = table.Column<int>(type: "int", nullable: false),
                    Pledge_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignment", x => x.Assignment_ID);
                    table.ForeignKey(
                        name: "FK_Assignment_Pledge_Pledge_ID",
                        column: x => x.Pledge_ID,
                        principalTable: "Pledge",
                        principalColumn: "Pledge_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Assignment_User_investor_User_investor_ID",
                        column: x => x.User_investor_ID,
                        principalTable: "User_investor",
                        principalColumn: "User_investor_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Person_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Identification = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    Full_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date_born = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Photo_ID = table.Column<int>(type: "int", nullable: true),
                    User_client_ID = table.Column<int>(type: "int", nullable: true),
                    User_investor_ID = table.Column<int>(type: "int", nullable: true),
                    User_chempe_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Person_ID);
                    table.ForeignKey(
                        name: "FK_Person_Photo_Photo_ID",
                        column: x => x.Photo_ID,
                        principalTable: "Photo",
                        principalColumn: "Photo_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Person_User_chempe_User_chempe_ID",
                        column: x => x.User_chempe_ID,
                        principalTable: "User_chempe",
                        principalColumn: "User_chempe_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Person_User_client_User_client_ID",
                        column: x => x.User_client_ID,
                        principalTable: "User_client",
                        principalColumn: "User_client_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Person_User_investor_User_investor_ID",
                        column: x => x.User_investor_ID,
                        principalTable: "User_investor",
                        principalColumn: "User_investor_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Acceptance_User_client_ID",
                table: "Acceptance",
                column: "User_client_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Approval_Pledge_ID",
                table: "Approval",
                column: "Pledge_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Approval_User_chempe_ID",
                table: "Approval",
                column: "User_chempe_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Assignment_Pledge_ID",
                table: "Assignment",
                column: "Pledge_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Assignment_User_investor_ID",
                table: "Assignment",
                column: "User_investor_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Document_Documents_typeList_documents_type_ID",
                table: "Document",
                column: "Documents_typeList_documents_type_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Document_Person_ID",
                table: "Document",
                column: "Person_ID");

            migrationBuilder.CreateIndex(
                name: "IX_List_TV_brand_models_List_TV_brands_ID",
                table: "List_TV_brand_models",
                column: "List_TV_brands_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Logs_Person_ID",
                table: "Logs",
                column: "Person_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Person_Photo_ID",
                table: "Person",
                column: "Photo_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Person_User_chempe_ID",
                table: "Person",
                column: "User_chempe_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Person_User_client_ID",
                table: "Person",
                column: "User_client_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Person_User_investor_ID",
                table: "Person",
                column: "User_investor_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Photo_Document_ID",
                table: "Photo",
                column: "Document_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Photo_Person_ID",
                table: "Photo",
                column: "Person_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Pledge_Approval_ID",
                table: "Pledge",
                column: "Approval_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Pledge_Assignment_ID",
                table: "Pledge",
                column: "Assignment_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Pledge_Pledge_status_ID",
                table: "Pledge",
                column: "Pledge_status_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Pledge_Request_ID",
                table: "Pledge",
                column: "Request_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Pledge_Warrant_ID",
                table: "Pledge",
                column: "Warrant_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Pledge_status_Pledge_ID",
                table: "Pledge_status",
                column: "Pledge_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Request_Pledge_ID",
                table: "Request",
                column: "Pledge_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Request_User_client_ID",
                table: "Request",
                column: "User_client_ID");

            migrationBuilder.CreateIndex(
                name: "IX_User_chempe_Person_ID",
                table: "User_chempe",
                column: "Person_ID");

            migrationBuilder.CreateIndex(
                name: "IX_User_client_Person_ID",
                table: "User_client",
                column: "Person_ID");

            migrationBuilder.CreateIndex(
                name: "IX_User_investor_Person_ID",
                table: "User_investor",
                column: "Person_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Warrant_List_goods_type_ID",
                table: "Warrant",
                column: "List_goods_type_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Warrant_Pledge_ID",
                table: "Warrant",
                column: "Pledge_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Pledge_Approval_Approval_ID",
                table: "Pledge",
                column: "Approval_ID",
                principalTable: "Approval",
                principalColumn: "Approval_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pledge_Assignment_Assignment_ID",
                table: "Pledge",
                column: "Assignment_ID",
                principalTable: "Assignment",
                principalColumn: "Assignment_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pledge_Pledge_status_Pledge_status_ID",
                table: "Pledge",
                column: "Pledge_status_ID",
                principalTable: "Pledge_status",
                principalColumn: "Pledge_status_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pledge_Request_Request_ID",
                table: "Pledge",
                column: "Request_ID",
                principalTable: "Request",
                principalColumn: "Request_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pledge_Warrant_Warrant_ID",
                table: "Pledge",
                column: "Warrant_ID",
                principalTable: "Warrant",
                principalColumn: "Warrant_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Photo_Document_Document_ID",
                table: "Photo",
                column: "Document_ID",
                principalTable: "Document",
                principalColumn: "Document_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Photo_Person_Person_ID",
                table: "Photo",
                column: "Person_ID",
                principalTable: "Person",
                principalColumn: "Person_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Document_Person_Person_ID",
                table: "Document",
                column: "Person_ID",
                principalTable: "Person",
                principalColumn: "Person_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Logs_Person_Person_ID",
                table: "Logs",
                column: "Person_ID",
                principalTable: "Person",
                principalColumn: "Person_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_chempe_Person_Person_ID",
                table: "User_chempe",
                column: "Person_ID",
                principalTable: "Person",
                principalColumn: "Person_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_client_Person_Person_ID",
                table: "User_client",
                column: "Person_ID",
                principalTable: "Person",
                principalColumn: "Person_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_investor_Person_Person_ID",
                table: "User_investor",
                column: "Person_ID",
                principalTable: "Person",
                principalColumn: "Person_ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Person_User_client_User_client_ID",
                table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK_Request_User_client_User_client_ID",
                table: "Request");

            migrationBuilder.DropForeignKey(
                name: "FK_Approval_Pledge_Pledge_ID",
                table: "Approval");

            migrationBuilder.DropForeignKey(
                name: "FK_Assignment_Pledge_Pledge_ID",
                table: "Assignment");

            migrationBuilder.DropForeignKey(
                name: "FK_Pledge_status_Pledge_Pledge_ID",
                table: "Pledge_status");

            migrationBuilder.DropForeignKey(
                name: "FK_Request_Pledge_Pledge_ID",
                table: "Request");

            migrationBuilder.DropForeignKey(
                name: "FK_Warrant_Pledge_Pledge_ID",
                table: "Warrant");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_User_chempe_User_chempe_ID",
                table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_User_investor_User_investor_ID",
                table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK_Document_List_documents_type_Documents_typeList_documents_type_ID",
                table: "Document");

            migrationBuilder.DropForeignKey(
                name: "FK_Document_Person_Person_ID",
                table: "Document");

            migrationBuilder.DropForeignKey(
                name: "FK_Photo_Person_Person_ID",
                table: "Photo");

            migrationBuilder.DropTable(
                name: "Acceptance");

            migrationBuilder.DropTable(
                name: "List_TV_brand_models");

            migrationBuilder.DropTable(
                name: "List_TV_technologies");

            migrationBuilder.DropTable(
                name: "Logs");

            migrationBuilder.DropTable(
                name: "User_Session");

            migrationBuilder.DropTable(
                name: "Warrant_TV");

            migrationBuilder.DropTable(
                name: "List_TV_brands");

            migrationBuilder.DropTable(
                name: "User_client");

            migrationBuilder.DropTable(
                name: "Pledge");

            migrationBuilder.DropTable(
                name: "Approval");

            migrationBuilder.DropTable(
                name: "Assignment");

            migrationBuilder.DropTable(
                name: "Pledge_status");

            migrationBuilder.DropTable(
                name: "Request");

            migrationBuilder.DropTable(
                name: "Warrant");

            migrationBuilder.DropTable(
                name: "List_warrants_type");

            migrationBuilder.DropTable(
                name: "User_chempe");

            migrationBuilder.DropTable(
                name: "User_investor");

            migrationBuilder.DropTable(
                name: "List_documents_type");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "Photo");

            migrationBuilder.DropTable(
                name: "Document");
        }
    }
}
