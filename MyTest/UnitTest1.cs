using NUnit.Framework;

namespace MyTest
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
            //这里直接写调用

            //这里写期望的结果
            Assert.Pass();  // Assert.AreEqual(期望, student.Age);
            
        }
    
    }
}