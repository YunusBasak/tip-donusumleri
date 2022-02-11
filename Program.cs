using System;

namespace tip_donusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            // implicit Conversion (Bilinçsiz Dönüşüm)

            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a+b+c;
            System.Console.WriteLine("d :" + d);

            long h = d;
            System.Console.WriteLine("h :" + h);

            float i = h;
            System.Console.WriteLine("i :" + i);

            string e = "Yunus";
            char f = 'Y';
            object g = e+f+d; // object değişkeni ile diğer tüm değişkenleri birlikte kullanabiliriz.
            System.Console.WriteLine("g :" + g);

            // Explicit Conversion (Bilinçli Dönüşüm)

            System.Console.WriteLine("*** Explicit Conversion ***");

            int x = 4;
            byte y = (byte)x; // parantez içine yazılan veri tipi sağına gelen ifadeyi parantez içindeki veri tipine dönüştürür.
            System.Console.WriteLine("y : " + y);

            int z = 100;
            byte t = (byte)z;
            System.Console.WriteLine("t : " +t);

            float w = 10.3f;
            byte v = (byte)w;
            System.Console.WriteLine("v: " +v);

             // ToString Metodu
            System.Console.WriteLine("*** ToString Metodu *** ");

            int xx = 6;
            string yy = xx.ToString(); // int xx değerinini (6) string veri tipinde yy değeri olarak atadı
            System.Console.WriteLine("yy :" +yy);

            string zz = 12.5f.ToString();
            System.Console.WriteLine("zz :" +zz);

            // System.Convert sınıfı
            System.Console.WriteLine("*** System.Convert sınıfı *** ");

            // stirng veri tipinde verilen sayıları int veri tipine döştürüp(ToInt32) topladık.

            string s1 ="10", s2 ="20";
            int sayi1, sayi2;
            int Toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);

            Toplam = sayi1 + sayi2;
            System.Console.WriteLine("Toplam : " + Toplam);

            // Parse

            System.Console.WriteLine("*** Parse Metodu ***");
            ParseMethod();


        }

        public static void ParseMethod()
        {   
            string metin1 = "10";
            string metin2 = "10,25";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1); // -Parse- String ifadeleri dönüştürmek için kullanılır ve her zaman string alır.
            System.Console.WriteLine("rakam1 : " + rakam1);
            double1 = Double.Parse(metin2);
            System.Console.WriteLine("double1 : " + double1);



        }
    }
}
