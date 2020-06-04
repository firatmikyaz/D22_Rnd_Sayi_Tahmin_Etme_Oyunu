using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D22_Rnd_Sayi_Tahmin_Etme_Oyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sayı Tahmin Etme Oyunu //
            
            Random rnd = new Random();
            int rastgele = rnd.Next(10, 20);
            Console.WriteLine("Üretilen Sayı:{0}", rastgele);
            int hak = 3;
            BASADON:
            Console.Write("Bir sayı tahmininde bulununuz?");
            int tahmin = Convert.ToInt32(Console.ReadLine());
            if (tahmin == rastgele)
            {
                Console.Write("Tebrikler... Puan:{0}", hak * 10);
            }
            else if (tahmin < rastgele)
            {
                hak--;
                if (hak == 0)
                {
                    Console.Write("Hakkınız bitmiştir.");
                }
                else
                {
                    Console.Write("Tahmini büyütünüz!");
                    goto BASADON;
                }
            }
            else if (tahmin > rastgele)
            {
                hak--;
                if(hak == 0) 
                {
                    Console.Write("Hakkınız bitmiştir.");
                }
                else
                {
                    Console.Write("Tahmini küçültünüz.");
                    goto BASADON;
                }
            }
            Console.ReadKey();
        }
    }
}
