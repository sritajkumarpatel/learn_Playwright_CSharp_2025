using Microsoft.Playwright;

namespace learn_Playwright_CSharp_2025.Pages;

public class LoginPageUpgraded
{
    private IPage  _page;
    
    public LoginPageUpgraded(IPage page) => _page = page;
    private ILocator _uname => _page.Locator("#user-name");
    private ILocator _password => _page.Locator("#password");
    private ILocator _loginButton => _page.Locator("#login-button");
    
    
    public async Task LoginUpgraded(string userName, string password)
    {
        await _uname.FillAsync(userName);
        await _password.FillAsync(password);
        await _loginButton.ClickAsync();
        // await _productTitle.IsVisibleAsync();
    }
    
    
}