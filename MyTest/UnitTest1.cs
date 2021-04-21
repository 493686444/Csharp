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

        [Test]//1.�������ҵ���Сֵ
        public void GetMinTest()
        {
            double[] scores = { 1, 2, 3, 4, 5, };
            double numbers= procedure.GetMin(scores);
            Assert.AreEqual(1,numbers);  // Assert.AreEqual(����, student.Age);
        }

        [Test]//2.�ҵ�100���ڵ���������
        public void PrimenumberTest()
        {
            int[] expectations = new int[25] 
            { 2, 3, 5, 7, 11, 13, 17,19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
            int[] numbers= procedure.Primenumber(100);
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
            int[] numbers = new int[10] { 0,1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int expection = 
            procedure.BinarySeek(numbers, 3);
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




        //�������˫������Ĳ��ԺͿ�����ʵ�֣�

        //node3.InsertAfter(node1); ����
        //InerstBefore()����ĳ���ڵ�ǰ����
        //Delete()��ɾ��ĳ���ڵ�
        //[ѡ] Swap()������ĳ�����ڵ�
        //[ѡ] FindBy()�����ݽڵ�ֵ���ҵ�ĳ���ڵ�

    }
}