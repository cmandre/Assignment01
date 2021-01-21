using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueLib
{
    interface IStack <T>
    {
        void Push(T o);

        T Pop();

        T Peek();

        T Count();

        bool Empty();

    }
}
