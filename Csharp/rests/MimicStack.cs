using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
    class MimicStack
    {
        //构造函数
        public MimicStack(int x)
        {
            box = new object[x];
        }
        //数据
        public object[] box;
        public int pointer = -1;
        //行为
        public object Pop()
        {
            if (pointer==-1)
            {
                Console.WriteLine("栈空");
                return 0;            }
            else
            {
                pointer = pointer - 1;
                Console.WriteLine("取出"+box[pointer]);
                return box[pointer];
            }
        }
        public void Push(object x)
        {
            pointer = pointer + 1;
            if (pointer ==box.Length)
            {
                Console.WriteLine("栈溢出");
            }
            else
            {
                box[pointer] = x;
                Console.WriteLine("已放入" + box[pointer]);
            }
        }

    }
}
