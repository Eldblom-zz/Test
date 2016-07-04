﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Sitecore.Feature.Accounts.Specflow
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Xunit.TraitAttribute("Category", "UI")]
    public partial class LogOutFeature : Xunit.IClassFixture<LogOutFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Log out.feature"
#line hidden
        
        public LogOutFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Log out", null, ProgrammingLanguage.CSharp, new string[] {
                        "UI"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
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
        
        public virtual void SetFixture(LogOutFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(DisplayName="Accounts_Log out_UC1_Simple log out")]
        [Xunit.TraitAttribute("FeatureTitle", "Log out")]
        [Xunit.TraitAttribute("Description", "Accounts_Log out_UC1_Simple log out")]
        [Xunit.TraitAttribute("Category", "Ready")]
        public virtual void Accounts_LogOut_UC1_SimpleLogOut()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Log out_UC1_Simple log out", new string[] {
                        "Ready"});
#line 6
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table1.AddRow(new string[] {
                        "kovLogout1@sitecore.net",
                        "k",
                        "k"});
#line 7
 testRunner.Given("User with following data is registered in Habitat", ((string)(null)), table1, "Given ");
#line 10
 testRunner.When("Actor selects User icon on Navigation bar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.And("Actor clicks Logout button on User form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
 testRunner.And("Actor selects User icon on Navigation bar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
 testRunner.Then("Habitat Main page presents", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Button name"});
            table2.AddRow(new string[] {
                        "Logout"});
#line 14
 testRunner.And("Following buttons is no longer present under User icon", ((string)(null)), table2, "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Link name"});
            table3.AddRow(new string[] {
                        "Edit details"});
#line 17
 testRunner.And("Following links is no longer present under User popup", ((string)(null)), table3, "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field name"});
            table4.AddRow(new string[] {
                        "Email"});
            table4.AddRow(new string[] {
                        "Password"});
#line 20
 testRunner.And("Following fields present on User form", ((string)(null)), table4, "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Login Form Buttons"});
            table5.AddRow(new string[] {
                        "Login"});
            table5.AddRow(new string[] {
                        "Forgot your password?"});
            table5.AddRow(new string[] {
                        "Register"});
#line 24
 testRunner.And("Following buttons present under User icon", ((string)(null)), table5, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Accounts_Log out_UC2_Session expired")]
        [Xunit.TraitAttribute("FeatureTitle", "Log out")]
        [Xunit.TraitAttribute("Description", "Accounts_Log out_UC2_Session expired")]
        [Xunit.TraitAttribute("Category", "Ready")]
        public virtual void Accounts_LogOut_UC2_SessionExpired()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Log out_UC2_Session expired", new string[] {
                        "Ready"});
#line 32
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table6.AddRow(new string[] {
                        "kovLogout2@sitecore.net",
                        "k",
                        "k"});
#line 33
 testRunner.Given("User with following data is registered in Habitat", ((string)(null)), table6, "Given ");
#line 36
 testRunner.And("Session was expired", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
 testRunner.When("Actor selects User icon on Navigation bar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 38
 testRunner.And("Actor clicks Logout button on User form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
 testRunner.And("Actor selects User icon on Navigation bar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
 testRunner.Then("Habitat Main page presents", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Button name"});
            table7.AddRow(new string[] {
                        "Logout"});
#line 41
 testRunner.And("Following buttons is no longer present under User icon", ((string)(null)), table7, "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Link name"});
            table8.AddRow(new string[] {
                        "Edit details"});
#line 44
 testRunner.And("Following links is no longer present under User popup", ((string)(null)), table8, "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field name"});
            table9.AddRow(new string[] {
                        "Email"});
            table9.AddRow(new string[] {
                        "Password"});
#line 47
 testRunner.And("Following fields present on User form", ((string)(null)), table9, "And ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Login Form Buttons"});
            table10.AddRow(new string[] {
                        "Login"});
            table10.AddRow(new string[] {
                        "Forgot your password?"});
            table10.AddRow(new string[] {
                        "Register"});
#line 51
 testRunner.And("Following buttons present under User icon", ((string)(null)), table10, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                LogOutFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                LogOutFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion