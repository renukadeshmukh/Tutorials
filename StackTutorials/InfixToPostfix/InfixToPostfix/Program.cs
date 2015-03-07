using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfixToPostfix
{
    class Program
    {
        static void Main(string[] args)
        {
            //a+b*(c^d-e)^(f+g*h)-i ==> abcd^e-fgh*+^*+i-
            InfixToPostfix inf = new InfixToPostfix();
            string infix = "a+b*(c^d-e)^(f+g*h)-i";// Console.ReadLine();
            string postFix = inf.Convert(infix);

            Console.WriteLine("PostFix output is :: {0}", postFix);
            Console.ReadKey();
        }
    }
}
