using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;


namespace SumCalculationHomeWork
{
    public class SumHW
    {
        [Test]
        public static void SeleniumDemoTest1()
        {
            string valueOfA = "2";
            string valueOfB = "2";
            string expectedResult = "4";

            IWebDriver firefox = new FirefoxDriver();
            firefox.Manage().Window.Maximize();
            firefox.Url = "https://www.seleniumeasy.com/test/basic-first-form-demo.html";

            // Test passes even without closing popup
            WebDriverWait wait = new WebDriverWait(firefox, TimeSpan.FromSeconds(10));
            IWebElement closePopUpButton = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("at-cv-lightbox-close")));
            closePopUpButton.Click();

            // Find elements
            IWebElement sum1InputField = firefox.FindElement(By.Id("sum1"));
            sum1InputField.SendKeys(valueOfA);

            IWebElement sum2InputField = firefox.FindElement(By.Id("sum2"));
            sum2InputField.SendKeys(valueOfB);

            // CSSSelector button.btn:nth-child(3)
            IWebElement getTotalButton = firefox.FindElement(By.CssSelector("button.btn:nth-child(3)"));
            getTotalButton.Click();

            // #displayvalue
            IWebElement resultText = firefox.FindElement(By.Id("displayvalue"));

            Assert.AreEqual(expectedResult, resultText.Text, "Wrong answer");

            firefox.Close();
        }

        [Test]
        public static void SeleniumDemoTest2()
        {
            string valueOfA = "-5";
            string valueOfB = "3";
            string expectedResult = "-2";

            IWebDriver firefox = new FirefoxDriver();
            firefox.Manage().Window.Maximize();
            firefox.Url = "https://www.seleniumeasy.com/test/basic-first-form-demo.html";

            // Test passes even without closing popup
            WebDriverWait wait = new WebDriverWait(firefox, TimeSpan.FromSeconds(10));
            IWebElement closePopUpButton = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("at-cv-lightbox-close")));
            closePopUpButton.Click();

            // Find elements
            IWebElement sum1InputField = firefox.FindElement(By.Id("sum1"));
            sum1InputField.SendKeys(valueOfA);

            IWebElement sum2InputField = firefox.FindElement(By.Id("sum2"));
            sum2InputField.SendKeys(valueOfB);

            // CSSSelector button.btn:nth-child(3)
            IWebElement getTotalButton = firefox.FindElement(By.CssSelector("button.btn:nth-child(3)"));
            getTotalButton.Click();

            // #displayvalue
            IWebElement resultText = firefox.FindElement(By.Id("displayvalue"));

            Assert.AreEqual(expectedResult, resultText.Text, "Wrong answer");

            firefox.Close();
        }

        [Test]
        public static void SeleniumDemoTest3()
        {
            string valueOfA = "a";
            string valueOfB = "b";
            string expectedResult = "NaN";

            IWebDriver firefox = new FirefoxDriver();
            firefox.Manage().Window.Maximize();
            firefox.Url = "https://www.seleniumeasy.com/test/basic-first-form-demo.html";

            // Test passes even without closing popup
            WebDriverWait wait = new WebDriverWait(firefox, TimeSpan.FromSeconds(10));
            IWebElement closePopUpButton = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("at-cv-lightbox-close")));
            closePopUpButton.Click();

            // Find elements
            IWebElement sum1InputField = firefox.FindElement(By.Id("sum1"));
            sum1InputField.SendKeys(valueOfA);

            IWebElement sum2InputField = firefox.FindElement(By.Id("sum2"));
            sum2InputField.SendKeys(valueOfB);

            // CSSSelector button.btn:nth-child(3)
            IWebElement getTotalButton = firefox.FindElement(By.CssSelector("button.btn:nth-child(3)"));
            getTotalButton.Click();

            // #displayvalue
            IWebElement resultText = firefox.FindElement(By.Id("displayvalue"));

            Assert.AreEqual(expectedResult, resultText.Text, "Wrong answer");

            firefox.Close();
        }
    }
}
