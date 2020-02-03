using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlogInfo",
                columns: table => new
                {
                    BlogId = table.Column<string>(type: "varchar(32)", nullable: false),
                    BlogName = table.Column<string>(type: "varchar(128)", nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<string>(type: "varchar(32)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogInfo", x => x.BlogId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogInfo");
        }
    }
}
