using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Figma.Ef.Migrations
{
    public partial class Modifies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ResumePath",
                table: "Profiles");

            migrationBuilder.AddColumn<byte[]>(
                name: "Resume",
                table: "Profiles",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.DropColumn(
                name: "Cover",
                table: "ApplicationForms");

            migrationBuilder.AddColumn<byte[]>(
                name: "Cover",
                table: "ApplicationForms",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AlterColumn<byte[]>(
                name: "Cover",
                table: "ApplicationForms",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Resume",
                table: "Profiles");

            migrationBuilder.AddColumn<string>(
                name: "ResumePath",
                table: "Profiles",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.DropColumn(
                name: "Cover",
                table: "ApplicationForms");

            migrationBuilder.AddColumn<string>(
                name: "Cover",
                table: "ApplicationForms",
                type: "nvarchar(500)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");
        }
    }
}
