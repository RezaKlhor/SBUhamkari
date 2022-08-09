using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL.UserRepos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Microsoft.EntityFrameworkCore;
using Models.Models;

namespace DAL.UserRepos.Tests
{
    [TestClass()]
    public class FacultyRepositoryTests
    {
        private readonly HamkariContext database;

        public FacultyRepositoryTests()
        {
            var options = new DbContextOptionsBuilder<HamkariContext>().UseSqlServer("Server=DESKTOP-NLOGANE;database=SBUhamkari;trusted_connection=true;", b => b.MigrationsAssembly("SBUhamkari"));
            database = new HamkariContext(options.Options);
        }

        [TestMethod()]
        public void GetFacultyByUserIdTest()
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
            //    StudentID = 96243057,
            //    NationalIdNum = 3242115120


            //};
            //unitOfWork.Students.Add(student);
            //unitOfWork.Complete();

            var faculty = unitOfWork.FacultyRecords.GetFacultyByUserId(unitOfWork.Users.GetUserByUsername("RezaKlhor").id);
            Assert.IsNotNull(faculty);
        }
    }
}