/*public class ParkingSystem
{
    public int Small { get; private set; }
    public int Medium { get; private set; }
    public int Big { get; private set; }

    public ParkingSystem(int big, int medium, int small)
    {
        Big = big;
        Medium = medium;
        Small = small;
    }

    public bool AddCar(int carType)
    {
        switch (carType)
        {
            case 1: if (Big > 0) { Big--; break; } else return false; 
            case 2: if (Medium > 0) { Medium--; break; } else return false;
            case 3: if (Small > 0) { Small--; break; } else return false;
            default: return false;
        }

        return true;
    }
}*/

public class ParkingSystem
{
    public int Small { get; private set; }
    public int Medium { get; private set; }
    public int Big { get; private set; }

    public ParkingSystem(int big, int medium, int small)
    {
        Big = big;
        Medium = medium;
        Small = small;
    }

    public bool AddCar(int carType)
    {
        switch (carType)
        {
            case 1 when Big > 0:
                Big--;
                return true;
            case 2 when Medium > 0:
                Medium--;
                return true;
            case 3 when Small > 0:
                Small--;
                return true;
            default:
                return false;
        }
    }
}