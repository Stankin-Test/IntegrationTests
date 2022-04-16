using NUnit.Framework;

[TestFixture]
public class IntegrationTests
{
    [Test]
    public async Task Test()
    {
        var httpClient = new HttpClient()
        {
            BaseAddress = new Uri("http://172.17.0.1:80"),
        };
        var response = await httpClient.GetAsync("/WeatherForecast");
        var content = await response.Content.ReadAsStringAsync();
        TestContext.Out.WriteLine(content);
        StringAssert.Contains("temperatureC", content);
    }
}