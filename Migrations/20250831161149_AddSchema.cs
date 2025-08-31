using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITI_Console_Day2EF.Migrations
{
    /// <inheritdoc />
    public partial class AddSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.EnsureSchema(
                name: "HR");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "Employee",
                newSchema: "HR");

            migrationBuilder.AddColumn<decimal>(
                name: "salary",
                schema: "HR",
                table: "Employee",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee",
                schema: "HR",
                table: "Employee",
                column: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee",
                schema: "HR",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "salary",
                schema: "HR",
                table: "Employee");

            migrationBuilder.RenameTable(
                name: "Employee",
                schema: "HR",
                newName: "Employees");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "id");
        }
    }
}
