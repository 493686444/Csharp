using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
    //4.使用object改造数据结构栈（MimicStack），并在出栈时获得出栈元素

    public class MimicStack<T>
    {
        #region 构造函数
        public MimicStack(int x)
        {
            array = new T[x];
        }
        #endregion

        #region 数据
        public T[] array;
        public int pointer = -1;
        #endregion

        #region 功能
        public bool Pop()
        {
            if (pointer == -1)
            { Console.WriteLine("栈空"); return false; }
            else
            {
                Console.WriteLine("取出" + array[pointer]);
                pointer = pointer - 1;
                return true;
            }
        }
        public object Push(T sth)
        {
            pointer = pointer + 1;
            if (pointer == array.Length)
            { Console.WriteLine("栈溢出"); return null; }
            else
            {
                array[pointer] = sth;
                Console.WriteLine("已放入" + array[pointer]);
                return array[pointer];
            }
        }
        #endregion


    }
}
