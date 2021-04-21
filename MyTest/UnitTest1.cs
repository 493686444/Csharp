using Csharp;
using NUnit.Framework;
using System;

namespace MyTest
{
    public class Tests
    {
        
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]//1.数组中找到最小值
        public void GetMinTest()
        {
            double[] scores = { 1, 2, 3, 4, 5, };
            double numbers= procedure.GetMin(scores);
            Assert.AreEqual(1,numbers);  // Assert.AreEqual(期望, student.Age);
        }

        [Test]//2.找到100以内的所有质数
        public void PrimenumberTest()
        {
            int[] expectations = new int[25] 
            { 2, 3, 5, 7, 11, 13, 17,19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
            int[] numbers= procedure.Primenumber(100);
            Assert.AreEqual(expectations, numbers);
        }

        [Test]//3.猜数字游戏
        public void GuessMeTest()
        {
         //暂时搁置
        }

        [Test]//4. 二分查找
        public void BinarySeekTest()
        {
            int[] numbers = new int[10] { 0,1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int expection = 
            procedure.BinarySeek(numbers, 3);
            Assert.AreEqual(4, expection);
        }

        [Test]//5.栈的压入弹出
        public void Test()
        {
            MimicStack mystack = new MimicStack(3);
            //栈空
            Assert.AreEqual(false, mystack.Pop());//开始以为这括号(assert的括号)里的代码不会对外面产生影响,但实际上确实产生嘞
            //入栈
            Assert.AreEqual(1, mystack.Push(1));
            //出站
            Assert.AreEqual(true, mystack.Pop());
            //溢出
            mystack.Push(1);
            mystack.Push(2);
            mystack.Push(3);
            Assert.AreEqual(null, mystack.Push(4));
        }




        //继续完成双向链表的测试和开发，实现：

        //node3.InsertAfter(node1); 场景
        //InerstBefore()：在某个节点前插入
        //Delete()：删除某个节点
        //[选] Swap()：交互某两个节点
        //[选] FindBy()：根据节点值查找到某个节点

    }
}