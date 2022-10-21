using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebStore.DAL.Migrations
{
    public partial class AdjustmentCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Addresses_BillingAddresId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Addresses_ShippingAddressId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Addresses_sShippingAddressId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_StationaryStores_StoreId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Invoices_InvoiceId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_StationaryStores_StationaryStoreId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderProduct_Order_OrderId",
                table: "OrderProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderProduct_Products_ProductId",
                table: "OrderProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderProduct",
                table: "OrderProduct");

            migrationBuilder.DropIndex(
                name: "IX_OrderProduct_OrderId",
                table: "OrderProduct");

            migrationBuilder.DropIndex(
                name: "IX_OrderProduct_ProductId",
                table: "OrderProduct");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_BillingAddresId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ShippingAddressId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_StoreId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "BillingAddresId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "BillingAddressId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Employment",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ShippingAddressId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "StoreId",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "sShippingAddressId",
                table: "AspNetUsers",
                newName: "StationaryStoreId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_sShippingAddressId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_StationaryStoreId");

            migrationBuilder.RenameColumn(
                name: "Town",
                table: "Addresses",
                newName: "Discriminator");

            migrationBuilder.RenameColumn(
                name: "Country",
                table: "Addresses",
                newName: "City");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "OrderProduct",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "StationaryStoreId",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "InvoiceId",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StationaryStoreId",
                table: "Invoices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Tag",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Position",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Addresses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StationaryStoreId",
                table: "Addresses",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderProduct",
                table: "OrderProduct",
                columns: new[] { "OrderId", "ProductId" });

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_StationaryStoreId",
                table: "Invoices",
                column: "StationaryStoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CustomerId",
                table: "Addresses",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_StationaryStoreId",
                table: "Addresses",
                column: "StationaryStoreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_AspNetUsers_CustomerId",
                table: "Addresses",
                column: "CustomerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_StationaryStores_StationaryStoreId",
                table: "Addresses",
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
                name: "FK_Invoices_StationaryStores_StationaryStoreId",
                table: "Invoices",
                column: "StationaryStoreId",
                principalTable: "StationaryStores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Invoices_InvoiceId",
                table: "Order",
                column: "InvoiceId",
                principalTable: "Invoices",
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
                name: "FK_OrderProduct_Order_OrderId",
                table: "OrderProduct",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProduct_Products_OrderId",
                table: "OrderProduct",
                column: "OrderId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_AspNetUsers_CustomerId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_StationaryStores_StationaryStoreId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_StationaryStores_StationaryStoreId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_StationaryStores_StationaryStoreId",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Invoices_InvoiceId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_StationaryStores_StationaryStoreId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderProduct_Order_OrderId",
                table: "OrderProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderProduct_Products_OrderId",
                table: "OrderProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderProduct",
                table: "OrderProduct");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_StationaryStoreId",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_CustomerId",
                table: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_StationaryStoreId",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "StationaryStoreId",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "Tag",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Position",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "StationaryStoreId",
                table: "Addresses");

            migrationBuilder.RenameColumn(
                name: "StationaryStoreId",
                table: "AspNetUsers",
                newName: "sShippingAddressId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_StationaryStoreId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_sShippingAddressId");

            migrationBuilder.RenameColumn(
                name: "Discriminator",
                table: "Addresses",
                newName: "Town");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "Addresses",
                newName: "Country");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "OrderProduct",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "StationaryStoreId",
                table: "Order",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "InvoiceId",
                table: "Order",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "BillingAddresId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BillingAddressId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Employment",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ShippingAddressId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StoreId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderProduct",
                table: "OrderProduct",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProduct_OrderId",
                table: "OrderProduct",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProduct_ProductId",
                table: "OrderProduct",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_BillingAddresId",
                table: "AspNetUsers",
                column: "BillingAddresId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ShippingAddressId",
                table: "AspNetUsers",
                column: "ShippingAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_StoreId",
                table: "AspNetUsers",
                column: "StoreId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Addresses_BillingAddresId",
                table: "AspNetUsers",
                column: "BillingAddresId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Addresses_ShippingAddressId",
                table: "AspNetUsers",
                column: "ShippingAddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Addresses_sShippingAddressId",
                table: "AspNetUsers",
                column: "sShippingAddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_StationaryStores_StoreId",
                table: "AspNetUsers",
                column: "StoreId",
                principalTable: "StationaryStores",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Invoices_InvoiceId",
                table: "Order",
                column: "InvoiceId",
                principalTable: "Invoices",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_StationaryStores_StationaryStoreId",
                table: "Order",
                column: "StationaryStoreId",
                principalTable: "StationaryStores",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProduct_Order_OrderId",
                table: "OrderProduct",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProduct_Products_ProductId",
                table: "OrderProduct",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
