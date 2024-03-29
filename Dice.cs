namespace Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random numberGen = new Random();
            int roll1 = 1,roll2 = 0, attempts = 0;
            while (roll1 != roll2) 
            {
               
                roll1 = numberGen.Next(1, 7);
                roll2 = numberGen.Next(1, 7);
                Console.WriteLine("Your rolled 1st : " + roll1);
                Console.WriteLine("Your rolled 2nd : " + roll2 + "\n" );
                attempts++;
            }
            Console.WriteLine("It took you " + attempts +" attempts to roll two of a kind");

        }
    }
}
