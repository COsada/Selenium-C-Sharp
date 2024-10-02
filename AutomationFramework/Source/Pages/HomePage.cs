﻿using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutomationFramework.Source.Pages
{
    public class HomePage
    {
        private IWebDriver _driver;

        [FindsBy(How = How.Name, Using = "search_query")]
        private IWebElement _searchBox;
        [FindsBy(How = How.Id, Using = "search-icon-legacy")]
        private IWebElement _searchButton;
        [FindsBy(How = How.XPath, Using = "//*[@id='buttons']/ytd-button-renderer")]
        private IWebElement _signInLink;

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void UseSearchBox (string searchText)
        {
            _searchBox.SendKeys(searchText);
            _searchButton.Click();
        }

        public void ClickSignInLink ()
        {
            _signInLink.Click();
        }
    }
}