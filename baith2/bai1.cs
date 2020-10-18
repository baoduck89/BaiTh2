using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
namespace baiTh
{
    class Stack
    {
        private int top;
        private int[] s;
        public bool empty()
        {
            return (top == -1);
        }
        public bool full()
        {
            return (top >= s.Length);
        }
        public Stack()
        {
            s = new int[20];
            top = -1;
        }
        public void push(int x)
        {
            if (!full())
            {
                top = top + 1;
                s[top] = x;
            }
            else
                Console.Write("stack tran");
        }
        public int pop()
        {
            if (empty())
            {
                Console.Write("stack can");
                return 0;
            }
            else
                return s[top--];
        }
    }
    class hecoso
    {
        static void Main()
        {
            int n;
            Console.Write("Nhap vao so can doi:");
            n = int.Parse(Console.ReadLine());
            Stack T = new Stack();
            string st = "0123456789ABCDEF";
            while (n != 0)
            {
                T.push((int)st[n % 16]);
                n = n / 16;
            }
            Console.Write("Ket qua doi sang he 16 :");
            while (!T.empty())
            {
                Console.Write("{0}", (char)T.pop());
            }
            Console.ReadLine();
        }
    }
}