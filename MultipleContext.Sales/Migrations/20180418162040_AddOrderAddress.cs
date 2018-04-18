using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MultipleContext.Sales.Migrations
{
    public partial class AddOrderAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address_City",
                schema: "Sales",
                table: "Order",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address_Street",
                schema: "Sales",
                table: "Order",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address_City",
                schema: "Sales",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Address_Street",
                schema: "Sales",
                table: "Order");
        }
    }
}
