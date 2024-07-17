namespace SwagLabsAppPOMTests.Tests
{
    public class HiddenMenuTests : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            Login("standard_user", "secret_sauce");
        }

        [Test]
        public void TestOpenMenu()
        {
            hiddenMenuPage.ClickHiddenMenuButton();

            Assert.That(hiddenMenuPage.IsHiddenMenuOpen(), Is.True, "Hidden menu is not open");
        }

        [Test]
        public void TestLogout()
        {
            hiddenMenuPage.ClickHiddenMenuButton();
            hiddenMenuPage.ClickLogoutButton();

            Assert.That(driver.Url.Equals("https://www.saucedemo.com/"), "User is not logged out");
        }
    }
}
