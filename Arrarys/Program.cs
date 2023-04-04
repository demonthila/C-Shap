using System.Transactions;

namespace Arrarys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //createing an arrary

            int[] Luncynum = {1, 2, 3, 4, 5};
            String[] friends = new string[5];

            friends[0] = "devanji";
            friends[1] = "navo";
            friends[2] = "yashoda";

            for (int i=0; i<3; i++)
            {
                Console.WriteLine("Enter your friends Name");
            }

            
            Console.ReadLine();
        }
    }
}