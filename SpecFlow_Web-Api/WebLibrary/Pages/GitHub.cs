using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebLibrary
{
    public class GitHub
    {

        public IWebDriver WebDriver { get; }

        public GitHub(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        private string Repo = "//a[contains(text(),'REPONAME')]";
        private string BranchToSelect = "(//span[contains(@class, 'select-menu-item-text') and (text()='BranchName')])[1]";
        private IWebElement PullRequestTab => WebDriver.FindElement(By.XPath("//span[contains(text(),'Pull requests')]"));
        private IWebElement NewPullRequestBtn => WebDriver.FindElement(By.XPath("//span[contains(text(),'New pull request')]"));
        private IList<IWebElement> PullRequestBannerElements => WebDriver.FindElements(By.CssSelector(".range-editor.text-gray.js-range-editor > div"));
        private IWebElement PreMergebilityValidationMsg => WebDriver.FindElement(By.XPath("//div[@class='pre-mergability']/strong"));

        private IWebElement ViewPullRequestBtn => WebDriver.FindElement(By.XPath("//a[@class='btn btn-primary']"));

        private IWebElement PreMergebilityValidationInnerMsg => WebDriver.FindElement(By.XPath("//div[@class='blankslate ']/p"));

        private IWebElement pullRequestStatus => WebDriver.FindElement(By.CssSelector(".gh-header-meta span.State"));

        public void ScrollToRepoName(string repoName)
        {
            IWebElement repo = WebDriver.FindElement(By.XPath(Repo.Replace("REPONAME", repoName)));
            ((IJavaScriptExecutor)WebDriver).ExecuteScript("arguments[0].scrollIntoView(true);", repo);
        }
        public void ClickOnRepoName(string repoName) => WebDriver.FindElement(By.XPath(Repo.Replace("REPONAME", repoName))).Click();

        public void ClickOnPullRequestTab() => PullRequestTab.Click();

        public void ClickOnNewPullRequestBtn() => NewPullRequestBtn.Click();

        public void ScrollTo(string xPixels, string yPixels)
        {
            ((IJavaScriptExecutor)WebDriver).ExecuteScript("window.scrollBy("+xPixels+","+yPixels+")");
        }

        public void ClickOnSourceBranchBtn() {
            WebDriver.FindElement(By.CssSelector(".range-editor .range-cross-repo-pair:nth-of-type(1) summary.btn.btn-sm.select-menu-button.branch span")).Click();
            System.Threading.Thread.Sleep(1000);
        }

        public void ClickOnTargetBranchBtn() {
            WebDriver.FindElement(By.CssSelector(".range-editor .range-cross-repo-pair:nth-of-type(2) summary.btn.btn-sm.select-menu-button.branch span")).Click();
            System.Threading.Thread.Sleep(1000);
        }

        public void SelectBranch(string branchName){
            WebDriver.FindElement(By.XPath(BranchToSelect.Replace("BranchName", branchName))).Click();
            System.Threading.Thread.Sleep(2000);
        }

        public string GetPremegebilityMessageText() {
            try
            {
                return PullRequestBannerElements.Count == 3 ?
                    PreMergebilityValidationMsg.Text.Trim() :
                    PreMergebilityValidationInnerMsg.Text.Trim();
            }
            catch (Exception)
            {
               return PreMergebilityValidationInnerMsg.Text.Trim();
            }
        }
        public bool IsViewPullRequestBtnExists => ViewPullRequestBtn.Displayed;

        public void ClickViewPullRequestBtn() => ViewPullRequestBtn.Click();

        public string GetExistingPullRequestStatus() => pullRequestStatus.Text; 

    }
}
