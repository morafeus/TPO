using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11.Pages
{
	public class PodcastPage : PageBase.PageBase
	{
		public PodcastPage(IWebDriver driver) : base(driver) { }

		public void GoToPodcast()
		{
			Driver.FindElement(By.XPath("//*[@id=\"editors_choice\"]/div/div/div[1]/div[1]/div[1]/div[1]/div/a")).Click();
		}

		public void PodcastSubscribe()
		{
			IWebElement searchInput = Driver.FindElement(By.XPath("\t\t\t//*[@id=\"book-card__wrapper\"]/div[2]/div[2]/div/div[2]/div[4]/div/div[2]/div/div/div[1]/form/div[1]/div/input"));
			//searchInput.Click();
			searchInput.SendKeys("aadamovich2003@gmail.com");
			Logger.Logger.Info("gmail input");
			Thread.Sleep(1000);
			//Driver.FindElement(By.XPath("//*[@id=\"book-card__wrapper\"]/div[2]/div[2]/div/div[2]/div[4]/div/div[2]/div/div/div[1]/form/button/div")).Click();
		}

		public void PodcastListen()
		{
			Driver.FindElement(By.XPath("//*[@id=\"playerPortal\"]/div/div[1]/div/div[2]/button")).Click();
			Thread.Sleep(3000);
		}
	}
}
