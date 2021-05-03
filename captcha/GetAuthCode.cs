using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace captcha
{
    class GetAuthCode
    {
        public string InAuthCode;
        public string OutAuthCode;

        public void AuthCode()
        {
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
            string letters = letter[random.Next(0, 25)] + letter[random.Next(0, 25)] + letter[random.Next(0, 25)] + letter[random.Next(0, 25)];

            g.DrawString(letters,
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

            InAuthCode = letters;
        }

        public void Inquisitor()
        {
            if (OutAuthCode is null)
            {
                Console.WriteLine("验证码不可空");
                throw new ArgumentNullException("验证码不可空");
            }
           else
            {
                if (OutAuthCode != InAuthCode)
                {
                    Console.WriteLine("验证码错误");
                    throw new Exception("验证码错误");
                }
                else
                {
                    Console.WriteLine("验证码正确");
                }
            }
           
        }
    }
}
