
using System;

namespace encaps
{
    class encaps
    {

        public static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.Isim = "Ismet";
            ogrenci1.Soyisim = "ozhel";
            ogrenci1.OgrenciNo = 1976;
            ogrenci1.Sinif = 3;
            ogrenci1.OgrenciBilgileriniGetir();

            Console.WriteLine("nihayet getter and setter isledi..");

            ogrenci1.SinifAtlat();
            ogrenci1.OgrenciBilgileriniGetir();

            Console.WriteLine("yeni ogrenci bilgilerini gorecegiz simdi");

            Ogrenci ogrenci2 = new Ogrenci("ishak","ozen",1965,1);
            //1.sinifta bir ogrenci olusturduk sinif dusurunce dusmeyecegini gormek icin
            ogrenci2.SinifDusur();
            ogrenci2.OgrenciBilgileriniGetir();


        }
    }

    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string Isim { get => isim; set => isim = value; }

        public string Soyisim { get => soyisim; set => soyisim = value; }

        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }

        public int Sinif
        {
            get => sinif;
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("sinif 1 den kucuk olamaz");
                }
                else
                {

                    sinif = value;
                }
            }
        }


        public Ogrenci(string isim, string soyisim, int ogrenciNo, int sinif)
        {
            Isim = isim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }

        public Ogrenci() { }
        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("*******ogrenci bilgileri*******");
            Console.WriteLine("ogrenci adi : {0}", this.Isim);
            Console.WriteLine("ogrenci soyadi : {0}", this.Soyisim);
            Console.WriteLine("ogrenci no : {0}", this.OgrenciNo);
            Console.WriteLine("ogrenci sinif : {0}", this.Sinif);
        }

        public void SinifAtlat()
        {
            this.Sinif = this.Sinif + 1;
        }

        public void SinifDusur()
        {
            this.Sinif = this.Sinif - 1;
        }
    }
}