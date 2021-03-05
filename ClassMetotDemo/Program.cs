using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Musteri musteri1 = new Musteri();
            musteri1.Id = 10001;
            musteri1.AdSoyad = "Mesut Bereket";
            musteri1.Kredibilite = 1800;
         

            Musteri musteri2 = new Musteri();
            musteri2.Id = 10002;
            musteri2.AdSoyad = "Şükrü Karar  ";
            musteri2.Kredibilite = 1100;
            
            Musteri musteri3 = new Musteri();
            musteri3.Id = 10003;
            musteri3.AdSoyad = "Barbar Tacir ";
            musteri3.Kredibilite = 500;

           
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach(var musteri in musteriler) 
            {
                Console.WriteLine(musteri.Id+"  "+musteri.AdSoyad+"  "+musteri.Kredibilite);
               
              
                if (musteri.Kredibilite < 700)
                {
                    Console.WriteLine("Riskli");
                }
                else if (musteri.Kredibilite <= 1100)
                {
                    Console.WriteLine("Az Riskli");
                }
                else if (musteri.Kredibilite < 1900)
                {
                    Console.WriteLine("Çok iyi");
                }
            }
            Console.WriteLine("\n");
           
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);

            Console.WriteLine("\t");
            musteriManager.Sil(musteri3);

            Console.WriteLine("\n");
            musteriManager.Listele(musteriler);
         
            Console.ReadLine();
        }
    }
}
