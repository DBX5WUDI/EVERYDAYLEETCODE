using System;
using System.Collections.Generic;
namespace MinStack
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b;
            MinStack minStack = new  MinStack();
            minStack.Push(2147483646);
            minStack.Push(2147483646);
            minStack.Push(2147483647);

            a = minStack.Top();
            minStack.Pop();
            b = minStack.Min();
            minStack.Pop();
            b = minStack.Min();
            minStack.Pop();
            minStack.Push(2147483647);
            a = minStack.Top();
            b = minStack.Min();
            minStack.Push(-2147483648);
            a = minStack.Top();

            b = minStack.Min();
            a = minStack.Top();
            b = minStack.Min();


            Console.WriteLine("Hello World!");
        }
    }
    public class MinStack
    {
        private List<int> mylist = new List<int>();
        private Stack<int> pstack = new Stack<int>();
        private int p = 0;

        /** initialize your data structure here. */
        public MinStack()
        {
            pstack.Push(0);
        }

        public void Push(int x)
        {
            mylist.Add(x);
            if (mylist.Count > 0)
            {
                if (x < mylist[p])
                {
                    p = mylist.Count - 1;
                    pstack.Push(p);
                }
            }
        }

        public void Pop()
        {
            if(p == mylist.Count - 1&& p!=0)
            {
                pstack.Pop();
                p = pstack.Peek();
            }
            mylist.RemoveAt(mylist.Count-1);
        }

        public int Top()
        {
            return mylist[mylist.Count - 1];
        }

        public int Min()
        {
            return mylist[p];
        }
    }
}
