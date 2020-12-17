using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;

namespace LivelCmsSystem.Test.LoginPage
{
    public class AutomationTest:IDisposable
    {
        private readonly IWebDriver _driver;
        private readonly LoginPage _page;

        public AutomationTest()
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
        public void TC16()
        {
            _page.UsernameInput("");
            _page.PasswordInput("");
            _page.Submit();
            Assert.Contains("The Email field is required.", _page.UsernameValidator);
            Assert.Contains("The Password field is required.", _page.PasswordValidator);
        }
        [Fact]
        public void TC17()
        {
            _page.UsernameInput("admin@livel.com");
            _page.PasswordInput("111111");
            _page.Submit();
            Assert.Contains("Home Page - LivelCmsSystem", _page.Title);
        }
        [Fact]
        public void TC18()
        {
            _page.UsernameInput("admin@livel");
            _page.PasswordInput("111111");
            _page.Submit();
            Assert.Contains("Invalid login attempt.", _page.Validator);
        }
    }
}
