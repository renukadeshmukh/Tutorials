
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockSpanProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] span =  { 100, 80, 60, 70, 60, 75, 85 };
            //int[] span = {10, 4, 5, 90, 120, 80};
            int[] counts = new int[span.Length];

            Stack<int> s = new Stack<int>();
            s.Push(-1);
            for (int i = 0; i < span.Length; i++)
            {
                if (s.Peek() == -1){
                    counts[i] = 1;
                    s.Push(i);
                    Console.WriteLine(counts[i]);
                }
                else if (span[i] < span[s.Peek()])
                {
                    counts[i] = 1;
                    s.Push(i);
                    Console.WriteLine(counts[i]);
                }
                else {
                    int cnt = 1;
                    while (s.Peek() != -1 && span[s.Peek()] < span[i] )
                    {
                        int x =s.Pop();
                        cnt+=counts[x];
                    }
                    counts[i] = cnt;
                    s.Push(i);
                    Console.WriteLine(counts[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
