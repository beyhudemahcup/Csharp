using System;
namespace Enum_ders
{
    class Program
    {
        public static void Main(string[] args)
        {
                Console.WriteLine(Gunler.Pazartesi);
                Console.WriteLine((int)Gunler.Persembe);//0 inci indexten basliyor ve o gunun indexteki karsiligini donuyor
                //ben stringi int e cast ettigim icin

        }
    }
    enum Gunler
    {
        Pazartesi,
        Sali,
        Carsamba,
        Persembe,
        Cuma,
        Cumartesi,
        Pazar
    }
}
