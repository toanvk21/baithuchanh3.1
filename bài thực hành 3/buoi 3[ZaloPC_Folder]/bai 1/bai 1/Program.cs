using System;
using System.Net.NetworkInformation;
using System.Runtime.Serialization;

namespace bai_1
{
    class Time
    {
        private int gio, phut, giay;
        public Time()
        {
            gio = phut = giay = 0;    
        }
        public Time(int gio,int phut,int giay)
        {
            this.gio = gio;
            this.phut = phut;
            this.giay = giay;
        }
        public int Getgio
        {
           get { return gio; }
            set { gio = value; }
        }
        public int Getphut
        {
            get { return phut; }
            set {  phut = value; }

        }
        public int  Getgiay
        { 
            get {return giay; }
            set { giay = value; }
        }

        public void norma(int h, int m, int s)
        {
            int x;
            if (s> 60)
            {
                phut += s / 60;
                giay = s % 60;
            }
            if (m > 60)
            { 
                gio += m / 60;
                 m = m % 60;
        }
            if (h > 24)
                x = h / 24;
                gio = h % 24;
        }
        public void advanc(int h,int p,int s)
        {
            gio = this.gio + h;
            phut = this.phut + p;
            giay = this.giay + s;
            //Console.WriteLine("thoi gian hien hanh gio{0},phut{1},giay{1}", this.gio, this.phut, this.giay);
        }
        public void hien()
        {
            Console.WriteLine("thoi gian {0}gio,{1}phut,{2}giay", gio, phut, giay);
        }
        
        static void Main(string[] args)
        {
            Time t = new Time();
            t.advanc(1, 20,5);
            
            t.hien();
            Time a = new Time();
            a.norma(1, 70, 70);
            a.hien();

            Console.ReadKey();

        }
    }
}
