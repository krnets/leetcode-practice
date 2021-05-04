using NUnit.Framework;

public class SolutionTests
{
    ParkingSystem parkingSystem = new ParkingSystem(1, 1, 0);

    [Test]
    public void ExampleTest1()
    {
        Assert.AreEqual(true, parkingSystem.AddCar(1));
    }

    [Test]
    public void ExampleTest2()
    {
        Assert.AreEqual(true, parkingSystem.AddCar(2));
    }

    [Test]
    public void ExampleTest3()
    {
        Assert.AreEqual(false, parkingSystem.AddCar(3));
    }

    [Test]
    public void ExampleTest4()
    {
        Assert.AreEqual(false, parkingSystem.AddCar(1));
    }
}