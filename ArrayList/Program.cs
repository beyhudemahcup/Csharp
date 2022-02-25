using System;
using System.Collections;


namespace arrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            liste.Add("elma");
            liste.Add(21);
            liste.Add(false);
            liste.Add('B');

            Console.WriteLine(liste[1]);//1. indexteki elemani yazdirir

            Console.WriteLine("****** bosluk birakalim");

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("****** bosluk birakalim");
            //AddRange
            string [] renkler = {"mavi","mor", "pembe", "yesil"};
            List<int> sayilar = new List<int>(){1,8,4,6,2,11,3};
            //bu listeleri add range ile az once create ettigim liste isimli list e ekliyorum
            liste.AddRange(renkler);
            liste.AddRange(sayilar);

         foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("****** bosluk birakalim");
            //sort ise yarayamaz burada cunku icinde sayi olmayan bir list bu.. o yuzden list 
            //create ederken dikkatli olmaliyiz

            //Binary Seach(kendi icinde sirayip sonra kullanabiliriz)
            //Console.WriteLine(liste.BinarySearch(8))
            //8 rakami kacinci indexteyse binary search bana onu dondurur
            

        }
    }
}
