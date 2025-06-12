using learn_Playwright_CSharp_2025.Pages;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;

namespace learn_Playwright_CSharp_2025;

public class NUnitPlaywrightSwagLabs : PageTest
{
    
    [SetUp]
    public async Task Setup()
    {
        await Page.GotoAsync("https://www.saucedemo.com/");
    }
    
    [Test]
    public async Task ValidateSwagLabsTitle()
    {
        
        await Expect(Page.Locator(".login_logo")).ToBeVisibleAsync();
        await Expect(Page.Locator(".login_logo")).ToContainTextAsync("Swag Labs");

        await Page.FillAsync("#user-name", "standard_user");
        await Page.FillAsync("#password", "secret_sauce");
        
        await Page.ClickAsync("#login-button");
        await Expect(Page.Locator("text=Products")).ToBeVisibleAsync();


    }
 
    [Test]
    public async Task ValidateSwagLabsTitlePom()
    {
        
        LoginPage loginPage = new LoginPage(Page);
        ProductPage productPage = new ProductPage(Page);
        await loginPage.Login("standard_user", "secret_sauce");
        await productPage.VerifyPageTitle();

    }

    [Test]
    public async Task LoginToSwagLabs()
    {
        LoginPageUpgraded loginPageUpgraded = new LoginPageUpgraded(Page);
        loginPageUpgraded.LoginUpgraded("standard_user", "secret_sauce");
    }
}