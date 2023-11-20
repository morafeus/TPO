using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V117.DOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10.PageObject.page
{
	internal class MainPage
	{
		private readonly IWebDriver driver;


		public MainPage(IWebDriver webDriver)
		{
			this.driver = webDriver;
		}

		public void Open()
		{
			driver.Navigate().GoToUrl("https://www.litres.ru");
			driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(20);
		}

		public void Catalogue()
		{
			driver.FindElement(By.XPath("//*[@id=\"__next\"]/div[1]/header/div[2]/div[1]/button")).Click();
		}

		public void Ganre()
		{
			driver.FindElement(By.XPath("//*[@id=\"genres_popup\"]/div[1]/div/div[1]/ul/li[1]/a")).Click();
		}

		public void FindBook()
		{
		
			driver.Navigate().GoToUrl("https://www.litres.ru/book/erofey-trofimov/krov-na-klinke-69856405/");
		}

		public void Book()
		{
			driver.Navigate().GoToUrl("https://www.litres.ru/static/or4/view/or.html?baseurl=/pub/t/69856405.&art=69856405&trials=1&user=0&file=102034516&price=249&texttrialbutton=%D0%9A%D1%83%D0%BF%D0%B8%D1%82%D1%8C%20%D0%BF%D0%BE%D0%BB%D0%BD%D1%83%D1%8E%20%D0%B2%D0%B5%D1%80%D1%81%D0%B8%D1%8E%20%D0%B7%D0%B0%20249&uilang=ru&catalit2&half=1&track_reading&friendly_url=%D0%95%D1%80%D0%BE%D1%84%D0%B5%D0%B9%20%D0%A2%D1%80%D0%BE%D1%84%D0%B8%D0%BC%D0%BE%D0%B2.%20%D0%9A%D1%80%D0%BE%D0%B2%D1%8C%20%D0%BD%D0%B0%20%D0%BA%D0%BB%D0%B8%D0%BD%D0%BA%D0%B5");
		}
	}
}
