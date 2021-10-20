using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

 namespace TechJobTests
    {
        [TestClass]
        public class JobTests
        {
            Job testJob1 = new Job();
            Job testJob2 = new Job();
            Job testJob3 = new Job("Product tester", 
                new Employer("ACME"), 
                new Location("Desert"), 
                new PositionType("Quality"), 
                new CoreCompetency("Persistence"));
            Job testJob4 = new Job("Product tester", 
                new Employer("ACME"), 
                new Location("Desert"), 
                new PositionType("Quality"), 
                new CoreCompetency("Persistence"));

            [TestMethod]
            public void TestSettingJobId()
            {
                Assert.IsTrue(testJob1.Id < testJob2.Id && (testJob1.Id + 1) == testJob2.Id);
            }
            [TestMethod]
            public void TestJobConstructorSetsAllFields()
            {
                Assert.IsTrue(testJob3.Name == "Product tester");
                Assert.IsTrue(testJob3.EmployerName.Value == "ACME");
                Assert.IsTrue(testJob3.EmployerLocation.Value == "Desert");
                Assert.IsTrue(testJob3.JobType.Value == "Quality");
                Assert.IsTrue(testJob3.JobCoreCompetency.value == "Persistence");
            }
            [TestMethod]
            public void TestJobsForEquality()
            {
                Assert.IsFalse(testJob3.Equals(testJob4));
            }
            [TestMethod]
            public void TestJobsForToString()
            {
                string expectedOutput = $"ID:{testJob3.Id} \n " +
                $"Name:{testJob3.Name} \n " +
                $"Employer:{testJob3.EmployerName} \n " +
                $"Location:{testJob3.EmployerLocation} \n " +
                $"Position Type:{testJob3.JobType} \n " +
                $"Core Competency:{testJob3.JobCoreCompetency}";
                Assert.AreEqual(expectedOutput, testJob3.ToString());

            }
        }
    }
