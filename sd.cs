using System.Reflection.Metadata;

class aeomv
{
    static void Main()
    {
        Console.WriteLine("Pick Between 1 and 5:");
        Console.WriteLine("------------------");
        Console.WriteLine("1: Addition");
        Console.WriteLine("2: Subtraction");
        Console.WriteLine("3: Multiplication");
        Console.WriteLine("4: Division");
        Console.WriteLine("5: Modules");
        Console.WriteLine("------------------");
        int Opction = Convert.ToInt32(Console.ReadLine());
        while (Opction > 5 || Opction < 1)
        {
            Console.WriteLine("Pick Between 1 and 5:");
            Opction = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("\nEnter First Number: ");
        double number1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\nEnter Second Number: ");
        double number2 = Convert.ToDouble(Console.ReadLine());
       
        if(Opction == 1)
        {
            Console.WriteLine("Answer: " + (number1 + number2));
        }
        if (Opction == 2)
        {
            Console.WriteLine("Answer: " + (number1 - number2));
        }
        if (Opction == 3)
        {
            Console.WriteLine("Answer: " + (number1 * number2));
        }
        if (Opction == 4)
        {
            Console.WriteLine("Answer: " + (number1 / number2));
        }
        if (Opction == 5)
        {
            Console.WriteLine("Answer: " + (number1 % number2));
        }

    }
}

