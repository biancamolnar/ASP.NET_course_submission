using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bmerketo.Migrations
{
    /// <inheritdoc />
    public partial class Date : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eb0a9351-9c59-4a52-a03a-5e7001af25fb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "15da8f3e-82c6-41ee-833d-f9c3c16fee39", "3b619961-682f-4f3b-93c5-564f15c543aa" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "15da8f3e-82c6-41ee-833d-f9c3c16fee39");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b619961-682f-4f3b-93c5-564f15c543aa");

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "492c2320-c10f-4f1e-a29c-faedb0f30ee3", "4d7cd9a2-3c90-41ab-8c66-d59f5be1851c", "User", "USER" },
                    { "d685a377-733b-4bec-9d62-9025feb9e29b", "2738d2d7-866e-4cce-9f93-0113f8f11b89", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "514aa140-ea94-456b-a2b9-ec192333a695", 0, "0164baa1-9ad5-43cf-a790-f037f47acf28", "admin@domain.com", false, null, null, false, null, "ADMIN@DOMAIN.COM", "ADMIN@DOMAIN.COM", "AQAAAAIAAYagAAAAENfFhHG0SMS7QcWqXlbaWjgVL5dO7LSIoBSajiBeghR9+3/UbD+D2yds6vBUM37uig==", null, false, "e46b422b-5290-4669-a9bb-55aa6e18132d", false, "admin@domain.com" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "1",
                column: "Created",
                value: new DateTime(2023, 5, 26, 12, 24, 4, 745, DateTimeKind.Utc).AddTicks(9473));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "10",
                column: "Created",
                value: new DateTime(2023, 5, 26, 12, 24, 4, 745, DateTimeKind.Utc).AddTicks(9513));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "11",
                column: "Created",
                value: new DateTime(2023, 5, 26, 12, 24, 4, 745, DateTimeKind.Utc).AddTicks(9514));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "12",
                column: "Created",
                value: new DateTime(2023, 5, 26, 12, 24, 4, 745, DateTimeKind.Utc).AddTicks(9515));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "13",
                column: "Created",
                value: new DateTime(2023, 5, 26, 12, 24, 4, 745, DateTimeKind.Utc).AddTicks(9516));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "14",
                column: "Created",
                value: new DateTime(2023, 5, 26, 12, 24, 4, 745, DateTimeKind.Utc).AddTicks(9519));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "15",
                column: "Created",
                value: new DateTime(2023, 5, 26, 12, 24, 4, 745, DateTimeKind.Utc).AddTicks(9520));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "16",
                column: "Created",
                value: new DateTime(2023, 5, 26, 12, 24, 4, 745, DateTimeKind.Utc).AddTicks(9521));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "17",
                column: "Created",
                value: new DateTime(2023, 5, 26, 12, 24, 4, 745, DateTimeKind.Utc).AddTicks(9522));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "18",
                column: "Created",
                value: new DateTime(2023, 5, 26, 12, 24, 4, 745, DateTimeKind.Utc).AddTicks(9523));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "19",
                column: "Created",
                value: new DateTime(2023, 5, 26, 12, 24, 4, 745, DateTimeKind.Utc).AddTicks(9524));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "2",
                column: "Created",
                value: new DateTime(2023, 5, 26, 12, 24, 4, 745, DateTimeKind.Utc).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "20",
                column: "Created",
                value: new DateTime(2023, 5, 26, 12, 24, 4, 745, DateTimeKind.Utc).AddTicks(9525));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "3",
                column: "Created",
                value: new DateTime(2023, 5, 26, 12, 24, 4, 745, DateTimeKind.Utc).AddTicks(9482));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "4",
                column: "Created",
                value: new DateTime(2023, 5, 26, 12, 24, 4, 745, DateTimeKind.Utc).AddTicks(9483));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "5",
                column: "Created",
                value: new DateTime(2023, 5, 26, 12, 24, 4, 745, DateTimeKind.Utc).AddTicks(9484));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "6",
                column: "Created",
                value: new DateTime(2023, 5, 26, 12, 24, 4, 745, DateTimeKind.Utc).AddTicks(9508));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "7",
                column: "Created",
                value: new DateTime(2023, 5, 26, 12, 24, 4, 745, DateTimeKind.Utc).AddTicks(9509));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "8",
                column: "Created",
                value: new DateTime(2023, 5, 26, 12, 24, 4, 745, DateTimeKind.Utc).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: "9",
                column: "Created",
                value: new DateTime(2023, 5, 26, 12, 24, 4, 745, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d685a377-733b-4bec-9d62-9025feb9e29b", "514aa140-ea94-456b-a2b9-ec192333a695" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "492c2320-c10f-4f1e-a29c-faedb0f30ee3");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d685a377-733b-4bec-9d62-9025feb9e29b", "514aa140-ea94-456b-a2b9-ec192333a695" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d685a377-733b-4bec-9d62-9025feb9e29b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "514aa140-ea94-456b-a2b9-ec192333a695");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Products");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "15da8f3e-82c6-41ee-833d-f9c3c16fee39", "0f9dd02a-05b9-4c9e-8fbc-b80131d0dd3b", "Admin", "ADMIN" },
                    { "eb0a9351-9c59-4a52-a03a-5e7001af25fb", "1de4738d-a4b0-4bee-a90f-06104787ca20", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3b619961-682f-4f3b-93c5-564f15c543aa", 0, "3237f63a-a6af-4db3-ad06-205c70217f88", "admin@domain.com", false, null, null, false, null, "ADMIN@DOMAIN.COM", "ADMIN@DOMAIN.COM", "AQAAAAIAAYagAAAAEDHab4A+XHxYJsp2Zf6rKiOm0qcAwK8XLGl/Ibc/ap+7F7S9W/Y8xZjhtZUECvH1ug==", null, false, "b33ffb32-0c42-4473-b968-ece4b93f22d9", false, "admin@domain.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "15da8f3e-82c6-41ee-833d-f9c3c16fee39", "3b619961-682f-4f3b-93c5-564f15c543aa" });
        }
    }
}
