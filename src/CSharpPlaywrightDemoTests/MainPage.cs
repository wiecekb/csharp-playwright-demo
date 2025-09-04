using Allure.Net.Commons;
using Microsoft.Playwright;

namespace CSharpPlaywrightDemoTests;

public class MainPage:PageTest
{
    private readonly IPage _page;
    public MainPage(IPage page)
    {
        _page = page;
    }

    public async Task OpenWebPage(string url)
    {
        await _page.GotoAsync(url);
        AllureApi.AddAttachment("mainWebPage.png", "image/png", await _page.ScreenshotAsync(new() {FullPage = true}));
        await Expect(_page).ToHaveTitleAsync(new Regex("Playwright"));
    }
}