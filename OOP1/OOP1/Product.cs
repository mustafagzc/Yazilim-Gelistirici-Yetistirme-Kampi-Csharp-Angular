using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        //snippet 
        public int Id { get; set; } //primary Key

        public int CategoryId { get; set; } //Foreign Key Kod okunurluğunu attırmak için Primary Key'den sonra Foreign Key gelmelidir.
        public string ProductName { get; set; }

        public double UnitPrice { get; set; } //ürün birim fiyatı

        public int UnitsInStock { get; set; }


    }
}
