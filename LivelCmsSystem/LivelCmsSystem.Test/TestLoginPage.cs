using System;
using LiveCmsSystem.Test;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;
using Assert = Xunit.Assert;

namespace LivelCmsSystem.Test
{
    public class TestLoginPage:IDisposable
    {
        private readonly IWebDriver _driver;
        private readonly LoginPage _page;

        public TestLoginPage()
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
        public void Case2()
        {
            _page.UsernameInput("admin@livel.com");
            _page.PasswordInput("");
            _page.Submit();
            Assert.Contains("The Password field is required.", _page.PasswordValidator);
        }
        [Fact]
        public void Case1()
        {
            _page.UsernameInput("");
            _page.PasswordInput("111111");
            _page.Submit();
            Assert.Contains("The Email field is required.", _page.UsernameValidator);
        }

    }
}