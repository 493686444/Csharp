using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
    //双向链表(Doubly Linked List)
    public class DLL
    {
        #region 数据
        public int ID;
        public DLL left;
        public DLL right;

        #endregion

        //方法可精简(将同者取出),但精简后不易理解
        #region 功能---加
        public void Addleft(DLL target)
        {
            if (this.left == null)
            { this.left = target; }
            else
            {
                target.right = this;
                target.left = this.left;

                this.left.right = target;
                this.left = target;
            }
        }
        public void Addright(DLL target)
        {
            if (this.right == null)
            { this.right = target; }
            else
            {
                target.left = this;
                target.right = this.right;

                this.right.left = target;
                this.right = target;
            }
        }



        #endregion

        #region 功能---减
        public void Delete()
        {
            //if (right==null&&left==null)//左右两个null
            //{
            //    //这种情况不存在,链表  最少要有两个
            //}
            if (left == null && right != null)//  在左有一个null
            { right.left = null; right = null; }
            else if (left != null && right == null)// 在右有一个null
            { left.right = null; left = null; }
            else//无null
            {
                right.left = left;
                left.right = right;
            }
        }
        #endregion

        #region 功能---移动
        public static void Swap(DLL theright, DLL theleft)//两个对象之间交换 静态更好
        {
            //思路一 : 利用加减做,  思路二 : 备份6个对象  思路三 : 面向过程做

            //这个代码没有完善  左右连在一起的情况没写

            //备份
            DLL theleftup = theleft, therightup = theright;
            //修改右槽
            theright.left.right = theleft;
            if (theright.right != null)
            { theright.right.left = theleft; }
            //else {  }
            
            //修改左槽
            theleft.right.left = theright;
            if (theleft.left != null)
            { theleft.right.left = theright;  }
            //else { }

            //修改左者
            DLL backup_left = theleft;  //备份
            theleft.left = theright.left;
            if (theright.right!=null)
            { theleft.right = theright.right; }
            else
            { theleft.right = null; }
            //修改右者
            theright.right = backup_left.right;
            if (backup_left.left != null)
            { theright.left = backup_left.left; }
            else
            { theright.left = null; }



        }
        //想写个ChangeTo的方法( 属于对象 但是多余,还是算了)
        #endregion

        //[选] FindBy()：根据节点值查找到某个节点  //没懂是啥意思



        //自 : 问1 :为啥没这个对象自己呢?  答 : 因为 这是一个类(模板),{ 模板就是他自己的模板 },
        //      当模板实例化之后就是他自己了,所以没必要加他自己,这里涉及到变量和对象的关系.
        //问2 :对象和变量有啥关系  答 : 变量是用来直接或者间接 存放对象的 , 有时候会直接放个值或者字符串,这个是和new一下等价的




    }
}
