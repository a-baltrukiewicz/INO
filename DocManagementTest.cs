using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1.DocManagmentTests
{
    [TestClass]
    public class DocManagementUnitTest2
    {
        public DocManagementUnitTest2(){}

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
        public void AddDocumentsManagerTest()
        {
            DocManagement.DocManagementAPI docManagementAPI_DocumentsManager = new DocManagement.DocManagementAPI();
            docManagementAPI_DocumentsManager.AddDocumentsManager(new DINO.DocumentsManager());

            Assert.Fail();
        }
    }
}