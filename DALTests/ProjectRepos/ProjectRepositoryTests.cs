

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using Models.Models;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace DAL.ProjectRepos.ProjectRepos.Tests
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
                //unitOfWork.Projects.Add(
                //    new Project { Name = "Hamkari", ProjectState = ProjectState.Ongoing, ProjectExplain = "Job and Cowork" });
                //unitOfWork.Complete();
                //unitOfWork.Students.Add(new Student
                //{
                //    Username = "RezaKlhor",
                //    Password = "324reza",
                //    Firstname = "Reza",
                //    Lastname = "Kalhori",
                //    gender = Gender.male,
                //    NationalIdNum = 3242115120,
                //    StudentID = 96243057,
                //    BirthDate = new DateTime(1999, 6, 10),
                //    Role= unitOfWork.Roles.SingleOrDefault(m=> m.Name=="Student")

                //});
                //unitOfWork.Complete();
                unitOfWork.Professors.Add(new Professor
                {
                    Username = "Dr.vahidi",
                    Password = "51324342",
                    Firstname = "Mojtaba",
                    Lastname = "Vahidi",
                    gender = Gender.male,
                    NationalIdNum = 1535132133,
                    PersonnelID = 235133212,
                    BirthDate = new DateTime(1980, 1, 1),
                    Role = unitOfWork.Roles.SingleOrDefault(m => m.Name == "Professor")
                });
                unitOfWork.Complete();
                unitOfWork.Companies.Add(new Company
                {
                    CompanyName = "مرکز رشد دانشکده کامپیوتر",
                    CompanyIDnumber = 2222222222,
                    Username = "CSEroshd",
                    Password = "as6d4",
                    Role = unitOfWork.Roles.SingleOrDefault(m => m.Name == "Company")

                });

                unitOfWork.Complete();
                
                Assert.IsNotNull(null);

            }
        }

    }
}