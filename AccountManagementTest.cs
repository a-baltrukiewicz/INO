using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1.AccountManagmentTests
{
    [TestClass]
    public class AccountManagmentTests2
    {
        public AccountManagmentTests2() {}

        private TestContext testContextInstance;

        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        [TestMethod]
        public void NewUserTest()
        {
            AccountManagement.AccountManagementAPI acccountsManagementAPI_AccountManager = new AccountManagement.AccountManagementAPI();
            accountsManagementAPI_AcountManager.NewUser(new DINO.AccountManager());

            Assert.Fail();
        }
    }
}