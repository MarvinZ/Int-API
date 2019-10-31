using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace quiz_backend.Migrations
{
    public partial class FirstRealMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Quiz");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Answer1 = table.Column<string>(nullable: true),
                    Answer2 = table.Column<string>(nullable: true),
                    Answer3 = table.Column<string>(nullable: true),
                    Answer4 = table.Column<string>(nullable: true),
                    CorrectAnswer = table.Column<string>(nullable: true),
                    QuizId = table.Column<int>(nullable: false),
                    Text = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Quiz",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OwnerId = table.Column<string>(nullable: true),
                    TestFieldXXXXXX = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    okTestColumn = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quiz", x => x.ID);
                });
        }
    }
}
