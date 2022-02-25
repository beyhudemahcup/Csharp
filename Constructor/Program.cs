using System;

namespace Cons
{
    public class Cons
    {
        public static void Main(string[] args)
        {
            //classlarla alakali bir ders bu da..
            //javanin default accessli classi yerine burada internal class var
            Calisan calisan1 = new Calisan("isme", "ozet", 1975, "amentu");
            calisan1.calisanEkranaYazdir();

            Console.WriteLine("*****************");

            Calisan calisan2 = new Calisan("ismet", "ozel", 1968, "sair");

            calisan2.calisanEkranaYazdir();

        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public Calisan(string ad, string soyad, int no, string departman)
        {

            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }
        public void calisanEkranaYazdir()
        {
            Console.WriteLine("calisan ismi : {0}  ", Ad);
            Console.WriteLine("calisan soyadi : {0} ", Soyad);
            Console.WriteLine("calisan idsi  : {0} ", No);
            Console.WriteLine("calisanin departmani  : {0} ", Departman);
        }
    }
}