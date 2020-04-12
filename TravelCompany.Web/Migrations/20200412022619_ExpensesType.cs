using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelCompany.Web.Migrations
{
    public partial class ExpensesType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PhotoReceiptPath",
                table: "ExpensesType",
                newName: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "ExpensesType",
                newName: "PhotoReceiptPath");
        }
    }
}
