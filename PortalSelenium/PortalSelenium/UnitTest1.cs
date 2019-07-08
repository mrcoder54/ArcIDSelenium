using NUnit.Framework;
using SeleniumDriver;


namespace Tests
{
    public class Tests
    {
        private PortalMain main;
        [SetUp]
        public void Setup()
        {
            var path = System.Environment.GetEnvironmentVariable("PATH");
            System.Environment.SetEnvironmentVariable("PATH", $"{path};{TestContext.CurrentContext.TestDirectory}");

            main = new PortalMain("https://arcid.admin:Live$can1@10.36.62.179:9700");
        }

        [TearDown]
        public void TearDown()
        {
            main.Close();
        }

        [Test]
        public void Test1()
        {

            Assert.Pass();
        }
    }
}