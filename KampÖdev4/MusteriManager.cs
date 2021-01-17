using System;
using System.Collections.Generic;
using System.Text;

namespace KampÖdev4
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklenmiştir : " + musteri.Adi);
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Maalesef.Müşteri Silinmiştir! : " + musteri.Adi);
        }
        public void Guncelle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Güncellenmiştir  : " + musteri.Adi);
        }
    }
}
