using Allure.Net.Commons;
using Allure.NUnit;
using Allure.NUnit.Attributes;

namespace CSharpPlaywrightDemoTests;

[AllureNUnit]
[AllureSuite("UnitTests")]
[Parallelizable(ParallelScope.Self)]
public class UnitTests2 : PageTest
{
    [Test]
    public async Task Test2()
    {
        await Page.GotoAsync("https://playwright.dev");
        AllureApi.AddAttachment("image1.png", "image/png", await Page.ScreenshotAsync(new() {FullPage = true}));
        await Expect(Page).ToHaveTitleAsync(new Regex("Playwright"));
    }

    [Test]
    public async Task Test22()
    {
        await Task.CompletedTask;
    }
}
