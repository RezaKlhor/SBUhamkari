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
                    { new Guid("3704af32-771e-4f3e-8ceb-945051acc04c"), new DateTime(2022, 8, 18, 0, 35, 58, 877, DateTimeKind.Local).AddTicks(3857), null, "دانشگاه تهران" },
                    { new Guid("3775d682-118b-4af1-8460-af92c362a1fa"), new DateTime(2022, 8, 18, 0, 35, 58, 877, DateTimeKind.Local).AddTicks(3863), null, "دانشگاه صنعتی امیرکبیر" },
                    { new Guid("996d684a-adb7-49c6-af2b-5aefced9d8fe"), new DateTime(2022, 8, 18, 0, 35, 58, 877, DateTimeKind.Local).AddTicks(3899), null, "دانشگاه صنعتی صنعتی شریف" },
                    { new Guid("afd71194-7960-42b8-b8bd-f3a8da659045"), new DateTime(2022, 8, 18, 0, 35, 58, 877, DateTimeKind.Local).AddTicks(3773), null, "دانشگاه شهید بهشتی" },
                    { new Guid("b74abef7-fe30-419b-9326-49437d848c95"), new DateTime(2022, 8, 18, 0, 35, 58, 877, DateTimeKind.Local).AddTicks(3868), null, "دانشگاه علم و صنعت" }
                });

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("12e5dafa-e36f-488f-817a-7d57f4a50923"), new DateTime(2022, 8, 18, 0, 35, 58, 877, DateTimeKind.Local).AddTicks(4043), null, "دانشکده رواشناسی و علوم تربیتی" },
                    { new Guid("1b9070d5-9f62-496f-940a-d1a0e389f6c7"), new DateTime(2022, 8, 18, 0, 35, 58, 877, DateTimeKind.Local).AddTicks(4008), null, "دانشکده برق و کامپیوتر" },
                    { new Guid("24ea6d16-9dd9-417f-af45-1503f307b053"), new DateTime(2022, 8, 18, 0, 35, 58, 877, DateTimeKind.Local).AddTicks(4052), null, "دانشکده علوم پایه" },
                    { new Guid("598e0b26-195f-4dac-80d7-49f7ebb3505e"), new DateTime(2022, 8, 18, 0, 35, 58, 877, DateTimeKind.Local).AddTicks(4038), null, "دانشکده حقوق" },
                    { new Guid("cbbc4f09-c4e6-48bb-bdfa-9e06f7db714c"), new DateTime(2022, 8, 18, 0, 35, 58, 877, DateTimeKind.Local).AddTicks(4048), null, "دانشکده معماری" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("0665dccc-4bcc-4e39-82f7-267f4351c335"), new DateTime(2022, 8, 18, 0, 35, 58, 877, DateTimeKind.Local).AddTicks(4157), null, "Professor" },
                    { new Guid("25352780-90bc-465d-b553-8d1297d8d542"), new DateTime(2022, 8, 18, 0, 35, 58, 877, DateTimeKind.Local).AddTicks(4145), null, "Student" },
                    { new Guid("3e01eab9-f4af-4633-bd14-9a5b0e1d4a11"), new DateTime(2022, 8, 18, 0, 35, 58, 877, DateTimeKind.Local).AddTicks(4130), null, "Admin" },
                    { new Guid("a75d09d8-87ce-4cb0-8e35-fe0c46ce5082"), new DateTime(2022, 8, 18, 0, 35, 58, 877, DateTimeKind.Local).AddTicks(4162), null, "Company" }
                });

            migrationBuilder.InsertData(
                table: "WorkFields",
                columns: new[] { "id", "CreateTime", "DeleteTime", "Name" },
                values: new object[,]
                {
                    { new Guid("04ec3066-9ae6-4358-8248-056c15a6ff4a"), new DateTime(2022, 8, 18, 0, 35, 58, 877, DateTimeKind.Local).AddTicks(4298), null, "شبکه" },
                    { new Guid("1991447e-45c1-4485-958f-0942197878ce"), new DateTime(2022, 8, 18, 0, 35, 58, 877, DateTimeKind.Local).AddTicks(4289), null, "سخت افزار" },
                    { new Guid("2820cce5-ec38-4d5d-91c5-45e3325052bf"), new DateTime(2022, 8, 18, 0, 35, 58, 877, DateTimeKind.Local).AddTicks(4321), null, "فناوری اطلاعات" },
                    { new Guid("65a19480-af21-4b3e-9c99-8a65f9c5fbd8"), new DateTime(2022, 8, 18, 0, 35, 58, 877, DateTimeKind.Local).AddTicks(4284), null, "نرم افزار" },
                    { new Guid("996e0d44-04b2-441e-beb0-7713fbf26d4a"), new DateTime(2022, 8, 18, 0, 35, 58, 877, DateTimeKind.Local).AddTicks(4231), null, "هوش مصنوعی" },
                    { new Guid("a2248217-ad07-4163-8ce2-a3dc1a3532c5"), new DateTime(2022, 8, 18, 0, 35, 58, 877, DateTimeKind.Local).AddTicks(4305), null, "هوش مصنوعی" },
                    { new Guid("a6d24e89-dd08-4890-bf76-671c9472b979"), new DateTime(2022, 8, 18, 0, 35, 58, 877, DateTimeKind.Local).AddTicks(4293), null, "علوم داده" },
                    { new Guid("ff4d0570-3cbf-4061-b382-a358f5b9be1b"), new DateTime(2022, 8, 18, 0, 35, 58, 877, DateTimeKind.Local).AddTicks(4316), null, "شبکه‌های پیچیده" }
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
