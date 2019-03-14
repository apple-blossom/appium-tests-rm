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
    public class AppiumTests2
    {

        AndroidDriver<AppiumWebElement> _driver;

        [TestMethod]
        public void TestRealDevice()
        {
            //Set the capabilities
            DesiredCapabilities cap = new DesiredCapabilities();
            cap.SetCapability("device", "Android");
            cap.SetCapability("platformName", "Android");
            cap.SetCapability("deviceName", "5bf8b201169012a7");
            cap.SetCapability("platformVersion", "8.1.0");
            cap.SetCapability("udid", "5bf8b201169012a7");
            cap.SetCapability("chromedriverExecutable", "C:/cd/chromedriver.exe");
            cap.SetCapability(MobileCapabilityType.BrowserName, "Chrome");
            _driver = new AndroidDriver<AppiumWebElement>(new Uri("http://127.0.0.1:4723/wd/hub"), cap, TimeSpan.FromSeconds(60));

            //Navigate to browser
            _driver.Navigate().GoToUrl("https://www.google.com");
            _driver.FindElementByName("q").SendKeys("Microsoft");
            _driver.FindElementByName("q").SendKeys(Keys.Enter);
            _driver.Quit();
        }
    }
}