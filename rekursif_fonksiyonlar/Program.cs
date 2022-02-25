public class Program
{
    public static void Main(string[] args)
    {
        //rekursif fonksiyonlar kendi kendini cagirabilen fonksiyonlardir
        int result = 1;
        for (int i = 1; i < 4; i++)
        {
            result = result * 3;
        }
        Console.WriteLine("normal sekilde kuvvet alma : " + result);

        Rekursif constr = new Rekursif();

        Console.WriteLine("methodu kullanarak kuvvet alma : " + constr.UsluIslemler(3, 3));
        //sadece ucun kuvveti icin calisiyor yeteri kadar dynamic bir kod degil


        //Extention Methodlar
        string ifade = "c# ogreniyorum ! ! ";
        bool sonuc = ifade.CheckSpaces();
        
        if (sonuc)
        {
            Console.WriteLine(ifade.RemoveSpaces);
            Console.WriteLine(ifade.MakeUpperCase());

        }
    }

}
public static class Extention
{

    public static bool CheckSpaces(this string param)
    {

        return param.Contains(" ");

    }
    public static string RemoveSpaces(this string param)
    {
        string [] dizi = param.Split(" ");
        return string.Join("", dizi);
    }
    public static string MakeUpperCase(this string param)
    {
        return param.ToUpper();
    }
}


public class Rekursif
{
    public int UsluIslemler(int sayi, int us)
    {
        if (us < 2)
            return sayi;

        return UsluIslemler(sayi, us - 1) * 3;
    }
}