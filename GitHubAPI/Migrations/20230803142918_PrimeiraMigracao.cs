using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GitHubAPI.Migrations
{
    /// <inheritdoc />
    public partial class PrimeiraMigracao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Owner",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SiteAdmin = table.Column<bool>(type: "INTEGER", nullable: false),
                    Suspended = table.Column<bool>(type: "INTEGER", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AvatarUrl = table.Column<string>(type: "TEXT", nullable: false),
                    Bio = table.Column<string>(type: "TEXT", nullable: false),
                    Blog = table.Column<string>(type: "TEXT", nullable: false),
                    Collaborators = table.Column<string>(type: "TEXT", nullable: false),
                    Company = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DiskUsage = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Followers = table.Column<int>(type: "INTEGER", nullable: false),
                    Following = table.Column<int>(type: "INTEGER", nullable: false),
                    Hireable = table.Column<string>(type: "TEXT", nullable: false),
                    HtmlUrl = table.Column<string>(type: "TEXT", nullable: false),
                    NodeId = table.Column<string>(type: "TEXT", nullable: false),
                    Location = table.Column<string>(type: "TEXT", nullable: false),
                    Login = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Type = table.Column<int>(type: "INTEGER", nullable: false),
                    OwnedPrivateRepos = table.Column<int>(type: "INTEGER", nullable: false),
                    Plan = table.Column<string>(type: "TEXT", nullable: false),
                    PrivateGists = table.Column<string>(type: "TEXT", nullable: false),
                    PublicGists = table.Column<int>(type: "INTEGER", nullable: false),
                    PublicRepos = table.Column<int>(type: "INTEGER", nullable: false),
                    TotalPrivateRepos = table.Column<int>(type: "INTEGER", nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owner", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GitRepositories",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Url = table.Column<string>(type: "TEXT", nullable: false),
                    HtmlUrl = table.Column<string>(type: "TEXT", nullable: false),
                    CloneUrl = table.Column<string>(type: "TEXT", nullable: false),
                    GitUrl = table.Column<string>(type: "TEXT", nullable: false),
                    SshUrl = table.Column<string>(type: "TEXT", nullable: false),
                    SvnUrl = table.Column<string>(type: "TEXT", nullable: false),
                    MirrorUrl = table.Column<string>(type: "TEXT", nullable: false),
                    NodeId = table.Column<string>(type: "TEXT", nullable: false),
                    OwnerId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    FullName = table.Column<string>(type: "TEXT", nullable: false),
                    IsTemplate = table.Column<bool>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Homepage = table.Column<string>(type: "TEXT", nullable: false),
                    Language = table.Column<string>(type: "TEXT", nullable: false),
                    Private = table.Column<bool>(type: "INTEGER", nullable: false),
                    Fork = table.Column<bool>(type: "INTEGER", nullable: false),
                    ForksCount = table.Column<int>(type: "INTEGER", nullable: false),
                    StargazersCount = table.Column<int>(type: "INTEGER", nullable: false),
                    WatchersCount = table.Column<int>(type: "INTEGER", nullable: false),
                    DefaultBranch = table.Column<string>(type: "TEXT", nullable: false),
                    OpenIssuesCount = table.Column<int>(type: "INTEGER", nullable: false),
                    PushedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    HasIssues = table.Column<bool>(type: "INTEGER", nullable: false),
                    HasWiki = table.Column<bool>(type: "INTEGER", nullable: false),
                    HasDownloads = table.Column<bool>(type: "INTEGER", nullable: false),
                    HasPages = table.Column<bool>(type: "INTEGER", nullable: false),
                    SubscribersCount = table.Column<int>(type: "INTEGER", nullable: false),
                    Size = table.Column<long>(type: "INTEGER", nullable: false),
                    Archived = table.Column<bool>(type: "INTEGER", nullable: false),
                    Visibility = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GitRepositories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GitRepositories_Owner_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Owner",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GitRepositories_OwnerId",
                table: "GitRepositories",
                column: "OwnerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GitRepositories");

            migrationBuilder.DropTable(
                name: "Owner");
        }
    }
}
