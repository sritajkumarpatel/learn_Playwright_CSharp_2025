using Microsoft.Playwright;

namespace learn_Playwright_CSharp_2025;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public async Task Test1()
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