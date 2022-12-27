using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WADSRMSProject.Migrations
{
    /// <inheritdoc />
    public partial class Addmission : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AddmissionModels",
                columns: table => new
                {
                    EmailId = table.Column<string>(name: "Email_Id", type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(name: "First_Name", type: "varchar(20)", nullable: false),
                    LastName = table.Column<string>(name: "Last_Name", type: "varchar(20)", nullable: false),
                    MobileNumber = table.Column<string>(name: "Mobile_Number", type: "varchar(12)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddmissionModels", x => x.EmailId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AddmissionModels");
        }
    }
}
