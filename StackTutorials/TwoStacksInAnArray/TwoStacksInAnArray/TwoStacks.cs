using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoStacksInAnArray
{
    public class TwoStacks
    {
        int[] StackArr = new int[10];
        int Top1 = -1;
        int Top2 = -1;

        public void Push1(int x)
        {
            if (Top1 == -1)
            {
                StackArr[0] = x;
                Top1 = 0;
            }
            else if (Top2 - Top1 == 1 || Top1 == 9)
                Console.WriteLine("Stack1 Full !!");
            else
                StackArr[++Top1] = x;
        }

        public void Push2(int x)
        {
            if (Top2 == -1)
            {
                StackArr[9] = x;
                Top2 = 9;
            }
            else if (Top2 - Top1 == 1 || Top2 == 0)
                Console.WriteLine("Stack2 Full !!");
            else
                StackArr[--Top2] = x;
        }

        public int Pop1()
        {
            if (Top1 == -1)
                Console.WriteLine("Stack1 Empty !!");
            else if (Top1 == 0)
            {
                Top1 = -1;
                int x = StackArr[0];
                StackArr[0] = 0;
                return x;
            }
            else
            {
                int x = StackArr[Top1];
                StackArr[Top1] = 0;
                Top1--;
                return x;
            }
            return -1;
        }

        public int Pop2()
        {
            if (Top2 == -1)
                Console.WriteLine("Stack2 Empty !!");
            else if (Top2 == 9)
            {
                int x = StackArr[9];
                Top2 = -1;
                StackArr[9] = 0;
                return x;
            }
            else
            {
                int x = StackArr[Top2];
                StackArr[Top2] = 0;
                Top2++;
                return x;
            }
            return -1;
        }

        public void DisplayArray() {
            Console.Write("Array is :: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(StackArr[i] + " ");
            }
            Console.WriteLine(" ");
        }
       
    }
}
