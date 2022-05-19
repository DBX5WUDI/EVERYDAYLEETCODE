using System;

namespace CopyRandomList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Node head = new Node(7);
            head.next = new Node(13);
            head.next.next = new Node(11);
            head.next.next.next = new Node(10);
            head.next.next.next.next = new Node(1);

            head.random = head.next.next.next.next.next;
            head.next.random = head;
            head.next.next.random = head.next.next.next.next;
            head.next.next.next.random = head.next.next;
            head.next.next.next.next.random = head;
            Node node = CopyRandomList(head);
        }
        static public Node CopyRandomList(Node head)
        {
            while (head == null) return null;
            Node headtmp = head;
            Node node = new Node(head.val);
            Node nodetmp = node;
            while(headtmp.next != null)
            {
                nodetmp.next = new Node(headtmp.next.val);
                headtmp = headtmp.next;
                nodetmp = nodetmp.next;
            }
            nodetmp = node;
            headtmp = head;
            Node nodecheck = node;
            Node headcheck = head;
            while (headtmp != null)
            {
                int i;
                for ( i = 0; headtmp.random != headcheck; i++)
                {
                    headcheck = headcheck.next;
                }
                for(; i>0 ;i-- )
                {
                    nodecheck = nodecheck.next;
                }
                nodetmp.random = nodecheck;
                nodecheck = node;
                headcheck = head;
                headtmp = headtmp.next;
                nodetmp = nodetmp.next;
            }

            return node;
        }
    }

    public class Node
    {
        public int val;
        public Node next;
        public Node random;

        public Node(int _val)
        {
            val = _val;
            next = null;
            random = null;
        }
    }
}
