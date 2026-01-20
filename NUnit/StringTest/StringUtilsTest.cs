
using CSharp_Advance_Programming.NUnit.StringUtils;

[TestFixture]
public class StringUtilsTest
{
    private StringUtils _stringUtils;

    [SetUp]
    public void Setup()
    {
        _stringUtils = new StringUtils();
    }

    [Test]
    public void IsReverse()
    {
        string result =_stringUtils.Reverse("hello");
        Assert.AreEqual("olleh",result);
    }

    [Test]
    public void IsStringPalindrome()
    {
        bool result = _stringUtils.IsPalindrome("aba");
        Assert.AreEqual(true,result);
    }

    [Test]
    public void ToUpperCase()
    {
        string result = _stringUtils.ToUpperCase("hello");
        Assert.AreEqual("HELLO", result);
    }
}
