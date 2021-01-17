using System;

namespace Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.Adı = "Laptop";
            product1.Marka = "Monster";
            product1.Fiyat = 6000.81;

            Product product2 = new Product();
            product2.Id = 2;
            product2.Adı = "Klavye";
            product2.Marka = "Razer";
            product2.Fiyat = 650.66;

            Product product3 = new Product();
            product3.Id = 3;
            product3.Adı = "Mouse";
            product3.Marka = "Razer";
            product3.Fiyat = 380.28;

            Product[] products = new Product[]
            {
                product1,product2,product3
            };

            /*for(int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].Id + ". " + products[i].Adı + " : " + products[i].Marka + " : " + products[i].Fiyat);
            }*/

            /*foreach(Product product in products)
            {
                Console.WriteLine(product.Id + ". " + product.Adı + " : " + product.Marka + " : " + product.Fiyat);
            }*/
            int i = 0;
            while(i < products.Length) 
            {
                Console.WriteLine(products[i].Id + ". " + products[i].Adı + " : " + products[i].Marka + " : " + products[i].Fiyat);
                i++;
            }
        }
    }

    class Product
    {
        public int Id {get; set;}
        public string Adı  {get; set;}
        public string Marka {get; set;}
        public double Fiyat {get; set;}

    }
}
