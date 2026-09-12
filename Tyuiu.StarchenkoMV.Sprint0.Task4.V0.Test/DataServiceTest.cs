using Tyuiu.StarchenkoMV.Sprint0.Task4.V0.Lib;
namespace Tyuiu.StarchenkoMV.Sprint0.Task4.V0.Test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.AreEqual(10, DataService.Addition(5, 5));
    }

    [Test]
    public void Test2()
    {
        Assert.AreEqual(5, DataService.Subtraction(10, 5));
    }

    [Test]
    public void Test3()
    {
        Assert.AreEqual(50, DataService.Multiplication(10, 5)); 
    }

    [Test]
    public void Test4()
    {
        Assert.AreEqual(3, DataService.Division(9, 3));
    }

}