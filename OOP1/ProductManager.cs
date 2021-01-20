using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        // encapsulatıon
        // void bir deger dondurmez sadece bilgiyi yazar 
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName +  " eklendi. ");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi. ");
        }

    }
}
