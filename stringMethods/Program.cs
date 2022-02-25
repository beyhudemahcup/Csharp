class Solution
{
    public static void Main(String[] args)
    {

        List<int> sayilar = new List<int>();
        sayilar.Add(11);
        sayilar.Add(4);
        sayilar.Add(5);
        sayilar.Add(15);
        sayilar.Add(65);

        List<string> renkler = new List<string>();
        renkler.Add("kirmizi");
        renkler.Add("mor");
        renkler.Add("turuncu");
        renkler.Add("pembe");

        Console.WriteLine(renkler.Count);//eleman sayisini verir

        //istedigimiz collectionu foreach ile ekrana yazdirabiliriz
        foreach (var item in renkler)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("*****************");

        sayilar.ForEach(sayi => Console.WriteLine(sayi));

        //list.Remove(istenilenDeger) o listten yazdigimiz degeri cikartmaya yarar

        //RemoveAt(2) ---> 2. indexteki sayiyi cikartir

        //Contains(variable) o variable var mi yok mu diye bakar

        //BinarySearch ile 


        Console.WriteLine("*****************");

        //arrayi liste cevirme

        string[] hayvanlar = { "kedi", "kopek", "aslan", "fare" };

        List<string> hayvanList = new List<string>(hayvanlar);
        hayvanList.ForEach(hayvan => Console.WriteLine(hayvan));



    }
}