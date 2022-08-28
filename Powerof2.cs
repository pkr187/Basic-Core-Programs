namespace Power_of_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ispowertwo(8));
            Console.ReadKey();
        }
        static bool ispowertwo(ulong input)
        {
            return ((input & (input - 1)) == 0);
        }
        
    }
}