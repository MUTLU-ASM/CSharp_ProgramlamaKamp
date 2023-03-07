using System;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler();

            Vatandas vatandas1 = new Vatandas();
            vatandas1.Ad = "Asım";
            vatandas1.Soyad = "Mutlu";
            vatandas1.DogumYili = 1985;
            vatandas1.TcNo = 12345678910;

            Console.ReadLine();
        }

        private static void Degiskenler()
        {
            string mesaj = "Selam";
            double tutar = 10000;
            int sayi = 100;
            bool girisYapmisMi = false;

            string ad = "Asım";
            string soyad = "Mutlu";
            int dogumYili = 1985;
            long tcNo = 12345678910;

            Console.WriteLine("mesaj");
            Console.WriteLine(tutar * 1.18);
        }
    }

    //pascal casing : değişken, sınıf, metod veya fonksiyonun kelimeleri
    //bitişik ve büyük harfle başlayacak şekilde yazılmasıdır.

    public class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }
    }
}
