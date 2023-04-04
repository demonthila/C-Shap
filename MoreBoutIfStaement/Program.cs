namespace MoreBoutIfStaement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(madmax(2,10));
            


            Console.ReadLine();
        }

        static int madmax(int num1 , int num2)
        {
            int result;
            if (num1 > num2)
            {
                Console.WriteLine(num1 + " bigger than" + num2);

            }
            else
            {
                Console.WriteLine(num2 + " is bigger than " + num2);
            }
            return result;
        }
    }
}