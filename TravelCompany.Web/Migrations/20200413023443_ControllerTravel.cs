using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelCompany.Web.Migrations
{
    public partial class ControllerTravel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TravelEntity_ExpensesType_ExpensesTypeEntityid",
                table: "TravelEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TravelEntity",
                table: "TravelEntity");

            migrationBuilder.RenameTable(
                name: "TravelEntity",
                newName: "Travel");

            migrationBuilder.RenameIndex(
                name: "IX_TravelEntity_ExpensesTypeEntityid",
                table: "Travel",
                newName: "IX_Travel_ExpensesTypeEntityid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Travel",
                table: "Travel",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Travel_ExpensesType_ExpensesTypeEntityid",
                table: "Travel",
                column: "ExpensesTypeEntityid",
                principalTable: "ExpensesType",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Travel_ExpensesType_ExpensesTypeEntityid",
                table: "Travel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Travel",
                table: "Travel");

            migrationBuilder.RenameTable(
                name: "Travel",
                newName: "TravelEntity");

            migrationBuilder.RenameIndex(
                name: "IX_Travel_ExpensesTypeEntityid",
                table: "TravelEntity",
                newName: "IX_TravelEntity_ExpensesTypeEntityid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TravelEntity",
                table: "TravelEntity",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_TravelEntity_ExpensesType_ExpensesTypeEntityid",
                table: "TravelEntity",
                column: "ExpensesTypeEntityid",
                principalTable: "ExpensesType",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
