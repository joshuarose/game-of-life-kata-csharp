﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.34014
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace GameOfLife.Specs.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Cell configurations that are static")]
    public partial class CellConfigurationsThatAreStaticFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "static_structures.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Cell configurations that are static", "In order to create a functioning rules engine  \r\nAs a programmer of Conway\'s Game" +
                    " of Life  \r\nI can see static structures surviving in my world", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
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
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Block")]
        public virtual void Block()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Block", ((string[])(null)));
#line 6
  this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        ".",
                        ".",
                        ".",
                        ".",
                        "."});
            table1.AddRow(new string[] {
                        ".",
                        "x",
                        "x",
                        ".",
                        "."});
            table1.AddRow(new string[] {
                        ".",
                        "x",
                        "x",
                        ".",
                        "."});
            table1.AddRow(new string[] {
                        ".",
                        ".",
                        ".",
                        ".",
                        "."});
            table1.AddRow(new string[] {
                        ".",
                        ".",
                        ".",
                        ".",
                        "."});
#line 7
    testRunner.Given("the following setup", ((string)(null)), table1, "Given ");
#line 13
    testRunner.When("I evolve the board", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        ".",
                        ".",
                        ".",
                        ".",
                        "."});
            table2.AddRow(new string[] {
                        ".",
                        "x",
                        "x",
                        ".",
                        "."});
            table2.AddRow(new string[] {
                        ".",
                        "x",
                        "x",
                        ".",
                        "."});
            table2.AddRow(new string[] {
                        ".",
                        ".",
                        ".",
                        ".",
                        "."});
            table2.AddRow(new string[] {
                        ".",
                        ".",
                        ".",
                        ".",
                        "."});
#line 14
    testRunner.Then("I should see the following board", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Beehive")]
        public virtual void Beehive()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Beehive", ((string[])(null)));
#line 21
  this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        ".",
                        ".",
                        ".",
                        ".",
                        ".",
                        "."});
            table3.AddRow(new string[] {
                        ".",
                        ".",
                        "x",
                        "x",
                        ".",
                        "."});
            table3.AddRow(new string[] {
                        ".",
                        "x",
                        ".",
                        ".",
                        "x",
                        "."});
            table3.AddRow(new string[] {
                        ".",
                        ".",
                        "x",
                        "x",
                        ".",
                        "."});
            table3.AddRow(new string[] {
                        ".",
                        ".",
                        ".",
                        ".",
                        ".",
                        "."});
#line 22
    testRunner.Given("the following setup", ((string)(null)), table3, "Given ");
#line 28
    testRunner.When("I evolve the board", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        ".",
                        ".",
                        ".",
                        ".",
                        ".",
                        "."});
            table4.AddRow(new string[] {
                        ".",
                        ".",
                        "x",
                        "x",
                        ".",
                        "."});
            table4.AddRow(new string[] {
                        ".",
                        "x",
                        ".",
                        ".",
                        "x",
                        "."});
            table4.AddRow(new string[] {
                        ".",
                        ".",
                        "x",
                        "x",
                        ".",
                        "."});
            table4.AddRow(new string[] {
                        ".",
                        ".",
                        ".",
                        ".",
                        ".",
                        "."});
#line 29
    testRunner.Then("I should see the following board", ((string)(null)), table4, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Loaf")]
        public virtual void Loaf()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Loaf", ((string[])(null)));
#line 36
  this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        ".",
                        ".",
                        ".",
                        ".",
                        ".",
                        "."});
            table5.AddRow(new string[] {
                        ".",
                        ".",
                        "x",
                        "x",
                        ".",
                        "."});
            table5.AddRow(new string[] {
                        ".",
                        "x",
                        ".",
                        ".",
                        "x",
                        "."});
            table5.AddRow(new string[] {
                        ".",
                        ".",
                        "x",
                        ".",
                        "x",
                        "."});
            table5.AddRow(new string[] {
                        ".",
                        ".",
                        ".",
                        "x",
                        ".",
                        "."});
            table5.AddRow(new string[] {
                        ".",
                        ".",
                        ".",
                        ".",
                        ".",
                        "."});
#line 37
    testRunner.Given("the following setup", ((string)(null)), table5, "Given ");
#line 44
    testRunner.When("I evolve the board", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        ".",
                        ".",
                        ".",
                        ".",
                        ".",
                        "."});
            table6.AddRow(new string[] {
                        ".",
                        ".",
                        "x",
                        "x",
                        ".",
                        "."});
            table6.AddRow(new string[] {
                        ".",
                        "x",
                        ".",
                        ".",
                        "x",
                        "."});
            table6.AddRow(new string[] {
                        ".",
                        ".",
                        "x",
                        ".",
                        "x",
                        "."});
            table6.AddRow(new string[] {
                        ".",
                        ".",
                        ".",
                        "x",
                        ".",
                        "."});
            table6.AddRow(new string[] {
                        ".",
                        ".",
                        ".",
                        ".",
                        ".",
                        "."});
#line 45
    testRunner.Then("I should see the following board", ((string)(null)), table6, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Boat")]
        public virtual void Boat()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Boat", ((string[])(null)));
#line 53
  this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        ".",
                        ".",
                        ".",
                        ".",
                        "."});
            table7.AddRow(new string[] {
                        ".",
                        "x",
                        "x",
                        ".",
                        "."});
            table7.AddRow(new string[] {
                        ".",
                        "x",
                        ".",
                        "x",
                        "."});
            table7.AddRow(new string[] {
                        ".",
                        ".",
                        "x",
                        ".",
                        "."});
            table7.AddRow(new string[] {
                        ".",
                        ".",
                        ".",
                        ".",
                        "."});
#line 54
    testRunner.Given("the following setup", ((string)(null)), table7, "Given ");
#line 60
    testRunner.When("I evolve the board", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        ".",
                        ".",
                        ".",
                        ".",
                        "."});
            table8.AddRow(new string[] {
                        ".",
                        "x",
                        "x",
                        ".",
                        "."});
            table8.AddRow(new string[] {
                        ".",
                        "x",
                        ".",
                        "x",
                        "."});
            table8.AddRow(new string[] {
                        ".",
                        ".",
                        "x",
                        ".",
                        "."});
            table8.AddRow(new string[] {
                        ".",
                        ".",
                        ".",
                        ".",
                        "."});
#line 61
    testRunner.Then("I should see the following board", ((string)(null)), table8, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
