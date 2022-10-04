namespace AzureAPI.Tests;
using AzureAPI.Controllers;
public class UnitTest1
{
    [Fact]
    public void Test1()
    {

    }

    ValuesController controller = new ValuesController();
    [Fact]
    public void GetWeatherForecast(){
        var returnValue = controller.Get(1);
        Assert.Equal("Les Jackson", returnValue.Value);
    }

}