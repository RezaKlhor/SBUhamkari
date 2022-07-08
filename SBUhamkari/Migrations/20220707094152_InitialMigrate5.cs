using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SBUhamkari.Migrations
{
    public partial class InitialMigrate5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Tittle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Userguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.guid);
                    table.ForeignKey(
                        name: "FK_News_Users_Userguid",
                        column: x => x.Userguid,
                        principalTable: "Users",
                        principalColumn: "guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_News_Userguid",
                table: "News",
                column: "Userguid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "News");
        }
    }
}
