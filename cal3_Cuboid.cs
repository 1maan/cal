namespace ConsoleApp7;
class Program
{

    static void Select(out int Cuboid)
    {
        Console.WriteLine("|----------------------|");
        Console.WriteLine("|1)Cuboid              |");
        Console.WriteLine("|----------------------|");
        Console.WriteLine();
        Cuboid = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
    }
    static void CuboidSelect(out int Cuboidtype)
    {
        Console.WriteLine("|----------------------|");
        Console.WriteLine("|1)Volume              |");
        Console.WriteLine("|2)Area                |");
        Console.WriteLine("|----------------------|");
        Console.WriteLine();
        Cuboidtype = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
    }

    static void CuboidVolume()
    {
        int firstCuboidVolume, secondCuboidVolume, thirdCuboidVolume;
        Console.WriteLine();
        Console.Write("Enter the Length number: ");
        firstCuboidVolume = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the Width number: ");
        secondCuboidVolume = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the Height number: ");
        thirdCuboidVolume = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Answer: "+(firstCuboidVolume*secondCuboidVolume*thirdCuboidVolume));
    }

    static void CuboidArea()
    {
        int firstCuboidArea, secondCuboidArea;
        Console.WriteLine();
        Console.Write("Enter the Length number: ");
        firstCuboidArea = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the Width number: ");
        secondCuboidArea = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Answer: " + (firstCuboidArea * secondCuboidArea));
    }





    static void Main(string[] args)
    {
        int Cuboid;
        int Cuboidtype;

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
        }
        
    }
}
