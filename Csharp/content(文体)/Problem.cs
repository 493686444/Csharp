using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{

    class Problem
        : Content, IAgreeOrNot
    {
        #region  构造函数

        public Problem(string kind,string body)
            : base(kind)
        {
            Body = body; //1.每一个Problem对象一定有Body赋值
        }

        #endregion

        #region 数据

        private string[] _keyword = new string[10];
                public string this[int index]//3.一起帮的求助可以有多个（最多10个）关键字，请为其设置索引器，以便于我们通过其整数下标进行读写。
                {
                    get { return _keyword[index]; }
                    set { _keyword[index] = value; }
                }
        private int _reward;//Article也有这个
                public int Reward
                {
                    set
                    {
                        if (value < 0)
                        { Console.WriteLine("奖励不可以小于零"); }//3.problem.Reward不能为负数
                else
                        { _reward = value; }
                    }
                    get { return _reward; }
                }

        public int Rewardtype;
        public int Answer;
        public int Summary;

        #endregion

        #region 功能---发布(Publish)
        public  bool Publish(string readtitle, string readbody,
                          string readauth,
                         int readreward, string[] keyword)
        {
            Reward = readreward;
            if (_reward == readreward)
            {
                if (readbody is null)
                { return false; }
                else
                {
                    Title = readtitle;
                    Body = readbody;
                    Author = readauth; 
                    for (int i = 0; i < _keyword.Length; i++)
                    { _keyword[i] = keyword[i]; }
                    return true;
                }
            }
            else
            { return false; } 
        }
        #endregion
        //这两个需要重做一下
        #region 实现---Publish
        public override void Publish()
        {

        }

        #endregion 

        #region 实现---Change
        public void Change()
        {

        }

        #endregion



        //待补充完成(因为面向对象,所以先搁置)
        //static public bool Load(int Id) { }
        //static public bool Delete(int Id) { }
        //public bool repoistory() { }

    }
}
