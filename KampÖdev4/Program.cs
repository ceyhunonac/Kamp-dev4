using System;

namespace KampÖdev4
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1111;
            musteri1.Adi = "Ceyhun";
            musteri1.Soyadi = "Onaç";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 1112;
            musteri2.Adi = "Ediz";
            musteri2.Soyadi = "Onaç";

            Musteri[] musteriler = new Musteri[] {musteri1,musteri2 }; ;

            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Müşteri Bilgileri");
                Console.WriteLine("Müşteri  Id :" + musteri.Id);
                Console.WriteLine("Müşteri  Adı :" + musteri.Adi);
                Console.WriteLine("Müşteri  Soyadı :" + musteri.Soyadi);

                Console.WriteLine("-----------------------------------------------------");

              
            }

            MusteriManager manager = new MusteriManager();
            Console.WriteLine("MÜŞTERİ İŞLEMLERİ");

            manager.Ekle(musteri1);
            manager.Sil(musteri1);
            manager.Guncelle(musteri1);

            Console.WriteLine("-----------------------------------------------------");
            
            manager.Ekle(musteri2);
            manager.Sil(musteri2);
            manager.Guncelle(musteri2);

        }
    }
}
