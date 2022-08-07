using DAL.ProjectRepos;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using Models.Models;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace DAL.ProjectRepos.Tests
{
    [TestClass()]
    public class ProjectRepositoryTests
    {
        private readonly HamkariContext database;

        public ProjectRepositoryTests()
        {

            var options = new DbContextOptionsBuilder<HamkariContext>().UseSqlServer("Server=DESKTOP-NLOGANE;database=SBUhamkari;trusted_connection=true;", b => b.MigrationsAssembly("SBUhamkari"));
            database = new HamkariContext(options.Options);


        }

        [TestMethod()]
        public void GetProjectsByManagerTest()
        {

            using (var unitOfWork = new UnitOfWork(database))
            {


                var projects = unitOfWork.Projects.GetProjectsByManager(unitOfWork.ProjectManagers.GetAll().First().id);

                Assert.IsNotNull(projects);

            }
        }
        [TestMethod()]
        public void GetProjectsByManagerTypeTest()
        {
            using (var unitOfWork = new UnitOfWork(database))
            {


                var projects = unitOfWork.Projects.GetProjectsByManagerType(unitOfWork.Roles.GetRoleID("Professor"));

                Assert.IsNotNull(projects);

            }
        }




        [TestMethod()]
        public void GetProjectsByParticipatorTest()
        {
            using (var unitOfWork = new UnitOfWork(database))
            {

                //var participation = new ProjectParticapation
                //{
                //    Project = unitOfWork.Projects.GetProjectByName("همکاری بهشتی"),
                //    User = unitOfWork.Users.SingleOrDefault(m => m.Username == "RezaKlhor")
                //};
                //unitOfWork.ProjectParticapations.Add(participation);
                //unitOfWork.Complete();
                var projects = unitOfWork.Projects.GetProjectsByParticipator(unitOfWork.Students.GetAll().FirstOrDefault().id);

                Assert.IsNotNull(projects);

            }

        }

        [TestMethod()]
        public void GetProjectsByProjectStateTest()
        {
            //var project = new Project
            //{
            //    Name = "گلستان",
            //    ProjectExplain = "سییسیشسیشسیشسیشسیسش",
            //    ProjectState = ProjectState.Ended
            //};
            UnitOfWork unitOfWork = new UnitOfWork(database);
            //unitOfWork.Projects.Add(project);
            //unitOfWork.Complete();
            var projects = unitOfWork.Projects.GetProjectsByProjectState(ProjectState.Ended);
            Assert.IsNotNull(projects);
        }

        [TestMethod()]
        public void GetProjectsByWorkFieldTest()
        {
            UnitOfWork unitOfWork = new UnitOfWork(database);

            //var student = new Student
            //{
            //    Faculty = unitOfWork.FacultyRecords.SingleOrDefault(m => m.Name == "دانشکده مهندسی برق و کامپیوتر"),
            //    Firstname = "رضا",
            //    Lastname = "کلهری",
            //    Username = "RezaKlhor",
            //    Password = "12345678",
            //    Role = unitOfWork.Roles.SingleOrDefault(m => m.Name == "Student"),
            //    gender = Gender.male,
            //    StudentID=96243057,
            //    NationalIdNum= 3242115120


            //};
            //unitOfWork.Students.Add(student);
            //unitOfWork.Complete();
            //var professor = new Professor
            //{
            //    Firstname = "مجتبی",
            //    Lastname = "وحیدی",
            //    Username = "m.vahidi",
            //    Password = "12345678",
            //    Role = unitOfWork.Roles.SingleOrDefault(m => m.Name == "Professor"),
            //    gender = Gender.male,
            //    PersonnelID = 96243057,
            //    Faculty= unitOfWork.FacultyRecords.SingleOrDefault(m => m.Name == "دانشکده مهندسی برق و کامپیوتر"),
            //    NationalIdNum= 3242561341

            //};
            //unitOfWork.Professors.Add(professor);
            //unitOfWork.Complete();
            //var company = new Company
            //{
            //    CompanyName = "پارک",
            //    CompanyIDnumber = 12345678,
            //    Role = unitOfWork.Roles.SingleOrDefault(m => m.Name == "Company"),
            //    Faculty = unitOfWork.FacultyRecords.SingleOrDefault(m => m.Name == "دانشکده مهندسی برق و کامپیوتر"),
            //    Password = "12345678",
            //    Username = "Park",

            //};
            //unitOfWork.Companies.Add(company);
            //unitOfWork.Complete();
            //var project = new Project
            //{
            //    Name = "همکاری بهشتی",
            //    ProjectExplain = "سامانه همکاری بهشتی یک سامانه تحت وب می‌باشد",
            //    ProjectState = ProjectState.Ongoing,



            //};
            //unitOfWork.Projects.Add(project);
            //unitOfWork.Complete();
            //var projectManager = new ProjectManager
            //{
            //    Project = unitOfWork.Projects.GetProjectByName("همکاری بهشتی"),
            //    User = unitOfWork.Users.SingleOrDefault(m => m.Username == "RezaKlhor")
            //};
            //unitOfWork.ProjectManagers.Add(projectManager);
            //unitOfWork.Complete();
            //var projectWorkFields = new List<ProjectWorkField>
            //{
            //    new ProjectWorkField{
            //        Project=unitOfWork.Projects.GetProjectByName(Constants.HamkariProject),
            //        WorkField=unitOfWork.WorkFields.GetWorkFieldByName(Constants.SoftwareWorkField)


            //    },
            //    new ProjectWorkField
            //    {
            //        Project=unitOfWork.Projects.GetProjectByName(Constants.HamkariProject),
            //        WorkField= unitOfWork.WorkFields.GetWorkFieldByName(Constants.NetworkWorkField)
            //    },
            //    new ProjectWorkField
            //    {
            //        Project=unitOfWork.Projects.GetProjectByName("گلستان"),
            //        WorkField= unitOfWork.WorkFields.GetWorkFieldByName(Constants.NetworkWorkField)
            //    },
            //    new ProjectWorkField
            //    {
            //        Project=unitOfWork.Projects.GetProjectByName("گلستان"),
            //        WorkField= unitOfWork.WorkFields.GetWorkFieldByName(Constants.SoftwareWorkField)
            //    },
            //    new ProjectWorkField
            //    {
            //        Project=unitOfWork.Projects.GetProjectByName("گلستان"),
            //        WorkField= unitOfWork.WorkFields.GetWorkFieldByName(Constants.ItWorkField)
            //    }

            //};
            //unitOfWork.ProjectWorkFields.AddRange(projectWorkFields);
            //unitOfWork.Complete();
            var projects = unitOfWork.Projects.GetProjectsByWorkField(unitOfWork.WorkFields.GetWorkFieldByName(Constants.SoftwareWorkField).id);
            Assert.IsNotNull(projects);
        }

        [TestMethod()]
        public void GetProjectsByWorkfieldsTest()
        {
            UnitOfWork unitOfWork = new UnitOfWork(database);
            //unitOfWork.ProjectWorkFields.Add(new ProjectWorkField {
            //    Project= unitOfWork.Projects.GetProjectByName("گلستان"),
            //    WorkField=unitOfWork.WorkFields.GetWorkFieldByName(Constants.SoftwareWorkField)
            //});
            //unitOfWork.Complete();
            var workFields = new List<Guid>
            {
                 unitOfWork.WorkFields.GetWorkFieldByName(Constants.SoftwareWorkField).id,
                 unitOfWork.WorkFields.GetWorkFieldByName(Constants.NetworkWorkField).id,

            };
            var projects = unitOfWork.Projects.GetProjectsByWorkfields(workFields);
            Assert.IsNotNull(projects);

        }

        [TestMethod()]
        public void GetProjectsInSavedBoxTest()
        {
            UnitOfWork unitOfWork = new UnitOfWork(database);
            //var project = new Project
            //{
            //    Name = "همکاری بهشتی",
            //    ProjectExplain = "سامانه همکاری بهشتی یک سامانه تحت وب می‌باشد",
            //    ProjectState = ProjectState.Ongoing,



            //};
            //var project2 = new Project
            //{
            //    Name = "گلستان",
            //    ProjectExplain = "سامانه همکاری بهشتی یک سامانه تحت وب می‌باشد",
            //    ProjectState = ProjectState.Ended,



            //};
            //var student = new Student
            //{
            //    Faculty = unitOfWork.FacultyRecords.SingleOrDefault(m => m.Name == "دانشکده مهندسی برق و کامپیوتر"),
            //    Firstname = "رضا",
            //    Lastname = "کلهری",
            //    Username = "RezaKlhor",
            //    Password = "12345678",
            //    Role = unitOfWork.Roles.SingleOrDefault(m => m.Name == "Student"),
            //    gender = Gender.male,
            //    StudentID = 96243057,
            //    NationalIdNum = 3242115120


            //};
            //unitOfWork.Students.Add(student);
            //unitOfWork.Complete();
            //var professor = new Professor
            //{
            //    Firstname = "مجتبی",
            //    Lastname = "وحیدی",
            //    Username = "m.vahidi",
            //    Password = "12345678",
            //    Role = unitOfWork.Roles.SingleOrDefault(m => m.Name == "Professor"),
            //    gender = Gender.male,
            //    PersonnelID = 96243057,
            //    Faculty = unitOfWork.FacultyRecords.SingleOrDefault(m => m.Name == "دانشکده مهندسی برق و کامپیوتر"),
            //    NationalIdNum = 3242561341

            //};
            //unitOfWork.Professors.Add(professor);
            //unitOfWork.Complete();
            //var company = new Company
            //{
            //    CompanyName = "پارک",
            //    CompanyIDnumber = 12345678,
            //    Role = unitOfWork.Roles.SingleOrDefault(m => m.Name == "Company"),
            //    Faculty = unitOfWork.FacultyRecords.SingleOrDefault(m => m.Name == "دانشکده مهندسی برق و کامپیوتر"),
            //    Password = "12345678",
            //    Username = "Park",

            //};
            //unitOfWork.Companies.Add(company);
            //unitOfWork.Complete();
            //unitOfWork.Projects.Add(project);
            //unitOfWork.Projects.Add(project2);
            //unitOfWork.Complete();
            //unitOfWork.SavedProjects.Add(new SavedProject { Project = project, User = student });
            //unitOfWork.SavedProjects.Add(new SavedProject { Project = project2, User = student });
            //unitOfWork.Complete();
            var projects = unitOfWork.Projects.GetProjectsInSavedBox(unitOfWork.Students.Find(m => m.Firstname == "رضا").First().id);
            if (projects.Count == 0)
            {
                projects = null;
            }
            Assert.IsNotNull(projects);
        }

        [TestMethod()]
        public void GetProjectsByAllTest()
        {
            UnitOfWork unitOfWork = new UnitOfWork(database);
            var projectWorkFields = new List<ProjectWorkField>
            {
                new ProjectWorkField{
                    Project=unitOfWork.Projects.GetProjectByName(Constants.HamkariProject),
                    WorkField=unitOfWork.WorkFields.GetWorkFieldByName(Constants.SoftwareWorkField)


                },
                new ProjectWorkField
                {
                    Project=unitOfWork.Projects.GetProjectByName(Constants.HamkariProject),
                    WorkField= unitOfWork.WorkFields.GetWorkFieldByName(Constants.NetworkWorkField)
                },
                new ProjectWorkField
                {
                    Project=unitOfWork.Projects.GetProjectByName("گلستان"),
                    WorkField= unitOfWork.WorkFields.GetWorkFieldByName(Constants.NetworkWorkField)
                },
                new ProjectWorkField
                {
                    Project=unitOfWork.Projects.GetProjectByName("گلستان"),
                    WorkField= unitOfWork.WorkFields.GetWorkFieldByName(Constants.SoftwareWorkField)
                },
                new ProjectWorkField
                {
                    Project=unitOfWork.Projects.GetProjectByName("گلستان"),
                    WorkField= unitOfWork.WorkFields.GetWorkFieldByName(Constants.ItWorkField)
                }

            };
            unitOfWork.ProjectWorkFields.AddRange(projectWorkFields);
            unitOfWork.Complete();
            var projects = unitOfWork.Projects.GetProjectsByAll(new List<Guid>
            {
                unitOfWork.WorkFields.GetWorkFieldByName(Constants.SoftwareWorkField).id

            },unitOfWork.Roles.GetRoleID(Constants.StudentRole),ProjectState.Ongoing);
            Assert.IsNotNull(projects);

        }
    }
}

