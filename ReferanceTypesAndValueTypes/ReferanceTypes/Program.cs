using System;

namespace ReferanceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int,decimal,float,enum,boolean are value types
            int sayi1 = 10;
            int sayi2 = 20;

            sayi1 = sayi2;
            sayi2 = 100;
            Console.WriteLine("Sayi 1 : " + sayi1); //sayi1 ne olur ?


            //arrays,class,interface... are referance types
            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 10, 20, 30 };

            sayilar1 = sayilar2;
            sayilar2[0] = 1000;
            Console.WriteLine("Sayilar1[0] : " + sayilar1[0]); //sayilar2 nin 0. indisindeki sayının değeri ne olur?
            


            Person person1 = new Person();
            Person person2 = new Person();

            person1.FirstName = "Mustafa";
            person2 = person1; //değer eşitlemesi değil adres eşitlemesi yapıyoruz

            person1.FirstName = "Elif";
            Console.WriteLine(person2.FirstName);


            Customer customer = new Customer();
            customer.FirstName = "TEVFİK";
            customer.CreditCardNumber = "1234567890";

            Person person3 = customer; // Mirası alan sınıf Mirası veren sınıfa atanbilir. Çünkü Customer bir Person'dır.
            customer.FirstName = "AYNUR";
            Console.WriteLine(person3.FirstName); //Person is a base clas. (Temel sınıf)


            Console.WriteLine(((Customer)person3).CreditCardNumber);





            Console.Read();
        }
    }
    
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer:Person       
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }
}
