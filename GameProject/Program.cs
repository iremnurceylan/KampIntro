using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, DogumYili = 1985, Adi = "Engin", Soyadi = "Demiroğ", TCNo = 12345 });

            GamerManager gamerManager1 = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { Id = 2, DogumYili = 2000, Adi = "irem", Soyadi = "Ceylan", TCNo = 123456 });

        }
    }
}
