using System;

namespace Csharp
{
    class Program
    {

        static void Main(string[] args)
        {
            ////面向过程
            //1.输出两个整数 / 小数的和 / 差 / 积 / 商
            //    Console.WriteLine(1 + 1);
            //    Console.WriteLine(0.1 + 0.2);
            ////2.电脑计算并输出：[(23 + 7)x12-8]÷6的小数值
            //  Console.WriteLine(Math.Round((Single)((23 + 7) * 12 - 8) / 6, 2));

            ////将源栈同学姓名/昵称分别：
            ////1.按进栈时间装入一维数组，
            //string[] names = { "小红", "小明", "小刚" };
            ////2.按座位装入二维数组，
            ////方法一 
            //string[,] seats = new string[2, 3];
            //seats[0, 0] = "韩佳宝";
            //seats[0, 1] = "胡涛";
            //seats[0, 0] = "夏康平";

            //seats[1, 0] = "1";
            //seats[1, 1] = "2";
            //seats[1, 2] = "3";
            ////方法二
            //string[,] seats = { { "小红", "小明", "小刚" }, { "1", "2", "3" } };
            ////并输出共有多少名同学。
            //Console.WriteLine(names.GetLength(1));

            //1.分别用for循环和while循环输出：1,2,3,4,5 和 1,3,5,7,9
            ////for
            //for (int i = 0; i < 5; i++)
            //{ Console.WriteLine(i + 1); }
            //while
            //int j = 0;
            //while (j < 5)
            //{
            //    //Console.WriteLine(j + 1);
            //    j = j + 1;
            //}
            //for (int i = 0; i < 9; i += 2)
            //{ Console.WriteLine(i + 1); }

            //////1.用for循环输出存储在一维 / 二维数组里的源栈所有同学姓名 / 昵称
            ////part1
            //string[] names = { "小红", "小明", "小刚" };
            //procedure.Findpeople(names);
            ////part2
            //string[,] nameplaces = { { "小红(0,0)", null, "小刚(0,2)" }, { null, null, "小明(1,2)" } };
            //procedure.Findpeople(nameplaces);


            ////2.让电脑计算并输出：99 + 97 + 95 + 93 + ...+1的值
            //int sum = 1;
            //for (int i = 3; i < 100; i += 2)
            //{
            //    sum = sum + i;
            //}
            //Console.WriteLine(sum);

            ////3.将源栈同学的成绩存入一个double数组中，用循环找到最高分和最低分
            //double[] scores = { 79.13, 38.22, 66.31, 44.44, 87.52 };
            //procedure.Maxandmin(scores);

            ////找到100以内的所有质数（只能被1和它自己整除的数）
            //int number = 100;
            //procedure.Primenumber(number);

            //2.生成一个元素（值随机）从小到大排列的数组(随机数的累加)

            int[] numbers = new int[9];
            numbers[0] = new Random().Next(1, 20);
            for (int i = 1; i < numbers.Length; i++)
            {
                numbers[i] = new Random().Next(1, 200) + numbers[i - 1];
                Console.WriteLine(numbers[i]);
            }



            //3.设立并显示一个多维数组的值，元素值等于下标之和。Console.Write()









            /////现在开始的  所有重做工作全部面向对象/////
            ////登录功能----User完成
            //User hjb = new User();
            //hjb.Name = "hjb";
            //hjb.Password = "123";
            //hjb.Authcore = "q1q1";
            //hjb.Login();







            ////            2.作业：面向对象：引用类型和值类型
            ////1.用代码和调试过程演示：
            ////1.值类型参数的值传递
            ////测试环境 同一个class下
            //            static int V(int i)
            //            {
            //                i = i + 1;
            //                return i;
            //            }
            //            //------------------
            //            int i = 1;
            //            V(i);
            ////            2.引用类型参数的值传递
            ////测试环境跨了一个class 指针进去给了b, b又给换回来了
            //              public static User a(User test)
            //            {
            //                User b = new User();
            //                b = test;
            //                return b;
            //            }
            //            //--------------------------------------------
            //             User test = new User();
            //            test.small = 1;
            //            User.a(test);

            //            //3.值类型参数的引用传递
            //        static int V(ref int i)
            //            {
            //                i = i + 1;
            //                return i;
            //            }
            //            //------------------------------------------------
            //        static void Main(string[] args)
            //            {
            //                int i = 1;
            //                V(ref i);
            //            }


            //            //4.引用类型参数的引用传递
            //         public static User a(ref User test)
            //            {
            //                User b = test;
            //                return b;
            //            }

            //            //--------------------------------------------------------
            //                        User test = new User();
            //            test.small = 1;
            //            User.a(ref test);

            //            //5.return代替引用类型的引用传递
            //          public static User a(User test)
            //            {
            //                User b = new User();
            //                b.small = 1;
            //                return b;
            //            }
            //            //------------------------------
            //                        User test = new User();
            //                          test.small = 1;
            //                         User.a(test);
            ////            2.思考：为什么需要区分引用类型和值类型？
            ////根据数据的大小来设计的
            ////------------------注册------------------------
            //string readname = Console.ReadLine();
            //string readpassword = Console.ReadLine();
            //string readpasswordcopy = Console.ReadLine();

            //string readinvitedby = Console.ReadLine();
            //string readauthcode = Console.ReadLine();
            ////声明
            //User newuser = new User();
            //newuser.Invitedby = "han";
            //newuser.Authcore = "1234";
            //if (newuser.Register(readname, readpassword, readpasswordcopy, readinvitedby, readauthcode))
            //{
            //    Console.WriteLine("注册成功");
            //}
            //else
            //{
            //    Console.WriteLine("注册失败");

            //}

            ////-----------------登录------------------1----
            ////用户输入的内容
            //readname = "aaa";
            //readpassword = "123";
            //readauthcode = "1234";
            ////声明

            //User han = new User("hanjiabao", "123", "1234");
            ////调用对象方法
            //if (han.Login(readname, readpassword, readauthcode))
            //{
            //    Console.WriteLine("登录成功");
            //}
            //else
            //{
            //    Console.WriteLine("登录失败");
            //}

            ////-------------------求助问题的发布----------------------
            ////用户输入的内容
            //string readtitle = Console.ReadLine();
            //string readbody = Console.ReadLine();
            //DateTime readpublishtime = new DateTime(Convert.ToInt64(Console.ReadLine()));
            //string readauthor = Console.ReadLine();

            //int readreward = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("关键字");
            //String[] keyword = new string[10];
            //keyword[0] = Console.ReadLine();

            ////声明
            //Problem newproblem = new Problem("Problem");
            ////调用
            //if (newproblem.Publish(readtitle, readbody, readauthor, readreward, keyword))
            //{
            //    Console.WriteLine("发布成功");
            //}
            //else
            //{
            //    Console.WriteLine("发布失败");
            //}

            ////----------------BB币变动--------------
            ////用户输入
            //int change_number= Convert.ToInt32(Console.ReadLine());
            //string remark = Console.ReadLine();
            ////声明
            //HelpMoney newhelpMoney = new HelpMoney();
            ////数据赋值
            //newhelpMoney.Useable=10;
            //newhelpMoney.Freeze=true;
            //newhelpMoney.Kind="金";
            //newhelpMoney.Change_number=1;
            //newhelpMoney.Remark="无";
            ////调用
            //newhelpMoney.change(change_number, remark);


            ////出入栈
            //MimicStack stack = new MimicStack(2);
            ////调用
            //stack.Push(1);
            //stack.Push(2);
            //stack.Pop();


            ////            用代码证明struct定义的类型是值类型
            ////a不用new,b需要new
            //int a =1;
            //Problem b=1;

            ////源栈的学费是按周计费的，所以请实现这两个功能：
            ////函数GetDate()，能计算一个日期若干（日 / 周 / 月）后的日期
            //Console.WriteLine("请输入起始时间,格式为:年,月,日");
            //DateTime sth = Convert.ToDateTime(Console.ReadLine());
            //Console.WriteLine("请输入变化的时间,单位/天");
            //int dd = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入变化的时间,单位/月");
            //int mm = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入变化的时间,单位/年");
            //int yy = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(GetDateTime.GetDate(dd, mm, yy, sth).ToString("yyyy年MM月dd日"));

            ////    给定任意一个年份，就能按周排列显示每周的起始日期，如下图所示：
            //Console.WriteLine("请输入起始时间,格式为:年");
            //int year = Convert.ToInt32(Console.ReadLine());
            //GetDateTime.GetDate(year);


            //            声明一个令牌（Token）枚举，包含值：SuperAdmin、Admin、Blogger、Newbie、Registered。
            //声明一个令牌管理（TokenManager）类：
            //使用私有的Token类型的_tokens存储所具有的权限
            //暴露Add(Token)、Remove(Token)和Has(Token)方法，可以添加、删除和判断其有无某个权限
            //User类中添加一个Tokens属性，类型为TokenManager


            ////1.在https://source.dot.net/中找到 Console.WriteLine(new Student()); 输出Student类名的源代码
            //Entity id = new User();
            //Console.WriteLine(id.GetType().Name);
            //Console.WriteLine(typeof(User));/*这个只可以是类型*/
            ////2.思考dynamic和var的区别，并用代码予以演示
            ////一个是动态,一个是自动调整(第一次会自动适应数值类型,以后会一直用这个数据类型)
            //dynamic a = 1;
            //a = "123";
            //var b= 1;
            //b = "123";/*报错了*/
            ////3.构造一个能装任何数据的数组，并完成数据的读写
            //object[] box = new object[3] { 1, "2", true };
            //box[0] = 2;
            //bool a = (bool)box[2];
            ////4.使用object改造数据结构栈（MimicStack），并在出栈时获得出栈元素(改造结束)













            //测试

            //Console.WriteLine(1|0);
            //Console.WriteLine(1&0);

        }
        }
    }
