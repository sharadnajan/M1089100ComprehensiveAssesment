using System;
using System.Collections.Generic;
using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TideBDDSpecflow.Hooks;
using System.Threading;
using WDSE.Decorators;
using WDSE.ScreenshotMaker;
using ImageMagick;
using OpenQA.Selenium.Support.Extensions;
using WDSE;

namespace TideBDDSpecflow.Utilities
{
    public class ScreenShotClass
    {
        public void ScrnShot1()
        {
            VerticalCombineDecorator comdeco = new VerticalCombineDecorator(new ScreenshotMaker().RemoveScrollBarsWhileShooting());
            var Format = MagickFormat.Jpg;
            HooksFile.driver.TakeScreenshot(comdeco).ToMagickImage().Write(@"C:\Users\mindc1may134\source\repos\TideBDDSpecflow\TideBDDSpecflow\Utilities\Scr1.Jpg", Format);
        }
        public void ScrnShot2()
        {
            VerticalCombineDecorator comdeco = new VerticalCombineDecorator(new ScreenshotMaker().RemoveScrollBarsWhileShooting());
            var Format = MagickFormat.Jpg;
            HooksFile.driver.TakeScreenshot(comdeco).ToMagickImage().Write(@"C:\Users\mindc1may134\source\repos\TideBDDSpecflow\TideBDDSpecflow\Utilities\Scr2.Jpg", Format);
        }
        public void ScrnShot3()
        {
            VerticalCombineDecorator comdeco = new VerticalCombineDecorator(new ScreenshotMaker().RemoveScrollBarsWhileShooting());
            //var Format = MagickFormat.Jpg;
            HooksFile.driver.TakeScreenshot(comdeco).ToMagickImage().Write(@"C:\Users\mindc1may134\source\repos\TideBDDSpecflow\TideBDDSpecflow\Utilities\Scr3.Jpg");
        }
        public void ScrnShot4()
        {
            VerticalCombineDecorator comdeco = new VerticalCombineDecorator(new ScreenshotMaker().RemoveScrollBarsWhileShooting());
            //var Format = MagickFormat.Jpg;
            HooksFile.driver.TakeScreenshot(comdeco).ToMagickImage().Write(@"C:\Users\mindc1may134\source\repos\TideBDDSpecflow\TideBDDSpecflow\Utilities\Scr4.Jpg");
        }
        public void ScrnShot5()
        {
            VerticalCombineDecorator comdeco = new VerticalCombineDecorator(new ScreenshotMaker().RemoveScrollBarsWhileShooting());
            //var Format = MagickFormat.Jpg;
            HooksFile.driver.TakeScreenshot(comdeco).ToMagickImage().Write(@"C:\Users\mindc1may134\source\repos\TideBDDSpecflow\TideBDDSpecflow\Utilities\Scr5.Jpg");
        }
        public void ScrnShot6()
        {
            VerticalCombineDecorator comdeco = new VerticalCombineDecorator(new ScreenshotMaker().RemoveScrollBarsWhileShooting());
            //var Format = MagickFormat.Jpg;
            HooksFile.driver.TakeScreenshot(comdeco).ToMagickImage().Write(@"C:\Users\mindc1may134\source\repos\TideBDDSpecflow\TideBDDSpecflow\Utilities\Scr6.Jpg");
        }
        public void ScrnShot7()
        {
            VerticalCombineDecorator comdeco = new VerticalCombineDecorator(new ScreenshotMaker().RemoveScrollBarsWhileShooting());
            //var Format = MagickFormat.Jpg;
            HooksFile.driver.TakeScreenshot(comdeco).ToMagickImage().Write(@"C:\Users\mindc1may134\source\repos\TideBDDSpecflow\TideBDDSpecflow\Utilities\Scr7.Jpg");
        }
    }
}
