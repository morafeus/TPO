using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11.Pages
{
	public class FavPage : PageBase.PageBase
	{
		public FavPage(IWebDriver driver) : base(driver) { }

		public void GoToFav()
		{
			Driver.FindElement(By.XPath("//*[@id=\"__next\"]/div[1]/header/div[2]/nav/div[1]/a")).Click();
		}

		public bool CheckBook()
		{
			try
			{
				Driver.FindElement(By.XPath("//*[@id=\"liked-arts\"]/div[3]/div")).Click(); // это короче корзина пуста. надо будет чтобы это нельзя найти.
				return true;
			}
			catch
			{
				return false;
			}
		}

		public void DeleteFav()
		{

			Driver.FindElement(By.XPath("//*[@id=\"liked-arts\"]/div[3]/div/div[5]/a")).Click();
			Thread.Sleep(1000);
			Driver.FindElement(By.XPath("//*[@id=\"liked-arts\"]/div[3]/div/div[5]/div/ul/li[3]/form/button")).Click();
			Thread.Sleep(1000);
		}
	}
}
