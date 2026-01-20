using System.Runtime.InteropServices;
using CSharp_Advance_Programming.NUnit.PerformanceTest;

public class PerformanceTests
{
    private Performance _performance;

    [SetUp]
    public void Setup()
    {
        _performance = new Performance();
    }

    [Test]
    [Timeout(5000)]
    public void Test1()
    {
        string temp = _performance.TimeDelay();
        Assert.AreEqual("Done",temp);
    }
}
