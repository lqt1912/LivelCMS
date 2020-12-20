using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LivelCmsSystem.Test.CustomerPage
{
    public class AutomationTest:IDisposable
    {
        private readonly IWebDriver _driver;
        private readonly CustomerPage _page;
        public AutomationTest()
        {
            _driver = new ChromeDriver();
            _page = new CustomerPage(_driver);
            _page.Navigate();
        }
        public void Dispose()
        {
            _driver.Quit();
            _driver.Dispose();
        }
        [Fact]
        public void TC29()
        {
            _page.Entry("10");
            Assert.Contains("Showing 1 to 10", _page.EntriesValidator);
        }

        [Fact]
        public void TC30()
        {
            _page.Entry("25");
            Assert.Contains("Showing 1 to 25", _page.EntriesValidator);
        }

        [Fact]
        public void TC31()
        {
            _page.Entry("50");
            Assert.Contains("Showing 1 to 50", _page.EntriesValidator);
        }

        [Fact]
        public void TC32()
        {
            _page.Entry("100");
            Assert.Contains("Showing 1 to 100", _page.EntriesValidator);
        }

        [Fact]
        public void TC33()
        {
            _page.Search("1bc0b");
            Assert.Contains("1bc0b", _page.SearchValidator);
        }
        [Fact]
        public void TC34()
        {
            _page.Search("Anh");
            Assert.Contains("Showing 1 to 2 ", _page.EntriesValidator);
        }
        [Fact]
        public void TC35()
        {
            _page.Search("0868992467");
            Assert.Contains("1bc0b", _page.SearchValidator);
        }
        [Fact]
        public void TC36()
        {
            _page.Update();
            Assert.Contains("Chỉnh sửa thông tin khách hàng", _page.UpdateValidator);
        }

        [Fact]
        public void TC37()
        {
            _page.Delete();
            Assert.Contains("Thành công", _page.DeleteValidator);
        }
    }
}
