using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        // ürünün Id'si
        public int Id { get; set; }
        //ürünün kategorisi
        public int CategoryId { get; set; }
        //ürünün adı 
        public string ProductName { get; set; }
        // ürünün fiyatı
        public double UnitPrice { get; set; }
        // ürünün stok adedi
        public int UnitsInStock { get; set; }

    }
}
