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


                var projects = unitOfWork.Projects.GetProjectsByManagerType(unitOfWork.Roles.GetStudentRoleID("Professor"));

                Assert.IsNotNull(projects);

            }
        }




        [TestMethod()]
        public void GetProjectsByParticipatorTest()
        {
            using (var unitOfWork = new UnitOfWork(database))
            {


                var projects = unitOfWork.Projects.GetProjectsByParticipator(unitOfWork.Students.GetAll().FirstOrDefault().id);

                Assert.IsNotNull(projects);

            }

        }

        [TestMethod()]
        public void GetProjectsByProjectStateTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetProjectsByWorkFieldTest()
        {
            UnitOfWork unitOfWork = new UnitOfWork(database);

            var student = new Student
            {
                Faculty = unitOfWork.FacultyRecords.SingleOrDefault(m => m.Name == "دانشکده مهندسی برق و کامپیوتر"),

                
            }
            
        }
    }
}

