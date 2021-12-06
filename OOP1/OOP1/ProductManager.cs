using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {

        public void Add(Product product) //Product sınıfına ulaşıp product isteniyor. Bizde Program.cs'de yazdığımız Add metotunun içerisine product1 yazıyoruz. Bu metotda product1 i product olarak tutuyor.
        {
            Console.WriteLine(product.ProductName + " "+ "Ürün Eklendi");
        }


        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " " + "Ürün Güncellendi");
        }

    }
}
