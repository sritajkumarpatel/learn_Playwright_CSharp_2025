using Microsoft.Playwright;

namespace learn_Playwright_CSharp_2025;

public class GoogleHomePage
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public async Task ValidateGoogleHomePage()
    {
        using var playwright = await Playwright.CreateAsync();
        await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
        {
            Headless = false
        });
        
        var page = await browser.NewPageAsync();
        await page.GotoAsync("https://google.com/");
        
        var aboutLink = page.Locator("text=About");
        await aboutLink.IsVisibleAsync();

        await page.ScreenshotAsync(new PageScreenshotOptions
        {
            Path = "Google.jpg"
        });

    }
}