using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SBUhamkari.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EducationInstitute",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationInstitute", x => x.id);
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
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Facultyid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Roleid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyIDnumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Firstname = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Lastname = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    NationalIdNum = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    gender = table.Column<int>(type: "int", nullable: true),
                    CV = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PersonnelID = table.Column<long>(type: "bigint", maxLength: 8, nullable: true),
                    StudentID = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
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
                });

            migrationBuilder.CreateTable(
                name: "ProjectWorkFields",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    projectRelatedforeignKey = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectWorkFields", x => x.id);
                    table.ForeignKey(
                        name: "FK_ProjectWorkFields_Projects_projectRelatedforeignKey",
                        column: x => x.projectRelatedforeignKey,
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
                    Degree = table.Column<int>(type: "int", nullable: false),
                    EducationState = table.Column<int>(type: "int", nullable: false),
                    EducationInstitueName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Personid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EducationInstituteid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationRecords", x => x.id);
                    table.ForeignKey(
                        name: "FK_EducationRecords_EducationInstitute_EducationInstituteid",
                        column: x => x.EducationInstituteid,
                        principalTable: "EducationInstitute",
                        principalColumn: "id");
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
                    PersonRelatedforeignKey = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PersonID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonWorkFields", x => x.id);
                    table.ForeignKey(
                        name: "FK_PersonWorkFields_Users_PersonRelatedforeignKey",
                        column: x => x.PersonRelatedforeignKey,
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
                name: "SavedProjects",
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
                    table.PrimaryKey("PK_SavedProjects", x => x.id);
                    table.ForeignKey(
                        name: "FK_SavedProjects_Projects_Projectid",
                        column: x => x.Projectid,
                        principalTable: "Projects",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SavedProjects_Users_Userid",
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
                table: "EducationInstitute",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("291e50bc-7ef1-4db1-999f-c8eb8a728963"), new DateTime(2022, 8, 22, 23, 22, 17, 253, DateTimeKind.Local).AddTicks(8761), null, "دانشگاه صنعتی امیرکبیر" },
                    { new Guid("889bdc0f-e8f1-4400-8bdf-6402030088fb"), new DateTime(2022, 8, 22, 23, 22, 17, 253, DateTimeKind.Local).AddTicks(8755), null, "دانشگاه تهران" },
                    { new Guid("938d7de5-634b-4d11-9907-9b39380b8cb3"), new DateTime(2022, 8, 22, 23, 22, 17, 253, DateTimeKind.Local).AddTicks(8682), null, "دانشگاه شهید بهشتی" },
                    { new Guid("dc95d067-8f71-49dd-bc34-864e9a1f21d9"), new DateTime(2022, 8, 22, 23, 22, 17, 253, DateTimeKind.Local).AddTicks(8769), null, "دانشگاه صنعتی صنعتی شریف" },
                    { new Guid("f50c7f59-d866-4ed4-b0af-d969fe19408e"), new DateTime(2022, 8, 22, 23, 22, 17, 253, DateTimeKind.Local).AddTicks(8765), null, "دانشگاه علم و صنعت" }
                });

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("5455ef33-9fd0-4ef5-97df-85b5fd3796db"), new DateTime(2022, 8, 22, 23, 22, 17, 253, DateTimeKind.Local).AddTicks(8915), null, "دانشکده رواشناسی و علوم تربیتی" },
                    { new Guid("784692a4-b40f-4bbb-a69e-4e3a8ea4314d"), new DateTime(2022, 8, 22, 23, 22, 17, 253, DateTimeKind.Local).AddTicks(8910), null, "دانشکده حقوق" },
                    { new Guid("d0f35fe2-bf46-4032-a19b-85052cd76a93"), new DateTime(2022, 8, 22, 23, 22, 17, 253, DateTimeKind.Local).AddTicks(8929), null, "دانشکده علوم پایه" },
                    { new Guid("f48a5c70-7773-49f2-b51b-3e4399bf3f32"), new DateTime(2022, 8, 22, 23, 22, 17, 253, DateTimeKind.Local).AddTicks(8924), null, "دانشکده معماری" },
                    { new Guid("f6c975bd-e308-408c-9c58-71999343be52"), new DateTime(2022, 8, 22, 23, 22, 17, 253, DateTimeKind.Local).AddTicks(8890), null, "دانشکده برق و کامپیوتر" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("1143f51e-e82f-41e8-9998-19157f37ca38"), new DateTime(2022, 8, 22, 23, 22, 17, 253, DateTimeKind.Local).AddTicks(9023), null, "Company" },
                    { new Guid("6802192b-d21e-4944-9809-1f3cd69d8cfa"), new DateTime(2022, 8, 22, 23, 22, 17, 253, DateTimeKind.Local).AddTicks(9015), null, "Student" },
                    { new Guid("ccc55750-2906-4f60-8f41-19de73cd66bc"), new DateTime(2022, 8, 22, 23, 22, 17, 253, DateTimeKind.Local).AddTicks(9019), null, "Professor" },
                    { new Guid("e2366539-dcde-4200-a495-d402b3cf67c3"), new DateTime(2022, 8, 22, 23, 22, 17, 253, DateTimeKind.Local).AddTicks(9004), null, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "WorkFields",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("2ddce829-2f42-4d59-8c40-278e1cd8d44a"), new DateTime(2022, 8, 22, 23, 22, 17, 253, DateTimeKind.Local).AddTicks(9073), null, "هوش مصنوعی" },
                    { new Guid("38a0b10e-584a-48c1-816c-e8032bf283fb"), new DateTime(2022, 8, 22, 23, 22, 17, 253, DateTimeKind.Local).AddTicks(9145), null, "فناوری اطلاعات" },
                    { new Guid("436daa26-52fd-4400-9a13-05e29a4132eb"), new DateTime(2022, 8, 22, 23, 22, 17, 253, DateTimeKind.Local).AddTicks(9126), null, "علوم داده" },
                    { new Guid("47d7e208-db3d-4c0a-a956-269a21368fe9"), new DateTime(2022, 8, 22, 23, 22, 17, 253, DateTimeKind.Local).AddTicks(9122), null, "سخت افزار" },
                    { new Guid("8a7c9a08-8d1d-42a8-bc4f-32bc386fe7dc"), new DateTime(2022, 8, 22, 23, 22, 17, 253, DateTimeKind.Local).AddTicks(9137), null, "هوش مصنوعی" },
                    { new Guid("a92ef48a-93cd-4bc9-ad56-24562457a35e"), new DateTime(2022, 8, 22, 23, 22, 17, 253, DateTimeKind.Local).AddTicks(9130), null, "شبکه" },
                    { new Guid("ca77894f-53b2-4804-b6e8-7f9b77eb4f6d"), new DateTime(2022, 8, 22, 23, 22, 17, 253, DateTimeKind.Local).AddTicks(9112), null, "نرم افزار" },
                    { new Guid("fc3146fa-836d-42ae-92f7-745bcbfb310d"), new DateTime(2022, 8, 22, 23, 22, 17, 253, DateTimeKind.Local).AddTicks(9141), null, "شبکه‌های پیچیده" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CoAnnouncements_Creatorid",
                table: "CoAnnouncements",
                column: "Creatorid");

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
                name: "IX_PersonWorkFields_PersonRelatedforeignKey",
                table: "PersonWorkFields",
                column: "PersonRelatedforeignKey");

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
                name: "IX_ProjectWorkFields_projectRelatedforeignKey",
                table: "ProjectWorkFields",
                column: "projectRelatedforeignKey");

            migrationBuilder.CreateIndex(
                name: "IX_SavedProjects_Projectid",
                table: "SavedProjects",
                column: "Projectid");

            migrationBuilder.CreateIndex(
                name: "IX_SavedProjects_Userid",
                table: "SavedProjects",
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
                name: "IX_Users_StudentID",
                table: "Users",
                column: "StudentID",
                unique: true,
                filter: "[StudentID] IS NOT NULL");

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
                name: "SavedProjects");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "TAapplications");

            migrationBuilder.DropTable(
                name: "CoAnnouncements");

            migrationBuilder.DropTable(
                name: "EducationInstitute");

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
