using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace captcha
{

    class Program
    {
     
        static void Main(string[] args)
        {
            //IO和文件操作

            // 参考一起帮的登录页面，绘制一个验证码图片，存放到当前项目中。验证码应包含：
            {
                //1.随机字符串
                //2.混淆用的各色像素点
                //3.混淆用的直线（或曲线）
            }
            string[] letter = new string[] { "q", "w", "e", "r", "t", "y", "u", "i", "o", "p", "a", "s", "d", "f", "g", "h", "j", "k", "l", "z", "x", "c", "v", "b", "n", "m" };

            //随机数
            Random random = new Random();
    

            Bitmap board = new Bitmap(200, 80);//画板

            Graphics g = Graphics.FromImage(board);//图
            g.Clear(Color.FromArgb
                    (
                        random.Next(255),
                        random.Next(255),
                        random.Next(255),
                        random.Next(255)
                        ));

            //乱线和点
            for (int i = 0; i < 100; i++)
            {

                g.DrawLine(
                    new Pen(
                        Color.FromArgb
                    (
                        random.Next(255),
                        random.Next(255),
                        random.Next(255),
                        random.Next(255)
                        )
                    ),
                    new Point(random.Next(200), random.Next(80)),
                    new Point(random.Next(200), random.Next(80)));
                board.SetPixel(random.Next(200), random.Next(80), Color.FromArgb
                    (
                        random.Next(255),
                        random.Next(255),
                        random.Next(255),
                        random.Next(255)
                        ));

            }

            //字母
            g.DrawString(
               letter[random.Next(0, 25)] + letter[random.Next(0, 25)] + letter[random.Next(0, 25)] + letter[random.Next(0, 25)],
               new Font("Tahoma", 55),
               new SolidBrush(Color.FromArgb
                    (
                        random.Next(255),
                        random.Next(255),
                        random.Next(255),
                        random.Next(255)
                        )),
               new PointF(1, 0)
               );


            //保存的位置
            board.Save(@"E:\hello.jpg");


            //一.现有一个txt文件，里面存放了若干email地址，使用分号（;）或者换行进行了分隔。
            //请删除其中重复的email地址，并按每30个email一行（行内用; 分隔）重新组织


            //二.将生成验证码的代码拆分成若干个方法，并为其添加异常机制，要求能够：
            {
                //1.显式的抛出一个自定义异常
                //2.捕获并包裹一个被抛出的异常，记入日志文件，然后再次抛出
                //3.根据不同的异常，给用户相应的友好的异常提示
                //4.使用using释放文件资源
            }

        }
    }
}
