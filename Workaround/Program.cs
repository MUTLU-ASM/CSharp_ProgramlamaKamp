using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler();

            Vatandas vatandas1 = new Vatandas();
            //vatandas1.Ad = "Asım";
            //vatandas1.Soyad = "Mutlu";
            //vatandas1.DogumYili = 1985;
            //vatandas1.TcNo = 12345678910;


            SelamVer(isim: "Ahmet");
            SelamVer();


            int sonuc = Topla(5, 2);

            //Diziler / Arrays
            string ogrenci1 = "Engin";
            string ogrenci2 = "Murat";
            string ogrenci3 = "Berkay";

            Console.WriteLine(ogrenci1);
            Console.WriteLine(ogrenci2);
            Console.WriteLine(ogrenci3);


            string[] ogrenciler = new string[3];
            ogrenciler[0]= "Engin";
            ogrenciler[1]= "Murat";
            ogrenciler[2]= "Berkay";

            for(int i=0; i< ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] {"Ankara","İstanbul","İzmir"};
            string[] sehirler2 = new[] {"Bursa","Antalya","Diyarbakır"};

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]); //Adana yazar.

            int sayi1 = 10;
            int sayi2 = 20;
            sayi2 = sayi1;
            sayi1 = 30;
            // sayi2 ?? 10 dur.

            foreach (string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }

            List<string> yeniSehirler = new List<string> { "Ankara1", "İstanbul1", "İzmir1" };
            yeniSehirler.Add("Sakarya1");

            foreach (string sehir in yeniSehirler)
            {
                Console.WriteLine(sehir);
            }

            Console.WriteLine("----------------------------------");

            Person person1 = new Person();
            person1.FirstName = "ASIM";
            person1.LastName = "MUTLU";
            person1.DateOfBirthYear = 2001;
            person1.NationalIdentity = 123; //dogru kimlik numarasi yazildiginda true donecektir ve maske verilecek.
            
            Person person2 = new Person();
            person2.FirstName = "Engin";

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);


            Console.ReadLine();
        }

        //default parametre
        static void SelamVer(string isim="isimsiz")
        {
            Console.WriteLine("Merhaba " + isim);
        }
        static int Topla(int sayi1=5 ,int sayi2=10)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam : " + sonuc);
            return sonuc;
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
