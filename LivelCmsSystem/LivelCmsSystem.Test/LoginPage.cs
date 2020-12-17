using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiveCmsSystem.Test
{
    public class LoginPage
    {
        private readonly IWebDriver _driver;

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public string Title => _driver.Title;
        public string Source => _driver.PageSource;
        public string UsernameValidator => _driver.FindElement(By.Id("Input_Email-error")).Text;
        public string PasswordValidator => _driver.FindElement(By.Id("Input_Password-error")).Text;

        private const string URL = "https://localhost:44334/Identity/Account/Login";

        private IWebElement UsernameElement => _driver.FindElement(By.Id("Input_Email"));
        private IWebElement PasswordElement => _driver.FindElement(By.Id("Input_Password"));
        private IWebElement Create => _driver.FindElement(By.ClassName("btn-primary"));
        public void Navigate() => _driver.Navigate().GoToUrl(URL);


        public void UsernameInput(string username) => UsernameElement.SendKeys(username);
        public void PasswordInput(string password) => PasswordElement.SendKeys(password);
        public void Submit() => Create.Click();

    }
}