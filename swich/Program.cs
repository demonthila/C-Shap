
namespace swich
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(getDay(0));

        }
        static string getDay(int dayNum)
        {
            String dayName;

            switch (dayNum)
            {
                case 0:
                    dayName = "sunday";
                    break;
                case 1:
                    dayName = "Tuesday";
                    break;
                case 2:
                    dayName = "Wed";
                    break;

                case 3:
                    dayName = "thur";
                    break;
                case 4:
                    dayName = "fri";
                    break;
                case 5:
                    dayName = "sat";
                    break;
                default:
                    dayName = "invalid daynumber";
                    break;

                    

            }
            return dayName;

        }
    }
}