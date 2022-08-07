using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.Tests
{
    [TestClass()]
    public class RepositoryTests

    {
        private readonly HamkariContext database;
        public RepositoryTests()
        {
            var options = new DbContextOptionsBuilder<HamkariContext>().UseSqlServer("Server=DESKTOP-NLOGANE;database=SBUhamkari;trusted_connection=true;", b => b.MigrationsAssembly("SBUhamkari"));
            database = new HamkariContext(options.Options);
        }

        [TestMethod()]
        public void RemoveTest()
        {
            UnitOfWork unitOfWork = new UnitOfWork(database);
            unitOfWork.Projects.Remove(unitOfWork.Projects.GetProjectByName("گلستان"));
            unitOfWork.Complete();
            
        }
    }
}