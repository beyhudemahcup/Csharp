using System;
namespace structYapilar
{
    class Program
    {
        public static void Main(string[] args)
        {
            Dikdortgen dikdortgen = new Dikdortgen();
            Console.WriteLine("dikdortgenin alani : {0}",dikdortgen.AlanHesapla(3,4));

            Dikdortgen_Struct dikdortgen_Struct = new Dikdortgen_Struct();
            Console.WriteLine("dikdortgenin alani : {0}",dikdortgen_Struct.AlanHesapla(3,4));
            //gorunurde bir fark yok ikisinde de class ile yapabildigim islemleri yapmis oldum
            //Class lar referans tipi ile calisir structlar ise değer tipli özellikler gösterirler.
        }
    }
    class Dikdortgen
    {
        public int KisaKenar;
        public int UzunKenar;

        public long AlanHesapla()
        {
            return this.Kisakenar * this.UzunKenar;
        }
    }
    struct Dikdortgen_Struct
    {
        public int KisaKenar;
        public int UzunKenar;

        public long AlanHesapla()
        {
            return this.Kisakenar * this.UzunKenar;
        }
    }
}
 