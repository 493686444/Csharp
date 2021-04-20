using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{

    class Problem
        : Content, IAgreeOrNot
    {
        #region  构造函数

        public Problem(string kind)
            : base(kind)
        {

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

        public Repoistory repoistory;
        public int Rewardtype;
        public int Answer;
        public int Summary;

        #endregion



        #region 功能---发布(Publish)
        public bool Publish(string readtitle, string readbody,
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
        //这两个需要整合一下,不过暂时先搁置
        //没设置参数,因为在实现
        #region 实现---Publish
        public override void Publish()
        {

        }
        #endregion





        #region 功能---删除
        public void Delete(int Id) 
        { 
        
        }
        #endregion

        #region 功能---获取1条求助
        public void Load(int Id) 
        { 
        
        }

        #endregion

        #region 实现---Change
        public void Change()
        {

        }
        #endregion

        #region 实现---Agree&Disagree
        public override void Agree() 
        {
        
        }
        public override void Disagree() 
        { 
        
        }
        #endregion

    }
}
