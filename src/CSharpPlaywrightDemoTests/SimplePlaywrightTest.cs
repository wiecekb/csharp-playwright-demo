
using Allure.NUnit;
using Allure.NUnit.Attributes;

namespace CSharpPlaywrightDemoTests;

[AllureNUnit]
[AllureSuite("Playwright")]
[Parallelizable(ParallelScope.Self)]
public class UnitTests2 : PageTest
{
    [Test]
    [Category("Playwright")]
    public async Task PlaywrightTest()
    {
        var playwrightTestImpl = new MainPage(Page);
        await playwrightTestImpl.OpenWebPage("https://playwright.dev");
    }
}
