using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{

    class Problem
        : Content, IAgreeOrNot
    {
        //0.0构造函数
        public Problem(string kind)
            :base(kind)
        { 
        
        }

        //1.数据
                //特有
                public int Rewardtype;
                public int Answer;
                public int Summary;

                //和文章共有
                        //公有(假私有)
                        private string[] _keyword = new string[10];
                        public string this[int index]
                        {
                            get { return _keyword[index]; }
                            set { _keyword[index] = value; }
                        }

                //三者共有(写在父类)
                  
                        //私有
                        private int _reward;
                //^property
                public int Reward
                {
                    set
                    {
                        if (value < 0)
                        { 
                            Console.WriteLine("奖励不可以小于零");
                        }
                        else 
                        {
                            _reward = value;
                    }
                }
                    get { return _reward; }
                }


        //2.1功能
        public bool Publish(string readtitle, string readbody,
                             string readauth,
                            int readreward,string[] keyword)
        {
            Reward = readreward;
            if (_reward==readreward)
            {
                if (readbody is null)
                {
                    return false;
                }
                else
                {
                    Title = readtitle;
                    Body = readbody;
                    Author = readauth;

                    for (int i = 0; i < _keyword.Length; i++)
                    {
                        _keyword[i] = keyword[i];
                    }
                    return true;
                }
            }
            else
            {
                return false;
            }
            
        }

        //2.2接口的实现
        public void Change() 
        {
            
        }
        //2.3抽象成员的实现
        public override void  Publish()
        {

        }


        //待补充完成(因为面向对象,所以先搁置)
        //static public bool Load(int Id) { }
        //static public bool Delete(int Id) { }
        //public bool repoistory() { }

    }
}
