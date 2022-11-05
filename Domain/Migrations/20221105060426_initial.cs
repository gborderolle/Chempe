using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "List_goods_type",
                columns: table => new
                {
                    List_goods_type_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enabled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_List_goods_type", x => x.List_goods_type_ID);
                });

            migrationBuilder.CreateTable(
                name: "Photo",
                columns: table => new
                {
                    Photo_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Datetime_upload = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photo", x => x.Photo_ID);
                });

            migrationBuilder.CreateTable(
                name: "Pledge_state",
                columns: table => new
                {
                    Pledge_state_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Datetime_lastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pledge_state", x => x.Pledge_state_ID);
                });

            migrationBuilder.CreateTable(
                name: "User_chempe",
                columns: table => new
                {
                    User_chempe_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_chempe", x => x.User_chempe_ID);
                });

            migrationBuilder.CreateTable(
                name: "User_client",
                columns: table => new
                {
                    User_client_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_client", x => x.User_client_ID);
                });

            migrationBuilder.CreateTable(
                name: "User_investor",
                columns: table => new
                {
                    User_investor_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image_Url = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_investor", x => x.User_investor_ID);
                });

            migrationBuilder.CreateTable(
                name: "Warrant",
                columns: table => new
                {
                    Warrant_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Goods_typeList_goods_type_ID = table.Column<int>(type: "int", nullable: true),
                    Datetime_purchase = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Purchase_import = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Current_fair_value = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warrant", x => x.Warrant_ID);
                    table.ForeignKey(
                        name: "FK_Warrant_List_goods_type_Goods_typeList_goods_type_ID",
                        column: x => x.Goods_typeList_goods_type_ID,
                        principalTable: "List_goods_type",
                        principalColumn: "List_goods_type_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Approval",
                columns: table => new
                {
                    Approval_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_chempe_ID = table.Column<int>(type: "int", nullable: true),
                    Datetime_approval = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Loan_amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Primary_coupon_rate = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Approval", x => x.Approval_ID);
                    table.ForeignKey(
                        name: "FK_Approval_User_chempe_User_chempe_ID",
                        column: x => x.User_chempe_ID,
                        principalTable: "User_chempe",
                        principalColumn: "User_chempe_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Acceptance",
                columns: table => new
                {
                    Acceptance_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_client_ID = table.Column<int>(type: "int", nullable: true),
                    Datetime_acceptance = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acceptance", x => x.Acceptance_ID);
                    table.ForeignKey(
                        name: "FK_Acceptance_User_client_User_client_ID",
                        column: x => x.User_client_ID,
                        principalTable: "User_client",
                        principalColumn: "User_client_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Request",
                columns: table => new
                {
                    Request_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_client_ID = table.Column<int>(type: "int", nullable: true),
                    Datetime_request = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Request", x => x.Request_ID);
                    table.ForeignKey(
                        name: "FK_Request_User_client_User_client_ID",
                        column: x => x.User_client_ID,
                        principalTable: "User_client",
                        principalColumn: "User_client_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Assignment",
                columns: table => new
                {
                    Assignment_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_investor_ID = table.Column<int>(type: "int", nullable: true),
                    Datetime_assignment = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignment", x => x.Assignment_ID);
                    table.ForeignKey(
                        name: "FK_Assignment_User_investor_User_investor_ID",
                        column: x => x.User_investor_ID,
                        principalTable: "User_investor",
                        principalColumn: "User_investor_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Person_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Full_name = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Identification = table.Column<string>(type: "nvarchar(max)", nullable: true),
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

            migrationBuilder.CreateTable(
                name: "Pledge",
                columns: table => new
                {
                    Pledge_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Warrant_ID = table.Column<int>(type: "int", nullable: true),
                    Request_ID = table.Column<int>(type: "int", nullable: true),
                    Approval_ID = table.Column<int>(type: "int", nullable: true),
                    Assignment_ID = table.Column<int>(type: "int", nullable: true),
                    Pledge_state_ID = table.Column<int>(type: "int", nullable: true),
                    Loan_term = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pledge", x => x.Pledge_ID);
                    table.ForeignKey(
                        name: "FK_Pledge_Approval_Approval_ID",
                        column: x => x.Approval_ID,
                        principalTable: "Approval",
                        principalColumn: "Approval_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pledge_Assignment_Assignment_ID",
                        column: x => x.Assignment_ID,
                        principalTable: "Assignment",
                        principalColumn: "Assignment_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pledge_Pledge_state_Pledge_state_ID",
                        column: x => x.Pledge_state_ID,
                        principalTable: "Pledge_state",
                        principalColumn: "Pledge_state_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pledge_Request_Request_ID",
                        column: x => x.Request_ID,
                        principalTable: "Request",
                        principalColumn: "Request_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pledge_Warrant_Warrant_ID",
                        column: x => x.Warrant_ID,
                        principalTable: "Warrant",
                        principalColumn: "Warrant_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Logs",
                columns: table => new
                {
                    Log_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Datetime_created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Person_ID = table.Column<int>(type: "int", nullable: true),
                    IP_client = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Info = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.Log_ID);
                    table.ForeignKey(
                        name: "FK_Logs_Person_Person_ID",
                        column: x => x.Person_ID,
                        principalTable: "Person",
                        principalColumn: "Person_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Acceptance_User_client_ID",
                table: "Acceptance",
                column: "User_client_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Approval_User_chempe_ID",
                table: "Approval",
                column: "User_chempe_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Assignment_User_investor_ID",
                table: "Assignment",
                column: "User_investor_ID");

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
                name: "IX_Pledge_Approval_ID",
                table: "Pledge",
                column: "Approval_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Pledge_Assignment_ID",
                table: "Pledge",
                column: "Assignment_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Pledge_Pledge_state_ID",
                table: "Pledge",
                column: "Pledge_state_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Pledge_Request_ID",
                table: "Pledge",
                column: "Request_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Pledge_Warrant_ID",
                table: "Pledge",
                column: "Warrant_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Request_User_client_ID",
                table: "Request",
                column: "User_client_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Warrant_Goods_typeList_goods_type_ID",
                table: "Warrant",
                column: "Goods_typeList_goods_type_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Acceptance");

            migrationBuilder.DropTable(
                name: "Logs");

            migrationBuilder.DropTable(
                name: "Pledge");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "Approval");

            migrationBuilder.DropTable(
                name: "Assignment");

            migrationBuilder.DropTable(
                name: "Pledge_state");

            migrationBuilder.DropTable(
                name: "Request");

            migrationBuilder.DropTable(
                name: "Warrant");

            migrationBuilder.DropTable(
                name: "Photo");

            migrationBuilder.DropTable(
                name: "User_chempe");

            migrationBuilder.DropTable(
                name: "User_investor");

            migrationBuilder.DropTable(
                name: "User_client");

            migrationBuilder.DropTable(
                name: "List_goods_type");
        }
    }
}
