using System;
using System.ComponentModel.DataAnnotations;

namespace bai_4._2
{
    class Nhanvien
    {
        private string hoten, quequan;
        private static int lcb;
        public  double hesl;
        public string Hoten
        {
            get { return hoten; }
            set { hoten = value; }
        }
        public double HSL
        {
            get { return hesl; }
            set { hesl = value; }
        }
        public void nhap()
        {
            Console.WriteLine("nhap ho ten"); hoten = Console.ReadLine();
            Console.WriteLine("nhap qq"); quequan = Console.ReadLine();
            Console.WriteLine("nhap lcb"); lcb = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap hsl"); hesl = double.Parse(Console.ReadLine());
        }
        public double tinhluong()
        {
            return hesl * lcb;
        }
        public void hien()
        {
            Console.WriteLine("thong tin");
            Console.WriteLine("hoten" + hoten);
            Console.WriteLine("qe quan" + quequan);
            Console.WriteLine("luong cb" + lcb);
            Console.WriteLine("hsl" + hesl);
            Console.WriteLine("thunhap" + tinhluong());
        }
    }

    class Quanli
    {
        private Nhanvien[] a;
        private int n;

        public void nhap()
        {
            Console.WriteLine("nhap so l nv"); n = int.Parse(Console.ReadLine());
            a = new Nhanvien[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = new Nhanvien();
                a[i].nhap();
            }
        }
        public void hien()
        {
            for (int i = 0; i < n; i++)
            {
                a[i].hien();
                Console.WriteLine();
            }
        }
        public void sapxep()
        {
            for (int i = 0; i < n; ++i)
            {
                for (int j = i + 1; i < n; ++j)

                    if (string.Compare(a[i].Hoten, a[j].Hoten)>0)
                    {
                        Nhanvien t = a[i];
                        a[i] = a[j];
                        a[j] = t;
                    }


            }
        }
        public double hslmax()
        {
            double max = a[0].hesl;
            for (int i = 0; i < n; i++)

                if (a[i].hesl > max)
                {
                    max = a[i].hesl;
                }
            return max;
        }
            public void hiendsmax()
        {
            double max = hslmax();
            for (int i = 0; i < n; i++)
            {
                if (a[i].hesl == max)
                    a[i].hien();
            }
        }
    }
    class test
    {

        static void Main(string[] args)
        {
            Quanli q = new Quanli();
            q.nhap();q.sapxep();
            q.hien();
            q.hiendsmax();
            Console.ReadKey();
        }
    }
}
