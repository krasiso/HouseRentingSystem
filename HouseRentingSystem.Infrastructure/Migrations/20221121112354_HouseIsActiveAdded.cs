using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    public partial class HouseIsActiveAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Houses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            //migrationBuilder.UpdateData(
            //    table: "AspNetUsers",
            //    keyColumn: "Id",
            //    keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
            //    columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
            //    values: new object[] { "a6e7beae-5268-4a30-b29b-71d4de6e7b08", "AQAAAAEAACcQAAAAEBMzl2QhYpgGXjrURYssWX7ozPYwMGK7L2ubHLfbub8JGJHlX/FBrC/bc9CG6+EpaQ==", "4a4188b2-9aa2-4c49-bf08-170ff4f1bf0e" });

            //migrationBuilder.UpdateData(
            //    table: "AspNetUsers",
            //    keyColumn: "Id",
            //    keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
            //    columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
            //    values: new object[] { "3d787b0d-ca3c-499b-afe7-5fb241cde24a", "AQAAAAEAACcQAAAAEJI/4trkuYtMQdJwOy+dlFOLdDRrNrXfQ9UCqQlC8o9bpwH2sbII/h0WMmHxDsHKng==", "14d5c0b5-69ee-4167-86b2-fdc19593873f" });

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "IsActive" },
                values: new object[] { "This bike is for racing and amateur riding on a motocross track!", true });

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsActive",
                value: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Houses");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38acf703-5369-4154-9962-455df6433360", "AQAAAAEAACcQAAAAEPebynMNtdLZv30UJESTjHfWM1WeXGX7nxs2aUgi2aAOA9/v9NZsZPORSy5x9jr7Dw==", "79a196ec-7a1d-440b-8e36-07d6e7a344d1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b5ff8bf0-e164-47e4-9156-d7ead157c4a9", "AQAAAAEAACcQAAAAEJoRq2JvYSSk4kXJYEDFvpz2PkJpmMtqdbCGWusNtfS49ZCmcsb62IgV7+5idO7lYA==", "d46ac5be-459d-476b-9e14-2fd7d7c1e552" });

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "A big house for your whole family. Don't miss to buy a house with three bedrooms.");
        }
    }
}
