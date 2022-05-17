using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScopesLesson
{
    public class Configuration
    {
        public static string AppName = "Macamies par scopiem";

        public static void Sum()
        {
            Console.WriteLine("Sum was called");
        }
    }
}
//how was before .NET 6
//namespace ScopesLession
//{
//    public static class Program
//    {
//        public static void Main(string[] args)
//        {
//            int number = 15;

//            if (number > 45)
//            {
//                int number2 = number + 5;
//                Console.WriteLine($"Mans skaitlis ir: {number2}");

//                if (number2 < 45)
//                {
//                    int number3 = number2 + 8;
//                    Console.WriteLine($"Mans skaitlis ir: {number3}");
//                }

//                {
//                    int number4 = number2 + 9;
//                    Console.WriteLine($"Mans skaitlis ir: {number4}");
//                }
//            }
//            Console.WriteLine($"Mans skaitlis ir: {number}");

//            string appName = Configuration.AppName;
//            Console.WriteLine($"Aplikācijas nosaukums ir {appName}");

//            // Piemērs ja nebūtu static
//            // Configuration configuration = new Configuration();
//            //configuration.Sum();

//            Configuration.Sum();
//        }
//    }
//}