namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SayHello("thila", 23);
            Console.ReadLine(); 
        }

        static void SayHello(String name , int age )
        {
            Console.WriteLine("hello "+ name);
        }

        
    }
}