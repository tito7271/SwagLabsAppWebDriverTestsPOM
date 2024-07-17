using OpenQA.Selenium;

namespace SwagLabsAppPOMTests.Pages
{
    public class LoginPage : BasePage
    {
        private readonly By usernameField = By.Id("user-name");
        private readonly By passwordField = By.Id("password");
        private readonly By loginButton = By.Id("login-button");

        private readonly By errorMessage = By.XPath("//div[@class='error-message-container error']//h3");

        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        public void FillUsername(string username)
        {
            Type(usernameField, username);
        }

        public void FillPassword(string password) 
        {
            Type(passwordField, password); 
        }

        public void ClickLoginButton()
        {
            Click(loginButton);
        }

        public string GetErrorMessage()
        {
            return GetText(errorMessage);
        }

        public void LoginUser(string username, string password)
        {
            FillUsername(username);
            FillPassword(password);
            ClickLoginButton();
        }
    }
}
