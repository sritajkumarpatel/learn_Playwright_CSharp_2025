using Microsoft.Playwright;

namespace learn_Playwright_CSharp_2025;

public class PlaywrightUiTestSwagLabs
{
    [Test]
    public async Task ValidateSwagLabsTitle()
    {
        using var playwright = await Playwright.CreateAsync();
        await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
        {
            Headless = false
        });
        
        var page = await browser.NewPageAsync();
        await page.GotoAsync("https://www.saucedemo.com/");

        var pageTitle = page.Locator(".login_logo");

        var actualTitle = await pageTitle.TextContentAsync();
        
        Console.WriteLine(actualTitle);
        
        Assert.That(actualTitle, Is.Not.Null.Or.Empty);
        Assert.That(actualTitle, Is.EqualTo("Swag Labs"));

        await page.FillAsync("#user-name", "standard_user");
        await page.FillAsync("#password", "secret_sauce");
        
        await page.ClickAsync("#login-button");

        await page.Locator("text=Products").IsVisibleAsync();


    }
}