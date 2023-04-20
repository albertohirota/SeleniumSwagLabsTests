﻿using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SpecFlowBDDAutomationFramework.Utility
{
    public class ExtentReport
    {
        public static ExtentReports? _extentReports;
        public static ExtentTest? _feature;
        public static ExtentTest? _scenario;

        public static String dir = AppDomain.CurrentDomain.BaseDirectory;
        public static String testResultPath = dir.Replace("bin\\Debug\\net6.0", "TestResults");

        public static void ExtentReportInit()
        {
            var htmlReporter = new ExtentHtmlReporter(testResultPath);
            htmlReporter.Config.ReportName = "Automation Swag Lab Test Report";
            htmlReporter.Config.DocumentTitle = "Automation Swag Lab Test Report";
            htmlReporter.Config.Theme = Theme.Standard;
            htmlReporter.Start();

            _extentReports = new ExtentReports();
            _extentReports.AttachReporter(htmlReporter);
            _extentReports.AddSystemInfo("Application", "Swag Labs");
            _extentReports.AddSystemInfo("Framework", "Selenium");
            _extentReports.AddSystemInfo("Step Definitions", "Specflow");
            _extentReports.AddSystemInfo("Characteristics", "Page Object Model");
            _extentReports.AddSystemInfo("OS", "Windows");
            _extentReports.AddSystemInfo("Language", "C#");
        }

        public static void ExtentReportTearDown()
        {
            _extentReports?.Flush();
        }

        public string addScreenshot(IWebDriver driver, ScenarioContext scenarioContext)
        {
            ITakesScreenshot takesScreenshot = (ITakesScreenshot)driver;
            Screenshot screenshot = takesScreenshot.GetScreenshot();
            string screenshotLocation = Path.Combine(testResultPath, scenarioContext.ScenarioInfo.Title + ".png");
            screenshot.SaveAsFile(screenshotLocation, ScreenshotImageFormat.Png);
            return screenshotLocation;
        }


    }
}