using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LivelCmsSystem.Test.ProductFunction
{
    public class AutomationTestUpdate
    {
        private readonly IWebDriver _driver;
        private readonly ProductPage _page;
        public AutomationTestUpdate()
        {
            _driver = new ChromeDriver();
            _page = new ProductPage(_driver);
            _page.NavigateUrl1();
        }
        public void Dispose()
        {
            _driver.Quit();
            _driver.Dispose();
        }
        [Fact]
        public void TC56()
        {
            _page.PriceClear();
            _page.PriceInput("0");
            _page.Submit();
            Assert.Contains("Thất bại", _page.Validator);
        }
        [Fact]
        public void TC57()
        {
            _page.PriceClear();
            _page.PriceInput("0");
            _page.Submit();
            Assert.Contains("Thất bại", _page.Validator);
        }
        [Fact]
        public void TC58()
        {
            _page.PriceClear();
            _page.PriceInput("0");
            _page.Submit();
            Assert.Contains("Thất bại", _page.Validator);
        }
        [Fact]
        public void TC59()
        {
            _page.PriceClear();
            _page.PriceInput("0");
            _page.Submit();
            Assert.Contains("Thất bại", _page.Validator);
        }
        [Fact]
        public void TC60()
        {
            _page.PriceClear();
            _page.PriceInput("0");
            _page.Submit();
            Assert.Contains("Thất bại", _page.Validator);
        }
        [Fact]
        public void TC61()
        {
            _page.PriceClear();
            _page.PriceInput("0");
            _page.Submit();
            Assert.Contains("Thất bại", _page.Validator);
        }
        [Fact]
        public void TC62()
        {
            _page.PriceClear();
            _page.PriceInput("0");
            _page.Submit();
            Assert.Contains("Thất bại", _page.Validator);
        }
    }
}
