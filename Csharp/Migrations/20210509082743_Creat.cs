using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Csharp.Migrations
{
    public partial class Creat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Authcore = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.id);
                    table.CheckConstraint("CK_CreateTime", "CreateTime Between '2000/1/1' AND '2999/12/31'");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_CreateTime",
                table: "Users",
                column: "CreateTime",
                unique: true,
                filter: "[CreateTime] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
