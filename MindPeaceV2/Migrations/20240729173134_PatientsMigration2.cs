using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MindPeaceV2.Migrations
{
    /// <inheritdoc />
    public partial class PatientsMigration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Biography",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhotoURL",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Biography",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "PhotoURL",
                table: "Patients");
        }
    }
}
