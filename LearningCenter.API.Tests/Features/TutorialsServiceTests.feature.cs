﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace LearningCenter.API.Tests.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class TutorialsServiceTestsFeature : object, Xunit.IClassFixture<TutorialsServiceTestsFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "TutorialsServiceTests.feature"
#line hidden
        
        public TutorialsServiceTestsFeature(TutorialsServiceTestsFeature.FixtureData fixtureData, LearningCenter_API_Tests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "TutorialsServiceTests", "As a Developer\nI want to add new Tutorial through API\nIn order to make it availab" +
                    "le for applications.", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public void TestInitialize()
        {
        }
        
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 6
    #line hidden
#line 7
        testRunner.Given("the Endpoint https://localhost:7070/api/v1/tutorials is available", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Add Tutorial with unique Title")]
        [Xunit.TraitAttribute("FeatureTitle", "TutorialsServiceTests")]
        [Xunit.TraitAttribute("Description", "Add Tutorial with unique Title")]
        [Xunit.TraitAttribute("Category", "tutorial-adding")]
        public void AddTutorialWithUniqueTitle()
        {
            string[] tagsOfScenario = new string[] {
                    "tutorial-adding"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Tutorial with unique Title", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 10
    this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 6
    this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                            "Title",
                            "Description",
                            "CategoryId"});
                table1.AddRow(new string[] {
                            "Sample",
                            "A Sample Tutorial",
                            "1"});
#line 11
        testRunner.When("a Post Request is sent", ((string)(null)), table1, "When ");
#line hidden
#line 14
        testRunner.Then("A Response is received with Status 200", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                            "Id",
                            "Title",
                            "Description",
                            "CategoryId"});
                table2.AddRow(new string[] {
                            "1",
                            "Sample",
                            "A Sample Tutorial",
                            "1"});
#line 15
        testRunner.And("a Tutorial Resource is included in Response Body", ((string)(null)), table2, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Add Tutorial with existing Title")]
        [Xunit.TraitAttribute("FeatureTitle", "TutorialsServiceTests")]
        [Xunit.TraitAttribute("Description", "Add Tutorial with existing Title")]
        [Xunit.TraitAttribute("Category", "tutorial-adding")]
        public void AddTutorialWithExistingTitle()
        {
            string[] tagsOfScenario = new string[] {
                    "tutorial-adding"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Tutorial with existing Title", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 20
    this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 6
    this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                            "Id",
                            "Title",
                            "Description",
                            "CategoryId"});
                table3.AddRow(new string[] {
                            "1",
                            "Ultimate",
                            "The Ultimate Tutorial",
                            "1"});
#line 21
        testRunner.Given("A Tutorial is already stored", ((string)(null)), table3, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                            "Title",
                            "Description",
                            "CategoryId"});
                table4.AddRow(new string[] {
                            "Ultimate",
                            "The Ultimate Tutorial",
                            "1"});
#line 24
        testRunner.When("a Post Request is sent", ((string)(null)), table4, "When ");
#line hidden
#line 27
        testRunner.Then("A Response is received with Status 400", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 28
        testRunner.And("An Error Message is returned with value \"Tutorial title already exists.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                TutorialsServiceTestsFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                TutorialsServiceTestsFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
