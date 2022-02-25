using System;
public class Dictionary
{

    public static void Main(string[] args)
    {
        //javadaki mapslerle ayni sey.. api testing icin de dictionary kullanilabilir demek oluyor bu 

        Dictionary <int, string> kullanicilar = new Dictionary<int, string>();
        kullanicilar.Add(10,"ayse");
        kullanicilar.Add(11,"cervantes");
        kullanicilar.Add(12,"donatello");

        //butun elemanlari yine for each ile consoleda yazdirabiliriz
        foreach (var item in kullanicilar)
        {
            Console.WriteLine(item);
        }

        //bir de count yazdiralim
        Console.WriteLine(kullanicilar.Count);

        //contains
        Console.WriteLine(kullanicilar.ContainsKey(12));//Contains key and value ile kullanabiliriz

        Console.WriteLine(kullanicilar.ContainsValue("donatello"));

         //simdi yalnizca isimleri yazdiracagim.. bunun icin item.value kullaniyorum, ayni sekilde item.key ile de unique keyleri yazdirabilirim
          foreach (var item in kullanicilar)
        {
            Console.WriteLine();
            Console.WriteLine(item.Value);
        }

    }
}
