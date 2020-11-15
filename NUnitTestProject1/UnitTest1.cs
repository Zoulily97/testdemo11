using ConsoleApp1;
using NUnit.Framework;

namespace NUnitTestProject1
{
    public class StudentTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Greet()
        {
            Assert.Pass();
        }
        [Test]
        public void Learn()
        {
            Assert.Pass();
        }
        
        [Test]
        public void Test1()
        {
            Assert.AreEqual(5, 3 + 2);
        }
        [Test]
        public void Test2()
        {
            Assert.AreEqual(8, 3 + 5);
        }
        [Test]
        public void GetMinTest()
        {
            int min = BaseLearn.GetMin(new int[] {1,23,3,4,5 });
            Assert.AreEqual(1, min);
        }
    }
}