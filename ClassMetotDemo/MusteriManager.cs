using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Id+" "+"Müşteri Eklendi");
        }

        public void Sil(Musteri musteri) 
        {
            Console.WriteLine(musteri.Id + " " + "Id Numaralı Müşteri Silindi");

        }

        public void Listele(Musteri[] musteriler) 
        {
            
            Console.WriteLine("Listeleme Türü Girin:"+ "\n\n\t Id No için 1, \n \t KrediNotu için 2 ");
            tekrar:
            var tur= Convert.ToInt32(Console.ReadLine());
            switch (tur)
            {
                case 1:
                    foreach (var musteri in musteriler)
                    {
                        Console.WriteLine(musteri.Id +" "+ "Numaralı Müşteri: "+musteri.AdSoyad);
                    }
                    break;
                case 2:
                    foreach (var musteri in musteriler)
                    {
                        Console.WriteLine(musteri.AdSoyad +"   " + "Kredi Notu: " + musteri.Kredibilite);
                    }
                    break;
               
                default:
                Console.WriteLine("Tekrar Deneyin");
                    goto tekrar;
           
            }
        }
    }
}
