using Microsoft.VisualStudio.TestTools.UnitTesting;
using QueueLib;
using System;

namespace QueueTest
{
    [TestClass]
    public class QueueArrayTest
    {
        [TestMethod]
        public void Array_TestPushPop_String()
        {
            Queue280A<string> q = new Queue280A<string>();
            q.Push("First");
            Assert.AreEqual("First", q.Pop());
        }

        [TestMethod]
        public void Array_TestPushPeek_String()
        {
            Queue280A<string> q = new Queue280A<string>();
            q.Push("First");
            Assert.AreEqual("First", q.Pop());
        }

        [TestMethod]
        public void Array_TestPush3Pop1Peek1_String()
        {
            Queue280A<string> q = new Queue280A<string>();
            q.Push("First");
            q.Push("Second");
            q.Push("Third");
            q.Pop();
            Assert.AreEqual("Second", q.Pop());
        }

        //[TestMethod]
        //public void Array_CanAddPastStartingSize()
        //{
        //    Queue280A<int> q = new Queue280A<int>();
        //    q.Push(0);
        //    q.Push(1);
        //    q.Push(2);
        //    q.Push(3);
        //    q.Push(4);
        //    q.Push(5);
        //    q.Push(6);
        //    q.Push(7);
        //    q.Push(8);
        //    q.Push(9);
        //    q.Push(10);

        //    q.Pop();
        //    q.Pop();
        //    q.Pop();
        //    q.Pop();
        //    q.Pop();
        //    q.Pop();
        //    q.Pop();
        //    q.Pop();
        //    q.Pop();
        //    q.Pop();
        //    Assert.AreEqual(10, q.Pop());

        //}

        [TestMethod]
        public void Array_CanAddPastStartingSize()
        {
            Queue280A<string> q = new Queue280A<string>();
            q.Push("0");
            q.Push("1");
            q.Push("2");
            q.Push("3");
            q.Push("4");
            q.Push("5");
            q.Push("6");
            q.Push("7");
            q.Push("8");
            q.Push("9");
            q.Push("10");

            q.Pop();
            q.Pop();
            q.Pop();
            q.Pop();
            q.Pop();
            q.Pop();
            q.Pop();
            q.Pop();
            q.Pop();
            q.Pop();
            Assert.AreEqual(10, q.Pop());

        }

        [TestMethod]
        public void Array_Pop_Empty_String()
        {
            Queue280A<string> q = new Queue280A<string>();
            Assert.AreEqual(null, q.Pop());
;
        }
    }
}
