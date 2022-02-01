using System;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
           CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();


        }
    }
}
