using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //CheckStandardSingleton();
            CheckStandardSingletonFailureWithThreads();
            Console.ReadKey();
        }

        /// <summary>
        /// Check for regular object creation based on single instace
        /// </summary>
        static void CheckStandardSingleton()
        {
            StandardSingleton standardSingletonObject = StandardSingleton.GetStandardSingletonInstance();
            Console.WriteLine(standardSingletonObject.Add(1, 2));
        }

        /// <summary>
        /// Check for object creation based multiple threads
        /// </summary>
        static void CheckStandardSingletonFailureWithThreads()
        {
            List<int> listofNumbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            try
            {
                Parallel.ForEach(listofNumbers, (number) =>
                {
                    StandardSingleton standardSingletonObject = StandardSingleton.GetStandardSingletonInstance();
                    Console.WriteLine(standardSingletonObject.Add(1, 2));
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
