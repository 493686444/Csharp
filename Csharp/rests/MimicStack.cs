using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
    //4.使用object改造数据结构栈（MimicStack），并在出栈时获得出栈元素

    class MimicStack
    {
        #region 构造函数
        public MimicStack(int x)
        {
            array = new object[x];
        }
        #endregion

        #region 数据
        public object[] array;
        public int pointer = -1;
        #endregion

        #region 功能
        public void Pop()
        {
            if (pointer == -1)
            {
                Console.WriteLine("栈空");
                
            }
            else
            {
                Console.WriteLine("取出" + array[pointer]);
                pointer = pointer - 1;
            }
        }
        public void Push(int x)
        {
            pointer = pointer + 1;
            if (pointer == array.Length)
            { Console.WriteLine("栈溢出"); }
            else
            {
                array[pointer] = x;
                Console.WriteLine("已放入" + array[pointer]);
            }
        }
        #endregion


    }
}
