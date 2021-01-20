using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product() { Id = 2, CategoryId = 5, ProductName = "Kalem", UnitPrice = 5, UnitsInStock = 35 };


            //PascalCase    //camelCase
            //case sensitive -- kücük büyük harflere duyarlı 
            ProductManager productManager = new ProductManager();
            //Ekleme operasyonu neyi ekleyecek ? bilinmiyo parametre gerek Add() metoduna parametre ekle..
            productManager.Add(product1);


        }
    }
}