using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebStore.DAL.Migrations
{
    public partial class ModifyStationaryStore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_StationaryStores_StationaryStoreId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_WebStoreUsers_StationaryStores_StationaryStoreId",
                table: "WebStoreUsers");

            migrationBuilder.DropIndex(
                name: "IX_WebStoreUsers_StationaryStoreId",
                table: "WebStoreUsers");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_StationaryStoreId",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "Salary",
                table: "WebStoreUsers");

            migrationBuilder.DropColumn(
                name: "StationaryStoreId",
                table: "WebStoreUsers");

            migrationBuilder.DropColumn(
                name: "StationaryStoreId",
                table: "Addresses");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Salary",
                table: "WebStoreUsers",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StationaryStoreId",
                table: "WebStoreUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StationaryStoreId",
                table: "Addresses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_WebStoreUsers_StationaryStoreId",
                table: "WebStoreUsers",
                column: "StationaryStoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_StationaryStoreId",
                table: "Addresses",
                column: "StationaryStoreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_StationaryStores_StationaryStoreId",
                table: "Addresses",
                column: "StationaryStoreId",
                principalTable: "StationaryStores",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WebStoreUsers_StationaryStores_StationaryStoreId",
                table: "WebStoreUsers",
                column: "StationaryStoreId",
                principalTable: "StationaryStores",
                principalColumn: "Id");
        }
    }
}
