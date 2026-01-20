using CSharp_Advance_Programming.NUnit.MathCalculator;

[TestFixture]
public class CalcultorTest
{
    private MathCalculator _calculator;

    [SetUp]
    public void Setup()
    {
        _calculator = new MathCalculator();
    }

    [Test]
    public void Add_ShouldReturnCorrectSum()
    {
        int result = _calculator.Add(5, 3);
        Assert.AreEqual(8, result);
    }

    [Test]
    public void Subtract_ShouldReturnCorrectDifference()
    {
        int result = _calculator.Subtract(10, 4);
        Assert.AreEqual(6, result);
    }

    [Test]
    public void Multiply_ShouldReturnCorrectProduct()
    {
        int result = _calculator.Multiply(4, 5);
        Assert.AreEqual(20, result);
    }

    [Test]
    public void Divide_ShouldReturnCorrectQuotient()
    {
        int result = _calculator.Divide(20, 4);
        Assert.AreEqual(5, result);
    }

    // 👉 BONUS TEST — Division by Zero
    [Test]
    public void Divide_ShouldThrowException_WhenDivisorIsZero()
    {
        Assert.Throws<DivideByZeroException>(
            () => _calculator.Divide(10, 0)
        );
    }
}
