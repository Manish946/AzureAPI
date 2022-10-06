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
    public void GetReturnsMyName(){
        var returnValue = controller.Get(1);
        Assert.Equal("Manish Shrestha", returnValue.Value);
    }

}