namespace BuildingAMadLib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String color, pluralnoun, Aname;

            Console.Write("Enter a color");
            color = Console.ReadLine();

            Console.WriteLine("Enter a plural noun");
            pluralnoun = Console.ReadLine();

            Console.WriteLine("Enter a name some you love");
            Aname = Console.ReadLine();

            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralnoun +" are blue ");
            Console.WriteLine("I love "+Aname);


            Console.ReadLine();
        }
    }
}