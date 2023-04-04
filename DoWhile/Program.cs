namespace DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int index;

            Console.WriteLine("Enter a number");
            index = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine(index);
                index++;
            } while (index < 1000);


            Console.ReadLine();
        }
    }
}