using TechTalk.SpecFlow;
using TideBDDSpecflow.POM;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TideBDDSpecflow.Hooks;
using System.Threading;
using TideBDDSpecflow.Utilities;
using TechTalk.SpecFlow;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;



namespace TideBDDSpecflow.Steps
{
    [Binding]
    public class TideStepDefinitions
    {
        DriverClass Baseobject = new DriverClass();
        ScreenShotClass ScrObject = new ScreenShotClass();

        [Given(@"Load the website")]
        public void GivenLoadTheWebsite()
       {
            Baseobject.WebsiteLoad();
       }

        [Given(@"user click on language")]
        public void GivenUserClickOnLanguage()
        {
            Baseobject.LaguageChange_();
        }

        [When(@"user select language")]
        public void WhenUserSelectLanguage()
        {
            Baseobject.SelectLang();
        }

        [Then(@"websites language changed")]
        public void ThenWebsitesLanguageChanged()
        {
            ScrObject .ScrnShot1();
        }
        [Given(@"Lunch the tide website")]
        public void GivenLunchTheTideWebsite()
        {
            Baseobject.WebsiteLoad();
        }



        [Given(@"hover mouse pointer on the shop product")]
        public void GivenHoverMousePointerOnTheShopProduct()
        {
            Baseobject.ShopProducts();
        }

        [When(@"click on pacs  product")]
        public void WhenClickOnPacsProduct()
        {
            Baseobject.ShopProductsClick();
        }

        [Then(@"result for pacs product displayed")]
        public void ThenResultForPacsProductDisplayed()
        {
            ScrObject.ScrnShot2();
        }

        [Given(@"Open browser and open Website")]
        public void GivenOpenBrowserAndOpenWebsite()
        {
            Baseobject.WebsiteLoad();
        }

        [Given(@"hover mouse pointer on the our commitment")]
        public void GivenHoverMousePointerOnTheOurCommitment()
        {
            Baseobject.OurCommitmentHover();
        }

        [When(@"click on our ambition")]
        public void WhenClickOnOurAmbition()
        {
            Baseobject.OurCommitment();
        }

        [Then(@"our ambtion displayed")]
        public void ThenOurAmbtionDisplayed()
        {
            Baseobject.OurCommitmentAssert();
        }
        [Given(@"Open  The Website")]
        public void GivenOpenTheWebsite()
        {
            Baseobject.WebsiteLoad();
        }

        [Given(@"hover mouse pointer on the how to wash clothes")]
        public void GivenHoverMousePointerOnTheHowToWashClothes()
        {
            Baseobject.WashClothes();
        }

        [When(@"click on how to remove stains")]
        public void WhenClickOnHowToRemoveStains()
        {
            Baseobject. WashClothe();
        }

        [Then(@"Information for How to remove stain dispalyed")]
        public void ThenInformationForHowToRemoveStainDispalyed()
        {
            ScrObject.ScrnShot3();
        }
       
        [Given(@"open the web")]
        public void GivenOpenTheWeb()
        {
            Baseobject.WebsiteLoad();
        }


        [Given(@"click on Coupons and rewards")]
        public void GivenClickOnCouponsAndRewards()
        {
            Baseobject.Cupons();
        }

        [When(@"click on save now")]
        public void WhenClickOnSaveNow()
        {
            Baseobject.CuponsSelect();
        }

        [Then(@"page redirected on log in page")]
        public void ThenPageRedirectedOnLogInPage()
        {
            ScrObject.ScrnShot4();
        }
        [Given(@"Open  the Tide Website")]
        public void GivenOpenTheTideWebsite()
        {
            Baseobject.WebsiteLoad();
        }

        [When(@"Click on Live Chat")]
        public void WhenClickOnLiveChat()
        {
            Baseobject.LiveChat();
        }

        [Then(@"Page redirected on Live chat page")]
        public void ThenPageRedirectedOnLiveChatPage()
        {
            ScrObject. ScrnShot5();
        }
        [Given(@"Open the Tidecom website")]
        public void GivenOpenTheTidecomWebsite()
        {
            Baseobject.WebsiteLoad();
        }
        [Given(@"click on website language")]
        public void GivenClickOnWebsiteLanguage()
        {
            Baseobject.LaguageChange();
        }

        [When(@"user select the language")]
        public void WhenUserSelectTheLanguage()
        {
           
            Baseobject.LaguageChangeClick();
        }

        [Then(@"language shown in the selected language")]
        public void ThenLanguageShownInTheSelectedLanguage()
        {
            ScrObject.ScrnShot6();
        }

        [Given(@"load the tidecom website")]
        public void GivenLoadTheTidecomWebsite()
        {
            Baseobject.WebsiteLoad();
        }

        [Given(@"Enter the product name in the search box")]
        public void GivenEnterTheProductNameInTheSearchBox()
        {
            Baseobject. SearchBox();
        }

        [When(@"click on the search icon")]
        public void WhenClickOnTheSearchIcon()
        {
            Baseobject.SearchIcon();
        }

        [Then(@"result for Searched product displayed")]
        public void ThenResultForSearchedProductDisplayed()
        {
            
        }
    }
}











