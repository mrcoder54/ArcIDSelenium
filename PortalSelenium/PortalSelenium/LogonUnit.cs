using Xunit;
using SeleniumDriver;
using System;
using System.IO;
using System.Reflection;

namespace Tests
{
    [Collection("Portal Logon")]
    public class LogonUnit : IDisposable
    {
        private PortalMain main;
        public LogonUnit()
        {
            var executionPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var path = System.Environment.GetEnvironmentVariable("PATH");
            System.Environment.SetEnvironmentVariable("PATH", $"{path};{executionPath}");

            main = new PortalMain("https://reg1.fdorqa.com:9700", "crossmatch", "livescan");
        }

        public void Dispose()
        {
            main.Close();
        }

  
        [Fact]
        public void LogonTest()
        {
            var logonResult = main.Logon();

            Assert.True(logonResult);
        }
    }
}