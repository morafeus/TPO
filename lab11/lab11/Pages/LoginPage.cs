using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11.Pages
{
	public class LoginPage : PageBase.PageBase
	{
		public LoginPage(IWebDriver driver) : base(driver) { }

		public bool InsertValue()
		{
	
			List<string> windowHandles = new List<string>(Driver.WindowHandles);
			Driver.SwitchTo().Window(windowHandles[windowHandles.Count - 1]);
			IWebElement searchInput = Driver.FindElement(By.XPath("//*[@id=\"identifierId\"]"));
			searchInput.Click();
			searchInput.SendKeys("aadamovich2003@gmail.com");
			Logger.Logger.Info("gmail input");
			Driver.FindElement(By.XPath("//*[@id=\"identifierNext\"]/div/button")).Click();
			return true;
			
		}
	}
}
