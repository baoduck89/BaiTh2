using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.bai2
{
    class PS
    {
        private int ts, ms;
        public PS()
        {
            ts = 0; ms = 1;
        }
        public PS(int ts, int ms)
        {
            this.ts = ts;
            this.ms = ms;
        }
        public PS(PS t)
        {
            this.ts = t.ts;
            this.ms = t.ms;
        }
        public void Nhap()
        {
            Console.Write("Nhap tu so"); ts = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau so"); ms = int.Parse(Console.ReadLine());
        }
        public PS Tong(PS t2)
        {
            PS t = new PS();
            t.ts = this.ts * t2.ms + this.ms * t2.ts;
            t.ms = this.ms * t2.ms;
            return t;
        }
        public PS Hieu(PS t2)
        {
            PS t = new PS();
            t.ts = this.ts * t2.ms - this.ms * t2.ts;
            t.ms = this.ms * t2.ms;
            return t;
        }
        public PS Nhan(PS t2)
        {
            PS t = new PS();
            t.ts = this.ts * t2.ts;
            t.ms = this.ms * t2.ms;
            return t;
        }
        public PS Chia(PS t2)
        {
            PS t = new PS();
            t.ts = this.ts * t2.ms;
            t.ms = this.ms * t2.ts;
            return t;
        }

        public void hien()
        {
            Console.WriteLine("phan so co dang {0}/{1}", ts, ms);
            
        }
        class test
        {
            static void Main(string[] args)
            {
                PS t = new PS();
                t.Nhap(); t.hien();
                PS t2 = new PS();
                t2.Nhap(); t2.hien();
                PS t3 = t + t2; t3.hien();
                PS t4 = t * t2; t4.hien();
                if (t > t2)
                {
                    Console.WriteLine("ps t1>t2");
                }
                else if (t < t2)
                {
                    Console.WriteLine("ps t1<t2S");
                }
                else
                    Console.WriteLine("hai ps = nhau");
                Console.ReadKey();
            }
        }
    }
}
