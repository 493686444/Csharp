using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
    static public class procedure
    {
        
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


    }
}
