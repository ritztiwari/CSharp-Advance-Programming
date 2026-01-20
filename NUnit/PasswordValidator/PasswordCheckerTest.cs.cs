using CSharp_Advance_Programming.NUnit.PasswordValidator;

public class Tests
{
    private PasswordChecker validator;

    [SetUp]
    public void Setup()
    {
        validator = new PasswordChecker();
    }

    [Test]
    public void ValidPassword()
    {
        string password = "Password12";

        bool result = validator.IsStrongPassword(password);

        Assert.IsTrue(result);
    }

    [Test]
    public void Password_TooShort()
    {
        string password = "Pass1";

        bool result = validator.IsStrongPassword(password);

        Assert.IsFalse(result);
    }

    [Test]
    public void Password_NoUppercase()
    {
        string password = "password123";

        bool result = validator.IsStrongPassword(password);

        Assert.IsFalse(result);
    }

    [Test]
    public void Password_NoDigit()
    {
        string password = "Password";

        bool result = validator.IsStrongPassword(password);

        Assert.IsFalse(result);
    }

    [Test]
    public void NullPassword()
    {
        string password = null;

        bool result = validator.IsStrongPassword(password);

        Assert.IsFalse(result);
    }
}
