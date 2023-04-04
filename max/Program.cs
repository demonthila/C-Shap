namespace max
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num1;
            int num2;
            int num3;

            Console.WriteLine("Enter the first number");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second Number ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Third Number");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1>num2 && num1 > num3)
            {
                Console.WriteLine(num1);
            }
            else if (num2>num1 && num2 > num3)
            {
                Console.WriteLine(num2);
            }
            else
            {
                Console.WriteLine(num3);
            }


            Console.ReadLine();

        }
    }
}