using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class LargestMultipleOfThree
    {
        public string GetLargestNumber(List<int> array) {
            List<int> q0 = new List<int>();
            List<int> q1 = new List<int>();
            List<int> q2 = new List<int>();

            foreach (var item in array)
            {
                if (item % 3 == 0)
                    q0.Add(item);
                else if (item % 3 == 1)
                    q1.Add(item);
                else q2.Add(item);

            }
            q0.Sort((a, b) => -1 * a.CompareTo(b)); 
            q1.Sort((a, b) => -1 * a.CompareTo(b));
            q2.Sort((a, b) => -1 * a.CompareTo(b)); 

            while (true)
            {

                if (q1.Count>0 && q2.Count>0)
                {
                    int e1 = q1[0];
                    int e2 = q2[0];
                    q0.Add(e1);
                    q0.Add(e2);
                   q1.RemoveAt(0);
                    q2.RemoveAt(0);
                }
                else break;
            }

            q0.Sort((a, b) => -1 * a.CompareTo(b)); 
            
            string output = string.Empty;
            for (int i = 0; i <q0.Count; i++)
            {
                output = output+ q0[i] + " ";
            }

            return output.Trim();

        }
    }
}
