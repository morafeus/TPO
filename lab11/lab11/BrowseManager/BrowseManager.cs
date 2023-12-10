﻿using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.DevTools;
using lab11.Logger;

namespace lab11.BrowseManager
{
	internal class BrowseManager
	{
		public class BrowserManager
		{
			private static IWebDriver _driver;

			public static IWebDriver Driver
			{
				get
				{
					if (_driver == null)
					{
						InitializeDriver();
					}
					return _driver;
				}
			}

			private static void InitializeDriver()
			{
				_driver = new ChromeDriver();
				_driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
				Logger.Logger.Info("WebDriver initialized.");
			}

			public static void QuitDriver()
			{
				if (_driver != null)
				{  
					_driver.Quit();
					_driver = null;
					Logger.Logger.Info("WebDriver quit.");
				}
			}
		}
	}
}
