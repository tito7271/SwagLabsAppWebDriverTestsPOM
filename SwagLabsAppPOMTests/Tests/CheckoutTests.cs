namespace SwagLabsAppPOMTests.Tests
{
    public class CheckoutTests : BaseTest
    {
        [SetUp]
        public void Setup() 
        {
            Login("standard_user", "secret_sauce");
            inventoryPage.AddToCartByIndex(1);
            inventoryPage.ClickCartLink();
            cartPage.ClickCheckoutButton();
        }

        [Test]
        public void TestCheckoutPageLoaded()
        {
            Assert.That(checkoutPage.IsPageLoaded(), Is.True, "Checkout page is not navigated correctly");
        }

        [Test]
        public void TestContinueToNextStep()
        {
            checkoutPage.FillFirstName("Petar");
            checkoutPage.FillLastName("Petrov");
            checkoutPage.FillPostalCode("1000");
            checkoutPage.ClickContinueButton();

            Assert.That(driver.Url.Contains("checkout-step-two.html"), Is.True, "Not navigated to correct checkout page");
        }

        [Test]
        public void TestCompleteOrder()
        {
            checkoutPage.FillFirstName("Petar");
            checkoutPage.FillLastName("Petrov");
            checkoutPage.FillPostalCode("1000");
            checkoutPage.ClickContinueButton();
            checkoutPage.ClickFinishButton();

            Assert.That(checkoutPage.IsCheckoutComplete(), Is.True, "Checkout is not completed");
        }
    }
}
