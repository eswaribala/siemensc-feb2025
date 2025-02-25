using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankingApp.Migrations
{
    /// <inheritdoc />
    public partial class MyFirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Account_No = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    First_Name = table.Column<string>(type: "varchar(100)", nullable: true),
                    Last_Name = table.Column<string>(type: "varchar(100)", nullable: true),
                    Middle_Name = table.Column<string>(type: "varchar(100)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone_Number = table.Column<long>(type: "bigint", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Account_No);
                });

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Address_Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Door_No = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Postal_Code = table.Column<long>(type: "bigint", nullable: false),
                    Account_No_FK = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Address_Id);
                    table.ForeignKey(
                        name: "FK_Address_Customer_Account_No_FK",
                        column: x => x.Account_No_FK,
                        principalTable: "Customer",
                        principalColumn: "Account_No",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Corporate",
                columns: table => new
                {
                    Account_No = table.Column<long>(type: "bigint", nullable: false),
                    Company_Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Corporate", x => x.Account_No);
                    table.ForeignKey(
                        name: "FK_Corporate_Customer_Account_No",
                        column: x => x.Account_No,
                        principalTable: "Customer",
                        principalColumn: "Account_No",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Individual",
                columns: table => new
                {
                    Account_No = table.Column<long>(type: "bigint", nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Individual", x => x.Account_No);
                    table.ForeignKey(
                        name: "FK_Individual_Customer_Account_No",
                        column: x => x.Account_No,
                        principalTable: "Customer",
                        principalColumn: "Account_No",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Address_Account_No_FK",
                table: "Address",
                column: "Account_No_FK");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Corporate");

            migrationBuilder.DropTable(
                name: "Individual");

            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
