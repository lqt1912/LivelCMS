using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Linq;
using Xunit;

namespace TestLiveCMS
{
    public class TestLogin: IDisposable
    {
        private readonly IWebDriver _driver;
        private readonly LoginPage _page;

        public TestLogin()
        {
            _driver = new ChromeDriver();
            _page = new LoginPage(_driver);
            _page.Navigate();
        }

        public void Dispose()
        {
            _driver.Quit();
            _driver.Dispose();
        }

        [Fact]
        public void Case1()
        {
            _page.UserNameInput("");
            _page.PassWordInput("");
            _page.Submit();
            Assert.Contains("The Email field is required.", _page.UserNameValidator);
        }
    }
}
