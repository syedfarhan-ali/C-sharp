namespace CS;

using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
   {
      Console.WriteLine("Enter the size of array : ");
      int size = Convert.ToInt32(Console.ReadLine());
      string [] names = new string[size];

      Console.WriteLine("Enter "+size+" names :");

      for (int i = 0; i < size; i++)
      {
         names[i] = Console.ReadLine();
      }

      Console.WriteLine("----------------------------------------------------------------");

      Array.Sort(names);

      Console.WriteLine("Here they are in alphabatiacl order :)");

      for (int i = 0; i < size; i++)
      {
         Console.WriteLine(names[i],"\n");
      }

      Console.WriteLine("----------------------------------------------------------------");

      Console.ReadKey();
   }
}
