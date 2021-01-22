using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlarr
{
    class SepetManager
    {
        public void Ekle(Product product)
		{
            Console.WriteLine("Tebrikler. Sepete eklendi: " + product.Adi);

		}

        public void Ekle2(string ad, string aciklama, double fiyat, int stokAdedi)
		{
            Console.WriteLine("Tebrikler. Sepete eklendi: " + ad);
        }
    }
}
