using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
    static public class procedure
    {
        #region  循环输出名字
        static public void Findpeople(string[] names)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
        static public void Findpeople(string[,] nameplaces)
        {
            for (int i = 0; i < nameplaces.GetLength(0); i++)
            {
                for (int j = 0; j < nameplaces.GetLength(1); j++)
                {
                    if (nameplaces[i, j] is null)
                    {
                        //blank
                    }
                    else
                    {
                        Console.WriteLine(nameplaces[i, j]);
                    }
                }
            }
        }
        #endregion

        /// <summary>
        /// 找最值
        /// </summary>
        /// <param name="scores"></param>
        static public void Maxandmin(double[] scores)
        {
            double max = scores[0];
            double min = scores[0];
            //最高分
            for (int i = 0; i < scores.Length; i++)
            {
                if (max > scores[i])
                {

                }
                else
                {
                    max = scores[i];
                }
            }
            Console.WriteLine(max);
            //最低分
            for (int i = 0; i < scores.Length; i++)
            {
                if (min < scores[i])
                {

                }
                else
                {
                    min = scores[i];
                }
            }
            Console.WriteLine(min);
        }

        /// <summary>
        /// 找 质数 合数
        /// </summary>
        /// <param name="number"></param>
        static public void Primenumber(int number)
        {
            for (int i = 2; i <= number; i++)
            {
                if (i == 2)
                {
                    Console.WriteLine(2 + "合数");
                }
                else
                {
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            Console.WriteLine(i + "合数");
                            break;/*打消合数误为素数*/
                        }
                        else if (j == i - 1)
                        {
                            Console.WriteLine(i + "质数");
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 计算平均数
        /// </summary>
        /// <param name="numbers"></param>
        static public void GetAverage(double[] numbers)
        {
            double x = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                x = numbers[i] + x;
            }
            Console.WriteLine(Math.Round((x / numbers.Length),2)); 
        }

        #region 猜数字游戏
        //判断猜测是否正确
        static private bool GuessMe_yesorno(int number,int random) 
        {
            if (number==random)   
            { return true; }   
            else 
            {
                if (number> random)
                { Console.WriteLine("大了"); }
                else
                { Console.WriteLine("小了"); }
                return false; 
            }
        }
        //根据猜的结果给出答复
        static public void GuessMe() 
        {
            int random = new Random().Next(0, 1000);
            Console.WriteLine(random);
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($" 第{i}次输入开始");
                int number = Convert.ToInt32(Console.ReadLine());
                if (GuessMe_yesorno(number, random))
                {
                    if (i < 5)
                    { Console.WriteLine("你真牛逼!"); return; }
                    else if (i < 8)
                    { Console.WriteLine(" 不错嘛!"); return; }
                    else
                    { Console.WriteLine("10-8 需求模糊"); return; }
                }
                else
                {
                    if (i == 10)
                    { Console.WriteLine("(～￣(OO)￣)ブ");}
                    else
                    { Console.WriteLine($"还剩{10-i}次"); }
                }
            }


            
        }
        #endregion

        /// <summary>
        /// 床位调换
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        static public void changebed(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static public  int[] GetArray() 
        {


        }

    }
}
