using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SBUhamkari.Migrations
{
    public partial class InitialMigrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EducationInstitutes",
                columns: table => new
                {
                    guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationInstitutes", x => x.guid);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectExplain = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectState = table.Column<int>(type: "int", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.guid);
                });

            migrationBuilder.CreateTable(
                name: "Faculties",
                columns: table => new
                {
                    guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EducationInstituteguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculties", x => x.guid);
                    table.ForeignKey(
                        name: "FK_Faculties_EducationInstitutes_EducationInstituteguid",
                        column: x => x.EducationInstituteguid,
                        principalTable: "EducationInstitutes",
                        principalColumn: "guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectFiles",
                columns: table => new
                {
                    guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    bytes = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Projectguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectFiles", x => x.guid);
                    table.ForeignKey(
                        name: "FK_ProjectFiles_Projects_Projectguid",
                        column: x => x.Projectguid,
                        principalTable: "Projects",
                        principalColumn: "guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Avatar = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Facultyguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Companyguid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Userguid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CompanyID = table.Column<int>(type: "int", maxLength: 10, nullable: true),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Firstname = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Lastname = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    NationalIdNum = table.Column<int>(type: "int", maxLength: 10, nullable: true),
                    gender = table.Column<int>(type: "int", nullable: true),
                    CV = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PersonnelID = table.Column<int>(type: "int", maxLength: 8, nullable: true),
                    StudentID = table.Column<int>(type: "int", maxLength: 8, nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.guid);
                    table.ForeignKey(
                        name: "FK_Users_Faculties_Facultyguid",
                        column: x => x.Facultyguid,
                        principalTable: "Faculties",
                        principalColumn: "guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_Users_Companyguid",
                        column: x => x.Companyguid,
                        principalTable: "Users",
                        principalColumn: "guid");
                    table.ForeignKey(
                        name: "FK_Users_Users_Userguid",
                        column: x => x.Userguid,
                        principalTable: "Users",
                        principalColumn: "guid");
                });

            migrationBuilder.CreateTable(
                name: "CoAnnouncements",
                columns: table => new
                {
                    guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Tittle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<int>(type: "int", nullable: false),
                    Creatorguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Projectguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoAnnouncements", x => x.guid);
                    table.ForeignKey(
                        name: "FK_CoAnnouncements_Projects_Projectguid",
                        column: x => x.Projectguid,
                        principalTable: "Projects",
                        principalColumn: "guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CoAnnouncements_Users_Creatorguid",
                        column: x => x.Creatorguid,
                        principalTable: "Users",
                        principalColumn: "guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContactInfos",
                columns: table => new
                {
                    guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Userguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactInfos", x => x.guid);
                    table.ForeignKey(
                        name: "FK_ContactInfos_Users_Userguid",
                        column: x => x.Userguid,
                        principalTable: "Users",
                        principalColumn: "guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EducationRecords",
                columns: table => new
                {
                    guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Degree = table.Column<int>(type: "int", nullable: true),
                    EducationState = table.Column<int>(type: "int", nullable: false),
                    EducationInstituteguid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Personguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationRecords", x => x.guid);
                    table.ForeignKey(
                        name: "FK_EducationRecords_EducationInstitutes_EducationInstituteguid",
                        column: x => x.EducationInstituteguid,
                        principalTable: "EducationInstitutes",
                        principalColumn: "guid");
                    table.ForeignKey(
                        name: "FK_EducationRecords_Users_Personguid",
                        column: x => x.Personguid,
                        principalTable: "Users",
                        principalColumn: "guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Score = table.Column<int>(type: "int", nullable: false),
                    Userguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Projectguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.guid);
                    table.ForeignKey(
                        name: "FK_Feedbacks_Projects_Projectguid",
                        column: x => x.Projectguid,
                        principalTable: "Projects",
                        principalColumn: "guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Feedbacks_Users_Userguid",
                        column: x => x.Userguid,
                        principalTable: "Users",
                        principalColumn: "guid",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NotifTittle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NotifText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Recieverguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Senderguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.guid);
                    table.ForeignKey(
                        name: "FK_Notifications_Projects_Senderguid",
                        column: x => x.Senderguid,
                        principalTable: "Projects",
                        principalColumn: "guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Notifications_Users_Recieverguid",
                        column: x => x.Recieverguid,
                        principalTable: "Users",
                        principalColumn: "guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectManagers",
                columns: table => new
                {
                    guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Projectguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Userguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectManagers", x => x.guid);
                    table.ForeignKey(
                        name: "FK_ProjectManagers_Projects_Projectguid",
                        column: x => x.Projectguid,
                        principalTable: "Projects",
                        principalColumn: "guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectManagers_Users_Userguid",
                        column: x => x.Userguid,
                        principalTable: "Users",
                        principalColumn: "guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectUser",
                columns: table => new
                {
                    ProjectParticipantsguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    projectsguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectUser", x => new { x.ProjectParticipantsguid, x.projectsguid });
                    table.ForeignKey(
                        name: "FK_ProjectUser_Projects_projectsguid",
                        column: x => x.projectsguid,
                        principalTable: "Projects",
                        principalColumn: "guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectUser_Users_ProjectParticipantsguid",
                        column: x => x.ProjectParticipantsguid,
                        principalTable: "Users",
                        principalColumn: "guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SavedProject",
                columns: table => new
                {
                    guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Userguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Projectguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SavedProject", x => x.guid);
                    table.ForeignKey(
                        name: "FK_SavedProject_Projects_Projectguid",
                        column: x => x.Projectguid,
                        principalTable: "Projects",
                        principalColumn: "guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SavedProject_Users_Userguid",
                        column: x => x.Userguid,
                        principalTable: "Users",
                        principalColumn: "guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SkillTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SkillLevel = table.Column<int>(type: "int", nullable: false),
                    Userguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.guid);
                    table.ForeignKey(
                        name: "FK_Skills_Users_Userguid",
                        column: x => x.Userguid,
                        principalTable: "Users",
                        principalColumn: "guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TArequests",
                columns: table => new
                {
                    guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Tittle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Professorguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TArequests", x => x.guid);
                    table.ForeignKey(
                        name: "FK_TArequests_Users_Professorguid",
                        column: x => x.Professorguid,
                        principalTable: "Users",
                        principalColumn: "guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkFields",
                columns: table => new
                {
                    guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Userguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Projectguid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkFields", x => x.guid);
                    table.ForeignKey(
                        name: "FK_WorkFields_Projects_Projectguid",
                        column: x => x.Projectguid,
                        principalTable: "Projects",
                        principalColumn: "guid");
                    table.ForeignKey(
                        name: "FK_WorkFields_Users_Userguid",
                        column: x => x.Userguid,
                        principalTable: "Users",
                        principalColumn: "guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CoApplication",
                columns: table => new
                {
                    guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CV = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Applicantguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CoAnnouncementguid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoApplication", x => x.guid);
                    table.ForeignKey(
                        name: "FK_CoApplication_CoAnnouncements_CoAnnouncementguid",
                        column: x => x.CoAnnouncementguid,
                        principalTable: "CoAnnouncements",
                        principalColumn: "guid");
                    table.ForeignKey(
                        name: "FK_CoApplication_Users_Applicantguid",
                        column: x => x.Applicantguid,
                        principalTable: "Users",
                        principalColumn: "guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TAapplications",
                columns: table => new
                {
                    guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Resume = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Studentguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Tarequestguid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TAapplications", x => x.guid);
                    table.ForeignKey(
                        name: "FK_TAapplications_TArequests_Tarequestguid",
                        column: x => x.Tarequestguid,
                        principalTable: "TArequests",
                        principalColumn: "guid");
                    table.ForeignKey(
                        name: "FK_TAapplications_Users_Studentguid",
                        column: x => x.Studentguid,
                        principalTable: "Users",
                        principalColumn: "guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CoAnnouncements_Creatorguid",
                table: "CoAnnouncements",
                column: "Creatorguid");

            migrationBuilder.CreateIndex(
                name: "IX_CoAnnouncements_Projectguid",
                table: "CoAnnouncements",
                column: "Projectguid");

            migrationBuilder.CreateIndex(
                name: "IX_CoApplication_Applicantguid",
                table: "CoApplication",
                column: "Applicantguid");

            migrationBuilder.CreateIndex(
                name: "IX_CoApplication_CoAnnouncementguid",
                table: "CoApplication",
                column: "CoAnnouncementguid");

            migrationBuilder.CreateIndex(
                name: "IX_ContactInfos_Userguid",
                table: "ContactInfos",
                column: "Userguid");

            migrationBuilder.CreateIndex(
                name: "IX_EducationRecords_EducationInstituteguid",
                table: "EducationRecords",
                column: "EducationInstituteguid");

            migrationBuilder.CreateIndex(
                name: "IX_EducationRecords_Personguid",
                table: "EducationRecords",
                column: "Personguid");

            migrationBuilder.CreateIndex(
                name: "IX_Faculties_EducationInstituteguid",
                table: "Faculties",
                column: "EducationInstituteguid");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_Projectguid",
                table: "Feedbacks",
                column: "Projectguid");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_Userguid",
                table: "Feedbacks",
                column: "Userguid");

            migrationBuilder.CreateIndex(
                name: "IX_News_Userguid",
                table: "News",
                column: "Userguid");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_Recieverguid",
                table: "Notifications",
                column: "Recieverguid");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_Senderguid",
                table: "Notifications",
                column: "Senderguid");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectFiles_Projectguid",
                table: "ProjectFiles",
                column: "Projectguid");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectManagers_Projectguid",
                table: "ProjectManagers",
                column: "Projectguid");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectManagers_Userguid",
                table: "ProjectManagers",
                column: "Userguid");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectUser_projectsguid",
                table: "ProjectUser",
                column: "projectsguid");

            migrationBuilder.CreateIndex(
                name: "IX_SavedProject_Projectguid",
                table: "SavedProject",
                column: "Projectguid");

            migrationBuilder.CreateIndex(
                name: "IX_SavedProject_Userguid",
                table: "SavedProject",
                column: "Userguid");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_Userguid",
                table: "Skills",
                column: "Userguid");

            migrationBuilder.CreateIndex(
                name: "IX_TAapplications_Studentguid",
                table: "TAapplications",
                column: "Studentguid");

            migrationBuilder.CreateIndex(
                name: "IX_TAapplications_Tarequestguid",
                table: "TAapplications",
                column: "Tarequestguid");

            migrationBuilder.CreateIndex(
                name: "IX_TArequests_Professorguid",
                table: "TArequests",
                column: "Professorguid");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Companyguid",
                table: "Users",
                column: "Companyguid");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Facultyguid",
                table: "Users",
                column: "Facultyguid");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Userguid",
                table: "Users",
                column: "Userguid");

            migrationBuilder.CreateIndex(
                name: "IX_WorkFields_Projectguid",
                table: "WorkFields",
                column: "Projectguid");

            migrationBuilder.CreateIndex(
                name: "IX_WorkFields_Userguid",
                table: "WorkFields",
                column: "Userguid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CoApplication");

            migrationBuilder.DropTable(
                name: "ContactInfos");

            migrationBuilder.DropTable(
                name: "EducationRecords");

            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "ProjectFiles");

            migrationBuilder.DropTable(
                name: "ProjectManagers");

            migrationBuilder.DropTable(
                name: "ProjectUser");

            migrationBuilder.DropTable(
                name: "SavedProject");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "TAapplications");

            migrationBuilder.DropTable(
                name: "WorkFields");

            migrationBuilder.DropTable(
                name: "CoAnnouncements");

            migrationBuilder.DropTable(
                name: "TArequests");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Faculties");

            migrationBuilder.DropTable(
                name: "EducationInstitutes");
        }
    }
}
