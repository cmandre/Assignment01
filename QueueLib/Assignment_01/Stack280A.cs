using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueLib
{
    public class Stack280A<T> : IStack<T>
    {
        T[] stack = new T[10];
        int front = 0;
        int rear = 0;
        
        public void Push(T o)
        {
            if (stack.Length - 1 <= rear)
            {
                T[] tmp = new T[stack.Length + 1];
                stack.CopyTo(tmp, 0);
                stack = tmp;
            }

            stack[rear] = o;
            rear++;
        }
        
        public T Pop()
        {
            T tmp = stack[front];
            front++;
            return tmp;
        }
        
        public T Peek()
        {
            return stack[front];
        }

        public T Count()
        {
            dynamic tmp = stack.Count();
            return tmp;
        }

        public bool Empty()
        {
            if (stack.Length <= 0)
                return true;
            else
                return false;
        } 

    }
}
