

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using Models.Models;
using Microsoft.EntityFrameworkCore;
namespace DAL.ProjectRepos.ProjectRepos.Tests
{
    [TestClass()]
    public class ProjectRepositoryTests
    {
        private readonly HamkariContext database;

        

        [TestMethod()]
        public void GetProjectsByManagerTest() 
        {
            Assert.IsTrue(true);
            using (var unitOfWork = new UnitOfWork(new HamkariContext(new DbContextOptions<HamkariContext>())))
            {

                Assert.IsTrue(true);
                
            }
        }
    }
}