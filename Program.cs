using System;

namespace Metotlarr
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Fiyati = 15;
            product1.Aciklama = "Amasya elması";
            product1.StokAdedi = 16;

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyati = 80;
            product2.Aciklama = "Diyarbakır karpuzu";
            product2.StokAdedi = 7;

            Product[] products = new Product[] {product1,product2};

			foreach (Product product in products)
			{
                Console.WriteLine(product.Adi + "\n" + product.Fiyati + "\n" + product.Aciklama + "\n" + product.StokAdedi);
                Console.WriteLine("***************");
            }

            Console.WriteLine("******Metotlar******");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 3);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12, 4);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, 10);


        }
    }
}
