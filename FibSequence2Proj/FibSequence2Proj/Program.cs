using System;
using System.Collections;

namespace FibSequence2Proj
{
    class Program
    {
        static void Main()
        {
            foreach (var x in new FibSequence2(10))
            {
                Console.WriteLine(x);
            }
        }
    }

    class FibSequence2 : IEnumerable
    {
        private int N;

        public FibSequence2(int n)
        {
            N = n;
        }
        
        public IEnumerator GetEnumerator()
        {
            int cur = 0;
            int prev = 1;
            for (int i = 0; i < N; i++)
            {
                yield return cur;
                (prev, cur) = (cur, cur + prev);
            }
        }
    }
}