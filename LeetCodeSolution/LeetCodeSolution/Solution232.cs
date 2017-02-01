using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolution
{
    public class Solution232
    {
        /**
         * Your MyQueue object will be instantiated and called as such:
         * MyQueue obj = new MyQueue();
         * obj.Push(x);
         * int param_2 = obj.Pop();
         * int param_3 = obj.Peek();
         * bool param_4 = obj.Empty();
         */
    }

    public class MyQueue
    {
        Stack<int> actual;
        Stack<int> buffer;
        /** Initialize your data structure here. */
        public MyQueue()
        {
            actual = new Stack<int>();
            buffer = new Stack<int>();
        }

        /** Push element x to the back of queue. */
        public void Push(int x)
        {
            while(actual.Count > 0)
            {
                buffer.Push( actual.Pop() );
            }

            actual.Push(x);

            while(buffer.Count>0)
            {
                actual.Push( buffer.Pop() );
            }
        }

        /** Removes the element from in front of queue and returns that element. */
        public int Pop()
        {
            return actual.Pop();
        }

        /** Get the front element. */
        public int Peek()
        {
            return actual.Peek();
        }

        /** Returns whether the queue is empty. */
        public bool Empty()
        {
            return actual.Count == 0;
        }
    }
}
