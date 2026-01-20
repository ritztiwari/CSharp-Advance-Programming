using System;
using System.Buffers;
using System.Reflection;
using  CSharp_Advance_Programming.NUnit.ExceptionHandling;

public class ExceptionHandlingTest
{

    private Operations _operations;

    [SetUp]
    public void Setup()
    {
        _operations = new Operations();
    }

    [Test]
    public void TestDivison()
    {
        int result = _operations.Division(10,2);
        Assert.AreEqual(5,result);
    }

    [Test]
    public void TestExceptionHanlding()
    {
        int result = _operations.Division(10,0);
        Assert.AreEqual(5,result);
    }
}
