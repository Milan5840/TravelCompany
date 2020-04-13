using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelCompany.Web.Migrations
{
    public partial class UserEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Travel_TravelDetails_TravelDetailsid",
                table: "Travel");

            migrationBuilder.DropTable(
                name: "TravelDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Travel",
                table: "Travel");

            migrationBuilder.RenameTable(
                name: "Travel",
                newName: "TravelEntity");

            migrationBuilder.RenameColumn(
                name: "TravelDetailsid",
                table: "TravelEntity",
                newName: "ExpensesTypeEntityid");

            migrationBuilder.RenameColumn(
                name: "Total",
                table: "TravelEntity",
                newName: "ExpenseTotal");

            migrationBuilder.RenameIndex(
                name: "IX_Travel_TravelDetailsid",
                table: "TravelEntity",
                newName: "IX_TravelEntity_ExpensesTypeEntityid");

            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "Expenses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "TravelEntity",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Document",
                table: "TravelEntity",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "TravelEntity",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VisitReason",
                table: "TravelEntity",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TravelEntity_ExpensesType_ExpensesTypeEntityid",
                table: "TravelEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TravelEntity",
                table: "TravelEntity");

            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "City",
                table: "TravelEntity");

            migrationBuilder.DropColumn(
                name: "Document",
                table: "TravelEntity");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "TravelEntity");

            migrationBuilder.DropColumn(
                name: "VisitReason",
                table: "TravelEntity");

            migrationBuilder.RenameTable(
                name: "TravelEntity",
                newName: "Travel");

            migrationBuilder.RenameColumn(
                name: "ExpensesTypeEntityid",
                table: "Travel",
                newName: "TravelDetailsid");

            migrationBuilder.RenameColumn(
                name: "ExpenseTotal",
                table: "Travel",
                newName: "Total");

            migrationBuilder.RenameIndex(
                name: "IX_TravelEntity_ExpensesTypeEntityid",
                table: "Travel",
                newName: "IX_Travel_TravelDetailsid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Travel",
                table: "Travel",
                column: "id");

            migrationBuilder.CreateTable(
                name: "TravelDetails",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    City = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Document = table.Column<int>(nullable: false),
                    ExpensesTypeEntityid = table.Column<int>(nullable: true),
                    FullName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TravelDetails", x => x.id);
                    table.ForeignKey(
                        name: "FK_TravelDetails_ExpensesType_ExpensesTypeEntityid",
                        column: x => x.ExpensesTypeEntityid,
                        principalTable: "ExpensesType",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TravelDetails_ExpensesTypeEntityid",
                table: "TravelDetails",
                column: "ExpensesTypeEntityid");

            migrationBuilder.AddForeignKey(
                name: "FK_Travel_TravelDetails_TravelDetailsid",
                table: "Travel",
                column: "TravelDetailsid",
                principalTable: "TravelDetails",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
