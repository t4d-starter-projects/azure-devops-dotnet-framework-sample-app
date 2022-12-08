using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleApp.Web;
using SampleApp.Web.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace SampleApp.Web.Tests.Controllers
{
  [TestClass]
  public class HomeControllerTest
  {
    [TestMethod]
    public void About()
    {
      // Arrange
      HomeController controller = new HomeController();

      // Act
      ViewResult result = controller.About() as ViewResult;

      // Assert
      Assert.AreEqual("Your application description page.", result.ViewBag.Message);
    }

    [TestMethod]
    public void Contact()
    {
      // Arrange
      HomeController controller = new HomeController();

      // Act
      ViewResult result = controller.Contact() as ViewResult;

      // Assert
      Assert.IsNotNull(result);
    }
  }
}
