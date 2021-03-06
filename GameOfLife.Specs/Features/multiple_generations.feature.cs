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
    [NUnit.Framework.DescriptionAttribute("Evolving a grid over multiple generations")]
    public partial class EvolvingAGridOverMultipleGenerationsFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "multiple_generations.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Evolving a grid over multiple generations", "In order to create a functioning rules engine  \r\nAs a programmer of Conway\'s Game" +
                    " of Life  \r\nI can evolve a grid over multiple generations", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Cells come alive, then die off")]
        public virtual void CellsComeAliveThenDieOff()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Cells come alive, then die off", ((string[])(null)));
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
                        ".",
                        ".",
                        ".",
                        "."});
            table1.AddRow(new string[] {
                        ".",
                        "x",
                        "x",
                        "x",
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
                        ".",
                        "x",
                        ".",
                        "."});
            table2.AddRow(new string[] {
                        ".",
                        ".",
                        "x",
                        ".",
                        "."});
            table2.AddRow(new string[] {
                        ".",
                        ".",
                        "x",
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
#line 20
    testRunner.When("I evolve the board", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        ".",
                        ".",
                        ".",
                        ".",
                        "."});
            table3.AddRow(new string[] {
                        ".",
                        ".",
                        ".",
                        ".",
                        "."});
            table3.AddRow(new string[] {
                        ".",
                        "x",
                        "x",
                        "x",
                        "."});
            table3.AddRow(new string[] {
                        ".",
                        ".",
                        ".",
                        ".",
                        "."});
            table3.AddRow(new string[] {
                        ".",
                        ".",
                        ".",
                        ".",
                        "."});
#line 21
    testRunner.Then("I should see the following board", ((string)(null)), table3, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
