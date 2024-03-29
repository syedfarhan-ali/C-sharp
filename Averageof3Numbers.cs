using System.ComponentModel;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x,y,z;
            Console.WriteLine("Average of 3 numbers! \nEnter First number :");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Second number :");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Third number :");
            z = Convert.ToDouble(Console.ReadLine());

            double Result = (x + y + z) / 3;
            Console.WriteLine("The average of "+x+" , " +y+ " and " +z+ " is : "+Result);
        }
    }
}
