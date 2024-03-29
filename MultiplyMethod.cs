namespace CS;

using System.Collections;


class Program
{
    static void Main(string[] args)
   {
      int result = Multiply(3,8);
      Console.WriteLine("The result is "+result);

      if(result % 2 == 0)
      {
         Console.WriteLine("It's an even number");
      }
      else
      {
         Console.WriteLine("It's an odd number");
         
      }

      Console.ReadKey();
   }
   static int Multiply(int num01, int num02)
   {
      int result = num01 * num02;
      return result;
   }
}
