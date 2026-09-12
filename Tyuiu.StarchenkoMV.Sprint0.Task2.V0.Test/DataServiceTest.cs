using Tyuiu.StarchenkoMV.Sprint0.Task2.V0.Lib;
namespace Tyuiu.StarchenkoMV.Sprint0.Task2.V0.Test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CheckGetMessageValid()
    {
        var name = "Матвей";
        var res = DataService.GetMessage(name);
        Assert.AreEqual("Привет, Матвей", res);
    }
}