namespace CS;

using System.Collections;


class Program
{
    static void Main(string[] args)
   {
      for (int i = 0; i < 10; i++)
      {
        // Console.WriteLine("Press any key to meet an alien...");
        // Console.ReadKey();
         MeetAlien();
         Console.WriteLine("------------------------------------");
      }
      Console.WriteLine("Press any key to exit...");
      Console.ReadKey();
   }
   static void MeetAlien()
   {
      Random numberGen = new Random();

      string name = "X-" + numberGen.Next(10,999);
      int age = numberGen.Next(10,500);

      Console.WriteLine("Hi , I'm " +name );
      Console.WriteLine("I'm " +age+ " years old." );
      Console.WriteLine("Oh , I am an alien.");
   }
}
