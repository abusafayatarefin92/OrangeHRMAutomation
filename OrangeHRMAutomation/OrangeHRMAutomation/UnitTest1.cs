using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace OrangeHRMAutomation
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ApplyLeave()
        {
            IWebDriver driver = new EdgeDriver();

            //Go to the website
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();

            //Login page
            driver.FindElement(By.XPath("(//input[@placeholder='Username'])[1]")).SendKeys("Admin");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            driver.FindElement(By.XPath("(//input[@placeholder='Password'])[1]")).SendKeys("admin123");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            driver.FindElement(By.XPath("(//button[normalize-space()='Login'])[1]")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Apply Leave
            driver.FindElement(By.XPath("//a[normalize-space()='Leave']")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("(//a[normalize-space()='Apply'])[1]")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            
            driver.FindElement(By.XPath("(//div[@class='oxd-select-text-input'])[1]")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            driver.FindElement(By.XPath("(//div[@role='listbox'])[1]")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            driver.FindElement(By.XPath("(//input[@placeholder='yyyy-dd-mm'])[1]")).SendKeys("2024-02-12");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            driver.FindElement(By.XPath("(//textarea[@class='oxd-textarea oxd-textarea--active oxd-textarea--resize-vertical'])[1]")).SendKeys("2024-02-12");

            driver.FindElement(By.XPath("//button[normalize-space()='Apply']")).Submit();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

        }
    }
}