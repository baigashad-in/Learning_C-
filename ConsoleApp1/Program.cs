namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            // WAP to input two numbers and find their sum
            //int a, b;
            //Console.WriteLine("Enter two numbers");
            //a = Convert.ToInt32(Console.ReadLine());
            //b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Sum = " + (a + b) + " Hello this is the result of " + a + " + " + b);


            EvenOrOdd.Func1();

        }
    }

    static class EvenOrOdd
    {

        public static void Func1()
        {
            // WAP to input a number and check enve or odd
            int num;
            Console.WriteLine("Enter a number : ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is an even number");
            }
            else
            {
                Console.WriteLine($"{num} is an odd number");
            }
        }
        
    }



}
