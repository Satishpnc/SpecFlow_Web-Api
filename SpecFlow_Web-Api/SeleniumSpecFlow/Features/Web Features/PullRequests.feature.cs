﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.5.0.0
//      SpecFlow Generator Version:3.5.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace TestLibrary.Features.WebFeatures
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.5.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Validate Pull Requests Functionality")]
    [NUnit.Framework.CategoryAttribute("web")]
    public partial class ValidatePullRequestsFunctionalityFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = new string[] {
                "web"};
        
#line 1 "PullRequests.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/Web Features", "Validate Pull Requests Functionality", null, ProgrammingLanguage.CSharp, new string[] {
                        "web"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 4
#line hidden
#line 5
 testRunner.Given("I navigate to sympli-coding-challenge GitHub", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Validate there should be different source and target branch(s) while raising PR")]
        [NUnit.Framework.CategoryAttribute("Web_GitHub")]
        [NUnit.Framework.TestCaseAttribute("QA-CC-V1-OperaHouse", "master", "develop", "Able to merge", null)]
        [NUnit.Framework.TestCaseAttribute("QA-CC-V1-OperaHouse", "master", "master", "You’ll need to use two different branch names to get a valid comparison.", null)]
        [NUnit.Framework.TestCaseAttribute("QA-CC-V1-Campbelltown", "develop", "sympli-cc-qa-write-patch-1", "Can’t automatically merge.", null)]
        public virtual void ValidateThereShouldBeDifferentSourceAndTargetBranchSWhileRaisingPR(string repo, string source_Branch, string target_Branch, string message, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Web_GitHub"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("repo", repo);
            argumentsOfScenario.Add("source_branch", source_Branch);
            argumentsOfScenario.Add("target_branch", target_Branch);
            argumentsOfScenario.Add("message", message);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Validate there should be different source and target branch(s) while raising PR", null, tagsOfScenario, argumentsOfScenario);
#line 8
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
#line 9
 testRunner.Given(string.Format("I navigate to {0} to raise PR", repo), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 10
 testRunner.When(string.Format("I raise new pull request of {0} and {1}", source_Branch, target_Branch), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 11
 testRunner.Then(string.Format("I should able to see the {0}", message), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Validate there should have different commits in source and target while raising P" +
            "R")]
        [NUnit.Framework.CategoryAttribute("Web_GitHub")]
        [NUnit.Framework.TestCaseAttribute("QA-CC-V1-HarbourBridge", "master", "develop", "master and develop are identical.", null)]
        [NUnit.Framework.TestCaseAttribute("QA-CC-V1-Kakadu", "main", "develop", "Able to merge", null)]
        public virtual void ValidateThereShouldHaveDifferentCommitsInSourceAndTargetWhileRaisingPR(string repo, string source_Branch, string target_Branch, string message, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Web_GitHub"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("repo", repo);
            argumentsOfScenario.Add("source_branch", source_Branch);
            argumentsOfScenario.Add("target_branch", target_Branch);
            argumentsOfScenario.Add("message", message);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Validate there should have different commits in source and target while raising P" +
                    "R", null, tagsOfScenario, argumentsOfScenario);
#line 20
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
#line 21
 testRunner.Given(string.Format("I navigate to {0} to raise PR", repo), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 22
 testRunner.When(string.Format("I raise new pull request of {0} and {1}", source_Branch, target_Branch), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 23
 testRunner.Then(string.Format("I should able to see the {0}", message), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Validate duplicate PR prompts interactive message and user can able to see it wit" +
            "h a click")]
        [NUnit.Framework.CategoryAttribute("Web_GitHub")]
        [NUnit.Framework.TestCaseAttribute("QA-CC-V1-Campbelltown", "master", "develop", "Able to merge.", null)]
        public virtual void ValidateDuplicatePRPromptsInteractiveMessageAndUserCanAbleToSeeItWithAClick(string repo, string source_Branch, string target_Branch, string message, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Web_GitHub"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("repo", repo);
            argumentsOfScenario.Add("source_branch", source_Branch);
            argumentsOfScenario.Add("target_branch", target_Branch);
            argumentsOfScenario.Add("message", message);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Validate duplicate PR prompts interactive message and user can able to see it wit" +
                    "h a click", null, tagsOfScenario, argumentsOfScenario);
#line 31
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
#line 32
 testRunner.Given(string.Format("I navigate to {0} to raise PR", repo), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 33
 testRunner.When(string.Format("I raise new pull request of {0} and {1}", source_Branch, target_Branch), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 34
 testRunner.Then(string.Format("I should able to see the {0}", message), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 35
 testRunner.And("I should see the pull request raised by clicking \'View pull request\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Validate PR can\'t be raised for empty repo")]
        [NUnit.Framework.CategoryAttribute("Web_GitHub")]
        [NUnit.Framework.TestCaseAttribute("QA-CC-V1-OperaHouse", "master", "develop", "Able to merge", null)]
        [NUnit.Framework.TestCaseAttribute("QA-CC-V1-OperaHouse", "master", "master", "You’ll need to use two different branch names to get a valid comparison.", null)]
        public virtual void ValidatePRCantBeRaisedForEmptyRepo(string repo, string source_Branch, string target_Branch, string message, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Web_GitHub"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("repo", repo);
            argumentsOfScenario.Add("source_branch", source_Branch);
            argumentsOfScenario.Add("target_branch", target_Branch);
            argumentsOfScenario.Add("message", message);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Validate PR can\'t be raised for empty repo", null, tagsOfScenario, argumentsOfScenario);
#line 42
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
#line 43
 testRunner.Given(string.Format("I navigate to {0} to raise PR", repo), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 44
 testRunner.When(string.Format("I raise new pull request of {0} and {1}", source_Branch, target_Branch), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 45
 testRunner.Then(string.Format("I should able to see the {0}", message), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
