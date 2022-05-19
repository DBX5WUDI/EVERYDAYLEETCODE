using System;
using System.Collections.Generic;

namespace AppendTailAndDeleteHead
{
    class Program
    {
        static void Main(string[] args)
        {
            CQueue queue = new CQueue();
            int a;
            a = queue.DeleteHead();
            queue.AppendTail(5);
            queue.AppendTail(2);
            a = queue.DeleteHead();
            a = queue.DeleteHead();
            Console.WriteLine("Hello World!");
        }
    }
}
public class CQueue
{
    private Stack<int> stackin;
    private Stack<int> stackout;
    public CQueue()
    {
        stackin = new Stack<int>();
        stackout = new Stack<int>();
    }

    public void AppendTail(int value)//每当入队操作，首先把stackout中的数都Pop到stackin中
    {
        for (; stackout.Count > 0;)
        {
            stackin.Push(stackout.Pop());
        }
        stackin.Push(value);        //再在stackin中push要入队的数据
    }

    public int DeleteHead()             
    {
        for (; stackin.Count > 0;)  //每当出队操作，首先把stackin中的数都pop到stackout中
        {
            stackout.Push(stackin.Pop());
        }
        if (stackout.Count > 0)     //再出队
        {
            return stackout.Pop();
        }
        else return -1;
    }
}