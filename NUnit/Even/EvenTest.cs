using CSharp_Advance_Programming.NUnit.Even;

public class Tests
{
    private EvenNumber _evenNumber;

    [SetUp]
    public void Setup()
    {
        _evenNumber = new EvenNumber();
    }

    //testing the multiple inputs on the same method.
    //it checks the number is even or not.
    [TestCase(2, true)]
    [TestCase(4, true)]
    [TestCase(6, true)]
    [TestCase(7, false)]
    [TestCase(9, false)]
    public void IsEven_ShouldReturnCorrectResult(int input, bool expected)
    {
        bool result = _evenNumber.FindEven(input);

        Assert.AreEqual(expected, result);
    }
}
