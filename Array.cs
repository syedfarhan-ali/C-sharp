namespace CS;

class Program
{
    static void Main(string[] args)
    {
       string [] names = new string[4]; // assignment of string variable to 4 spaces

       Console.WriteLine("Type four names");

       for (int i = 0; i < names.Length; i++)
       {
            names[i] = Console.ReadLine(); 
       }
       Console.WriteLine("\nHere they are alphabetically : ");

       Array.Sort(names);

       for (int i = 0; i < names.Length; i++)
       {
            Console.WriteLine(names[i]); 
       }

       Console.ReadKey();
    }
}
