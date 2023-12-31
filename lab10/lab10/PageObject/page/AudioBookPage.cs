﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10.PageObject.page
{
	internal class AudioBookPage
	{
		private readonly IWebDriver driver;


		public AudioBookPage(IWebDriver webDriver)
		{
			this.driver = webDriver;
		}

		public void PickFirstBook()
		{
			driver.FindElement(By.XPath("//*[@id=\"__next\"]/div[1]/header/div[3]/nav/div/div[4]/a")).Click();
			//driver.FindElement(By.XPath("//*[@id=\"editors_choice\"]/div/div/div[1]/div[1]/div[1]")).Click();
			driver.Navigate().GoToUrl("https://www.litres.ru/audiobook/donato-karrizi/dom-ogney-69970498/");
		

			try
			{
				driver.FindElement(By.XPath("//*[@id=\"book-card__wrapper\"]/div[1]/ul/li[2]/button")).Click();
			}
			catch
			{
				driver.FindElement(By.XPath("//*[@id=\"page-wrap\"]/div[3]/div[2]/div/div[1]/div/div[2]/div[5]/div[1]/div[2]/div/div/div[2]/form/button")).Click();

			}
		}

		public void AddToFav()
		{
			try
			{
				driver.FindElement(By.XPath("//*[@id=\"promo-books-popup\"]/a")).Click();
			}
			catch
			{
				driver.FindElement(By.XPath("/html/body/div[3]/div[5]/div/div/div/div/div[1]/div/svg/use")).Click();

			}
		}
	}
}
