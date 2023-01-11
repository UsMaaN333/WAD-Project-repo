using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WADSRMSProject.Migrations
{
    public partial class login : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Login",
                table: "Login");

            migrationBuilder.RenameTable(
                name: "Login",
                newName: "loginmodel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_loginmodel",
                table: "loginmodel",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_loginmodel",
                table: "loginmodel");

            migrationBuilder.RenameTable(
                name: "loginmodel",
                newName: "Login");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Login",
                table: "Login",
                column: "Id");
        }
    }
}
