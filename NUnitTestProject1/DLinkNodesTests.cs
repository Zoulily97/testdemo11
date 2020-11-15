using ConsoleApp1;
using NUnit.Framework;
using System.Security.Cryptography;

namespace NUnitTestProject1
{
    public class DLinkNodesTests
    {

        private DoubleLinked node1,node2,node3,node4;

        [SetUp]
        public void Setup()
        {
           /* DoubleLinked*/ node1 = new DoubleLinked();
            /*DoubleLinked*/ node2 = new DoubleLinked();
            /*DoubleLinked*/ node3 = new DoubleLinked();
           /* DoubleLinked*/ node4 = new DoubleLinked();
            node1.Next = node2;
            node2.Next = node3;
            node3.Next = node4;
            node4.Previous = node3;
            node3.Previous = node2;
            node2.Previous = node1;

        }



        [Test]
        public void AddTest()
        {
           
            node1.AddAfter(node2);//把node2加在node1之后

            //1 [2]
            Assert.IsNull(node1.Previous);
            Assert.AreEqual(node2, node1.Next);
            Assert.AreEqual(node1, node2.Previous);
           // Assert.IsNull(node2.Next);
            // 1 2 [3]
            //DoubleLinked node3 = new DoubleLinked();
            node2.AddAfter(node3);
            Assert.AreEqual(node3, node2.Next);
            Assert.AreEqual(node2, node3.Previous);
            //Assert.IsNull(node3.Next);

            //1 2  [4] 3
         //   DoubleLinked node4 = new DoubleLinked();
            node3.AddAfter(node4);
            Assert.AreEqual(node4, node3.Next);
            Assert.AreEqual(node3, node4.Previous);
            Assert.AreEqual(node4, node3.Next);
            Assert.AreEqual(node3, node4.Previous);
            //Assert.IsNull(node4.Next);

        }

        [Test]
        public void InsertBeforTest()
        {
            //1 2  [3] 4
            node4.InsertBefor(node3);
            Assert.IsNull(node4.Next);
            Assert.AreEqual(node3, node4.Previous);
            Assert.AreEqual(node4, node3.Next);

            // [2] 3 4
            node3.InsertBefor(node2);
            
            Assert.AreEqual(node2, node3.Previous);
            Assert.AreEqual(node3, node2.Next);
            //2[1] 3 4
            node3.InsertBefor(node1);
            Assert.AreEqual(node1, node3.Previous);
            Assert.AreEqual(node2, node1.Previous);
            Assert.AreEqual(node1, node2.Next);
            Assert.AreEqual(node3, node1.Next);
          //  Assert.IsNull(node2.Previous);


        }
    }
}
