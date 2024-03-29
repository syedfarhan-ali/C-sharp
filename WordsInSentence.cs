namespace CS;

using System.Collections;


class Program
{
    static void Main(string[] args)
   {
      Console.WriteLine("Enter your sentence :");
      string sentence = Console.ReadLine();
     
     int wordCount = countwords(sentence);

     Console.WriteLine("You have "+wordCount+" words in your sentence");
      
      Console.ReadKey();
   }
   static int countwords(string sentence)
   {
      int wordCount = sentence.Split(' ').Length;

      return wordCount;
   }
}
