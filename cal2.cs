namespace ConsoleApp7;
class Program
{

    static void Inputtake(out int number1,out int number2, out string ouperator)
    {
        ouperator = "";
        while(ouperator != "+" || ouperator != "-" || ouperator != "*" || ouperator != "/")
        {
            Console.Write("Enter the operator (+, -, *, /): ");
            ouperator = Console.ReadLine();
            if (ouperator == "+")
            {
                break;
            }
            if (ouperator == "-")
            {
                break;
            }
            if (ouperator == "*")
            {
                break;
            }
            if (ouperator == "/")
            {
                break;
            }
        }
        Console.Write("Enter the first number: ");
        number1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the second  number: ");
        number2 = Convert.ToInt32(Console.ReadLine());
        if (ouperator == "+")
        {
            Console.WriteLine(number1 + ouperator + number2 + " = " + (number1 + number2));
        }
        if (ouperator == "-")
        {
            Console.WriteLine(number1 + ouperator + number2 + " = " + (number1 - number2));
        }
        if (ouperator == "*")
        {
            Console.WriteLine(number1 + ouperator + number2 + " = " + (number1 * number2));
        }
        if (ouperator == "/")
        {
            Console.WriteLine(number1 + ouperator + number2 + " = " + (number1 / number2));
        }
    }

    static void tocontinue(out string wanttocontinue)
    {
        Console.Write("Do you want to continue? (Y/N): ");
        wanttocontinue = Console.ReadLine();
    }

    static void Main(string[] args)
    {
        int number1;
        int number2;
        string ouperator;
        string wanttocontinue;
        Inputtake(out number1, out number2, out ouperator);

        tocontinue(out wanttocontinue);
        while (wanttocontinue == "Y")
        {
            Inputtake(out number1, out number2, out ouperator);
            tocontinue(out wanttocontinue);
            if(wanttocontinue == "N")
            {
                break;
            }
        }

    }
}
