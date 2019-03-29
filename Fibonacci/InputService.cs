using System;

namespace Fibonacci
{
    public class InputService
    {
        public static int GetParam(string str)
        {
            Console.WriteLine(str);
            try
            {
                return Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid param");
                GetParam(str);
                return 0;
            }
        }
    }
}
