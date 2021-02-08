using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RedditSQLServerDB.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Awards",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Icon70 = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    URL = table.Column<string>(nullable: true),
                    Icon40 = table.Column<string>(nullable: true),
                    AwardId = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Awards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    SubredditId = table.Column<string>(nullable: true),
                    Subreddit = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    Body = table.Column<string>(nullable: true),
                    BodyHTML = table.Column<string>(nullable: true),
                    Collapsed = table.Column<bool>(nullable: false),
                    CollapsedReason = table.Column<string>(nullable: true),
                    IsSubmitter = table.Column<bool>(nullable: false),
                    ScoreHidden = table.Column<bool>(nullable: false),
                    Depth = table.Column<int>(nullable: false),
                    AuthorFullname = table.Column<string>(nullable: true),
                    Permalink = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    Edited = table.Column<DateTime>(nullable: false),
                    Score = table.Column<int>(nullable: false),
                    Ups = table.Column<int>(nullable: false),
                    Downs = table.Column<int>(nullable: false),
                    Removed = table.Column<bool>(nullable: false),
                    Spam = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Likes = table.Column<bool>(nullable: true),
                    CommentId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Comments_CommentId",
                        column: x => x.CommentId,
                        principalTable: "Comments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    SubredditId = table.Column<string>(nullable: true),
                    Subreddit = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Downs = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    UpvoteRatio = table.Column<double>(nullable: false),
                    Ups = table.Column<int>(nullable: false),
                    Domain = table.Column<string>(nullable: true),
                    AuthorFullname = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    NumComments = table.Column<int>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    Edited = table.Column<DateTime>(nullable: false),
                    Score = table.Column<int>(nullable: false),
                    Likes = table.Column<bool>(nullable: true),
                    ViewCount = table.Column<int>(nullable: true),
                    Archived = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mores",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Count = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ParentId = table.Column<string>(nullable: true),
                    Depth = table.Column<int>(nullable: false),
                    CommentId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mores_Comments_CommentId",
                        column: x => x.CommentId,
                        principalTable: "Comments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_CommentId",
                table: "Comments",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_Mores_CommentId",
                table: "Mores",
                column: "CommentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Awards");

            migrationBuilder.DropTable(
                name: "Mores");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Comments");
        }
    }
}
