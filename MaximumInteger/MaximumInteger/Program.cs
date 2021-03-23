using System;

namespace MaximumInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            FindTheMaximum find = new FindTheMaximum();
            Console.WriteLine(find.MaximumIntegerNumber(10, 20, 30));
        }
    }
}
