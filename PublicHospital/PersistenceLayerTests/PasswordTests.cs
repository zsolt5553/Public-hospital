using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersistenceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace PersistenceLayer.Tests
{
    [TestClass()]
    public class PasswordTests
    {
        [TestMethod()]
        public void compareSessionIDTest()
        {
            AdminBDO p = new AdminBDO();
            p.sessionID = "0C4J8DlS7AHFQa8j4U1Ap39gFDDOeNBJ/N1B2eXw";
            p.id = 11;
            Password pass = new Password();
            if (!pass.compareSessionID(p))
                Assert.Fail();
        }

        [TestMethod()]
        public void authenticatePersonTest()
        {
            Password pass = new Password();
            if(pass.authenticatePerson("aaaa", "aaaa") == null)
            {
                Assert.Fail();
            }
        }
    }
}