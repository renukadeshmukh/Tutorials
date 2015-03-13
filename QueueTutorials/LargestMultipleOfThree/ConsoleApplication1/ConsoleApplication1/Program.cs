using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            LargestMultipleOfThree lmt = new LargestMultipleOfThree();
            List<int> list = new List<int> { 8, 1, 7, 6, 0 };
            string s = lmt.GetLargestNumber(list);
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
