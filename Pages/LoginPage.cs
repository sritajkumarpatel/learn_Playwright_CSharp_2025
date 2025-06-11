using Microsoft.Playwright;

namespace learn_Playwright_CSharp_2025.Pages;

public class LoginPage
{
    private IPage  _page;
    private readonly ILocator _uname;
    private readonly ILocator _password;
    private readonly ILocator _loginButton;
    // private readonly ILocator _productTitle;
    
    public LoginPage(IPage page)
    {
        _page = page;
        _uname = page.Locator("#user-name");
        _password = page.Locator("#password");
        _loginButton = page.Locator("#login-button");
        // _productTitle = page.Locator("text=Products");
    }
    
    public async Task Login(string userName, string password)
    {
        await _uname.FillAsync(userName);
        await _password.FillAsync(password);
        await _loginButton.ClickAsync();
        // await _productTitle.IsVisibleAsync();
    }
    
    
}