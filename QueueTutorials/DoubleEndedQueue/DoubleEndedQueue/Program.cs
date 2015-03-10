using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleEndedQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            DeQueLibrary q = new DeQueLibrary();
            q.Display();

            for (int i = 1; i < 11; i++)
            {
                q.InsetFront(i);
                q.Display();
                q.InsertLast(++i);
                q.Display();
            }

            for (int i = 0; i < 6; i++)
            {
                Console.Write("\nDeleted Last :: {0}",q.DeleteLast());
                q.Display();
                Console.Write("\nDeleted Front :: {0}", q.DeleteFront());
                q.Display();
            }

            Console.ReadKey();
        }
    }
}
