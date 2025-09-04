using System.Text;
using Allure.Net.Commons;
using RestSharp;

namespace CSharpPlaywrightDemoTests;

public class SimpleRestSharpTestImpl
{
    private string _uri;
    private  RestClient _restclient;
    private  RestRequest _request;
    private RestResponse _response;
    public SimpleRestSharpTestImpl(string uri)
    {
        _uri = uri;
        _restclient = new RestClient(_uri);
    }

    public void CreateRequest(string endpointUrl)
    {
        _request = new RestRequest(endpointUrl);
        _response = _restclient.Execute(_request);
        AllureApi.AddAttachment("mainWebPage.png", "application/json",  Encoding.UTF8.GetBytes(_response.Content),"json");
        System.Console.WriteLine();
    }
}