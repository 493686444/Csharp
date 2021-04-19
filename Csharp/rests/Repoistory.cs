using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
    /// <summary>
    /// 仓库(储藏室)
    /// </summary>
    class Repoistory
    {
        //1.一个int类型的常量version
        //2.一个静态只读的字符串connection，以后可用于连接数据库
        //3.思考Respoitory应该是static类还是实例类更好
        #region 数据
        public int version;
        public static string connection { private set; get; }
    
        #endregion

        #region 功能---存
        public void Save() 
        {
        
        }
        #endregion

        #region 功能---取
        public void Get()
        {

        }
        #endregion


    }
}
