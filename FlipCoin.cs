namespace FlipCoin
{
    public class Program
    {
        static void Main(string[] args)
        {
            // INITIALIZATION
            Random ran = new Random();
            int randNum = ran.Next();
            Console.WriteLine("guess head or tail");
            string guess = Console.ReadLine();
            if (randNum == 1 && guess == "Heads")
            {
                Console.WriteLine("the coin flip was heads, you win!");
            }
            else if (randNum == 2 && guess == "Tails")
            {
                Console.WriteLine("the coin flip was Tails, you win:");
            }
            else
            {
                string result;
                if (randNum == 1)
                {
                    result = "Heads";
                }
                else
                {
                    result = "Tails";
                }
                Console.WriteLine("you lose the coin flip was {0}", result);
                Console.WriteLine("press any key to quit");
                Console.ReadKey();
            }
            Console.ReadLine();
        }
    }
}