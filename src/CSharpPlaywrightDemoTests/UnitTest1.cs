using Allure.NUnit;
using Allure.NUnit.Attributes;

namespace CSharpPlaywrightDemoTests;

[AllureNUnit]
[AllureSuite("PlaywrightTests")]
[Parallelizable(ParallelScope.Self)]
public class Tests : PageTest
{
    [Test]
    public async Task Test1()
    {
        await Page.GotoAsync("https://playwright.dev");

        await Expect(Page).ToHaveTitleAsync(new Regex("Playwright"));

        var getStarted = Page.Locator("text=Get Started");

        await Expect(getStarted).ToHaveAttributeAsync("href", "/docs/intro");

        await getStarted.ClickAsync();
//
        await Expect(Page).ToHaveURLAsync(new Regex(".*intro"));
    }
}
