namespace ReturnStaement_2
{
    internal class Program

        // in a if condition there are two conditions eg   I wake up
                                                         //if I am Hungry 
                                                         //I eat breakfast 
    {
        static void Main(string[] args)
        {
            hungry();
            Console.ReadLine();
        }

        static void hungry()
        {
            bool IsMale = true;
            bool IsTall = true;

            
            if (IsMale && IsTall)// && if u use this must be true both || if this use at lest one should be true 
            {
                Console.WriteLine("You are a boy and you are tall");
            }// ! nigationof the operator  

            else if (!IsTall && IsMale)
            {
                Console.WriteLine("You are male but not tall");
            }
            else if (!IsMale && IsTall)
            {
                Console.WriteLine("You are girl But you are tall");
            }
            else
            {
                Console.WriteLine("so you are a girl and you are tall enough  ");
            }

        }
    }
}