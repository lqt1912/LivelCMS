using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Assert = Xunit.Assert;

namespace LivelCmsSystem.Test.ProductPage
{
    public class AutomationTest:IDisposable
    {
        private readonly IWebDriver _driver;
        private readonly ProductPage _page;
        public AutomationTest()
        {
            _driver = new ChromeDriver();
            _page = new ProductPage(_driver);
            _page.Navigate();
        }
        public void Dispose()
        {
            _driver.Quit();
            _driver.Dispose();
        }
        [Fact]
        public void TC19()
        {
            _page.Entry("10");
            Assert.Contains("Showing 1 to 10", _page.EntriesValidator);
        }
        [Fact]
        public void TC20()
        {
            _page.Entry("25");
            Assert.Contains("Showing 1 to 25", _page.EntriesValidator);
        }
        [Fact]
        public void TC21()
        {
            _page.Entry("50");
            Assert.Contains("Showing 1 to 50", _page.EntriesValidator);
        }
        [Fact]
        public void TC22()
        {
            _page.Entry("100");
            Assert.Contains("Showing 1 to 100", _page.EntriesValidator);
        }
        [Fact]
        public void TC23()
        {
            _page.Search("88");
            Assert.Contains("f9881", _page.SearchValidator);
        }
        [Fact]
        public void TC24()
        {
            _page.Search("f9881");
            Assert.Contains("f9881", _page.SearchValidator);
        }
        [Fact]
        public void TC25()
        {
            _page.Search("Xe");
            Assert.Contains("Showing 1 to 10 of 22 entries", _page.EntriesValidator);
        }

        [Fact]
        public void TC26()
        {
            _page.Search("1,540,004");
            Assert.Contains("7d7de", _page.SearchValidator);
        }

        [Fact]
        public void TC27()
        {
            _page.Update();
            Assert.Contains("", _page.UpdateValidator);
        }
    }
}
