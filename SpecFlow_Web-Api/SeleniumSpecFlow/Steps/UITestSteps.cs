using NUnit.Framework;
using SeleniumSpecFlow.Utilities;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;


namespace SeleniumSpecFlow.Steps
{
    [Binding]
    public class UITestSteps : ObjectFactory
    {
        [Given(@"I navigate to sympli-coding-challenge GitHub")]
        public void GivenINavigateToSympli_Coding_ChallengeGitHub()
        {
            //--INFO
            //Navigate to Web Url in AppSetting.json -- Implemented in DriverFactory
        }

        [Given(@"I navigate to (.*) to raise PR")]
        public void GivenINavigateToToRaisePR(string repo)
        {
            GitHub.Value.ScrollToRepoName(repo);
            GitHub.Value.ClickOnRepoName(repo);
        }
        [When(@"I raise new pull request of (.*) and (.*)")]
        public void WhenIRaiseNewPullRequestOfAnd(string source, string target)
        {
            GitHub.Value.ClickOnPullRequestTab();
            GitHub.Value.ClickOnNewPullRequestBtn();
            GitHub.Value.ClickOnSourceBranchBtn();
            GitHub.Value.SelectBranch(source); //Select Source Branch 
            GitHub.Value.ClickOnTargetBranchBtn();
            GitHub.Value.SelectBranch(target); //Select Target Branch
        }
        [Then(@"I should able to see the (.*)")]
        public void ThenIShouldAbleToSeeThe(string actualMessage)
        {
            string expectedMessage = GitHub.Value.GetPremegebilityMessageText();
            Assert.IsTrue(expectedMessage.Contains(actualMessage));
        }

        [Then(@"I should see the pull request raised by clicking '(.*)' button")]
        public void ThenIShouldAbleToSeeeThePullRequestRaisedByClickingButton(string btnName)
        {
            Assert.IsTrue(GitHub.Value.IsViewPullRequestBtnExists, "View Pull Request Button Expected but not present");
            GitHub.Value.ClickViewPullRequestBtn();
            Assert.IsTrue(GitHub.Value.GetExistingPullRequestStatus().Trim().Equals("Open"), "View Pull Request Expected to be Open");
        }


    }
}
