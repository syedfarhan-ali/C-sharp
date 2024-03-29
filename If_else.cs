namespace If_Else
{
    internal class IfElse
    {
        static void Main()
        {
            int marks;
                Console.WriteLine("Welcome to pass fail teller!");
                Console.WriteLine("State ur marks out of 100");

            marks = Convert.ToInt32(Console.ReadLine());
            if (marks <= 100)
            {
                if (marks >= 33)
                {
                    Console.WriteLine("CONGRATS YOU PASSED!");
                }
                else
                {
                    Console.WriteLine("SORRY BUT YOU FAILED T_T");
                }
            }
            else
            {
                Console.WriteLine("INVALID MARKS!!!");
            }
        }
    }
}
