using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataLayer;
using PersistenceLayer;

namespace PersistenceLayer.Tests
{
    [TestClass()]
    public class AdminTests
    {
        [TestMethod()]
        public void GetAdminTest()
        {
            int id = 1;
            AdminDAO adminDAO = new AdminDAO();
            if(adminDAO.GetAdmin(id) == null)
            {
                Assert.Fail();
            }
        }
    }
}
