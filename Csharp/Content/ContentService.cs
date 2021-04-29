using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{


    class ContentService
    {
        public Content Option;
        public void ToDataBase()
        {

        }

        public void Publish()
        {
            try
            {
                Option.Publish();
            }
            catch (ArgumentOutOfRangeException)
            {
              
            }
            catch (ArgumentNullException)
            {
                throw new ArgumentNullException();
            }
            finally
            {
                Console.WriteLine($"{DateTime.Now}，请求发布内容ID={Option.id}");
            }
        }

        ///问:实例一个文体就可以publish,为哈还要新建一个ContentService?
        /// 答: 因为这样还可以附带处理更多的数据,例如把这个文体存到数据库,或者第几次publish啥的
    }
}
