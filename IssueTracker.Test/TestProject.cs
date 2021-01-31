using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IssueTracker.API;
using IssueTracker.API.Controllers;
using NUnit.Framework;

namespace IssueTracker.Test
{
    [TestFixture]
    public class TestProject
    {
        [Test]
        public void TestGetAllProjects()
        {
            ProjectController controller = new ProjectController();
            var output = controller.GetAll();
            Assert.IsNotNull(output);
        }
    }
}