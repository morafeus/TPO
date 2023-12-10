using lab11.Pages;
using OpenQA.Selenium.Chrome;
using BrowserManager = lab11.BrowseManager.BrowseManager.BrowserManager;


namespace lab11.Tests
{
    [TestClass]
    public class UnitTest1
    {
		private Pages.MainPage mainPage;
		private Pages.AudioBookPage audioBookPage;
		private Pages.FavPage favPage;


		[TestInitialize]
		public void TestInitialize()
		{
			
			mainPage = new Pages.MainPage(BrowserManager.Driver);
			audioBookPage = new Pages.AudioBookPage(BrowserManager.Driver);
			favPage = new Pages.FavPage(BrowserManager.Driver);
		}

		[TestMethod]
        public void TestMethod1()
        {
			mainPage.Open();

			audioBookPage.PickFirstBook();
			audioBookPage.AddToFav();

			favPage.GoToFav();
			Assert.IsTrue(favPage.CheckBook());
		}

		[TestCleanup]
		public void TestCleanup()
		{
			BrowserManager.QuitDriver();
		}


	}

	[TestClass]
	public class UnitTest2
	{
		private Pages.MainPage mainPage;
		private Pages.AudioBookPage audioBookPage;
		private Pages.FavPage favPage;


		[TestInitialize]
		public void TestInitialize()
		{
			mainPage = new MainPage(BrowserManager.Driver);
			audioBookPage = new AudioBookPage(BrowserManager.Driver);
			favPage = new FavPage(BrowserManager.Driver);
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
			BrowserManager.QuitDriver();
		}
	}

	[TestClass]
	public class UnitTest3
	{
		private Pages.MainPage mainPage;
		private Pages.LoginPage loginPage;
	
		[TestInitialize]
		public void TestInitialize()
		{
			mainPage = new MainPage(BrowserManager.Driver);
			loginPage= new LoginPage(BrowserManager.Driver);
		}

		[TestMethod]
		public void PreviewCheck()
		{
			mainPage.Open();
			mainPage.RegistrateBook();
			mainPage.Google();
			Thread.Sleep(3000);
			Assert.IsTrue(loginPage.InsertValue());
			
			
		}

		[TestCleanup]
		public void TestCleanup()
		{
			BrowserManager.QuitDriver();
		}
	}

	[TestClass]
	public class UnitTest4
	{
		private Pages.MainPage mainPage;
		private Pages.AudioBookPage audioBookPage;


		[TestInitialize]
		public void TestInitialize()
		{
			mainPage = new MainPage(BrowserManager.Driver);
			audioBookPage = new AudioBookPage(BrowserManager.Driver);
		}

		[TestMethod]
		public void PreviewCheck()
		{
			mainPage.Open();
			audioBookPage.PickFirstBook();
			audioBookPage.Listen();

		}

		[TestCleanup]
		public void TestCleanup()
		{
			BrowserManager.QuitDriver();
		}
	}

	[TestClass]
	public class UnitTest5
	{
		private Pages.MainPage mainPage;
		private Pages.AudioBookPage audioBookPage;


		[TestInitialize]
		public void TestInitialize()
		{
			mainPage = new MainPage(BrowserManager.Driver);
			audioBookPage = new AudioBookPage(BrowserManager.Driver);
		}

		[TestMethod]
		public void PreviewCheck()
		{
			mainPage.Open();
			audioBookPage.PickFirstBook();
			audioBookPage.AddReview();

		}

		[TestCleanup]
		public void TestCleanup()
		{
			BrowserManager.QuitDriver();
		}
	}

	[TestClass]
	public class UnitTest6
	{
		private Pages.MainPage mainPage;

		[TestInitialize]
		public void TestInitialize()
		{
			mainPage = new MainPage(BrowserManager.Driver);
		}

		[TestMethod]
		public void PreviewCheck()
		{
			mainPage.Open();
			mainPage.CheckBook();

		}

		[TestCleanup]
		public void TestCleanup()
		{
			BrowserManager.QuitDriver();
		}

	}

	[TestClass]
	public class UnitTest7
	{
		private Pages.MainPage mainPage;

		[TestInitialize]
		public void TestInitialize()
		{
			mainPage = new MainPage(BrowserManager.Driver);
		}

		[TestMethod]
		public void PreviewCheck()
		{
			mainPage.Open();
			mainPage.Promocode();

		}

		[TestCleanup]
		public void TestCleanup()
		{
			BrowserManager.QuitDriver();
		}

	}

	[TestClass]
	public class UnitTest8
	{
		private Pages.MainPage mainPage;
		private Pages.PodcastPage podcastPage;

		[TestInitialize]
		public void TestInitialize()
		{
			mainPage = new MainPage(BrowserManager.Driver);
			podcastPage = new PodcastPage(BrowserManager.Driver);
		}

		[TestMethod]
		public void PreviewCheck()
		{
			mainPage.Open();
			mainPage.GoToPodcast();

			podcastPage.GoToPodcast();
			podcastPage.PodcastSubscribe();


		}

		[TestCleanup]
		public void TestCleanup()
		{
			BrowserManager.QuitDriver();
		}
	}

	[TestClass]
	public class UnitTest9
	{
		private Pages.MainPage mainPage;
		private Pages.PodcastPage podcastPage;

		[TestInitialize]
		public void TestInitialize()
		{
			mainPage = new MainPage(BrowserManager.Driver);
			podcastPage = new PodcastPage(BrowserManager.Driver);
		}

		[TestMethod]
		public void PreviewCheck()
		{
			mainPage.Open();
			mainPage.GoToPodcast();

			podcastPage.GoToPodcast();
			Thread.Sleep(1000);
			podcastPage.PodcastListen();


		}

		[TestCleanup]
		public void TestCleanup()
		{
			BrowserManager.QuitDriver();
		}
	}


	[TestClass]
	public class UnitTest10
	{
		private Pages.MainPage mainPage;
		private Pages.AudioBookPage audioBookPage;
		private Pages.FavPage favPage;


		[TestInitialize]
		public void TestInitialize()
		{

			mainPage = new Pages.MainPage(BrowserManager.Driver);
			audioBookPage = new Pages.AudioBookPage(BrowserManager.Driver);
			favPage = new Pages.FavPage(BrowserManager.Driver);
		}

		[TestMethod]
		public void TestMethod1()
		{
			mainPage.Open();

			audioBookPage.PickFirstBook();
			audioBookPage.AddToFav();

			favPage.GoToFav();
			favPage.DeleteFav();
			Assert.IsFalse(favPage.CheckBook());
	
		}

		[TestCleanup]
		public void TestCleanup()
		{
			BrowserManager.QuitDriver();
		}


	}
}