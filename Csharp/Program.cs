using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

namespace Csharp
{
    class Program
    {

        static void Main(string[] args)
        {
            #region 面向过程

            #region 运算符和表达式

            #region 1.输出两个整数 / 小数的和 / 差 / 积 / 商
            //Console.WriteLine(1 + 1);
            //Console.WriteLine(0.1 + 0.2);
            #endregion

            #region 2.电脑计算并输出：[(23 + 7)x12-8]÷6的小数值
            //  Console.WriteLine(Math.Round((Single)((23 + 7) * 12 - 8) / 6, 2));
            #endregion

            #endregion

            #region 数组
            ////将源栈同学姓名/昵称分别：
            #region 1.按进栈时间装入一维数组
            //string[] names = { "小红", "小明", "小刚" };
            #endregion

            #region 2.按座位装入二维数组
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
            #endregion

            #endregion

            #region 循环

            #region 1.分别用for循环和while循环输出：1,2,3,4,5 和 1,3,5,7,9
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
            #endregion

            #region 2.用for循环输出存储在一维 / 二维数组里的源栈所有同学姓名 / 昵称
            ////part1   一维
            //string[] names = { "小红", "小明", "小刚" };
            //procedure.Findpeople(names);
            ////part2   二维
            //string[,] nameplaces = { { "小红(0,0)", null, "小刚(0,2)" }, { null, null, "小明(1,2)" } };
            //procedure.Findpeople(nameplaces);

            #endregion

            #region 3.让电脑计算并输出：99 + 97 + 95 + 93 + ...+1的值
            //int sum = 1;
            //for (int i = 3; i < 100; i += 2)
            //{
            //    sum = sum + i;
            //}
            //Console.WriteLine(sum);
            #endregion

            #region 4.将源栈同学的成绩存入一个double数组中，用循环找到最高分和最低分
            //double[] scores = { 79.13, 38.22, 66.31, 44.44, 87.52 };
            //procedure.GetMin(scores);
            #endregion

            #region 5.找到100以内的所有质数（只能被1和它自己整除的数）
            //int number = 100;
            //procedure.Primenumber(number);//[test]之后加了返回值,可以直接返回数组
            #endregion

            #region 6.生成一个元素（值随机）从小到大排列的数组(随机数的累加)
            //int[] numbers = new int[9];
            //numbers[0] = new Random().Next(1, 20);
            //for (int i = 1; i < numbers.Length; i++)
            //{
            //    numbers[i] = new Random().Next(1, 200) + numbers[i - 1];
            //    Console.WriteLine(numbers[i]);
            //}
            #endregion

            #region 7.设立并显示一个多维数组的值，元素值等于下标之和。
            //int[,] numbers = new int[3,4];
            //for (int i = 0; i <= numbers.GetLength(1); i++)
            //{
            //    for (int j = 0; j <= numbers.GetLength(0); j++)
            //    {
            //        numbers[i, j] = i + j;
            //        Console.Write(numbers[i, j]);
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #endregion

            #region  方法基础：声明 / 调用 / 返回值

            #region  2.计算得到源栈同学的平均成绩（精确到两位小数），方法名GetAverage()
            //double[] numbers = { 23.2, 43.5, 23.5, 56.5 };
            //procedure.GetAverage(numbers);
            #endregion

            #region 3.完成“猜数字”游戏，方法名GuessMe()
            {
                //随机生成一个大于0小于1000的整数
                //用户输入一个猜测值，系统进行判断，告知用户猜测的数是“大了”，还是“小了”
                //没猜中可以继续猜，但最多不能超过10次
                //①　如果5次之内猜中，输出：你真牛逼！
                //②　如果8次之内猜中，输出：不错嘛！
                //③　10次还没猜中，输出：(～￣(OO)￣)ブ
            }
            //procedure.GuessMe();
            #endregion

            #endregion

            #region 方法进阶：值/引用传递

            #region 1.利用ref调用Swap()方法交换两个同学的床位号
            //int hjb = 1;
            //int xkp = 2;
            //procedure.changebed(ref hjb,ref xkp);
            #endregion

            #region 2.将登陆的过程封装成一个方法LogOn()，调用之后能够获得：
            {
                //true / false，表示登陆是否成功
                //string，表示登陆失败的原因
            }
            //User来做这事  login
            #endregion

            #endregion

            #region 方法进阶：参数：重载/可选/params

            #region  1.定义一个生成数组的方法：int[] GetArray()，其元素随机生成从小到大排列。利用可选参数控制：
            {
                //最小值min（默认为1） 
                //相邻两个元素之间的最大差值gap（默认为5）
                //元素个数length（默认为10个）
            }
            ////最小值1
            //int min= 1;
            ////最大差值5
            //int span = 5;
            ////元素个数10
            //int number = 10;
            //procedure.GetArray(min,span,number);
            #endregion

            #region 2.实现二分查找，方法名BinarySeek(int[] numbers, int target)：
            {
                //传入一个有序（从大到小 / 从小到大）数组和数组中要查找的元素
                //如果找到，返回该元素所在的下标；否则，返回 - 1
            }

            //int[] numbers = new int[9] { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
            //int target = 3;
            //procedure.BinarySeek(numbers, target);

            #endregion

            #endregion

            #region 两个算法

            #region 冒泡排序
            //int[] a_ints= { 2, 7, 3, 9, 4, 7, 5 };
            //procedure.bubble(a_ints);

            #endregion

            #region 快排
            //搁置
            #endregion

            #endregion

            #endregion 面向过程-结束

            #region 面向对象

            #region 一些对象(调用工作,在此处进行)

            #region User 对象

            #region 登录功能----User
            //User hjb = new User();
            //hjb.Name = "hjb";
            //hjb.Password = "123";
            //hjb.Authcore = "q1q1";
            //hjb.Login();
            #endregion

            #region 注册功能---User

            //User readuser = new User();
            //Console.WriteLine("name");
            //readuser.Name= Console.ReadLine();
            //Console.WriteLine("password");
            //readuser.Password= Console.ReadLine();
            //Console.WriteLine("invitedby");
            //readuser.Invitedby= Console.ReadLine();
            //Console.WriteLine( "authcore");
            //readuser.Authcore= Console.ReadLine();
            //Console.WriteLine(  "second password");
            //string readpasswordcopy = Console.ReadLine();

            //User newuser = new User();
            //newuser.Invitedby = "han";
            //newuser.Authcore = "1234";

            //if (newuser.Register(readpasswordcopy, readuser))
            //{  Console.WriteLine("注册成功"); }
            //else
            //{  Console.WriteLine("注册失败"); }

            #endregion

            #endregion

            #region Problem 对象
            //重改之后没更新
            ////Console.WriteLine("收到了前端数据  即将发送至后端");

            ////用户输入的内容
            //string readtitle = Console.ReadLine();
            //string readbody = Console.ReadLine();
            //DateTime readpublishtime = new DateTime(Convert.ToInt64(Console.ReadLine()));
            //string readauthor = Console.ReadLine();
            //int readreward = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("关键字");
            //String[] keyword = new string[10];
            //for (int i = 0; i < keyword.Length; i++)
            //{
            //    keyword[i] = Console.ReadLine();
            //}
            //声明
            //Problem myproblem = new Problem("problem");
            //调用   (没有返回值的话也可以,但是  失败或者成功的反馈结果  要放在函数里边)
            //if (myproblem.Publish(readtitle, readbody, readauthor, readreward, keyword))
            //{ Console.WriteLine("发布成功"); }
            //else
            //{ Console.WriteLine("发布失败"); }




            #endregion

            #region 模拟栈 对象
            ////出入栈
            //MimicStack stack = new MimicStack(2);
            ////调用
            //stack.Push(1);
            //stack.Push(2);
            //stack.Pop();
            //stack.Pop();
            //stack.Pop();

            #endregion

            #region Article 对象
            //因为反射的是父类的中的方法 ,所以要用.BaseType
            //Article article = new Article("Article"); 
            //article.GetType()
            //     .BaseType.GetField("_createtime", BindingFlags.NonPublic | BindingFlags.Instance)
            //     .SetValue(article, new DateTime(2020,2,13));
            //Console.WriteLine(article.CreateTime);

            #endregion

            #endregion

            #region 引用类型和值类型

            ////值类型参数的值传递
            //int number= 1;
            //procedure.Transmit(number);

            ////引用类型参数的值传递
            //ThePublic hjb = new ThePublic();
            //procedure.Transmit(hjb);

            ////值类型参数的引用传递0
            //int number = 1;
            //procedure.Transmit (ref number);

            ////引用类型参数的引用传递
            //ThePublic hjb = new ThePublic();
            //procedure.Transmit(ref hjb);

            ////return代替引用类型的引用传递
            //ThePublic hjb = new ThePublic();
            //procedure.Transmit_r(hjb);

            #endregion

            #region 结构和日期

            #region 1.用代码证明struct定义的类型是值类型
            //class类型需要new,默认为空,struct为值类型,有默认数值

            //int thevalue = 1;  //不报错      int struct类型
            //Problem theref = 1;    //报错  class 引用类型
            #endregion

            #region 2.源栈的学费是按周计费的，所以请实现这两个功能：
            {
                //1.函数GetDate()，能计算一个日期若干（日 / 周 / 月）后的日期
                //2.给定任意一个年份，就能按周排列显示每周的起始日期，如下图所示：
            }
            ////2.1
            //Console.WriteLine("请输入起始时间,格式为:年,月,日");
            //DateTime sth = Convert.ToDateTime(Console.ReadLine());
            //Console.WriteLine("请输入变化的时间,单位/天");
            //int dd = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入变化的时间,单位/月");
            //int mm = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入变化的时间,单位/年");
            //int yy = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(GetDateTime.GetDate(dd, mm, yy, sth).ToString("yyyy年MM月dd日"));

            ////2/2
            //Console.WriteLine("请输入起始时间,格式为:年");
            //int year = Convert.ToInt32(Console.ReadLine());
            //GetDateTime.GetDate(year);


            #endregion

            #endregion

            #region Object和装箱拆箱

            ////1.在https://source.dot.net/中找到 Console.WriteLine(new Student()); 输出Student类名的源代码
            //ThePublic thepublic = new ThePublic();
            //Console.WriteLine(thepublic.GetType().Name);        /*这个可以是实例后的对象*/       // (可用于猜数字部分)  
            //Console.WriteLine(typeof(User));                                /*这个只可以是类型*/
            ////2.思考dynamic和var的区别，并用代码予以演示
            ////一个是动态,一个是自动调整(第一次会自动适应数值类型,以后会一直用这个数据类型)
            //dynamic dynamic = 1;
            //dynamic = "123";   /*没报错*/
            //var var = 1;
            //var = "123";   /*报错了*/
            ////3.构造一个能装任何数据的数组，并完成数据的读写
            //object[] all = new object[3] { 1, "2", true };
            //all[0] = 2;
            //bool abool = (bool)all[2];
            #endregion

            #region 特性的实例化

            //Attribute att = HelpMoneyChangedAttribute.GetCustomAttribute(
            //    typeof(Content).GetMethod("Publish"),   // 从哪找 类/结构/方法/数据
            //    typeof(HelpMoneyChangedAttribute));  // 找什么
            //                                         //如果有就实例化它   测试一下有没有实例化
            //Console.WriteLine(((HelpMoneyChangedAttribute)att).amount);

            #endregion

            #region GetCount 
            //string container = "12H456H789", target = "H";
            //Console.WriteLine(procedure.GetCount(container, target)); 
            #endregion

            #region mimicJoin

            //// mimicJoin("-", "a", "b", "c", "d")，其运行结果为：a - b - c - d
            //Console.WriteLine(procedure.mimicJoin("-", "a", "b", "c", "d"));

            #endregion

            #endregion 面向对象结束

            #region 进阶

            #region in&out

            //Func<Content, Content> daddad=null;
            //Func<Problem, Content> sondad=null;
            //sondad = daddad;//in 父给子
            //Func<Content, Problem> dadson=null;
            //daddad = dadson;//out 子给父

            #endregion

            #region 打水（ProvideWater）
            ////1.方法
            //Person hjb = new Person();
            //ProvideWater dsone = procedure.NeedWater;
            //Console.WriteLine(dsone(hjb));
            ////2.匿名法
            //ProvideWater dstwo = delegate (Person person) { return 2; };
            //Console.WriteLine(dstwo(hjb));
            ////3.Lambda
            //ProvideWater dsthree = (person) => { return 3; };
            //Console.WriteLine(dsthree(hjb));

            ////声明一个方法GetWater()，该方法接受ProvideWater作为参数，并能将ProvideWater的返回值输出
            //Console.WriteLine(
            //hjb.GetWater(dsthree));

            #endregion

            #region Linq: where/order/group/select
            //User
            //    fg = new User("飞哥", "fgF3333"),
            //    xy = new User("小鱼", "fgF3333");

            //Keyword cSharp = new Keyword();
            //cSharp.Name = "C#";
            //cSharp.Articles = new List<Article>();
            //Keyword pointNet = new Keyword();
            //pointNet.Name = ".NET";
            //pointNet.Articles = new List<Article>();

            //Comment
            //    comment_one = new Comment(),
            //    comment_two = new Comment(),
            //    comment_three = new Comment(),
            //    comment_four = new Comment();


            //Article
            //    article_one = new Article("article"),
            //    article_two = new Article("article"),
            //    article_three = new Article("article");

            //article_one.ID = 1;
            //article_one.Author = fg;
            //article_one.Keywords = new List<Keyword> { cSharp };
            //article_one.Comments = new List<Comment> { comment_one, comment_four };
            //article_one.GetType().BaseType.GetField("_publishTime", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(article_one, new DateTime(2020, 1, 1));

            //article_two.ID = 2;
            //article_two.Author = fg;
            //article_two.Keywords = new List<Keyword> { cSharp };
            //article_two.Comments = new List<Comment> { comment_two };
            //article_two.GetType().BaseType.GetField("_publishTime", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(article_two, new DateTime(2021, 8, 4));

            //article_three.ID = 3;
            //article_three.Author = xy;
            //article_three.Keywords = new List<Keyword> { pointNet };
            //article_three.Comments = new List<Comment> { comment_three };
            //article_three.GetType().BaseType.GetField("_publishTime", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(article_three, new DateTime(2017, 7, 7));


            //List<Article> articles = new List<Article>
            //{
            //article_three,
            //article_two,
            //article_one,
            //};


            //////    找出“飞哥”发布的文章  fg  Article
            //Console.WriteLine();
            //var fgArticle = from a in articles
            //                where a.Author.Equals(fg)
            //                select a;
            //foreach (var item in fgArticle)
            //{ Console.WriteLine("飞哥的文章 ID:" + item.ID); }
            //Console.WriteLine("方法↓↓↓");
            //fgArticle = articles.Where(a => a.Author.Equals(fg));//select可有可无
            //foreach (var item in fgArticle)
            //{ Console.WriteLine("飞哥的文章 ID:" + item.ID); }
            ////    找出2019年4月21日以后“小鱼”发布的文章   
            //Console.WriteLine();
            //var xyArttcle = from a in articles
            //                where a.Author.Name.Equals("小鱼") &&
            //                           a.PublishTime > new DateTime(2019 / 4 / 21)
            //                select a;
            //foreach (var item in xyArttcle)
            //{ Console.WriteLine("作者" + item.Author.Name + "---" + item.PublishTime + "文章ID:" + item.ID); }
            //Console.WriteLine("方法↓↓↓");
            //xyArttcle = articles.Where(a => a.Author.Name.Equals("小鱼")).Where(a => a.PublishTime > new DateTime(2019 / 4 / 21));/*.Select(a => a);*//*这个select可有可无*/
            //foreach (var item in xyArttcle)
            //{ Console.WriteLine("作者" + item.Author.Name + "---" + item.PublishTime + "文章ID:" + item.ID); }
            ////    按发布时间升序 / 降序排列显示文章    
            //var timeArttcle = from a in articles
            //                  orderby a.PublishTime descending
            //                  select a;
            //foreach (var item in timeArttcle)
            //{ Console.WriteLine(item.ID + ":" + item.PublishTime); }
            //Console.WriteLine("方法↓↓↓");
            //timeArttcle = articles.OrderByDescending(a => a.PublishTime);//理解方法的原理可知,这个不需要select
            //foreach (var item in timeArttcle)
            //{ Console.WriteLine(item.ID + ":" + item.PublishTime); }
            ////    统计每个用户各发布了多少篇文章    
            //var contArttcle = from a in articles
            //                  group a by a.Author into ga
            //                  select new { ga.Key, count = ga.Count() };
            //foreach (var item in contArttcle)
            //{ Console.WriteLine(item.Key.Name + ":" + item.count); }
            //Console.WriteLine("方法↓↓↓");
            //contArttcle = articles.GroupBy(a => a.Author).Select(a => new { a.Key, count=a.Count() });
            //foreach (var item in contArttcle)
            //{ Console.WriteLine(item.Key.Name + ":" + item.count); }
            //// 找出包含关键字“C#”或“.NET”的文章
            //var keyWordArttcles = from a in articles
            //                      where a.Keywords != null && a.Keywords.Any(k => k.Name == "C#" || k.Name == ".NET ")
            //                      select a;
            //foreach (var item in keyWordArttcles)
            //{ Console.WriteLine("ID" + item.ID); }
            //Console.WriteLine("方法↓↓↓");
            //keyWordArttcles = articles.Where(a => a.Keywords != null && a.Keywords.Any(k => k.Name == "C#" || k.Name == ".NET "));
            //foreach (var item in keyWordArttcles)
            //{ Console.WriteLine("ID" + item.ID); }
            ////    找出评论数量最多的文章  Article    Appraise
            //var maxComments = from a in articles
            //                  select new { ID = a.ID, count = a.Comments.Count() };
            //int max = 1;
            //foreach (var item in maxComments)
            //{
            //    foreach (var item_ in maxComments)
            //    {
            //        if (item.count > item_.count)
            //        { max = item.ID; } /*else {  }nothing*/
            //    }
            //}
            //Console.WriteLine("评论数量最多的文章 ID:" + max);
            //Console.WriteLine("方法↓↓↓");
            //maxComments = articles.Select(a => new { ID = a.ID, count = a.Comments.Count() });
            //foreach (var item in maxComments)
            //{
            //    foreach (var item_ in maxComments)
            //    {
            //        if (item.count > item_.count)
            //        { max = item.ID; } /*else {  }nothing*/
            //    }
            //}
            //Console.WriteLine("评论数量最多的文章 ID:" + max);

            //// 找出每个作者评论数最多的文章
            //var maxUserComments = from a in articles
            //                      group a by a.Author into ga
            //                      select ga.OrderByDescending(a => a?.Comments.Count()).FirstOrDefault();//这一套组合方法,把组内定的东西给调用出来了,原来linq的原理就是方法*/
            //foreach (var item in maxUserComments)
            //{ Console.WriteLine(item.Author.Name + "评论最多的文章 ID:" + item.ID); }
            //Console.WriteLine("方法↓↓↓");
            //maxUserComments = articles.GroupBy(a => a.Author).Select(a => a.OrderByDescending(b => b?.Comments.Count()).FirstOrDefault());
            //foreach (var item in maxUserComments)
            //{ Console.WriteLine(item.Author.Name + "评论最多的文章 ID:" + item.ID); }

            ////找出每个作者最近发布的一篇文章
            //var lastarttcle = articles.GroupBy(a => a.Author).Select(ga => ga.OrderByDescending(a => a?.PublishTime).FirstOrDefault());
            //foreach (var item in lastarttcle)
            //{ Console.WriteLine(item.Author.Name + "最近发布的文章 ID:" + item.ID+"     时间为:"+item.PublishTime); }

            ////找出每一篇求助的悬赏都大于5个帮帮币的求助作者
            //Problem problem_one = new Problem("Problem");
            //problem_one.Reward = 10;
            //problem_one.Author = fg;
            //Problem problem_two = new Problem("Problem");
            //problem_two.Reward = 4;    
            //problem_two.Author = fg;
            //Problem problem_three = new Problem("Problem");
            //problem_three.Reward = 5;
            //problem_three.Author = xy;
            //List<Problem> problems = new List<Problem>() { problem_one,problem_two,problem_three}; 
            //var authors = problems.Where(a => a.Reward.CompareTo(5) > 0).Select(a => a.Author);
            //foreach (var item in authors)
            //{ Console.WriteLine("作者;"+item.Name);  }
            #endregion

            #region throw Exception



            #endregion
            #endregion









        }
    }
}

