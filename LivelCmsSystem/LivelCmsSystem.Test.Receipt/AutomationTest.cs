using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LivelCmsSystem.Test.Receipt
{
    public class AutomationTest:IDisposable
    {
        private readonly IWebDriver _driver;
        private readonly Receipt _page;
        public AutomationTest()
        {
            _driver = new ChromeDriver();
            _page = new Receipt(_driver);
            _page.Navigate();
        }
        public void Dispose()
        {
            _driver.Quit();
            _driver.Dispose();
        }
        [Fact]
        public void TC47()
        {
            _page.Entry("10");
            Assert.Contains("Showing 1 to 10", _page.EntriesValidator);
        }

        [Fact]
        public void TC48()
        {
            _page.Entry("25");
            Assert.Contains("Showing 1 to 25", _page.EntriesValidator);
        }

        [Fact]
        public void TC49()
        {
            _page.Entry("50");
            Assert.Contains("Showing 1 to 50", _page.EntriesValidator);
        }

        [Fact]
        public void TC50()
        {
            _page.Entry("100");
            Assert.Contains("Showing 1 to 100", _page.EntriesValidator);
        }

        [Fact]
        public void TC51()
        {
            _page.Search("3a9ba");
            Assert.Contains("3a9ba", _page.SearchValidator);
        }
        [Fact]
        public void TC52()
        {
            _page.Search("28/11");
            Assert.Contains("Showing 1 to 6", _page.EntriesValidator);
        }
        [Fact]
        public void TC53()
        {
            _page.Search("200");
            Assert.Contains("3a9ba", _page.SearchValidator);
        }
        [Fact]
        public void TC54()
        {
            _page.Update();
            Assert.Contains("Thông tin chứng từ", _page.UpdateValidator);
        }
    }
}
