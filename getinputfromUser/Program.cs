using System.Transactions;

namespace getinputfromUser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name");
            String name = Console.ReadLine();
            Console.WriteLine("Enter your age");
            String age = Console.ReadLine();

            Console.WriteLine("Hello"+name+"You are "+age);
             


            Console.ReadLine();
        }
    }
}