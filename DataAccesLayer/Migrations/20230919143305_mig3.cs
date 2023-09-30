using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccesLayer.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ExpiryDate",
                table: "Medicines",
                type: "datetime2",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_MedicineId",
                table: "Stocks",
                column: "MedicineId");

            migrationBuilder.AddForeignKey(
                name: "FK_Stocks_Medicines_MedicineId",
                table: "Stocks",
                column: "MedicineId",
                principalTable: "Medicines",
                principalColumn: "MedicineId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stocks_Medicines_MedicineId",
                table: "Stocks");

            migrationBuilder.DropIndex(
                name: "IX_Stocks_MedicineId",
                table: "Stocks");

            migrationBuilder.DropColumn(
                name: "ExpiryDate",
                table: "Medicines");
        }
    }
}
