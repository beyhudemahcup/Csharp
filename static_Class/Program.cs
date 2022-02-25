using System;

namespace StaticClass
{

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Calisan sayisi : {0}", Calisan.CalisanSayisi);//0
            Calisan calisan1 = new Calisan("isme", "ozel", "sair");
            Console.WriteLine("Calisan sayisi : {0}", Calisan.CalisanSayisi);//1
            Calisan calisan2 = new Calisan("ismet", "ozal", "dair");
            Calisan calisan3 = new Calisan("imset", "oz", "tair");
            Console.WriteLine("Calisan sayisi : {0}", Calisan.CalisanSayisi);//3
           //static siniflara bildigim uzere object create etmeden ulasabiliyorum
            Console.WriteLine("toplama sonucu : {0}" ,Islemler.Topla(3,4) );
            Console.WriteLine("cikarma sonucu : {0}" ,Islemler.Cikar(5,4) );


        }
    }
    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi; }

        private string Isim;
        private string Soyisim;
        private string Departman;

        static Calisan()
        {
            calisanSayisi = 0;
        }
        public Calisan(string isim, string soyisim, string departman)
        {
            this.Isim = isim;
            this.Soyisim = soyisim;
            this.Departman = departman;
            calisanSayisi++;
        }
    }
    static class Islemler
    {
        public static long Topla(int sayi1, int sayi2)
        {
            return sayi1+sayi2;
        }
        public static long Cikar(int sayi1,int sayi2)
        {
            return sayi1-sayi2;
        }
    }
}
