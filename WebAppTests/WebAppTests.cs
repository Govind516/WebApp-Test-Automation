using System;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace WebAppTests
{
    [TestFixture]
    public class FormTests : IDisposable
    {
        private readonly IWebDriver _driver;
        private const string baseUrl = "http://localhost:5175";

        public FormTests()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
        }

        // Test 1 : Check WebPage Title
        [Test]
        public void VerifyWebPageLoadsSuccessfully()
        {
            _driver.Navigate().GoToUrl(baseUrl);
            ClassicAssert.AreEqual("Home Page - WebApplication", _driver.Title);
        }

        // Test 2 : Form Submission when all fields are filled 
        [Test]
        public void SubmitForm_EntersAllFields()
        {
            _driver.Navigate().GoToUrl(baseUrl);
            _driver.FindElement(By.Name("Name")).SendKeys("Narendra Modi");
            Thread.Sleep(1000);
            _driver.FindElement(By.Name("Email")).SendKeys("modiNarendra293@gmail.com");
            Thread.Sleep(1000);
            _driver.FindElement(By.Name("Phone")).SendKeys("1234567890");
            Thread.Sleep(1000);
            _driver.FindElement(By.Name("Company")).SendKeys("BJP Co. Ltd.");
            Thread.Sleep(1000);
            SubmitForm();
            VerifyWelcomeMessage("Narendra Modi");
        }

        // Test 3 : Form Submission when optional fields are empty
        [Test]
        public void SubmitForm_WithoutOptionalFields()
        {
            _driver.Navigate().GoToUrl(baseUrl);
            _driver.FindElement(By.Name("Name")).SendKeys("Govind Gupta");
            Thread.Sleep(1000);
            _driver.FindElement(By.Name("Email")).SendKeys("guptagovind516@gmail.com");
            Thread.Sleep(1000);
            _driver.FindElement(By.Name("Phone")).SendKeys("8006213786");
            Thread.Sleep(1000);
            SubmitForm();
            VerifyWelcomeMessage("Govind Gupta");
        }

        private void SubmitForm()
        {
            _driver.FindElement(By.CssSelector("button[type='submit']")).Click();
        }

        private void VerifyWelcomeMessage(string expectedName)
        {
            // Simulate delay of 3 seconds for the welcome message
            Thread.Sleep(3000);
            var welcomeMessage = _driver.FindElement(By.CssSelector(".alert-success")).Text;
            ClassicAssert.AreEqual($"Welcome, {expectedName}!", welcomeMessage);
        }

        public void Dispose()
        {
            // Clean up resources
            _driver.Quit();
            _driver.Dispose();
        }
    }
}
