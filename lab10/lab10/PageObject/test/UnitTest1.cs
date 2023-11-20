using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using lab10.PageObject.page;

namespace lab10.PageObject.test
{
    [TestClass]
    public class UnitTest1
    {
        private IWebDriver driver;
        private MainPage mainPage;
        private AudioBookPage audioBookPage;
        private FavPage favPage;
     

        [TestInitialize]
        public void TestInitialize()
        {
            driver = new ChromeDriver();
            mainPage = new MainPage(driver);
            audioBookPage = new AudioBookPage(driver);
            favPage = new FavPage(driver);
        }

        [TestMethod]
        public void CreateNewPasteTest()
        {

            mainPage.Open();

            audioBookPage.PickFirstBook();
            audioBookPage.AddToFav();
            
            favPage.GoToFav();
            favPage.CheckBook();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            driver.Quit();
        }
    }

    [TestClass]
    public class UnitTest2
    {
		private IWebDriver driver;
		private MainPage mainPage;
		private AudioBookPage audioBookPage;
		private FavPage favPage;


		[TestInitialize]
		public void TestInitialize()
		{
			driver = new ChromeDriver();
			mainPage = new MainPage(driver);
			audioBookPage = new AudioBookPage(driver);
			favPage = new FavPage(driver);
		}

		[TestMethod]
        public void PreviewCheck()
        {
            mainPage.Open();
            mainPage.Catalogue();
            mainPage.Ganre();
            mainPage.FindBook();
        }

		[TestCleanup]
		public void TestCleanup()
		{
			driver.Quit();
		}
	}
}