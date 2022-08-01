using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using AventStack.ExtentReports;
using TideBDDSpecflow.Utilities;

namespace TideBDDSpecflow.Hooks
{
    [Binding]
    public sealed class HooksFile
    {
        public static IWebDriver driver;
        public static ExtentReports extents;
        public static ExtentTest feature;
        public static ExtentTest scenario;
        public static ExtentReport extentRepo = new ExtentReport();
        public static LogFile log = new LogFile();
        [BeforeFeature]
        public static void featureBrowser(FeatureContext featureContext)
        {
            extentRepo.beforFeatureextent(featureContext);
            log.beforeFeaturelog(featureContext);
        }
        [BeforeScenario]
        public static void BeforeScenario(ScenarioContext scenarioContext)
        {
            extentRepo.beforeScenarioExtent(scenarioContext);
            log.BeforeScenarioLog(scenarioContext);
            driver = new ChromeDriver();
        }
        [BeforeTestRun]
        public static void Report()
        {
            extentRepo.ExtentRepo();
            log.BeforeTestrunlog();
        }
        [AfterTestRun]
        public static void etentReportFlush()
        {
            extents.Flush();
        }
        [AfterStep]
        public static void reportSteps(ScenarioContext scenarioContext)
        {
            extentRepo.ExtentRepoAfterStep(scenarioContext);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }
    }
    
}
