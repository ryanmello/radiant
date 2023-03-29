using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorSyncfusionCrm.Server.Migrations
{
    /// <inheritdoc />
    public partial class LatLong : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "isDeleted",
                table: "Contacts",
                newName: "IsDeleted");

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 3, 29, 8, 37, 33, 961, DateTimeKind.Local).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 3, 29, 8, 37, 33, 961, DateTimeKind.Local).AddTicks(3869));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 3, 29, 8, 37, 33, 961, DateTimeKind.Local).AddTicks(3872));

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 3, 29, 8, 37, 33, 961, DateTimeKind.Local).AddTicks(3987));

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 3, 29, 8, 37, 33, 961, DateTimeKind.Local).AddTicks(3994));

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 3, 29, 8, 37, 33, 961, DateTimeKind.Local).AddTicks(3992));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Contacts",
                newName: "isDeleted");

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 3, 26, 22, 20, 3, 992, DateTimeKind.Local).AddTicks(4779));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 3, 26, 22, 20, 3, 992, DateTimeKind.Local).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 3, 26, 22, 20, 3, 992, DateTimeKind.Local).AddTicks(4823));

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 3, 26, 22, 20, 3, 992, DateTimeKind.Local).AddTicks(4947));

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 3, 26, 22, 20, 3, 992, DateTimeKind.Local).AddTicks(4953));

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 3, 26, 22, 20, 3, 992, DateTimeKind.Local).AddTicks(4951));
        }
    }
}
