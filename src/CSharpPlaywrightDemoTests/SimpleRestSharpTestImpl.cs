using System.Text;
using Allure.Net.Commons;
using Allure.NUnit.Attributes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace CSharpPlaywrightDemoTests;

public class SimpleRestSharpTestImpl
{
    private string _uri;
    private RestClient _restclient;
    private RestRequest _request;
    private RestResponse _response;

    public SimpleRestSharpTestImpl(string uri)
    {
        _uri = uri;
        _restclient = new RestClient(_uri);
    }

    public void CreateRequest(string endpointUrl)
    {
        AllureApi.Step($"Tested endpoint - {_uri + endpointUrl}", () =>
            {
                _request = new RestRequest(endpointUrl);
                _response = _restclient.Execute(_request);
                AllureApi.AddAttachment("Response", "application/json",
                    Encoding.UTF8.GetBytes(JToken.Parse(_response.Content).ToString(Formatting.Indented)));
            }
        );
    }
}