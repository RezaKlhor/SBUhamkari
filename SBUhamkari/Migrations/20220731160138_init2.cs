using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SBUhamkari.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EducationInstitutes",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationInstitutes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Faculties",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculties", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectExplain = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectState = table.Column<int>(type: "int", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "WorkFields",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkFields", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ProjectFiles",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    bytes = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Projectid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectFiles", x => x.id);
                    table.ForeignKey(
                        name: "FK_ProjectFiles_Projects_Projectid",
                        column: x => x.Projectid,
                        principalTable: "Projects",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectNews",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Tittle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Projectid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectNews", x => x.id);
                    table.ForeignKey(
                        name: "FK_ProjectNews_Projects_Projectid",
                        column: x => x.Projectid,
                        principalTable: "Projects",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Avatar = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Facultyid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Roleid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Companyid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyIDnumber = table.Column<long>(type: "bigint", maxLength: 10, nullable: true),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Firstname = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Lastname = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    NationalIdNum = table.Column<long>(type: "bigint", maxLength: 10, nullable: true),
                    gender = table.Column<int>(type: "int", nullable: true),
                    CV = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PersonnelID = table.Column<long>(type: "bigint", maxLength: 8, nullable: true),
                    StudentID = table.Column<long>(type: "bigint", maxLength: 8, nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.id);
                    table.ForeignKey(
                        name: "FK_Users_Faculties_Facultyid",
                        column: x => x.Facultyid,
                        principalTable: "Faculties",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Users_Roles_Roleid",
                        column: x => x.Roleid,
                        principalTable: "Roles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_Users_Companyid",
                        column: x => x.Companyid,
                        principalTable: "Users",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "ProjectWorkFields",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WorkfieldID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectWorkFields", x => x.id);
                    table.ForeignKey(
                        name: "FK_ProjectWorkFields_Projects_WorkfieldID",
                        column: x => x.WorkfieldID,
                        principalTable: "Projects",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectWorkFields_WorkFields_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "WorkFields",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContactInfos",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Userid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EntityState = table.Column<int>(type: "int", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactInfos", x => x.id);
                    table.ForeignKey(
                        name: "FK_ContactInfos_Users_Userid",
                        column: x => x.Userid,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EducationRecords",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Degree = table.Column<int>(type: "int", nullable: true),
                    EducationState = table.Column<int>(type: "int", nullable: false),
                    EducationInstituteid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Personid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationRecords", x => x.id);
                    table.ForeignKey(
                        name: "FK_EducationRecords_EducationInstitutes_EducationInstituteid",
                        column: x => x.EducationInstituteid,
                        principalTable: "EducationInstitutes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EducationRecords_Users_Personid",
                        column: x => x.Personid,
                        principalTable: "Users",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Score = table.Column<int>(type: "int", nullable: false),
                    Userid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Projectid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.id);
                    table.ForeignKey(
                        name: "FK_Feedbacks_Projects_Projectid",
                        column: x => x.Projectid,
                        principalTable: "Projects",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Feedbacks_Users_Userid",
                        column: x => x.Userid,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Followings",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Followerid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FollowedID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Followings", x => x.id);
                    table.ForeignKey(
                        name: "FK_Followings_Users_Followerid",
                        column: x => x.Followerid,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Tittle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Userid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.id);
                    table.ForeignKey(
                        name: "FK_News_Users_Userid",
                        column: x => x.Userid,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NotifTittle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NotifText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SenderName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecieverName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Recieverid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Senderid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.id);
                    table.ForeignKey(
                        name: "FK_Notifications_Projects_Senderid",
                        column: x => x.Senderid,
                        principalTable: "Projects",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Notifications_Users_Recieverid",
                        column: x => x.Recieverid,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonWorkFields",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WorkfieldID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PersonID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonWorkFields", x => x.id);
                    table.ForeignKey(
                        name: "FK_PersonWorkFields_Users_WorkfieldID",
                        column: x => x.WorkfieldID,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonWorkFields_WorkFields_PersonID",
                        column: x => x.PersonID,
                        principalTable: "WorkFields",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectManagers",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Projectid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Userid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectManagers", x => x.id);
                    table.ForeignKey(
                        name: "FK_ProjectManagers_Projects_Projectid",
                        column: x => x.Projectid,
                        principalTable: "Projects",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectManagers_Users_Userid",
                        column: x => x.Userid,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectParticapations",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Userid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Projectid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectParticapations", x => x.id);
                    table.ForeignKey(
                        name: "FK_ProjectParticapations_Projects_Projectid",
                        column: x => x.Projectid,
                        principalTable: "Projects",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectParticapations_Users_Userid",
                        column: x => x.Userid,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SavedProject",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Userid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Projectid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SavedProject", x => x.id);
                    table.ForeignKey(
                        name: "FK_SavedProject_Projects_Projectid",
                        column: x => x.Projectid,
                        principalTable: "Projects",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SavedProject_Users_Userid",
                        column: x => x.Userid,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SkillTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SkillLevel = table.Column<int>(type: "int", nullable: false),
                    Personid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.id);
                    table.ForeignKey(
                        name: "FK_Skills_Users_Personid",
                        column: x => x.Personid,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TArequests",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Tittle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Professorid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TArequests", x => x.id);
                    table.ForeignKey(
                        name: "FK_TArequests_Users_Professorid",
                        column: x => x.Professorid,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CoAnnouncements",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Tittle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<int>(type: "int", nullable: false),
                    Creatorid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Projectid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoAnnouncements", x => x.id);
                    table.ForeignKey(
                        name: "FK_CoAnnouncements_ProjectManagers_Creatorid",
                        column: x => x.Creatorid,
                        principalTable: "ProjectManagers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CoAnnouncements_Projects_Projectid",
                        column: x => x.Projectid,
                        principalTable: "Projects",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "ParticipationInvitations",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InvitationState = table.Column<int>(type: "int", nullable: false),
                    ProjectManagerid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InvitedUserid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParticipationInvitations", x => x.id);
                    table.ForeignKey(
                        name: "FK_ParticipationInvitations_ProjectManagers_ProjectManagerid",
                        column: x => x.ProjectManagerid,
                        principalTable: "ProjectManagers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ParticipationInvitations_Users_InvitedUserid",
                        column: x => x.InvitedUserid,
                        principalTable: "Users",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "TAapplications",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Resume = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Studentid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Tarequestid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TAapplications", x => x.id);
                    table.ForeignKey(
                        name: "FK_TAapplications_TArequests_Tarequestid",
                        column: x => x.Tarequestid,
                        principalTable: "TArequests",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TAapplications_Users_Studentid",
                        column: x => x.Studentid,
                        principalTable: "Users",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "CoApplications",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CV = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Applicantid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CoAnnouncementid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoApplications", x => x.id);
                    table.ForeignKey(
                        name: "FK_CoApplications_CoAnnouncements_CoAnnouncementid",
                        column: x => x.CoAnnouncementid,
                        principalTable: "CoAnnouncements",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CoApplications_Users_Applicantid",
                        column: x => x.Applicantid,
                        principalTable: "Users",
                        principalColumn: "id");
                });

            migrationBuilder.InsertData(
                table: "EducationInstitutes",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("6076e225-b8e2-4da2-80ed-4147c32cd605"), new DateTime(2022, 7, 31, 20, 31, 38, 387, DateTimeKind.Local).AddTicks(7480), null, "دانشگاه علم و صنعت" },
                    { new Guid("6f4b0c64-bc5d-4d8a-a9cd-1e29bace261e"), new DateTime(2022, 7, 31, 20, 31, 38, 387, DateTimeKind.Local).AddTicks(7450), null, "دانشگاه تهران" },
                    { new Guid("acf727a7-a55a-4af5-8167-0eb61bc9d916"), new DateTime(2022, 7, 31, 20, 31, 38, 387, DateTimeKind.Local).AddTicks(7475), null, "دانشگاه صنعتی امیرکبیر" },
                    { new Guid("c1f0c206-d1d3-4bd0-9c9a-5b4e61649fdf"), new DateTime(2022, 7, 31, 20, 31, 38, 387, DateTimeKind.Local).AddTicks(7398), null, "دانشگاه شهید بهشتی" },
                    { new Guid("f8004ff8-c898-4fcd-9f32-1d6740d2eafe"), new DateTime(2022, 7, 31, 20, 31, 38, 387, DateTimeKind.Local).AddTicks(7483), null, "دانشگاه صنعتی صنعتی شریف" }
                });

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("1eee1ee5-e2d6-44bd-ae5c-72606c6c7ddb"), new DateTime(2022, 7, 31, 20, 31, 38, 387, DateTimeKind.Local).AddTicks(7610), null, "دانشکده رواشناسی و علوم تربیتی" },
                    { new Guid("380a5ee6-8701-4203-ad7b-e9651d88e63c"), new DateTime(2022, 7, 31, 20, 31, 38, 387, DateTimeKind.Local).AddTicks(7614), null, "دانشکده معماری" },
                    { new Guid("7e1fe968-e3c7-4e51-8360-7bfbc72cc555"), new DateTime(2022, 7, 31, 20, 31, 38, 387, DateTimeKind.Local).AddTicks(7605), null, "دانشکده حقوق" },
                    { new Guid("d1208c45-9f94-468f-a881-0c7bc8b52701"), new DateTime(2022, 7, 31, 20, 31, 38, 387, DateTimeKind.Local).AddTicks(7618), null, "دانشکده علوم پایه" },
                    { new Guid("f27ddd1d-03b1-44d4-bb9e-3f9375b25206"), new DateTime(2022, 7, 31, 20, 31, 38, 387, DateTimeKind.Local).AddTicks(7594), null, "دانشکده برق و کامپیوتر" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("79e8d250-cd9d-45f2-b0b9-efedb4942e81"), new DateTime(2022, 7, 31, 20, 31, 38, 387, DateTimeKind.Local).AddTicks(7680), null, "Student" },
                    { new Guid("985518f0-3d57-417b-98ec-bf5b9e22d8f8"), new DateTime(2022, 7, 31, 20, 31, 38, 387, DateTimeKind.Local).AddTicks(7688), null, "Company" },
                    { new Guid("fdcf3bfc-7468-4a54-b9bf-6cbd3b649396"), new DateTime(2022, 7, 31, 20, 31, 38, 387, DateTimeKind.Local).AddTicks(7671), null, "Admin" },
                    { new Guid("ffda95ea-8f3d-4fc2-904b-22be34e6bd94"), new DateTime(2022, 7, 31, 20, 31, 38, 387, DateTimeKind.Local).AddTicks(7684), null, "Professor" }
                });

            migrationBuilder.InsertData(
                table: "WorkFields",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("1bac87f0-89d8-49d3-8a1f-edd7100a19f3"), new DateTime(2022, 7, 31, 20, 31, 38, 387, DateTimeKind.Local).AddTicks(7759), null, "هوش مصنوعی" },
                    { new Guid("22b09c11-4191-42cf-bea0-1dffb5c1f754"), new DateTime(2022, 7, 31, 20, 31, 38, 387, DateTimeKind.Local).AddTicks(7753), null, "شبکه" },
                    { new Guid("3a042889-093e-490e-b471-16dab03a0040"), new DateTime(2022, 7, 31, 20, 31, 38, 387, DateTimeKind.Local).AddTicks(7763), null, "شبکه‌های پیچیده" },
                    { new Guid("3bbc344d-5003-423b-91f1-fbcd6d22ff61"), new DateTime(2022, 7, 31, 20, 31, 38, 387, DateTimeKind.Local).AddTicks(7738), null, "نرم افزار" },
                    { new Guid("850b5e1e-096d-49bf-aed3-a8e86c32470a"), new DateTime(2022, 7, 31, 20, 31, 38, 387, DateTimeKind.Local).AddTicks(7745), null, "علوم داده" },
                    { new Guid("a9f948c9-f793-428d-982c-ccf479df720f"), new DateTime(2022, 7, 31, 20, 31, 38, 387, DateTimeKind.Local).AddTicks(7742), null, "سخت افزار" },
                    { new Guid("c9e5bab2-778a-47a3-865e-dbfd9d250f95"), new DateTime(2022, 7, 31, 20, 31, 38, 387, DateTimeKind.Local).AddTicks(7728), null, "هوش مصنوعی" },
                    { new Guid("dd2a1d73-e4fa-4639-b87f-0674cce6ab00"), new DateTime(2022, 7, 31, 20, 31, 38, 387, DateTimeKind.Local).AddTicks(7767), null, "فناوری اطلاعات" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CoAnnouncements_Creatorid",
                table: "CoAnnouncements",
                column: "Creatorid");

            migrationBuilder.CreateIndex(
                name: "IX_CoAnnouncements_Projectid",
                table: "CoAnnouncements",
                column: "Projectid");

            migrationBuilder.CreateIndex(
                name: "IX_CoApplications_Applicantid",
                table: "CoApplications",
                column: "Applicantid");

            migrationBuilder.CreateIndex(
                name: "IX_CoApplications_CoAnnouncementid",
                table: "CoApplications",
                column: "CoAnnouncementid");

            migrationBuilder.CreateIndex(
                name: "IX_ContactInfos_Userid",
                table: "ContactInfos",
                column: "Userid");

            migrationBuilder.CreateIndex(
                name: "IX_EducationRecords_EducationInstituteid",
                table: "EducationRecords",
                column: "EducationInstituteid");

            migrationBuilder.CreateIndex(
                name: "IX_EducationRecords_Personid",
                table: "EducationRecords",
                column: "Personid");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_Projectid",
                table: "Feedbacks",
                column: "Projectid");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_Userid",
                table: "Feedbacks",
                column: "Userid");

            migrationBuilder.CreateIndex(
                name: "IX_Followings_Followerid",
                table: "Followings",
                column: "Followerid");

            migrationBuilder.CreateIndex(
                name: "IX_News_Userid",
                table: "News",
                column: "Userid");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_Recieverid",
                table: "Notifications",
                column: "Recieverid");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_Senderid",
                table: "Notifications",
                column: "Senderid");

            migrationBuilder.CreateIndex(
                name: "IX_ParticipationInvitations_InvitedUserid",
                table: "ParticipationInvitations",
                column: "InvitedUserid");

            migrationBuilder.CreateIndex(
                name: "IX_ParticipationInvitations_ProjectManagerid",
                table: "ParticipationInvitations",
                column: "ProjectManagerid");

            migrationBuilder.CreateIndex(
                name: "IX_PersonWorkFields_PersonID",
                table: "PersonWorkFields",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_PersonWorkFields_WorkfieldID",
                table: "PersonWorkFields",
                column: "WorkfieldID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectFiles_Projectid",
                table: "ProjectFiles",
                column: "Projectid");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectManagers_Projectid",
                table: "ProjectManagers",
                column: "Projectid");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectManagers_Userid",
                table: "ProjectManagers",
                column: "Userid");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectNews_Projectid",
                table: "ProjectNews",
                column: "Projectid");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectParticapations_Projectid",
                table: "ProjectParticapations",
                column: "Projectid");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectParticapations_Userid",
                table: "ProjectParticapations",
                column: "Userid");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectWorkFields_ProjectID",
                table: "ProjectWorkFields",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectWorkFields_WorkfieldID",
                table: "ProjectWorkFields",
                column: "WorkfieldID");

            migrationBuilder.CreateIndex(
                name: "IX_SavedProject_Projectid",
                table: "SavedProject",
                column: "Projectid");

            migrationBuilder.CreateIndex(
                name: "IX_SavedProject_Userid",
                table: "SavedProject",
                column: "Userid");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_Personid",
                table: "Skills",
                column: "Personid");

            migrationBuilder.CreateIndex(
                name: "IX_TAapplications_Studentid",
                table: "TAapplications",
                column: "Studentid");

            migrationBuilder.CreateIndex(
                name: "IX_TAapplications_Tarequestid",
                table: "TAapplications",
                column: "Tarequestid");

            migrationBuilder.CreateIndex(
                name: "IX_TArequests_Professorid",
                table: "TArequests",
                column: "Professorid");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Companyid",
                table: "Users",
                column: "Companyid");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CompanyIDnumber",
                table: "Users",
                column: "CompanyIDnumber",
                unique: true,
                filter: "[CompanyIDnumber] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Facultyid",
                table: "Users",
                column: "Facultyid");

            migrationBuilder.CreateIndex(
                name: "IX_Users_NationalIdNum",
                table: "Users",
                column: "NationalIdNum",
                unique: true,
                filter: "[NationalIdNum] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Roleid",
                table: "Users",
                column: "Roleid");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Username",
                table: "Users",
                column: "Username",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CoApplications");

            migrationBuilder.DropTable(
                name: "ContactInfos");

            migrationBuilder.DropTable(
                name: "EducationRecords");

            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.DropTable(
                name: "Followings");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "ParticipationInvitations");

            migrationBuilder.DropTable(
                name: "PersonWorkFields");

            migrationBuilder.DropTable(
                name: "ProjectFiles");

            migrationBuilder.DropTable(
                name: "ProjectNews");

            migrationBuilder.DropTable(
                name: "ProjectParticapations");

            migrationBuilder.DropTable(
                name: "ProjectWorkFields");

            migrationBuilder.DropTable(
                name: "SavedProject");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "TAapplications");

            migrationBuilder.DropTable(
                name: "CoAnnouncements");

            migrationBuilder.DropTable(
                name: "EducationInstitutes");

            migrationBuilder.DropTable(
                name: "WorkFields");

            migrationBuilder.DropTable(
                name: "TArequests");

            migrationBuilder.DropTable(
                name: "ProjectManagers");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Faculties");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
