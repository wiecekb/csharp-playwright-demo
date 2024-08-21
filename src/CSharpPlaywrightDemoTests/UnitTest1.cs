namespace CSharpPlaywrightDemoTests;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class Tests : PageTest
{
    [Test]
    public async Task HomepageHasPlaywrightInTitleAndGetStartedLinkLinkingtoTheIntroPage()
    {
        await Page.GotoAsync("https://playwright.dev");

        await Expect(Page).ToHaveTitleAsync(new Regex("Playwright"));

        var getStarted = Page.Locator("text=Get Started");

        await Expect(getStarted).ToHaveAttributeAsync("href", "/docs/intro");

        await getStarted.ClickAsync();

        await Expect(Page).ToHaveURLAsync(new Regex(".*intro"));
    }
}
