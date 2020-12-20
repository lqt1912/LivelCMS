using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LivelCmsSystem.Test.InvoicePage
{
    public class AutomationTest:IDisposable
    {
        private readonly IWebDriver _driver;
        private readonly InvoicePage _page;

        public AutomationTest()
        {
            _driver = new ChromeDriver();
            _page = new InvoicePage(_driver);
            _page.Navigate();
        }

        public void Dispose()
        {
            _driver.Quit();
            _driver.Dispose();
        }

        [Fact]
        public void TC39()
        {
            _page.Entry("10");
            Assert.Contains("Showing 1 to 10", _page.EntriesValidator);
        }

        [Fact]
        public void TC40()
        {
            _page.Entry("25");
            Assert.Contains("Showing 1 to 25", _page.EntriesValidator);
        }

        [Fact]
        public void TC41()
        {
            _page.Entry("50");
            Assert.Contains("Showing 1 to 50", _page.EntriesValidator);
        }

        [Fact]
        public void TC42()
        {
            _page.Entry("100");
            Assert.Contains("Showing 1 to 100", _page.EntriesValidator);
        }

        [Fact]
        public void TC43()
        {
            _page.Search("1111fb");
            Assert.Contains("111fb", _page.SearchValidator);
        }
        [Fact]
        public void TC44()
        {
            _page.Search("Dân");
            Assert.Contains("Showing 1 to 4", _page.EntriesValidator);
        }
        [Fact]
        public void TC45()
        {
            _page.Search("1000");
            Assert.Contains("Showing 1 to 4", _page.EntriesValidator);
        }
        [Fact]
        public void TC46()
        {
            _page.Update();
            Assert.Contains("Chi tiết hóa đơn", _page.UpdateValidator);
        }
    }
}
