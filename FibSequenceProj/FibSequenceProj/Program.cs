using System;
using System.Collections;

namespace FibSequenceProj
{
    class Program
    {
        static void Main()
        {
            foreach (var x in new FibonacciSequence())
            {
                Console.WriteLine(x);
            }
        }
    }

    class FibonacciIterator : IEnumerator
    {
        private int N;
        private int i;
        private int cur = 0;
        private int prev = 1;
        public FibonacciIterator(int n)
        {
            N = n;
        }

        public bool MoveNext()
        {
            if (i >= N)
                return false;
            (prev, cur) = (cur, prev + cur);
            i++;
            return true;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public object Current
        {
            get{
                return cur;
            }
        }
    }

    class FibonacciSequence : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            return new FibonacciIterator(10);
        }
    }
}