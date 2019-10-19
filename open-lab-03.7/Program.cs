using System;

namespace open_lab_03._7
{
    class Program
    {
        public static bool EqualSlices(int total, int people, int each)
        {
            return (true);
        }

        static void Main(string[] args)
        {
            int total = Convert.ToInt32(Console.ReadLine());
            int people = Convert.ToInt32(Console.ReadLine());
            int each = Convert.ToInt32(Console.ReadLine());
            if (people * each <= total)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

        }
    }
}
