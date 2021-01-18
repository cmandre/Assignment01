using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueLib
{
    //public class Queue280A<T> : IQueue<T>
     public class Queue280A<T> where T : class
     {
        //array.CopyTo(<new array that has been resized>)
        
        T[] data = new T[10];
        int front = 0;
        int rear = 0;
        
        public T Peek()
        {
            return data[front];
        }

        public T Pop()
        {
            T tmp = data[front];
            front++;
            return tmp;
        }

        public void Push(T o)
        {
            //if (data.Length - 1 == rear)
            //{
            //    T[] tmp = new T[data.Length * 2];
            //    data.CopyTo(tmp, 0);
            //    data = tmp;
            //}


            if (data.Length - 1 <= rear)
            {
                T[] tmp = new T[data.Length * 2];
                data.CopyTo(tmp, 0);
                data = tmp;
            }

            data[rear] = o;
            rear++;
        }

        //public void NewArray()
        //{
        //    T[] tmp = new T[data.Length * 2];
            
        //    if (data > data.Length)
        //    {
        //        tmp = new T[data.Length * 2];
        //        tmp = data;
        //    }
            
        //}



     }
}
