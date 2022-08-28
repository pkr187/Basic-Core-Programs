namespace LeapYear
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            if(num1%100 == 0)
            {
                if (num1 % 400 == 0)
                    Console.WriteLine("Leap Year");
                else
                    Console.WriteLine("Not a leap year");
            }
            else
            {
                if (num1 % 4 == 0)
                    Console.WriteLine("Leap Year");
                else
                    Console.WriteLine("Not a leap year");
            }
            Console.Read();
                
            
        }
    }
}