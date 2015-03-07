using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationOfPostfixExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            //231*+9- ==> -4
            int res = c.Evaluate("231*+9-");
            Console.WriteLine(res);

            //2222^2-222*+^*+2-
            int res2 = c.Evaluate("2222^2-222*+^*+2-");
            Console.WriteLine(res2);
            
            Console.ReadKey();
        }
    }
}
