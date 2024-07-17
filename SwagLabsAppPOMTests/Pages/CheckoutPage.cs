using OpenQA.Selenium;

namespace SwagLabsAppPOMTests.Pages
{
    public class CheckoutPage : BasePage
    {
        private readonly By firstNameField = By.Id("first-name");
        private readonly By lastNameField = By.Id("last-name");
        private readonly By postalCodeField = By.Id("postal-code");
        private readonly By continueButton = By.Id("continue");
        private readonly By finishButton = By.Id("finish");
        private readonly By completeHeader = By.CssSelector(".complete-header");
        public CheckoutPage(IWebDriver driver) : base(driver)
        {
        }

        public void FillFirstName(string firstName)
        {
            Type(firstNameField, firstName);
        }
        public void FillLastName(string lastName)
        {
            Type(lastNameField, lastName);
        }

        public void FillPostalCode(string postalCode)
        {
            Type(postalCodeField, postalCode);
        }

        public void ClickContinueButton()
        {
            Click(continueButton);
        }

        public void ClickFinishButton()
        {
            Click(finishButton);
        }

        public bool IsPageLoaded() 
        {
            return driver.Url.Contains("checkout-step-one.html") || driver.Url.Contains("checkout-step-two.html");
        }

        public bool IsCheckoutComplete()
        {
            return GetText(completeHeader) == "Thank you for your order!";
        }
    }
}