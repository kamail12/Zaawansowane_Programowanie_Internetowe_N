using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebStore.DAL.Migrations
{
    public partial class AddSoftDelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_AspNetUsers_CustomerId",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Address_StationaryStores_StationaryStoreId",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_StationaryStores_StationaryStoreId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoice_StationaryStores_StationaryStoreId",
                table: "Invoice");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_StationaryStores_StationaryStoreId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderProduct_Product_OrderId",
                table: "OrderProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_StationaryStores_Address_AddressId",
                table: "StationaryStores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StationaryStores",
                table: "StationaryStores");

            migrationBuilder.DropIndex(
                name: "IX_StationaryStores_AddressId",
                table: "StationaryStores");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "StationaryStores");

            migrationBuilder.RenameTable(
                name: "StationaryStores",
                newName: "StationaryStore");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Product",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Order",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Invoice",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Address",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "StationaryStore",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "StationaryStore",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StationaryStore",
                table: "StationaryStore",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProduct_ProductId",
                table: "OrderProduct",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_AspNetUsers_CustomerId",
                table: "Address",
                column: "CustomerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_StationaryStore_StationaryStoreId",
                table: "Address",
                column: "StationaryStoreId",
                principalTable: "StationaryStore",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_StationaryStore_StationaryStoreId",
                table: "AspNetUsers",
                column: "StationaryStoreId",
                principalTable: "StationaryStore",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoice_StationaryStore_StationaryStoreId",
                table: "Invoice",
                column: "StationaryStoreId",
                principalTable: "StationaryStore",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_StationaryStore_StationaryStoreId",
                table: "Order",
                column: "StationaryStoreId",
                principalTable: "StationaryStore",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProduct_Product_ProductId",
                table: "OrderProduct",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_AspNetUsers_CustomerId",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Address_StationaryStore_StationaryStoreId",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_StationaryStore_StationaryStoreId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoice_StationaryStore_StationaryStoreId",
                table: "Invoice");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_StationaryStore_StationaryStoreId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderProduct_Product_ProductId",
                table: "OrderProduct");

            migrationBuilder.DropIndex(
                name: "IX_OrderProduct_ProductId",
                table: "OrderProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StationaryStore",
                table: "StationaryStore");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Invoice");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "StationaryStore");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "StationaryStore");

            migrationBuilder.RenameTable(
                name: "StationaryStore",
                newName: "StationaryStores");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Address",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "StationaryStores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_StationaryStores",
                table: "StationaryStores",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_StationaryStores_AddressId",
                table: "StationaryStores",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_AspNetUsers_CustomerId",
                table: "Address",
                column: "CustomerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Address_StationaryStores_StationaryStoreId",
                table: "Address",
                column: "StationaryStoreId",
                principalTable: "StationaryStores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_StationaryStores_StationaryStoreId",
                table: "AspNetUsers",
                column: "StationaryStoreId",
                principalTable: "StationaryStores",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoice_StationaryStores_StationaryStoreId",
                table: "Invoice",
                column: "StationaryStoreId",
                principalTable: "StationaryStores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_StationaryStores_StationaryStoreId",
                table: "Order",
                column: "StationaryStoreId",
                principalTable: "StationaryStores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProduct_Product_OrderId",
                table: "OrderProduct",
                column: "OrderId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StationaryStores_Address_AddressId",
                table: "StationaryStores",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
