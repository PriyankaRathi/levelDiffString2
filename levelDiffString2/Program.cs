using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace levelDiffString2
{
    class Program
    {
        static void Main(string[] args)
        {

            string A = Console.ReadLine();
            string B = Console.ReadLine();

            List<string> S = new List<string>();

            for (int length = 1; length <= A.Length; length++)
            {
                for (int start = 0; start <= A.Length - length; start++)
                    S.Add(A.Substring(start, length));
            }
            long P = 0;
            for (int length = 1; length <= B.Length; length++)
            {
                for (int start = 0; start <= B.Length - length; start++)
                    if (!S.Contains(B.Substring(start, length)))
                        P += 2;
            }

            Console.Write(P);
            Console.ReadKey();
        }
    }
}

/*

Example

Input:
aacd
cdaa

Output:
8

*/
