using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using static BigHealth.Helper.Base;
using TechTalk.SpecFlow;

namespace BigHealth.Hooks
{
	[Binding]
	public static class Hooks
	{
		#region variables
		public static ScopeAttribute newScope = new ScopeAttribute();

		#endregion

		[BeforeTestRun]
		public static void Initialize()
		{


			//Search for Chromedriver.exe runing task, If present then end it
			Process[] ChromeDriverProcess = Process.GetProcessesByName("chromedriver");
			foreach (var chromeDrivProc in ChromeDriverProcess)
			{
				chromeDrivProc.Kill();
			}

		}

		[BeforeFeature]
		[Scope(Feature = "SleepScoreSignup")]
		public static void BeforeInternalUIManagementPayments()
		{
			if (Driver == null)
			{
				InitializeBrowser();
			}
		}

		[AfterFeature]
		[Scope(Feature = "SleepScoreSignup")]
		public static void AfterInternalUIManagementPayments()
		{
			if (Driver != null)
			{
				Driver.Quit();
				Driver = null;
			}
		}

		[BeforeScenario]
		public static void BeforeScenarioToLaunchBrowser()
		{
			//Initialize Browser only for Web scripts	
			if (Driver == null)
			{
				InitializeBrowser();
			}
		}

		[AfterScenario]
		public static void AfterScenarioForSmokeTestWeb()
		{
			Console.WriteLine("After Scenario executed for SmokeTest and API tags");
			if (Driver != null)
			{
				Driver.Quit();
				Driver = null;
			}
		}

	}
}
