using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using CustomQueue;
using System.Collections.Generic;
using System.Collections;

namespace CustomQueueTests
{
    [TestClass]
    public class CustomQueueTests
    {

        [TestMethod]
        public void EnqueueTestMethod()
        {
            var actualQueue = new CustomQueue<int>();
            actualQueue.Enqueue(9);
            actualQueue.Enqueue(8);
            actualQueue.Enqueue(7);
            var expectedQueue = new Queue<int>();
            expectedQueue.Enqueue(9);
            expectedQueue.Enqueue(8);
            expectedQueue.Enqueue(7);
            var actual = actualQueue.ToArray();
            var expected = expectedQueue.ToArray();

            CollectionAssert.AreEqual(expected, actual);
            
        }

        [TestMethod]
        public void DequeueTestMethod()
        {
            var actualQueue = new CustomQueue<int>();
            actualQueue.Enqueue(9);
            actualQueue.Enqueue(8);
            actualQueue.Enqueue(7);
            actualQueue.Dequeue();

            var expectedQueue = new Queue<int>();
            expectedQueue.Enqueue(9);
            expectedQueue.Enqueue(8);
            expectedQueue.Enqueue(7);
            expectedQueue.Dequeue();
            
            var actual = actualQueue.ToArray();
            var expected = expectedQueue.ToArray();

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PeekTestMethod()
        {
            var actualQueue = new CustomQueue<int>();
            actualQueue.Enqueue(9);
            actualQueue.Enqueue(8);
            actualQueue.Enqueue(7);

            var expectedQueue = new Queue<int>();
            expectedQueue.Enqueue(9);
            expectedQueue.Enqueue(8);
            expectedQueue.Enqueue(7);

            var actual = actualQueue.Peek(); ;
            var expected = expectedQueue.Peek();

            

            Assert.AreEqual(expected, actual);
        }


    }
}
