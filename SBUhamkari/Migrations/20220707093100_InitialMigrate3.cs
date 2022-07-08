using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SBUhamkari.Migrations
{
    public partial class InitialMigrate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CoApplication_CoAnnouncements_CoAnnouncementguid",
                table: "CoApplication");

            migrationBuilder.DropForeignKey(
                name: "FK_CoApplication_Users_Applicantguid",
                table: "CoApplication");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CoApplication",
                table: "CoApplication");

            migrationBuilder.RenameTable(
                name: "CoApplication",
                newName: "CoApplications");

            migrationBuilder.RenameIndex(
                name: "IX_CoApplication_CoAnnouncementguid",
                table: "CoApplications",
                newName: "IX_CoApplications_CoAnnouncementguid");

            migrationBuilder.RenameIndex(
                name: "IX_CoApplication_Applicantguid",
                table: "CoApplications",
                newName: "IX_CoApplications_Applicantguid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CoApplications",
                table: "CoApplications",
                column: "guid");

            migrationBuilder.AddForeignKey(
                name: "FK_CoApplications_CoAnnouncements_CoAnnouncementguid",
                table: "CoApplications",
                column: "CoAnnouncementguid",
                principalTable: "CoAnnouncements",
                principalColumn: "guid");

            migrationBuilder.AddForeignKey(
                name: "FK_CoApplications_Users_Applicantguid",
                table: "CoApplications",
                column: "Applicantguid",
                principalTable: "Users",
                principalColumn: "guid",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CoApplications_CoAnnouncements_CoAnnouncementguid",
                table: "CoApplications");

            migrationBuilder.DropForeignKey(
                name: "FK_CoApplications_Users_Applicantguid",
                table: "CoApplications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CoApplications",
                table: "CoApplications");

            migrationBuilder.RenameTable(
                name: "CoApplications",
                newName: "CoApplication");

            migrationBuilder.RenameIndex(
                name: "IX_CoApplications_CoAnnouncementguid",
                table: "CoApplication",
                newName: "IX_CoApplication_CoAnnouncementguid");

            migrationBuilder.RenameIndex(
                name: "IX_CoApplications_Applicantguid",
                table: "CoApplication",
                newName: "IX_CoApplication_Applicantguid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CoApplication",
                table: "CoApplication",
                column: "guid");

            migrationBuilder.AddForeignKey(
                name: "FK_CoApplication_CoAnnouncements_CoAnnouncementguid",
                table: "CoApplication",
                column: "CoAnnouncementguid",
                principalTable: "CoAnnouncements",
                principalColumn: "guid");

            migrationBuilder.AddForeignKey(
                name: "FK_CoApplication_Users_Applicantguid",
                table: "CoApplication",
                column: "Applicantguid",
                principalTable: "Users",
                principalColumn: "guid",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
