using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueLib
{
    interface IStack <T>
    {
        T Push();

        T Pop();

        T Peek();

        T Count();

        T Empty();

    }
}
