using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace SampleApp.WebDriverTest
{
  [TestClass]
  public class EdgeDriverTest
  {
    // In order to run the below test(s), 
    // please follow the instructions from http://go.microsoft.com/fwlink/?LinkId=619687
    // to install Microsoft WebDriver.

    private EdgeDriver _driver;

    [TestInitialize]
    public void EdgeDriverInitialize()
    {
      // Initialize edge driver 
      var options = new EdgeOptions
      {
        PageLoadStrategy = PageLoadStrategy.Normal
      };
      _driver = new EdgeDriver(options);
    }

    [TestMethod]
    public void VerifyPageTitle()
    {
      // Replace with your own test logic
      _driver.Url = "https://localhost:44361";
      Assert.AreEqual("Index - My ASP.NET Application", _driver.Title);
    }

    [TestMethod]
    public void VerifyContactsTable()
    {
      // Replace with your own test logic
      _driver.Url = "https://localhost:44361";

      Assert.IsTrue(_driver
        .FindElementByTagName("tbody")
        .FindElements(By.TagName("tr")).Count > 0);
    }

    [TestCleanup]
    public void EdgeDriverCleanup()
    {
      _driver.Quit();
    }
  }
}
