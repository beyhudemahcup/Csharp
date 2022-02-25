namespace Inheritance
{
    public class Bitkiler : Canlilar
    {
        protected void Fotosentez()
        {
            Console.WriteLine("bitkiler fotosentez yapar");
        }

    }
    public class TohumluBitkiler : Bitkiler
    {
        public TohumluBitkiler()
        {
            base.Fotosentez();
            base.Solunum();
            base.Beslenme();
            base.Bosaltim();

        }
        public void TohumlaCogalma()
        {
            Console.WriteLine("Tohumlu bitkiler tohumla cogalir");
        }
    }

    public class TohumsuzBitkiler : Bitkiler
    {
        public TohumsuzBitkiler()
        {
            base.Fotosentez();
            base.Solunum();
            base.Beslenme();
            base.Bosaltim();
        }
        public void sporlaCogalma()
        {
            Console.WriteLine("tohumsuz bitkiler sporla cogalir");
        }
    }
}