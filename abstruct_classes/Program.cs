namespace Interface_example
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Focus focus = new Focus();
            Console.WriteLine(focus.HangiMarkaninAraci().ToString());
            Console.WriteLine(focus.KacTekerdenOlusur());
            Console.WriteLine(focus.StandartRengiNe().ToString());
        
            Civic civic = new Civic();
            Console.WriteLine(civic.HangiMarkaninAraci());
            Console.WriteLine(civic.KacTekerdenOlusur());
            Console.WriteLine(civic.StandartRengiNe().ToString());

        }


    }
}