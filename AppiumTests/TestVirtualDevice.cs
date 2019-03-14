using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;


namespace AppiumTests
{
    [TestClass]
    public class AppiumTests
    {

        AndroidDriver<AppiumWebElement> _driver;

        [TestMethod]
        public void TestVirtualDevice()
        {
            //Set the capabilities
            DesiredCapabilities cap = new DesiredCapabilities();
            cap.SetCapability("device", "Android");
            cap.SetCapability("platformName", "Android");
            cap.SetCapability("deviceName", "donatello");
            cap.SetCapability("platformVersion", "4.4.4");
            cap.SetCapability("udid", "169.254.76.233:5555");
            cap.SetCapability("chromedriverExecutable", "C:/cd/chromedriver.exe");
           // var options = new ChromeOptions();
            //options.AddArgument("no-sandbox");
            cap.SetCapability(MobileCapabilityType.BrowserName, "Browser");
            _driver = new AndroidDriver<AppiumWebElement>(new Uri("http://127.0.0.1:4723/wd/hub"), cap, TimeSpan.FromSeconds(60));
 
            //Navigate to browser
            _driver.Navigate().GoToUrl("https://www.google.com");
            _driver.FindElementByName("q").SendKeys("Microsoft");
            _driver.FindElementByName("q").SendKeys(Keys.Enter);
            _driver.Quit();
        }
    }
}