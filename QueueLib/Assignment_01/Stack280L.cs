using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueLib
{
    public class Stack280L<T> : IStack<T>
    {
        List<T> stack = new List<T>();

        public void Push(T o)
        {
            stack.Add(o);         
        }
        
        public T Pop()
        {
            T tmp = stack[0];
            stack.RemoveAt(0);
            return tmp;
        }
        
        public T Peek()
        {
            return stack[0];
        }

        public T Count()
        {
            dynamic count = stack.Count;

            //foreach (T tmp in data)
            //{
            //    count = tmp;
            //}
                return count;
        }

        public bool Empty()
        {
            if (stack.Count <= 0)
                return true;
            else
                return false;
        }   

    }
}
