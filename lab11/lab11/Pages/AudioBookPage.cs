using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11.Pages
{
	public class AudioBookPage : PageBase.PageBase
	{
		public AudioBookPage(IWebDriver driver) : base(driver)
		{

		}

		public void PickFirstBook()
		{
			Driver.FindElement(By.XPath("//*[@id=\"__next\"]/div[1]/header/div[3]/nav/div/div[4]/a")).Click();
			//driver.FindElement(By.XPath("//*[@id=\"editors_choice\"]/div/div/div[1]/div[1]/div[1]")).Click();
			Driver.Navigate().GoToUrl("https://www.litres.ru/audiobook/dina-rubina/ne-vycherkivay-menya-iz-spiska-70020430/");



		}

		public void AddToFav()
		{
			try
			{
				Driver.FindElement(By.XPath("//*[@id=\"book-card__wrapper\"]/div[1]/ul/li[2]/button")).Click();
			}
			catch
			{
				Driver.FindElement(By.XPath("//*[@id=\"page-wrap\"]/div[3]/div[2]/div/div[1]/div/div[2]/div[5]/div[1]/div[2]/div/div/div[2]/form/button")).Click();

			}


			//try
			//{
			//	Driver.FindElement(By.XPath("//*[@id=\"promo-books-popup\"]/a")).Click();
			//}
			//catch
			//{
			//	Driver.FindElement(By.XPath("/html/body/div[3]/div[5]/div/div/div/div/div[1]/div/svg/use")).Click();

			//}
		}

		public void Listen()
		{

			Driver.FindElement(By.XPath("//*[@id=\"playerPortal\"]/div/div[1]/div/div[2]/button")).Click();
			Thread.Sleep(3000);
		}

		public void AddReview()
		{

			Driver.Navigate().GoToUrl("https://www.litres.ru/audiobook/donato-karrizi/dom-ogney-69970498/otzivi");
			Thread.Sleep(2000);
		
		}
	}
}
