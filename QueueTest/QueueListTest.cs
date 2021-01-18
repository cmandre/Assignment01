using Microsoft.VisualStudio.TestTools.UnitTesting;
using QueueLib;
using System;

namespace QueueTest
{
    [TestClass]
    public class QueueListTest
    {
        [TestMethod]
        public void TestPushPeak()
        {
            Queue280L<string> q = new Queue280L<string>();
            q.Push("PROG280");
            Assert.AreEqual("PROG280", q.Peek());
        }

        [TestMethod]
        public void TestPushPop()
        {
            Queue280L<string> q = new Queue280L<string>();
            q.Push("PROG280");
            Assert.AreEqual("PROG280", q.Pop());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestPush2Pop()
        {
            Queue280L<string> q = new Queue280L<string>();
            q.Push("PROG280");
            q.Pop();
            q.Pop();
            //Assert.AreEqual(new Exception("Queue Empty"), q.Pop());
            //Assert.AreEqual("Queue Empty", q.Pop());
        }

        [TestMethod]
        public void TestPush5Pop3()
        {
            Queue280L<string> q = new Queue280L<string>();
            q.Push("A");
            q.Push("B");
            q.Push("C");
            q.Push("D");
            q.Push("E");
            q.Pop();
            q.Pop();
            q.Pop();
            //Assert.AreEqual(new Exception("Queue Empty"), q.Pop());
            Assert.AreEqual("D", q.Pop());
        }

        [TestMethod]
        public void TestPushPopDouble()
        {
            Queue280L<double> q = new Queue280L<double>();
            q.Push(0.99);
            Assert.AreEqual(0.99, q.Pop());
        }


    }
}
