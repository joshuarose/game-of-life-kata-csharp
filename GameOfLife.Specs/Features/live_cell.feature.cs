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
    [NUnit.Framework.DescriptionAttribute("Evolving a living cell")]
    public partial class EvolvingALivingCellFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "live_cell.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Evolving a living cell", "In order to create a functioning rules engine  \r\nAs a programmer of Conway\'s Game" +
                    " of Life  \r\nI can evolve a single living cell", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Living cell with 0 neighbors dies")]
        public virtual void LivingCellWith0NeighborsDies()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Living cell with 0 neighbors dies", ((string[])(null)));
#line 6
  this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        ".",
                        ".",
                        "."});
            table1.AddRow(new string[] {
                        ".",
                        "x",
                        "."});
            table1.AddRow(new string[] {
                        ".",
                        ".",
                        "."});
#line 7
    testRunner.Given("the following setup", ((string)(null)), table1, "Given ");
#line 11
    testRunner.When("I evolve the board", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
    testRunner.Then("the center cell should be dead", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Living cell with 1 neighbor dies")]
        public virtual void LivingCellWith1NeighborDies()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Living cell with 1 neighbor dies", ((string[])(null)));
#line 14
  this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        ".",
                        "x",
                        "."});
            table2.AddRow(new string[] {
                        ".",
                        "x",
                        "."});
            table2.AddRow(new string[] {
                        ".",
                        ".",
                        "."});
#line 15
    testRunner.Given("the following setup", ((string)(null)), table2, "Given ");
#line 19
    testRunner.When("I evolve the board", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 20
    testRunner.Then("the center cell should be dead", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Living cell with 2 neighbors lives")]
        public virtual void LivingCellWith2NeighborsLives()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Living cell with 2 neighbors lives", ((string[])(null)));
#line 22
  this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        ".",
                        "x",
                        "."});
            table3.AddRow(new string[] {
                        ".",
                        "x",
                        "x"});
            table3.AddRow(new string[] {
                        ".",
                        ".",
                        "."});
#line 23
    testRunner.Given("the following setup", ((string)(null)), table3, "Given ");
#line 27
    testRunner.When("I evolve the board", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 28
    testRunner.Then("the center cell should be alive", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Living cell with 3 neighbors lives")]
        public virtual void LivingCellWith3NeighborsLives()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Living cell with 3 neighbors lives", ((string[])(null)));
#line 30
  this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "x",
                        "x",
                        "x"});
            table4.AddRow(new string[] {
                        ".",
                        "x",
                        "."});
            table4.AddRow(new string[] {
                        ".",
                        ".",
                        "."});
#line 31
    testRunner.Given("the following setup", ((string)(null)), table4, "Given ");
#line 35
    testRunner.When("I evolve the board", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 36
    testRunner.Then("the center cell should be alive", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Living cell with 4 neighbors dies")]
        public virtual void LivingCellWith4NeighborsDies()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Living cell with 4 neighbors dies", ((string[])(null)));
#line 38
  this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "x",
                        "x",
                        "x"});
            table5.AddRow(new string[] {
                        ".",
                        "x",
                        "x"});
            table5.AddRow(new string[] {
                        ".",
                        ".",
                        "."});
#line 39
    testRunner.Given("the following setup", ((string)(null)), table5, "Given ");
#line 43
    testRunner.When("I evolve the board", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 44
    testRunner.Then("the center cell should be dead", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Living cell with 5 neighbors dies")]
        public virtual void LivingCellWith5NeighborsDies()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Living cell with 5 neighbors dies", ((string[])(null)));
#line 46
  this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "x",
                        "x",
                        "x"});
            table6.AddRow(new string[] {
                        "x",
                        "x",
                        "x"});
            table6.AddRow(new string[] {
                        ".",
                        ".",
                        "."});
#line 47
    testRunner.Given("the following setup", ((string)(null)), table6, "Given ");
#line 51
    testRunner.When("I evolve the board", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 52
    testRunner.Then("the center cell should be dead", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Living cell with 6 neighbors dies")]
        public virtual void LivingCellWith6NeighborsDies()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Living cell with 6 neighbors dies", ((string[])(null)));
#line 54
  this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "x",
                        "x",
                        "x"});
            table7.AddRow(new string[] {
                        "x",
                        "x",
                        "x"});
            table7.AddRow(new string[] {
                        "x",
                        ".",
                        "."});
#line 55
    testRunner.Given("the following setup", ((string)(null)), table7, "Given ");
#line 59
    testRunner.When("I evolve the board", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 60
    testRunner.Then("the center cell should be dead", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Living cell with 7 neighbors dies")]
        public virtual void LivingCellWith7NeighborsDies()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Living cell with 7 neighbors dies", ((string[])(null)));
#line 62
  this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "x",
                        "x",
                        "x"});
            table8.AddRow(new string[] {
                        "x",
                        "x",
                        "x"});
            table8.AddRow(new string[] {
                        "x",
                        "x",
                        "."});
#line 63
    testRunner.Given("the following setup", ((string)(null)), table8, "Given ");
#line 67
    testRunner.When("I evolve the board", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 68
    testRunner.Then("the center cell should be dead", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Living cell with 8 neighbors dies")]
        public virtual void LivingCellWith8NeighborsDies()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Living cell with 8 neighbors dies", ((string[])(null)));
#line 70
  this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "x",
                        "x",
                        "x"});
            table9.AddRow(new string[] {
                        "x",
                        "x",
                        "x"});
            table9.AddRow(new string[] {
                        "x",
                        "x",
                        "x"});
#line 71
    testRunner.Given("the following setup", ((string)(null)), table9, "Given ");
#line 75
    testRunner.When("I evolve the board", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 76
    testRunner.Then("the center cell should be dead", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion