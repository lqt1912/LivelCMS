using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivelCmsSystem.Test.ProductFunction
{
    class ProductPage
    {
        private readonly IWebDriver _driver;
        private const string URL1 = "https://localhost:44334/Product/UpdateProduct/3f265495-31bb-4af1-8b9e-6d06201ac9b9";
        private const string URL2 = "https://localhost:44334/Product/AddProduct";
        
        public ProductPage(IWebDriver driver)
        {
            _driver = driver;
        }
        public void NavigateUrl1() => _driver.Navigate().GoToUrl(URL1);
        public void NavigateUrl2() => _driver.Navigate().GoToUrl(URL2);
        public string Source => _driver.PageSource;
        public string NameValidator => _driver.FindElement(By.Id("name-validator")).Text;
        public string PriceValidator => _driver.FindElement(By.Id("price-validator")).Text;
        public string Validator => _driver.FindElement(By.TagName("strong")).Text;
        private IWebElement NameElement => _driver.FindElement(By.Id("Name"));
        private IWebElement PriceElement => _driver.FindElement(By.Id("UnitPrice"));
        private IWebElement Button => _driver.FindElement(By.ClassName("btn-primary"));
        public void NameInput(string username) => NameElement.SendKeys(username);
        public void PriceClear() => PriceElement.Clear();
        public void PriceInput(string password) => PriceElement.SendKeys(password);
        public void Submit() => Button.Click();
    }
}
