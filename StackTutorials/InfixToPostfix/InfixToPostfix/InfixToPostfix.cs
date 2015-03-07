using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfixToPostfix
{
    public class InfixToPostfix
    {
        public string Convert(string inFix) {
            StackLibrary s = new StackLibrary();

            char[] infixArr = inFix.ToCharArray();
            string postfixArr = string.Empty;
             //{'+','-','*','/'}
            Dictionary<string,int> Dict = new Dictionary<string,int>();
            Dict.Add("(", -1);
            Dict.Add("+",1);
            Dict.Add("-",1);
            Dict.Add("*",2);
            Dict.Add("/",2);
            Dict.Add("^", 3);
               
            for (int i = 0; i < inFix.Length; i++)
            {
                char c = inFix[i];
                switch (c)
                {
                    case '(':
                        s.Push(c.ToString());
                        break;

                    case ')':
                        while (!string.Equals(s.Peek(), "("))
                        {
                            postfixArr = string.Concat(postfixArr, s.Pop().Value);
                        }
                        s.Pop();
                        break;

                    case '+':
                    case '-':
                    case '*':
                    case '/':
                    case '^':

                        if (s.Peek() == null || Dict[c.ToString()] > Dict[s.Peek()])
                            {
                                s.Push(c.ToString());
                            }
                            else {
                                while (!s.IsEmpty() && Dict[c.ToString()] <= Dict[s.Peek()])
                                {
                                    postfixArr = string.Concat(postfixArr, s.Pop().Value);
                                }
                                s.Push(c.ToString());
                            }                        
                        break;

                    default:
                        postfixArr = string.Concat(postfixArr, c);
                        break;
                }
            }

            while(!s.IsEmpty())
                postfixArr = string.Concat(postfixArr, s.Pop().Value);
            return postfixArr.ToString();
        }
    }
}
