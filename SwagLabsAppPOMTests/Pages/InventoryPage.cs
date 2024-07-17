using OpenQA.Selenium;

namespace SwagLabsAppPOMTests.Pages
{
    public class InventoryPage : BasePage
    {
        private readonly By cartLink = By.CssSelector(".shopping_cart_link");
        private readonly By productsPageTitle = By.ClassName("title");
        private readonly By productItems = By.CssSelector(".inventory_item");

        public InventoryPage(IWebDriver driver) : base(driver)
        {
        }

        public void AddToCartByIndex(int itemIndex)
        {
            var itemByIndexButton = By.XPath($"//div[@class='inventory_list']//div[@class='inventory_item'][{itemIndex}]//button");
            Click(itemByIndexButton);
        }

        public void AddToCartByName(string name)
        {
            var itemByNameNumber = By.XPath($"//div[text()='{name}']/ancestor::div[@class='inventory_item_description']//button");
            Click(itemByNameNumber);
        }

        public void ClickCartLink()
        {
            Click(cartLink);
        }

        public bool IsInventoryPageHasItemsDisplayed()
        {
            return FindElements(productItems).Any();
        }

        public bool IsInventoryPageLoaded()
        {
            return GetText(productsPageTitle) == "Products" && driver.Url.Contains("inventory.html");
        }
    }
}
