using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool validate(Gamer gamer)
        {
            if (gamer.DogumYili == 1985 && gamer.Adi == "Engin" && gamer.Soyadi == "Demiroğ" && gamer.TCNo == 12345)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
