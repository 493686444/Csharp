using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
    public static class GetDateTime
    {
        //第一部分
        public static DateTime GetDate(int dd, int mm, int yy, DateTime sth)
        {
            return sth = sth.AddDays(dd).AddMonths(mm).AddYears(yy);
        }
        //第二部分计算 周
        //找出每周的第一天(sunday),由模板可知,年初未满一周的不计算
        public static void GetDate(int y)
        {
            DateTime sth = new DateTime(y, 1, 1);
            string leftsth;
            string rightsth;
            int week = 0;
            int a = sth.Year;
            for (int i = 0; i < 400; i++)
            {
                if ((int)sth.DayOfWeek == 0)
                {
                    week = week + 1;
                    Console.Write($"第{week}周  ");
                    leftsth = sth.ToString("yyyy年MM月dd日");
                    rightsth = sth.AddDays(6).ToString("yyyy年MM月dd日");
                    Console.WriteLine($"{leftsth}  -  {rightsth}");
                    sth = sth.AddDays(1);
                    if (sth.Year == a + 1)
                    {
                        break;
                    }
                    else
                    {
                        sth = sth.AddDays(1);
                    }
                }
            }
        }
    }
}


