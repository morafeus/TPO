using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace lab9
{
	[TestClass]
	public class UnitTest1
	{
		private IWebDriver driver;
		private PastebinPage pastebinPage;

		[TestInitialize]
		public void TestInitialize()
		{
			driver = new ChromeDriver();
			pastebinPage = new PastebinPage(driver);
		}

		[TestMethod]
		public void CreateNewPasteTest()
		{

			 driver.Navigate().GoToUrl("https://www.litres.ru");
			driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(20);

			driver.FindElement(By.XPath("//*[@id=\"__next\"]/div[1]/header/div[3]/nav/div/div[4]/a")).Click();
			driver.FindElement(By.XPath("//*[@id=\"editors_choice\"]/div/div/div[1]/div[1]/div[1]")).Click();
			try
			{
				driver.FindElement(By.XPath("//*[@id=\"book-card__wrapper\"]/div[2]/div[2]/div/div[2]/div[4]/div/div[1]/div[3]/button")).Click();
			}
			catch
			{
				driver.FindElement(By.XPath("//*[@id=\"page-wrap\"]/div[3]/div[2]/div/div[1]/div/div[2]/div[6]/div[1]/div[2]/div/div/div[2]/form/button")).Click();
			}
			try
			{
				driver.FindElement(By.XPath("//*[@id=\"modal\"]/div[5]/div/div/div/div/div[1]")).Click();
			}
			catch
			{
				driver.FindElement(By.XPath("//*[@id=\"promo-books-popup\"]/a")).Click();

			}



			driver.FindElement(By.XPath("/html/body/div[1]/div[1]/header/div[2]/nav/div[2]/a")).Click();
			try
			{
				driver.FindElement(By.XPath("//*[@id=\"__next\"]/div[1]/div[3]/div/div[2]/div[3]/div/div/div[2]/div[2]/button")).Click(); // это короче корзина пуста. надо будет чтобы это нельзя найти.
			}
			catch 
			{ 
				Assert.Fail();
			}
		}

		[TestCleanup]
		public void TestCleanup()
		{
			driver.Quit();
		}
	}
}