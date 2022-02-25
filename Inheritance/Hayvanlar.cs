namespace Inheritance
{
    public class Hayvanlar:Canlilar
    {
             protected void Adaptasyon()
     {
         Console.WriteLine("hayvanlar adaptasyon yapar");
     }   
        

    }
    public class Surungenler:Hayvanlar
    {
        public Surungenler()
        {
            base.Adaptasyon(); 
            base.Solunum();
            base.Beslenme();
            base.Bosaltim();
        }
        public void SurunerekHareketEderler()
        {
            Console.WriteLine("Surungenler surunerek hareket ederler");
        }
    }
    public class Kuslar:Hayvanlar
    {
        
        public Kuslar()
        {
            base.Adaptasyon();
            base.Solunum();
            base.Beslenme();
            base.Bosaltim();
        }
        public void Ucmak()
        {
            Console.WriteLine("Kuslar ucar");
        }
    }
}