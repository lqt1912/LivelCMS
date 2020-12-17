using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace TestLiveCMS
{
    public class LoginPage
    {
        private readonly IWebDriver _driver;

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public string title => _driver.Title;
        public string Soucre => _driver.PageSource;
        public string UserNameValidator => _driver.FindElement(By.Id("Input_Email-error")).Text;
        public string PassWordValidator => _driver.FindElement(By.Id("Input_Password-error")).Text;
        private const string Url = "https://tekapi.azurewebsites.net/Identity/Account/Login";
        private IWebElement Username => _driver.FindElement(By.Id("Input_Email"));
        private IWebElement Password => _driver.FindElement(By.Id("Input_Password"));
        private IWebElement Button => _driver.FindElement(By.ClassName("btn btn-primary"));
        public void Navigate() => _driver.Navigate().GoToUrl(Url);

        public void UserNameInput(string username) => Username.SendKeys(username);
        public void PassWordInput(string pass) => Password.SendKeys(pass);
        public void Submit() => Button.Click();
    }
}
