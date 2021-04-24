using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{

    class HelpMoney
        :Entity<int>
    {
        //1.数据
        //公有
        public DateTime Time;
        public int Useable;
        public bool Freeze;
        public string Kind;
        public int Change_number;
        public string Remark;

        //2.0功能
        public void change(int change_number, string remark)
        {
            Useable = Useable + change_number;
            Remark = remark;
        }







    }
}
