using System;
using System.Collections.Concurrent;
using System.Net.Http.Headers;

namespace _4._3
{
    class Person
    {
        private double [] ds;
        private int n;
        public void nhap()
        {
            Console.WriteLine("nhap so luong mon"); n = int.Parse(Console.ReadLine());
            ds = new double [n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("nhap diem on thu"+i);
                ds[i] = double.Parse(Console.ReadLine());
            }
        }
        public void hien()
        {
            Console.WriteLine("diem cac mon");
            for (int i = 0; i<n+1 ; i++)
            {
                Console.WriteLine("{0}\t",ds[i]);
                Console.WriteLine();
            }
        }
        public double  tb()
        {
            double a = ds[0];
            for (int i = 0; i<n+1; i++)
            {
                a = a + ds[i];
                i++;
            }
            return a/9;
        }
        
        static void Main(string[] args)
        {
            Person a = new Person();
            a.nhap(); a.tb(); ;a.hien();
            Console.ReadLine();
        }
    }
}
