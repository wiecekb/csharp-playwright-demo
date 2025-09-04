using Allure.NUnit;
using Allure.NUnit.Attributes;

namespace CSharpPlaywrightDemoTests;

[AllureNUnit]
[AllureSuite("RestSharp")]
[Parallelizable(ParallelScope.Self)]
public class SimpleRestSharpTest
{
    private readonly SimpleRestSharpTestImpl _simpleRestSharpTestImpl = new("http://api.nbp.pl");

    [Test]
    [Category("RestSharp")]
    public void RestSharpTest()
    { 
        _simpleRestSharpTestImpl.CreateRequest("/api/exchangerates/rates/A/GBP/2019-11-21");
    }
}