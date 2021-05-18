using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        string[] list1 = {"Shogun", "Tapioca Express", "Burger King", "KFC"};
        string[] list2 = {"Piatti", "The Grill at Torrey Pines", "Hungry Hunter Steakhouse", "Shogun"};
        var expected = new[] {"Shogun"};
        Assert.AreEqual(expected, s.FindRestaurant(list1, list2));
    }

    [Test]
    public void ExampleTest2()
    {
        string[] list1 = {"Shogun", "Tapioca Express", "Burger King", "KFC"};
        string[] list2 = {"KFC", "Shogun", "Burger King"};
        var expected = new[] {"Shogun"};
        Assert.AreEqual(expected, s.FindRestaurant(list1, list2));
    }

    [Test]
    public void ExampleTest3()
    {
        string[] list1 = {"Shogun", "Tapioca Express", "Burger King", "KFC"};
        string[] list2 = {"KFC", "Burger King", "Tapioca Express", "Shogun"};
        var expected = new[] {"KFC", "Burger King", "Tapioca Express", "Shogun"};
        Assert.AreEqual(expected, s.FindRestaurant(list1, list2));
    }

    [Test]
    public void ExampleTest4()
    {
        string[] list1 = {"Shogun", "Tapioca Express", "Burger King", "KFC"};
        string[] list2 = {"KNN", "KFC", "Burger King", "Tapioca Express", "Shogun"};
        var expected = new[] {"KFC", "Burger King", "Tapioca Express", "Shogun"};
        Assert.AreEqual(expected, s.FindRestaurant(list1, list2));
    }

    [Test]
    public void ExampleTest5()
    {
        string[] list1 = {"KFC"};
        string[] list2 = {"KFC"};
        var expected = new[] {"KFC"};
        Assert.AreEqual(expected, s.FindRestaurant(list1, list2));
    }
}