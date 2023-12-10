using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11.Pages
{
	public class MainPage : PageBase.PageBase
	{
		public MainPage(IWebDriver driver) : base(driver) { }

		public void Open()
		{
			Driver.Navigate().GoToUrl("https://www.litres.ru");
			Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(20);
		}

		public void Catalogue()
		{
			Driver.FindElement(By.XPath("//*[@id=\"__next\"]/div[1]/header/div[2]/div[1]/button")).Click();
		}

		public void Ganre()
		{
			Driver.FindElement(By.XPath("//*[@id=\"genres_popup\"]/div[1]/div/div[1]/ul/li[1]/a")).Click();
		}

		public void FindBook()
		{

			Driver.Navigate().GoToUrl("https://www.litres.ru/book/erofey-trofimov/krov-na-klinke-69856405/");
		}

		public void Book()
		{
			Driver.Navigate().GoToUrl("https://www.litres.ru/static/or4/view/or.html?baseurl=/pub/t/69856405.&art=69856405&trials=1&user=0&file=102034516&price=249&texttrialbutton=%D0%9A%D1%83%D0%BF%D0%B8%D1%82%D1%8C%20%D0%BF%D0%BE%D0%BB%D0%BD%D1%83%D1%8E%20%D0%B2%D0%B5%D1%80%D1%81%D0%B8%D1%8E%20%D0%B7%D0%B0%20249&uilang=ru&catalit2&half=1&track_reading&friendly_url=%D0%95%D1%80%D0%BE%D1%84%D0%B5%D0%B9%20%D0%A2%D1%80%D0%BE%D1%84%D0%B8%D0%BC%D0%BE%D0%B2.%20%D0%9A%D1%80%D0%BE%D0%B2%D1%8C%20%D0%BD%D0%B0%20%D0%BA%D0%BB%D0%B8%D0%BD%D0%BA%D0%B5");
		}

		public void RegistrateBook()
		{
			Driver.Navigate().GoToUrl("https://www.litres.ru/pages/login/");
		}

		public void Google()
		{
			Driver.FindElement(By.XPath("//*[@id=\"google_login\"]")).Click();
		}

		public void Promocode()
		{
			Driver.FindElement(By.XPath("//*[@id=\"__next\"]/div[1]/header/div[3]/nav/div/div[7]/a")).Click();
			IWebElement searchInput = Driver.FindElement(By.XPath("//*[@id=\"code1\"]"));
			searchInput.Click();
			searchInput.SendKeys("new_year_2024");
			Thread.Sleep(1000);
			Logger.Logger.Info("promocode input");
			Driver.FindElement(By.XPath("//*[@id=\"activate_coupon\"]")).Click();
		}

		public void GoToPodcast()
		{
			
			Driver.FindElement(By.XPath("//*[@id=\"__next\"]/div[1]/header/div[3]/nav/div/div[8]/div/a")).Click();
			Driver.FindElement(By.XPath("//*[@id=\"__next\"]/div[1]/header/div[3]/nav/div/div[9]/div/ul/li[3]/a")).Click();
		}

		public void CheckBook()
		{
			try
			{
				Driver.FindElement(By.XPath("//*[@id=\"__next\"]/div[1]/div[3]/div/div[2]/div/div/div/div[2]/div[1]/div/div[2]/div[1]/div/a")).Click(); // это короче корзина пуста. надо будет чтобы это нельзя найти.
			}
			catch
			{
				Assert.Fail();
			}
		}
	}
}
