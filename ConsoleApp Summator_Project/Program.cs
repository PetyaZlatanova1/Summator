using System;

namespace Summator
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Summator.Sum(new int[] { 1, 2, 3, 8, 5 });
            if (result == 19)
            {
                Console.WriteLine("TEST PASS");
            }
            else
            {
                Console.WriteLine("TEST FAIL");
            }
            
             result = Summator.Averag(new int[] { 3, 5 });

            if (result == 4)
            {
                Console.WriteLine("TEST PASS");

            }
            else {
                Console.WriteLine("TEST FAIL");
            }
                }
    }
}
