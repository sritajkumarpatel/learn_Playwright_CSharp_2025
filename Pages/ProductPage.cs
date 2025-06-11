using Microsoft.Playwright;

namespace learn_Playwright_CSharp_2025.Pages;

public class ProductPage
{
    private IPage _page;
    private readonly ILocator _productTitle;

    public ProductPage(IPage page)
    {
        _productTitle = page.Locator("text=Products");
    }

    public async Task VerifyPageTitle()
    {
        await _productTitle.IsVisibleAsync();
    }
}