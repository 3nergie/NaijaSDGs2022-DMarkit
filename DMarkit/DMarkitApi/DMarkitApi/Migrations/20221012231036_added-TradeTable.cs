using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DMarkitApi.Migrations
{
    public partial class addedTradeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trades",
                columns: table => new
                {
                    TradeId = table.Column<Guid>(nullable: false),
                    NameSeller = table.Column<string>(nullable: true),
                    Amount = table.Column<double>(nullable: false),
                    Rate = table.Column<double>(nullable: false),
                    DateCreated = table.Column<DateTimeOffset>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CurrencyPair = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trades", x => x.TradeId);
                });

            migrationBuilder.InsertData(
                table: "Trades",
                columns: new[] { "TradeId", "Amount", "CurrencyPair", "DateCreated", "IsActive", "NameSeller", "Rate" },
                values: new object[] { new Guid("5b1c2b4d-48c7-402a-80c3-cc796ad49c6b"), 50000.0, 4, new DateTimeOffset(new DateTime(2022, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -7, 0, 0, 0)), true, "Adebanjo olaide", 780.0 });

            migrationBuilder.InsertData(
                table: "Trades",
                columns: new[] { "TradeId", "Amount", "CurrencyPair", "DateCreated", "IsActive", "NameSeller", "Rate" },
                values: new object[] { new Guid("2902b665-1190-4c70-9915-b9c2d7680450"), 10000.0, 2, new DateTimeOffset(new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -7, 0, 0, 0)), false, "Adebanjo olatunji", 880.0 });

            migrationBuilder.InsertData(
                table: "Trades",
                columns: new[] { "TradeId", "Amount", "CurrencyPair", "DateCreated", "IsActive", "NameSeller", "Rate" },
                values: new object[] { new Guid("102b566b-ba1f-404c-b2df-e2cde39ade09"), 20000.0, 3, new DateTimeOffset(new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -7, 0, 0, 0)), false, "Adebanjo olatunji", 700.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trades");
        }
    }
}
