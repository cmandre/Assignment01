using System;
using System.Collections.Generic;

namespace QueueLib
{
    public class Queue280L<T> : IQueue<T>
    {
        List<T> data = new List<T>();
        
        public T Peek()
        {
            return data[0];
        }

        public T Pop()
        {
            T ret = data[0];
            try
            {
                data.RemoveAt(0);
            }
            catch
            {
                //throw new Exception("Queue Empty");
                throw;
            }
            return ret;
        }

        public void Push(T o)
        {
            data.Add(o);
        }
    }
}
