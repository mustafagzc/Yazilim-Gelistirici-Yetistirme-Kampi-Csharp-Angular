using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2; //2 numara Mobilya
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id = 3, CategoryId = 5, ProductName = "Kalem",UnitPrice = 400,
            UnitsInStock = 21,};



            //PascalCase   //camelCase
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Update(product2);




            Console.ReadLine();

            //case sensetive = büyük küçük harf duyarlılığı

        }
    }
}
