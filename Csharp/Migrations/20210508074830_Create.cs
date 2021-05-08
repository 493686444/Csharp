using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Csharp.Migrations
{
    public partial class Create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Register",
                columns: table => new
                {
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Authcore = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Register", x => x.UserName);
                    table.CheckConstraint("CK_CreateTime", "CreateTime Between '2000/1/1' AND '2999/12/31'");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Register_CreateTime",
                table: "Register",
                column: "CreateTime",
                unique: true,
                filter: "[CreateTime] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Register");
        }
    }
}
