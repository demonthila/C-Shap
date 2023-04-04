namespace BuildingABetterCal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            double result;

            Console.WriteLine("Enter Two numbers ");

            Console.Write("First -");
            num1 = Convert.ToDouble (Console.ReadLine());

            Console.Write("Second -  ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter an opertor ");
            String op = Console.ReadLine();

            if (op == "+")
            {
                Console.WriteLine("Addistion");
                result = (num1 + num2);
                Console.WriteLine(result);

            }
            else if (op == "-")
            {
                Console.WriteLine("Sub");
                result = num1- num2;
                Console.WriteLine(result);
            }
            else if (op =="*")
            {
                Console.WriteLine("Mul");
                result = num1 * num2;
                Console.WriteLine(result);
            }
            else if(op=="/")
                    {
                Console.WriteLine("Devide");
                result = num1 /num2;
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("plese enter the right operator");
            }

            Console.ReadLine();

        }
    }
}