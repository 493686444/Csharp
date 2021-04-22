using Csharp;
using NUnit.Framework;
using System;

namespace MyTest
{
    public class DLLTest
    {
        //测试的公用数据放在这里
        DLL node1 = new DLL(); DLL node2 = new DLL(); DLL node3 = new DLL();
        DLL node4 = new DLL(); DLL node5 = new DLL();

        [SetUp]//这里对公用数据进行加工处理
        public void Setup()   //为什么不在这里直接设置字段   因为方法内的数据不公用(否则也就不会出现返回值这个概念了)
        {
            node1.right = node2; node2.right = node3; node3.right = node4; node4.right = node5;
            node5.left = node4; node4.left = node3; node3.left = node2; node2.left = node1;
        }

        [Test]//加最左边
        public void AddleftTest()
        {
            DLL node1_L = new DLL();
            node1.Addleft(node1_L);
            DLL expection = node1.left;
            Assert.AreEqual(expection, node1_L);
        }
        [Test]//加左边
        public void AddleftTest2()
        {
            DLL node2_L = new DLL();
            node2.Addleft(node2_L);
            DLL expection1 = node2.left;
            Assert.AreEqual(expection1, node2_L);
            DLL expection2 = node1.right;
            Assert.AreEqual(expection2, node2_L);
        }

        [Test]
        public void DeleteTest()
        {
            node1.Delete();//最边边
            Assert.AreEqual(null, node2.left);
            node3.Delete();//中间
            Assert.AreEqual(node2, node4.left);
            Assert.AreEqual(node4, node2.right);
        }
        [Test]
        public void Swap()
        {
            DLL.Swap(node2, node4);
            Assert.AreEqual(node2, node5.left);
            Assert.AreEqual(node4, node3.right);
        }

    }
    public class Tests
    {

        [Test]//1.数组中找到最小值
        public void GetMinTest()
        {
            double[] scores = { 1, 2, 3, 4, 5, };
            double numbers = procedure.GetMin(scores);
            Assert.AreEqual(1, numbers);  // Assert.AreEqual(期望, student.Age);
        }

        [Test]//2.找到100以内的所有质数
        public void PrimenumberTest()
        {
            int[] expectations = new int[25]
            { 2, 3, 5, 7, 11, 13, 17,19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
            int[] numbers = procedure.Primenumber(100);
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
            int[] numbers = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int expection = procedure.BinarySeek(numbers, 3);
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

    }
}
