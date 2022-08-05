using NUnit.Framework;

namespace TestUnitExample
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.IsTrue(Calculator.Addition(2,2) == 4);
            Assert.AreEqual(4, Calculator.Addition(1, 3));
            Assert.AreNotEqual(2, Calculator.Addition(1, 7));
            Assert.IsInstanceOf<int>(Calculator.Addition(2, 3));
        }
    }
}
