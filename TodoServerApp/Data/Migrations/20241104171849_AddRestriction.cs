using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoServerApp.Migrations
{
    /// <inheritdoc />
    public partial class AddRestriction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 22, 18, 48, 871, DateTimeKind.Local).AddTicks(3466));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 22, 18, 48, 871, DateTimeKind.Local).AddTicks(3475));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 22, 18, 48, 871, DateTimeKind.Local).AddTicks(3476));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 8, 20, 24, 155, DateTimeKind.Local).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 8, 20, 24, 155, DateTimeKind.Local).AddTicks(8554));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 4, 8, 20, 24, 155, DateTimeKind.Local).AddTicks(8555));
        }
    }
}
