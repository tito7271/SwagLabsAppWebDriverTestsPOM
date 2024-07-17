using OpenQA.Selenium;

namespace SwagLabsAppPOMTests.Pages
{
    public class HiddenMenuPage : BasePage
    {
        private readonly By hiddenMenuButton = By.Id("react-burger-menu-btn");
        private readonly By logoutButton = By.Id("logout_sidebar_link");

        public HiddenMenuPage(IWebDriver driver) : base(driver)
        {
        }

        public void ClickHiddenMenuButton()
        {
            Click(hiddenMenuButton);
        }

        public void ClickLogoutButton()
        {
            Click(logoutButton);
        }

        public bool IsHiddenMenuOpen()
        {
            return FindElement(logoutButton).Displayed;
        }
    }
}
