using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlogUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserName = table.Column<string>(type: "varchar(32)", nullable: true),
                    PassWord = table.Column<string>(type: "varchar(32)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BlogInfos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    BlogName = table.Column<string>(type: "varchar(128)", nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogInfos_BlogUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "BlogUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BlogClasses",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ClassName = table.Column<string>(type: "varchar(32)", nullable: true),
                    Level = table.Column<int>(nullable: false),
                    OrderID = table.Column<string>(type: "varchar(12)", nullable: true),
                    BlogId = table.Column<Guid>(nullable: false),
                    ParentId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogClasses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogClasses_BlogInfos_BlogId",
                        column: x => x.BlogId,
                        principalTable: "BlogInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BlogClasses_BlogClasses_ParentId",
                        column: x => x.ParentId,
                        principalTable: "BlogClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BlogArticles",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    EditTime = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(type: "varchar(128)", nullable: true),
                    Content = table.Column<string>(nullable: true),
                    ReadCount = table.Column<int>(nullable: false),
                    PraiseCount = table.Column<int>(nullable: false),
                    BlogId = table.Column<Guid>(nullable: false),
                    ClassId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogArticles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogArticles_BlogInfos_BlogId",
                        column: x => x.BlogId,
                        principalTable: "BlogInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BlogArticles_BlogClasses_ClassId",
                        column: x => x.ClassId,
                        principalTable: "BlogClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "BlogUsers",
                columns: new[] { "Id", "PassWord", "UserName" },
                values: new object[] { new Guid("00000001-0000-0000-0000-000000000000"), "df6234833d7d4d76a96654a1c89ac08f", "Admin" });

            migrationBuilder.InsertData(
                table: "BlogInfos",
                columns: new[] { "Id", "BlogName", "CreateTime", "UserId" },
                values: new object[] { new Guid("00000001-0001-0000-0000-000000000000"), "MyBlog", new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000001-0000-0000-0000-000000000000") });

            migrationBuilder.CreateIndex(
                name: "IX_BlogArticles_BlogId",
                table: "BlogArticles",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogArticles_ClassId",
                table: "BlogArticles",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogClasses_BlogId",
                table: "BlogClasses",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogClasses_ParentId",
                table: "BlogClasses",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogInfos_UserId",
                table: "BlogInfos",
                column: "UserId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogArticles");

            migrationBuilder.DropTable(
                name: "BlogClasses");

            migrationBuilder.DropTable(
                name: "BlogInfos");

            migrationBuilder.DropTable(
                name: "BlogUsers");
        }
    }
}
