using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyBlog.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlogArticle",
                columns: table => new
                {
                    ArticleId = table.Column<string>(type: "varchar(32)", nullable: false),
                    BlogId = table.Column<string>(type: "varchar(32)", nullable: true),
                    ClassId = table.Column<string>(type: "varchar(32)", nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    EditTime = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    ContentType = table.Column<int>(nullable: false),
                    ReadCount = table.Column<int>(nullable: false),
                    PraiseCount = table.Column<int>(nullable: false),
                    CollectCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogArticle", x => x.ArticleId);
                });

            migrationBuilder.CreateTable(
                name: "BlogClass",
                columns: table => new
                {
                    ClassId = table.Column<string>(type: "varchar(32)", nullable: false),
                    BlogId = table.Column<string>(type: "varchar(32)", nullable: true),
                    ClassName = table.Column<string>(type: "varchar(128)", nullable: true),
                    ParentId = table.Column<string>(type: "varchar(32)", nullable: true),
                    Level = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogClass", x => x.ClassId);
                });

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
                name: "BlogArticle");

            migrationBuilder.DropTable(
                name: "BlogClass");

            migrationBuilder.DropTable(
                name: "BlogInfo");
        }
    }
}
