using RestSharp;

namespace CSharpPlaywrightDemoTests;

public class SimpleRestSharpTestImpl
{
    private string _uri;
    private  RestClient _restclient;
    private  RestRequest _request;
    public SimpleRestSharpTestImpl(string uri)
    {
        _uri = uri;
        _restclient = new RestClient(_uri);
    }

    public void CreateRequest(string endpointUrl)
    {
        _request = new RestRequest(endpointUrl);
        var response = _restclient.Execute(_request);
        System.Console.WriteLine();
    }
}