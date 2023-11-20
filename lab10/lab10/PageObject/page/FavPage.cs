using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10.PageObject.page
{
	internal class FavPage
	{
		private readonly IWebDriver driver;


		public FavPage(IWebDriver webDriver)
		{
			this.driver = webDriver;
		}

		public void GoToFav()
		{
			driver.FindElement(By.XPath("/html/body/div[1]/div[1]/header/div[2]/nav/div[2]/a")).Click();
		}

		public void CheckBook()
		{
			try
			{
				driver.FindElement(By.XPath("//*[@id=\"__next\"]/div[1]/div[3]/div/div[2]/div[3]/div/div/div[2]/div[2]/button")).Click(); // это короче корзина пуста. надо будет чтобы это нельзя найти.
			}
			catch
			{
				Assert.Fail();
			}
		}
	}
}
