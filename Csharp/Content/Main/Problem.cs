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
                    { throw new ArgumentOutOfRangeException("参数越界"); }//1.修改之前的属性验证：problem.Reward为负数时直接抛出“参数越界”异常
                else
                    { _reward = value; }
            }
            get { return _reward; }
        }

        public Repoistory repoistory;
        public int Rewardtype;
        public User Answer;
        public int Summary;

        #endregion




        //这两个需要整合一下,不过暂时先搁置
        //没设置参数,因为在实现
        #region 实现---Publish
        public override void Publish()
        {

        }
        #endregion





        #region 功能---删除
        public void Delete()
        {
                
        }
        #endregion

        #region 功能---获取1条求助
        public void Load()
        {

        }

        #endregion

        #region 实现---Change
        public void Change()
        {

        }
        #endregion




    }
}
