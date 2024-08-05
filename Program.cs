using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace tip_donusumleri
{
    class Program
    { 
        static void Main(string[] args)
        {
             // Implicit Conversion (Bilinçsiz dönüşüm)

                 Console.WriteLine("******Implicit Conversion******");

             byte a = 5;
             sbyte b = 50;
             short c = 20;

             int d = a+b+c;
             Console.WriteLine("d:" +d);

             long h = d;
             Console.WriteLine("h:" +h);

             float f = h;
             Console.WriteLine("f:" +f);

             string e= "muzaffer";
             char g='k';
             object m = d+e+g; 

            Console.WriteLine("m" +m);

             // Explicit Conversion 8Bilinçli Dönüşüm)

            Console.WriteLine("******Explicitly Conversion******");

            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y: " +y);

            int z = 100 ;
            byte t = (byte)z;
            Console.WriteLine("t: " +t);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v: " +v);

            // ****To String Methodu****
            Console.WriteLine("***To String Methodu***");

            int xx = 6;
            string yy =  xx.ToString();
            Console.WriteLine("yy: " +yy);

            string zz = 12.5f.ToString();
            Console.WriteLine("zz: " +zz);

            //System.Convert

            string s1 = "10" , s2 = "20" ;
            int sayi1,sayi2;
            int Toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);
            
            Toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam: " +Toplam);


            //Parse

            ParseMethod();

        }

        public static void ParseMethod()
        {
            string metin1  = "10";
            string metin2 = "10.25";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);
            double1 = Double.Parse(metin2);

            Console.WriteLine("rakam3:"  +rakam1);
            Console.WriteLine("double3: " +double1);

        }


    }
}