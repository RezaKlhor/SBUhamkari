using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SBUhamkari.Migrations
{
    public partial class init1 : Migration
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
                    WorkfieldID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                        name: "FK_ProjectWorkFields_Projects_WorkfieldID",
                        column: x => x.WorkfieldID,
                        principalTable: "Projects",
                        principalColumn: "id");
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
                table: "EducationInstitutes",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("158b444c-61db-4c49-9986-151695f1dc01"), new DateTime(2022, 8, 22, 0, 42, 53, 633, DateTimeKind.Local).AddTicks(3155), null, "دانشگاه تهران" },
                    { new Guid("389d1aba-1f44-4154-bc36-92c877418b80"), new DateTime(2022, 8, 22, 0, 42, 53, 633, DateTimeKind.Local).AddTicks(3091), null, "دانشگاه شهید بهشتی" },
                    { new Guid("3cebf69c-e28c-4ea5-a140-91e93ed27b8f"), new DateTime(2022, 8, 22, 0, 42, 53, 633, DateTimeKind.Local).AddTicks(3161), null, "دانشگاه صنعتی امیرکبیر" },
                    { new Guid("a4f9d2ee-5812-42e5-9fcc-1f40ac85c0bc"), new DateTime(2022, 8, 22, 0, 42, 53, 633, DateTimeKind.Local).AddTicks(3166), null, "دانشگاه علم و صنعت" },
                    { new Guid("cb8c6661-2d59-4c3b-bdbf-f9aec7c2d26e"), new DateTime(2022, 8, 22, 0, 42, 53, 633, DateTimeKind.Local).AddTicks(3194), null, "دانشگاه صنعتی صنعتی شریف" }
                });

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("2b08f140-bcdc-42b8-9fcb-7ba399f75e44"), new DateTime(2022, 8, 22, 0, 42, 53, 633, DateTimeKind.Local).AddTicks(3275), null, "دانشکده برق و کامپیوتر" },
                    { new Guid("5b9315a2-c6da-4563-8686-3bc7bded8c01"), new DateTime(2022, 8, 22, 0, 42, 53, 633, DateTimeKind.Local).AddTicks(3293), null, "دانشکده رواشناسی و علوم تربیتی" },
                    { new Guid("643fde80-5db4-49f2-97b3-f8ea68dc1439"), new DateTime(2022, 8, 22, 0, 42, 53, 633, DateTimeKind.Local).AddTicks(3302), null, "دانشکده علوم پایه" },
                    { new Guid("9cce9244-f42e-4751-b563-a4e37ea52161"), new DateTime(2022, 8, 22, 0, 42, 53, 633, DateTimeKind.Local).AddTicks(3288), null, "دانشکده حقوق" },
                    { new Guid("e7c3b96e-8519-41da-8378-078730c32fa9"), new DateTime(2022, 8, 22, 0, 42, 53, 633, DateTimeKind.Local).AddTicks(3297), null, "دانشکده معماری" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("35da13d9-0d4e-44bf-ab72-0577676bea91"), new DateTime(2022, 8, 22, 0, 42, 53, 633, DateTimeKind.Local).AddTicks(3396), null, "Company" },
                    { new Guid("694c3813-8507-45cb-b2a4-13caff16c759"), new DateTime(2022, 8, 22, 0, 42, 53, 633, DateTimeKind.Local).AddTicks(3381), null, "Student" },
                    { new Guid("93e857a3-e721-4d2d-a078-421e70f07481"), new DateTime(2022, 8, 22, 0, 42, 53, 633, DateTimeKind.Local).AddTicks(3368), null, "Admin" },
                    { new Guid("ca84ef32-4a94-493f-b67c-af9f87b8f169"), new DateTime(2022, 8, 22, 0, 42, 53, 633, DateTimeKind.Local).AddTicks(3391), null, "Professor" }
                });

            migrationBuilder.InsertData(
                table: "WorkFields",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("06892e90-0b52-4602-a345-21b6c5cff37b"), new DateTime(2022, 8, 22, 0, 42, 53, 633, DateTimeKind.Local).AddTicks(3481), null, "شبکه" },
                    { new Guid("0a640c6b-dd50-41ed-af76-ce12b93f4924"), new DateTime(2022, 8, 22, 0, 42, 53, 633, DateTimeKind.Local).AddTicks(3472), null, "سخت افزار" },
                    { new Guid("6a7d441a-5dce-4794-984e-96f086408dbf"), new DateTime(2022, 8, 22, 0, 42, 53, 633, DateTimeKind.Local).AddTicks(3501), null, "فناوری اطلاعات" },
                    { new Guid("6d3ec4fb-720e-4894-b7c8-7939148698a8"), new DateTime(2022, 8, 22, 0, 42, 53, 633, DateTimeKind.Local).AddTicks(3456), null, "هوش مصنوعی" },
                    { new Guid("93796950-4678-420e-888f-85d392f78fb3"), new DateTime(2022, 8, 22, 0, 42, 53, 633, DateTimeKind.Local).AddTicks(3467), null, "نرم افزار" },
                    { new Guid("b219811d-337d-48ff-8913-5bb08eade936"), new DateTime(2022, 8, 22, 0, 42, 53, 633, DateTimeKind.Local).AddTicks(3487), null, "هوش مصنوعی" },
                    { new Guid("fe2d7cb9-abf1-439c-968f-c41c4f77dda7"), new DateTime(2022, 8, 22, 0, 42, 53, 633, DateTimeKind.Local).AddTicks(3476), null, "علوم داده" },
                    { new Guid("fe4acd48-b82f-4fc1-a0d8-13d09a4126d7"), new DateTime(2022, 8, 22, 0, 42, 53, 633, DateTimeKind.Local).AddTicks(3496), null, "شبکه‌های پیچیده" }
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
                name: "IX_ProjectWorkFields_projectRelatedforeignKey",
                table: "ProjectWorkFields",
                column: "projectRelatedforeignKey");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectWorkFields_WorkfieldID",
                table: "ProjectWorkFields",
                column: "WorkfieldID");

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
