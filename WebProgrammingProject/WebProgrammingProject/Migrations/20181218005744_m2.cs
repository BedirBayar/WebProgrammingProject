using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace WebProgrammingProject.Migrations
{
    public partial class m2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Picture",
                table: "Computers",
                newName: "ImageUrl");

            migrationBuilder.AddColumn<string>(
                name: "ImageThumbnailUrl",
                table: "Computers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageThumbnailUrl",
                table: "Computers");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Computers",
                newName: "Picture");
        }
    }
}
