using HomeworkSubmission.DAL;
using HomeworkSubmission.MVC.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using HomeworkSubmission.MVC.Models;
using System.Web.Mvc;

namespace HomeworkSubmission.MVC.Tests
{
    
    
    /// <summary>
    ///This is a test class for SubmissionControllerTest and is intended
    ///to contain all SubmissionControllerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SubmissionControllerTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
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


        /// <summary>
        ///A test for Create
        ///</summary>
        ///
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("T:\\01. ASP-MVC\\Data\\InterviewProject\\HomeworkSubmission\\HomeworkSubmission.MVC", "/")]
        [UrlToTest("http://localhost:777/")]
        public void CreateTest()
        {
            SubmissionViewModel model = new SubmissionViewModel(StudentDAL.GetRandomStudent().AcademyID, "1", "1"); 
            //SubmissionController target = new SubmissionController(); 


            //ActionResult expected =
            //ActionResult actual;

            //actual = target.Create(model);
            //Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");


            var submissionControler = new SubmissionController();
            var result = submissionControler.Create(model) as ViewResult;

            Assert.IsNotNull(result, "Viewresult should be returned");

        }


    }
}
