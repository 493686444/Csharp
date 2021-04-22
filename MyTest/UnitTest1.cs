using Csharp;
using NUnit.Framework;
using System;

namespace MyTest
{
    public class DLLTest
    {
        //���ԵĹ������ݷ�������
        DLL node1 = new DLL(); DLL node2 = new DLL(); DLL node3 = new DLL();
        DLL node4 = new DLL(); DLL node5 = new DLL();

        [SetUp]//����Թ������ݽ��мӹ�����
        public void Setup()   //Ϊʲô��������ֱ�������ֶ�   ��Ϊ�����ڵ����ݲ�����(����Ҳ�Ͳ�����ַ���ֵ���������)
        {
            node1.right = node2; node2.right = node3; node3.right = node4; node4.right = node5;
            node5.left = node4; node4.left = node3; node3.left = node2; node2.left = node1;
        }

        [Test]//�������
        public void AddleftTest()
        {
            DLL node1_L = new DLL();
            node1.Addleft(node1_L);
            DLL expection = node1.left;
            Assert.AreEqual(expection, node1_L);
        }
        [Test]//�����
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
            node1.Delete();//��߱�
            Assert.AreEqual(null, node2.left);
            node3.Delete();//�м�
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

        [Test]//1.�������ҵ���Сֵ
        public void GetMinTest()
        {
            double[] scores = { 1, 2, 3, 4, 5, };
            double numbers = procedure.GetMin(scores);
            Assert.AreEqual(1, numbers);  // Assert.AreEqual(����, student.Age);
        }

        [Test]//2.�ҵ�100���ڵ���������
        public void PrimenumberTest()
        {
            int[] expectations = new int[25]
            { 2, 3, 5, 7, 11, 13, 17,19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
            int[] numbers = procedure.Primenumber(100);
            Assert.AreEqual(expectations, numbers);
        }

        [Test]//3.��������Ϸ
        public void GuessMeTest()
        {
            //��ʱ����
        }

        [Test]//4. ���ֲ���
        public void BinarySeekTest()
        {
            int[] numbers = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int expection = procedure.BinarySeek(numbers, 3);
            Assert.AreEqual(4, expection);
        }

        [Test]//5.ջ��ѹ�뵯��
        public void Test()
        {
            MimicStack mystack = new MimicStack(3);
            //ջ��
            Assert.AreEqual(false, mystack.Pop());//��ʼ��Ϊ������(assert������)��Ĵ��벻����������Ӱ��,��ʵ����ȷʵ������
            //��ջ
            Assert.AreEqual(1, mystack.Push(1));
            //��վ
            Assert.AreEqual(true, mystack.Pop());
            //���
            mystack.Push(1);
            mystack.Push(2);
            mystack.Push(3);
            Assert.AreEqual(null, mystack.Push(4));
        }

    }
}
