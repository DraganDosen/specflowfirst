using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using Microsoft.Extensions.Options;
using NUnitTestProject;



namespace NUnitTestProject.Steps
{
    //internal class RunCalculatorStepDefinition
    //{
    //}
    //AppiumDriver appiumdriver = new AppiumDriver();
    //var driver = appiumdriver.Initializeappium();
    [Binding]
    public sealed class RunCalculatorStepDefinition
    {
        // AppiumOptions options = new AppiumOptions();

        //options.AddAdditionalCapability("app", @"C:\Windows\notepad.exe");
        //WindowsDriver<WindowsElement> myDriver = null; private readonly ScenarioContext _scenarioContext;
        private readonly ScenarioContext _scenarioContext;
        private readonly Calculator _calculator = new Calculator();
        private int _result;
        private int _resultsubstracted;
        public RunCalculatorStepDefinition(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        AppiumDriverClass appiumdriver = new AppiumDriverClass();
        WindowsDriver<WindowsElement> driver;
        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            _calculator.FirstNumber = number;
        }

        [Given(@"the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            _calculator.SecondNumber = number;
        }

        [When(@"the two numbers are substracted")]
        public void WhenTheTwoNumbersAreSubstracted()
        {
            _result = _calculator.Substract();
            
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            // _result.Should().Be(result);
            //var calculatorResult = driver.FindElementByAccessibilityId("CalculatorResults").Text.Replace("Display is", string.Empty).Trim();
             Assert.That(_result, Is.EqualTo(result));
            //_result.Should().Be(result);
        }
        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            _result = _calculator.Add();
        }

        //driver = appiumdriver.Initializeappium();


        // private static WindowsDriver<WindowsElement> sessionCalc;
        [Given("I launch the Windows calculator application")]
        public void GivenLaunchWindowsCalculatorApplication()
        {
            //AppiumDriver appiumdriver = new AppiumDriver();
            //var driver = appiumdriver.Initializeappium();
            // AppiumOptions options = new AppiumOptions();
            //options.AddAdditionalCapability("app", @"C:\Windows\notepad.exe");
            // options.AddAdditionalCapability("app", "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App");
            //sessionCalc = new WindowsDriver<WindowsElement>(
            // var driver = new WindowsDriver<WindowsElement>(
            // new Uri("http://127.0.0.1:4723"), options);
           
            //AppiumDriverClass appiumdriver = new AppiumDriverClass();
            // driver = appiumdriver.Initializeappium();
            Thread.Sleep(2000);

            //}
            //Console.WriteLine("Hello you");
            //var input = Console.ReadLine();
            
        }
        [Given(@"I add new numbers")]
        public void GivenIAddNewNumbers()
        {
            driver = appiumdriver.Initializeappium(); Thread.Sleep(2000);
            driver.FindElementByName("Eight").Click();
            driver.FindElementByName("Plus").Click();
            driver.FindElementByName("Two").Click();
            driver.FindElementByName("Equals").Click();
            var calculatorResult = driver.FindElementByAccessibilityId("CalculatorResults").Text.Replace("Display is", string.Empty).Trim();
            Assert.That(calculatorResult, Is.EqualTo("10"));

            driver.FindElementByName("Five").Click();
            driver.FindElementByName("Plus").Click();
            driver.FindElementByName("Seven").Click();
            driver.FindElementByName("Equals").Click();
            var calculatorResulttwo = driver.FindElementByAccessibilityId("CalculatorResults").Text.Replace("Display is", string.Empty).Trim();
            Assert.That(calculatorResulttwo, Is.EqualTo("12"));
            driver.CloseApp();
        }
        [Given(@"I add multiple numbers")]
        public void GivenIAddMultipleNumbers()
        {
            driver = appiumdriver.Initializeappium(); Thread.Sleep(2000);
            driver.FindElementByName("Five").Click();
            driver.FindElementByName("Multiply by").Click();
            driver.FindElementByName("Two").Click();
            driver.FindElementByName("Equals").Click();
            var calculatorResult = driver.FindElementByAccessibilityId("CalculatorResults").Text.Replace("Display is", string.Empty).Trim();
            Assert.That(calculatorResult, Is.EqualTo("10"));

            driver.FindElementByName("Two").Click();
            driver.FindElementByName("Divide by").Click();
            driver.FindElementByName("Two").Click();
            driver.FindElementByName("Equals").Click();
            var calculatorResultthree = driver.FindElementByAccessibilityId("CalculatorResults").Text.Replace("Display is", string.Empty).Trim();
            Assert.That(calculatorResultthree, Is.EqualTo("1"));
            driver.CloseApp();
        }
        [Given(@"I divide two numbers")]
        public void GivenIDivideTwoNumbers()

        {
            driver = appiumdriver.Initializeappium(); Thread.Sleep(2000);
            driver.FindElementByName("Dva").Click();
            driver.FindElementByName("Dva").Click();
            driver.FindElementByName("Deli").Click();
            driver.FindElementByName("Dva").Click();
            driver.FindElementByName("Jednako").Click();
            var calculatorResult = driver.FindElementByAccessibilityId("CalculatorResults").Text.Replace("Prikaz je", string.Empty).Trim();
            Assert.That(calculatorResult, Is.EqualTo("11"));
            driver.CloseApp();
        }
        [Given(@"exponent")]
        public void GivenExponent()
        {
            driver = appiumdriver.Initializeappium(); Thread.Sleep(2000);
            driver.FindElementByName("Dva").Click();
            driver.FindElementByName("Dva").Click();
            driver.FindElementByName("Kvadrat").Click();
            var calculatorResult = driver.FindElementByAccessibilityId("CalculatorResults").Text.Replace("Prikaz je", string.Empty).Trim();
            Assert.That(calculatorResult, Is.EqualTo("484"));
            driver.CloseApp();
        }
        [Given(@"Given I launch the Windows notepad application")]
        public void GivenGivenILaunchTheWindowsNotepadApplication()
        {


            driver = appiumdriver.Initializenotepad(); Thread.Sleep(2000);
        }  

        [Given(@"Given I launch the Windows loto application")]
        public void GivenGivenILaunchTheWindowsLotoApplication()
        {
            driver = appiumdriver.Initializelotto(); Thread.Sleep(2000);
            
            //string txt = driver.FindElementByName("Morate odabrati koliko brojeva želite.").ToString();

            //Assert.IsTrue(txt != "Morate odabrati koliko brojeva želite.");
            
            
            driver.FindElementByAccessibilityId("checkBox1").Click();
            driver.FindElementByName("Kreni").Click(); Thread.Sleep(2000);
            driver.FindElementByAccessibilityId("checkBox1").Click();
            driver.FindElementByAccessibilityId("checkBox2").Click();
            driver.FindElementByName("Kreni").Click(); Thread.Sleep(1000);
            string originalWindow = driver.CurrentWindowHandle;
            Console.WriteLine("Status : {0}", originalWindow);
            Assert.That(1, Is.EqualTo(driver.WindowHandles.Count));
            driver.FindElementByName("Unos").Click(); Thread.Sleep(5000);
            //driver.SwitchTo().Window("2");
            
            foreach (string window in driver.WindowHandles)
            {
                if (originalWindow != window)
                {
                    driver.SwitchTo().Window(window);
                    Thread.Sleep(2000);
                    string nextWindow = driver.CurrentWindowHandle;
                   Console.WriteLine("Status : {0}", nextWindow);
                   // driver.FindElementByName("Form2").Click(); Thread.Sleep(2000);
                   // driver.FindElementByName("Dodaj").Click(); Thread.Sleep(2000);
                   // driver.FindElementByName("Kreni").Click(); Thread.Sleep(2000);
                   // driver.FindElementByName("Kraj").Click(); Thread.Sleep(1000);
                     break;
                }
            }
            // driver.SwitchTo().Window(driver.WindowHandles);
            // string nextWindow = driver.CurrentWindowHandle;
            // Console.WriteLine("Status : {0}", nextWindow);
            // driver.FindElementByName("Form2").Click(); Thread.Sleep(5000);
            // driver.FindElementByName("8/39").Click(); Thread.Sleep(3000);
           // driver.FindElementByName("Upišite želejne brojeve od kojih će program na slučajan način birati 7").Click(); Thread.Sleep(5000);
            driver.FindElementByAccessibilityId("checkBox1").Click(); Thread.Sleep(3000);
            driver.FindElementByAccessibilityId("checkBox2").Click(); Thread.Sleep(3000);
            driver.FindElementByAccessibilityId("checkBox3").Click(); Thread.Sleep(3000);
            driver.FindElementByName("Dodaj").Click(); Thread.Sleep(3000);
            driver.FindElementByName("OK").Click(); Thread.Sleep(2000);
            //driver.FindElementByName("Kreni").Click(); Thread.Sleep(2000);
            driver.FindElementByName("Kraj").Click(); Thread.Sleep(1000);
        }





    }
}
    

