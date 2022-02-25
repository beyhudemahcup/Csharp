using System;

namespace sinif_kavrami
{
    public class sinifKavrami
    {
        public static void Main(string[] args)
        {
            //classlarla alakali bir ders bu da..
            //javanin default accessli classi yerine burada internal class var
            Calisan calisan1 = new Calisan();
            Calisan calisan2 = new Calisan();
            calisan1.Ad = "ali";
            calisan1.Soyad = "veli";
            calisan1.No = 10;
            calisan1.Departman = "IT";
            calisan1.calisanEkranaYazdir();

            Console.WriteLine("*****************");

            calisan2.Ad = "ismet";
            calisan2.Soyad = "ozel";
            calisan2.No = 1968;
            calisan2.Departman = "sair";
            calisan2.calisanEkranaYazdir();

        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;


        public void calisanEkranaYazdir(){
            Console.WriteLine("calisan ismi : {0}  " , Ad);
            Console.WriteLine("calisan soyadi : {0} " , Soyad);
            Console.WriteLine("calisan idsi  : {0} " , No);
            Console.WriteLine("calisanin departmani  : {0} " , Departman);
        }
    }
}