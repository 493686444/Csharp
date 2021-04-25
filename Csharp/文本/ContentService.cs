using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{


    class ContentService
    {

        public Content Option;

        public void Publish(Contenttype type) //参数枚举更好
        {
            type = Contenttype.Article;//这行 根据用户的输入决定
            switch (type)
            {
                case Contenttype.Problem:
                    Content problem = new Problem("Problem");
                    problem.Publish();
                    break;
                case Contenttype.Article:
                    Content article = new Problem("Article");
                    article.Publish();
                    break;
                case Contenttype.Suggest:
                    Content suggest = new Problem("Suggest");
                    suggest.Publish();
                    break;
                default:
                    break;
            }



        }
    }
}
