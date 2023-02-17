namespace ConsoleApp7;
class Program
{

    static void Select(out double Cuboid)
    {
        Console.WriteLine("|----------------------|");
        Console.WriteLine("|1)Cuboid              |");
        Console.WriteLine("|----------------------|");
        Console.WriteLine();
        Cuboid = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
    }
    static void CuboidSelect(out double Cuboidtype)
    {
        Console.WriteLine("|----------------------|");
        Console.WriteLine("|1)Volume              |");
        Console.WriteLine("|2)Area                |");
        Console.WriteLine("|3)Total Surfce area   |");
        Console.WriteLine("|----------------------|");
        Console.WriteLine();
        Cuboidtype = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine();
    }

    static void CuboidVolume()
    {
        double firstCuboidVolume, secondCuboidVolume, thirdCuboidVolume;
        Console.WriteLine();
        Console.Write("Enter the Length number: ");
        firstCuboidVolume = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the Width number: ");
        secondCuboidVolume = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the Height number: ");
        thirdCuboidVolume = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Cuboid Volume: " + (firstCuboidVolume*secondCuboidVolume*thirdCuboidVolume));
    }

    static void CuboidArea()
    {
        double firstCuboidArea, secondCuboidArea;
        Console.WriteLine();
        Console.Write("Enter the Length number: ");
        firstCuboidArea = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the Width number: ");
        secondCuboidArea = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Cuboid Area: " + (firstCuboidArea * secondCuboidArea));
    }

    static void CuboidTotalSurfcearea()
    {
        double firstTotalSurfcearea, secondTotalSurfcearea, thirdTotalSurfcearea;
        Console.WriteLine();
        Console.Write("Enter the Length number: ");
        firstTotalSurfcearea = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the Width number: ");
        secondTotalSurfcearea = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the Height number: ");
        thirdTotalSurfcearea = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Cuboid Total Surfce area: " + (2*((firstTotalSurfcearea* secondTotalSurfcearea)+(firstTotalSurfcearea* thirdTotalSurfcearea)+(secondTotalSurfcearea* thirdTotalSurfcearea))));
    }




    static void Main(string[] args)
    {
        double Cuboid;
        double Cuboidtype;

        Select(out Cuboid);
        if (Cuboid == 1)
        {
            CuboidSelect(out Cuboidtype);
            if(Cuboidtype == 1)
            {
                CuboidVolume();
            }
            if (Cuboidtype == 2)
            {
                CuboidArea();
            }
            if (Cuboidtype == 3)
            {
                CuboidTotalSurfcearea();
            }
        }
        
    }
}
