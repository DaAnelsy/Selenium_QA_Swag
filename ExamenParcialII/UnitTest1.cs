using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class LoginExitoso
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
            baseURL = "https://www.google.com/";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void TheLoginExitosoTest()
        {
            //dado que se ingresa a la pagina de login
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            driver.FindElement(By.Id("user-name")).Click();
            driver.FindElement(By.Id("user-name")).Clear();
            //ingresar la cuenta de usuario "standard_user" 
            driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
            driver.FindElement(By.Id("password")).Clear();
            driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            driver.FindElement(By.Id("password")).Click();
            driver.FindElement(By.Id("login-button")).Click();
            //Entonces el sistema debe mostrar los productos
            driver.FindElement(By.XPath("//div[@id='header_container']/div[2]/span")).Click();
            Assert.AreEqual("Swag Labs", driver.Title);

        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }

    [TestFixture]
    public class ErrorInicioSeccion
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
            baseURL = "https://www.google.com/";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void TheErrorInicioSeccionTest()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            driver.FindElement(By.Id("user-name")).Click();
            driver.FindElement(By.Id("user-name")).Clear();
            driver.FindElement(By.Id("user-name")).SendKeys("invalid_user");
            driver.FindElement(By.Id("password")).Click();
            driver.FindElement(By.Id("password")).Clear();
            driver.FindElement(By.Id("password")).SendKeys("wrong_password");
            driver.FindElement(By.Id("login-button")).Click();
            driver.FindElement(By.XPath("//div[@id='root']/div/div[2]/div")).Click();
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }

    [TestFixture]
    public class AgregarProductoCarrito
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
            baseURL = "https://www.google.com/";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void TheAgregarProductoCarritoTest()
        {
            //dado que se ingresa a la pagina de login
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            driver.FindElement(By.Id("user-name")).Click();
            driver.FindElement(By.Id("user-name")).Clear();
            //ingresar la cuenta de usuario "standard_user" y password 
            driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
            driver.FindElement(By.Id("password")).Clear();
            driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            driver.FindElement(By.Id("password")).Click();
            driver.FindElement(By.Id("login-button")).Click();
            //Entonces el sistema debe mostrar Sauce Labs Backpack y mostrar 1 al carrito
            driver.FindElement(By.XPath("//div[@id='header_container']/div[2]/span")).Click();
            driver.FindElement(By.Id("react-burger-menu-btn")).Click();
            driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack")).Click();
            driver.FindElement(By.LinkText("1")).Click();
            driver.FindElement(By.XPath("//div[@id='cart_contents_container']/div/div/div")).Click();
            driver.FindElement(By.XPath("//div[@id='cart_contents_container']/div/div/div[3]")).Click();
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }


    [TestFixture]
    public class FinalizarCompra
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
            baseURL = "https://www.google.com/";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void TheFinalizarCompraTest()
        {
            //dado que se ingresa a la pagina de login
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            driver.FindElement(By.Id("user-name")).Click();
            driver.FindElement(By.Id("user-name")).Clear();
            //ingresar la cuenta de usuario "standard_user" y password 
            driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
            driver.FindElement(By.Id("password")).Clear();
            driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            driver.FindElement(By.Id("password")).Click();
            driver.FindElement(By.Id("login-button")).Click();
            //Entonces el sistema debe mostrar Sauce Labs Backpack y mostrar 1 al carrito
            driver.FindElement(By.XPath("//div[@id='header_container']/div[2]/span")).Click();
            driver.FindElement(By.Id("react-burger-menu-btn")).Click();
            driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack")).Click();
            driver.FindElement(By.LinkText("1")).Click();
            driver.FindElement(By.XPath("//div[@id='cart_contents_container']/div/div/div")).Click();
            driver.FindElement(By.XPath("//div[@id='cart_contents_container']/div/div/div[3]")).Click();
            driver.FindElement(By.XPath("//div[@id='cart_contents_container']/div")).Click();
            driver.FindElement(By.Id("checkout")).Click();
            driver.FindElement(By.Id("first-name")).Click();
            driver.FindElement(By.Id("first-name")).Clear();
            driver.FindElement(By.Id("first-name")).SendKeys("Daisy Abigail");
            driver.FindElement(By.Id("last-name")).Click();
            driver.FindElement(By.Id("last-name")).Clear();
            driver.FindElement(By.Id("last-name")).SendKeys("Racancoj Lopez");
            driver.FindElement(By.Id("postal-code")).Click();
            driver.FindElement(By.Id("postal-code")).Clear();
            driver.FindElement(By.Id("postal-code")).SendKeys("09001");
            driver.FindElement(By.Id("continue")).Click();
            driver.FindElement(By.XPath("//div[@id='checkout_summary_container']/div/div/div[3]")).Click();
            driver.FindElement(By.Id("finish")).Click();
            driver.FindElement(By.Id("checkout_complete_container")).Click();
            driver.FindElement(By.XPath("//div[@id='header_container']/div[2]")).Click();
            driver.FindElement(By.Id("checkout_complete_container")).Click();
            //Entonces el sistema debe mostrar los productos
            Assert.AreEqual("THANK YOU FOR YOUR ORDER", driver.Title);
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }

}
