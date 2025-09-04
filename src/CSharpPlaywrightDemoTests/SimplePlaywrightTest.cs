
using Allure.NUnit;
using Allure.NUnit.Attributes;

namespace CSharpPlaywrightDemoTests;

[AllureNUnit]
[AllureSuite("UnitTests")]
[Parallelizable(ParallelScope.Self)]
public class UnitTests2 : PageTest
{
    [Test]
    [Category("Fast")]
    public async Task Test2()
    {
        var testClass = new MainPage(Page);
        await testClass.OpenWebPage("https://playwright.dev");
    }
}
