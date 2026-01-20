using System.Reflection;

using CSharp_Advance_Programming.NUnit.ListManager;

public class ListManagerTest
{

    private ListManager _listManager;
    private List<int> _list;

    [SetUp]
    public void Setup()
    {
        _listManager = new ListManager();
        _list = new List<int>();
    }

    [Test]
    public void AddElementInList()
    {
        _listManager.AddElement(_list,10);
        Assert.AreEqual(1,_list.Count);
        Assert.Contains(10,_list);
    }

        [Test]
    public void AddElement_ShouldAddMultipleValues()
    {
        _listManager.AddElement(_list, 5);
        _listManager.AddElement(_list, 15);

        Assert.AreEqual(2, _listManager.GetSize(_list));
    }

    // -------- Remove Tests --------

    [Test]
    public void RemoveElement_ShouldRemoveExistingElement()
    {
        _listManager.AddElement(_list, 20);
        _listManager.RemoveElement(_list, 20);

        Assert.AreEqual(0, _listManager.GetSize(_list));
    }

    [Test]
    public void RemoveElement_ShouldDoNothing_WhenElementNotPresent()
    {
        _listManager.AddElement(_list, 30);
        _listManager.RemoveElement(_list, 99);   // not in list

        Assert.AreEqual(1, _listManager.GetSize(_list));
    }

    // -------- Size Tests --------

    [Test]
    public void GetSize_ShouldReturnCorrectCount()
    {
        _listManager.AddElement(_list, 1);
        _listManager.AddElement(_list, 2);
        _listManager.AddElement(_list, 3);

        Assert.AreEqual(3, _listManager.GetSize(_list));
    }
}
