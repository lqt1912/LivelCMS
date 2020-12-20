using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivelCmsSystem.Test.CustomerPage
{
    class CustomerPage
    {
        private readonly IWebDriver _driver;
        private const string URL = "https://localhost:44334/danh-sach-khach-hang";

        public CustomerPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public string Source => _driver.PageSource;
        public string EntriesValidator => _driver.FindElement(By.Id("example1_info")).Text;
        public string SearchValidator => _driver.FindElement(By.ClassName("sorting_1")).Text;
        public string UpdateValidator => _driver.FindElement(By.TagName("h4")).Text;
        public string DeleteValidator => _driver.FindElement(By.TagName("strong")).Text;

        //public IWebElement EntriesElement => _driver.FindElement(By.Id())
        private IWebElement SearchElement => _driver.FindElement(By.ClassName("form-control-sm"));
        private IWebElement UpdateElement => _driver.FindElement(By.Id("update"));
        private IWebElement DeleteElement => _driver.FindElement(By.Id("delete"));
        SelectElement EntriesElement => new SelectElement(_driver.FindElement(By.ClassName("custom-select")));
        public void Navigate() => _driver.Navigate().GoToUrl(URL);
        public void Entry(string entries) => EntriesElement.SelectByValue(entries);
        public void Search(string search) => SearchElement.SendKeys(search);
        public void Update() => UpdateElement.Click();
        public void Delete() => DeleteElement.Click();
    }
}
