using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationOfPostfixExpression
{
    public class Calculator
    {
        public int Evaluate(string expr)
        {
            Stack s = new Stack();
             int result = 0;
            char[] expArr = expr.ToCharArray();
            for (int i = 0; i < expArr.Length; i++)
            {
                char c = expArr[i];
                switch (c)
                {
                    case '+':
                    case '-':
                    case '*':
                    case '/':
                    case '^':
                       
                        int op2 = s.Pop().Value;
                        int op1 = s.Pop().Value;
                       
                        if(c == '^')
                        result = (int)Math.Pow(op1 , op2);
                        else if (c == '+')
                            result = op1 + op2;
                        else if (c == '-')
                            result = op1 - op2;
                        else if (c == '*')
                            result = op1 * op2;
                        else if (c == '/')
                            result = op1 / op2;

                        s.Push(result);
                        break;

                    default:
                        int val = Int32.Parse(c.ToString());
                        s.Push(val);
                        break;
                }
                
            }
            return result;

        }
    }
}
