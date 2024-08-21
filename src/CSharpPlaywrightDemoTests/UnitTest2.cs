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

        await Expect(Page).ToHaveTitleAsync(new Regex("Playwright1"));
    }
}
