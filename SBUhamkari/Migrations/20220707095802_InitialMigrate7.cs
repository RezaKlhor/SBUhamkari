using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SBUhamkari.Migrations
{
    public partial class InitialMigrate7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Goozs",
                columns: table => new
                {
                    guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MyProperty = table.Column<int>(type: "int", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goozs", x => x.guid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Goozs");
        }
    }
}
