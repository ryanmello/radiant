using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorSyncfusionCrm.Server.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NickName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notes_Contacts_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contacts",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateOfBirth", "DateUpdated", "FirstName", "LastName", "NickName", "Place", "isDeleted" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 3, 26, 22, 20, 3, 992, DateTimeKind.Local).AddTicks(4779), null, new DateTime(2001, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Peter", "Parker", "Spider-Man", "New York City", false },
                    { 2, new DateTime(2023, 3, 26, 22, 20, 3, 992, DateTimeKind.Local).AddTicks(4820), null, new DateTime(2001, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bruce", "Wayne", "Batman", "Gotham City", false },
                    { 3, new DateTime(2023, 3, 26, 22, 20, 3, 992, DateTimeKind.Local).AddTicks(4823), null, new DateTime(2001, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Tony", "Stark", "Ironman", "Malibu", false }
                });

            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "Id", "ContactId", "DateCreated", "Text" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 3, 26, 22, 20, 3, 992, DateTimeKind.Local).AddTicks(4947), "With great power comes great responsibility" },
                    { 2, 2, new DateTime(2023, 3, 26, 22, 20, 3, 992, DateTimeKind.Local).AddTicks(4953), "I am Iron Man" },
                    { 3, 3, new DateTime(2023, 3, 26, 22, 20, 3, 992, DateTimeKind.Local).AddTicks(4951), "I'm Batman!" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Notes_ContactId",
                table: "Notes",
                column: "ContactId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notes");

            migrationBuilder.DropTable(
                name: "Contacts");
        }
    }
}
