using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;


namespace SeleniumAdvanced
{
    class HomePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement allProductsField
        {
            get
            {
                return driver.FindElement(By.LinkText("All Products"));
            }
        }
        public HomePage AllProducts()
        {

            allProductsField.Click();

            return new HomePage(driver);
        }
        
        private IWebElement productDeleted

        {
            get
            {
                return driver.FindElement(By.CssSelector("tr:nth-child(79) > td:nth-child(12) > a"));
            }
        }

        public HomePage DeleteProduct() //удаление продукта
        {
            Actions actions = new Actions(driver);
            actions
                .Click(productDeleted)
                .Build()
                .Perform();

            return new HomePage(driver);
        }
    }
}

