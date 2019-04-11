using OpenQA.Selenium;
using SpecflowPages;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecflowTests.AcceptanceTest
{
    [Binding]
    public class SpecFlowFeaturetestcases1
    {
        public IWebElement Skill { get; private set; }

        [Given(@"I clicked on the dropdown tab under Profile page")]
        public void GivenIClickedOnTheDropdownTabUnderProfilePage()
        {
           
        }
        
        [Given(@"I clicked on the language under Profile page")]
        public void GivenIClickedOnTheLanguageUnderProfilePage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I clicked on the skill tab under Profile page")]
        public void GivenIClickedOnTheSkillTabUnderProfilePage()
        {
            //Wait
            Thread.Sleep(1500);

            // Click on Skill tab
            Driver.driver.FindElement(By.XPath("//a[contains(text(),'Skills')]")).Click();

        }

        [When(@"I add a skill")]
        public void WhenIAddASkill()
        {
            //Add new skill
            Driver.driver.FindElement(By.XPath("//div[@class='ui teal button']")).Click();

            //Add skill
            Driver.driver.FindElement(By.XPath("//input[@placeholder='Add Skill']")).SendKeys("Automation Testing");
            
            //Choose the skill level
            
            Driver.driver.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option"))[2].Click();

            //Final add
            Driver.driver.FindElement(By.XPath("//input[@value='Add']")).Click();
            
        }

        [Then(@"that skill should be displayed on my listings")]
        public void ThenThatSkillShouldBeDisplayedOnMyListings()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I clicked on the Education tab under Profile page")]
        public void GivenIClickedOnTheEducationTabUnderProfilePage()
        {
            //Click on Education Tab
            Driver.driver.FindElement(By.XPath("//a[@class='item'][contains(text(),'Education')]")).Click();
        }
        
        [Given(@"I clicked on the Educaton tab under profile page")]
        public void GivenIClickedOnTheEducatonTabUnderProfilePage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I clicked onthe dropdown menu of country of university or college")]
        public void GivenIClickedOntheDropdownMenuOfCountryOfUniversityOrCollege()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I upadte a laguage level")]
        public void WhenIUpadteALaguageLevel()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I add another new laguage")]
        public void WhenIAddAnotherNewLaguage()
        {
            ScenarioContext.Current.Pending();
        }
        
        

        [When(@"I add a new skill")]
        public void WhenIAddANewSkill()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I change a skill level")]
        public void WhenIChangeASkillLevel()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I add Education")]
        public void WhenIAddEducation()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I add University or college")]
        public void WhenIAddUniversityOrCollege()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I add the country of University or college")]
        public void WhenIAddTheCountryOfUniversityOrCollege()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"that should be displayed on my listings")]
        public void ThenThatShouldBeDisplayedOnMyListings()
        {
            ScenarioContext.Current.Pending();
        }
        
       
        
        [Then(@"that updated level should be displayed on my listings")]
        public void ThenThatUpdatedLevelShouldBeDisplayedOnMyListings()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"all the options should be displayed under education tab")]
        public void ThenAllTheOptionsShouldBeDisplayedUnderEducationTab()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"that particular university or college should be displayed")]
        public void ThenThatParticularUniversityOrCollegeShouldBeDisplayed()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"It should display all the listed countries")]
        public void ThenItShouldDisplayAllTheListedCountries()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
