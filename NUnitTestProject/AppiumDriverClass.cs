using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using Microsoft.Extensions.Options;

namespace NUnitTestProject
{
    public  class AppiumDriverClass
    {
        public WindowsDriver<WindowsElement> Driver { get; set; } = default!;
        public WindowsDriver<WindowsElement> Initializeappium()
        {

            var options = new AppiumOptions();
            //options.AddAdditionalCapability("app", @"C:\Windows\notepad.exe");
            options.AddAdditionalCapability("app", "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App");
            //sessionCalc = new WindowsDriver<WindowsElement>(
            return new WindowsDriver<WindowsElement>(
             new Uri("http://127.0.0.1:4723"), options);
        }
        public WindowsDriver<WindowsElement> Initializelotto()
        {

            var options = new AppiumOptions();
            //options.AddAdditionalCapability("app", @"C:\Windows\notepad.exe");
            options.AddAdditionalCapability("app", @"C:\Users\ddosen\Downloads\loto.exe");
            //sessionCalc = new WindowsDriver<WindowsElement>(
            return new WindowsDriver<WindowsElement>(
             new Uri("http://127.0.0.1:4723"), options);
        }
    }
}
