using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WADSRMSProject.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DataModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(name: "First_Name", type: "varchar(20)", nullable: false),
                    LastName = table.Column<string>(name: "Last_Name", type: "varchar(20)", nullable: false),
                    DateOfbirth = table.Column<DateTime>(name: "Date_Of_birth", type: "datetime2", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Password = table.Column<string>(type: "varchar(20)", nullable: false),
                    ReTypePassword = table.Column<string>(type: "varchar(20)", nullable: false),
                    SecurityQuestion = table.Column<string>(type: "varchar(50)", nullable: false),
                    SecurityAnswer = table.Column<string>(type: "varchar(50)", nullable: false),
                    Address = table.Column<string>(type: "varchar(30)", nullable: false),
                    City = table.Column<string>(type: "varchar(12)", nullable: false),
                    State = table.Column<string>(type: "varchar(8)", nullable: false),
                    ZipCode = table.Column<string>(type: "varchar(12)", nullable: false),
                    Phone = table.Column<string>(type: "varchar(12)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataModels", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DataModels");
        }
    }
}
