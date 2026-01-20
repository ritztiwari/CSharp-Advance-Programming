using NUnit.Framework;
using CSharp_Advance_Programming.NUnit.DatabaseConnection;

[TestFixture]
public class DatabaseConnectionTests
{
    private DatabaseConnection _db;

    [SetUp]
    public void Setup()
    {
        _db = new DatabaseConnection();
        _db.Connect();               // Runs before EVERY test
    }

    [TearDown]
    public void Cleanup()
    {
        _db.Disconnect();            // Runs after EVERY test
    }

    [Test]
    public void Connect_ShouldEstablishConnection()
    {
        Assert.IsTrue(_db.IsConnected);
    }

    [Test]
    public void Disconnect_ShouldCloseConnection()
    {
        _db.Disconnect();
        Assert.IsFalse(_db.IsConnected);
    }
}
